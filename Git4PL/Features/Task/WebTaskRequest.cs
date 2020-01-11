using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using Git4PL.Features.Settings;

namespace Git4PL.Features.Task
{
    class WebTaskRequest
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private string ResponseJson { get; set; }

        public WebTaskRequest(string WebTaskID, WebTaskType webTaskType)
        {
            logger.Trace("Начинаем WebTaskRequest");

            string RequestURL = string.Format(Constants.Instance.URL_REQUESTWEBTASK, GetWebTableName(webTaskType), WebTaskID);
                
            logger.Trace("RequestURL={0}", RequestURL);
            int trycount = 4;
            while (trycount > 0)
            {
                try
                {
                    ResponseJson = GetResponse(RequestURL);
                    break;
                }
                catch (WebException ex)
                {
                    trycount--;
                    LogError(ex);
                    HttpWebResponse response = (HttpWebResponse)ex.Response;
                    if (response != null && response.StatusCode == HttpStatusCode.Unauthorized)
                        throw new Git4PLException("Неверный логин или пароль");
                    if (trycount <= 0)
                        throw ex;
                    logger.Trace($"trycount={trycount}, Пробуем еще раз!");
                }
                catch (InvalidOperationException ex)
                {
                    trycount--;
                    LogError(ex);
                    if (trycount <= 0)
                        throw ex;
                    logger.Trace("trycount={0}, пробуем еще раз", trycount);
                }
                catch (Exception ex)
                {
                    LogError(ex);
                    throw ex;
                }
            }
            logger.Trace("Конец WebTaskRequest");
        }

        public string GetResponse(string uri)
        {
            logger.Trace("Начинаем GetResponse");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Credentials = GetCredentials();
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
            string answer;
            request.Timeout = 3500;
            request.Method = "GET";
            request.KeepAlive = false;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                logger.Trace("IN HttpWebResponse");
                logger.Trace("HttpWebResponse Status code: {0} {1}", (int)response.StatusCode, response.StatusCode.ToString());
                using (Stream stream = response.GetResponseStream())
                {
                    logger.Trace("IN Stream");
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        logger.Trace("IN StreamReader");
                        answer = reader.ReadToEnd();
                        logger.Trace($"answer={answer}");
                    }
                }
            }
            logger.Trace("Конец GetResponse");
            return answer;
        }

        /// <summary>
        /// Парсим Json-ответ в класс WebTaskContract
        /// </summary>
        /// <returns></returns>
        public WebTaskContract GetWebTask()
        {
            WebTaskResultContract deserializedUser = new WebTaskResultContract();
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(ResponseJson)))
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(deserializedUser.GetType());
                deserializedUser = ser.ReadObject(ms) as WebTaskResultContract;
            }
            return deserializedUser.result[0];
        }

        private NetworkCredential GetCredentials()
        {
            string ciphertext = Properties.Settings.Default.WebPassword;
            string entropy = Properties.Settings.Default.WebPasswordEntropy;
            if (string.IsNullOrEmpty(entropy) || string.IsNullOrEmpty(ciphertext))
                throw new Git4PLException("Не указаны учётные данные");
            byte[] plaintext = ProtectedData.Unprotect(Convert.FromBase64String(ciphertext), Convert.FromBase64String(entropy), DataProtectionScope.CurrentUser);
            NetworkCredential credentials = new NetworkCredential(Properties.Settings.Default.WebLogin, Encoding.UTF8.GetString(plaintext));
            for (int i = 0; i < plaintext.Length; i++)
                plaintext[i] = (byte)(7 + i % 4);
            return credentials;
        }

        public static string GetWebTableName(WebTaskType snTaskType)
        {
            switch (snTaskType)
            {
                case WebTaskType.Type1:
                    return Constants.Instance.WEBTABLENAME1;
                case WebTaskType.Type2:
                    return Constants.Instance.WEBTABLENAME2;
                default:
                    return "";
            }
        }

        private void LogError(Exception ex)
        {
            logger.Error($"Ошибка {ex.GetType().ToString()}");
            logger.Error(ex.Message);
            logger.Error(ex.StackTrace);
        }
    }
}
