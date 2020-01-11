using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RGiesecke.DllExport;
using Git4PL.PLSqlDeveloper.IDECallBacks;

namespace Git4PL.PLSqlDeveloper
{
    public class API
    {
        private static readonly PluginBuilder pluginBuilder = new PluginBuilder();

        /// <summary>
        /// Условная точка входа в плагин
        /// </summary>
        static API()
        {
            try
            {
                // Загружаем Nlog
                NlogAssist.InitializeNlog();
            }
            catch (FileNotFoundException ex)
            {
                // Если NLog.dll будет отсутствовать, PL/SQL Developer не сможет активировать плагин, будет не информативное сообщение (Не смогли загрузить плагин), 
                // поэтому добавляем наше сообщение
                string path = Path.Combine(new FileInfo(Application.ExecutablePath).Directory.FullName, "Nlog.dll");
                MessageBox.Show($"Плагин {pluginBuilder.GetPluginName} не будет загружен! Не найдена библиотека Nlog.dll в директори PL/SQL Developer. ({path})", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        /// <summary>
        /// Инициализация плагина в PL/SQL Developer. Вызывается PL/SQL Developer-ом при загрузке.
        /// </summary>
        /// <param name="ID">ID плагина, который передает нам PL/SQL Developer</param>
        /// <returns>Название плагина</returns>
        [DllExport("IdentifyPlugIn", CallingConvention = CallingConvention.Cdecl)]
        public static string IdentifyPlugIn(int ID)
        {
            NLog.LogManager.GetCurrentClassLogger().Info("Инициализация плагина. ID={0}", ID);
            pluginBuilder.PluginID = ID;
            return pluginBuilder.GetPluginName;
        }

        /// <summary>
        /// Кнопка About в настройках плагинов в PL/SQL Developer
        /// </summary>
        /// <returns>Текстовое сообщение с информацией о плагине</returns>
        [DllExport("About", CallingConvention = CallingConvention.Cdecl)]
        public static string About()
        {
            return pluginBuilder.GetAboutInfo;
        }

        [DllExport("CreateMenuItem", CallingConvention = CallingConvention.Cdecl)]
        public static string CreateMenuItem(int index)
        {
            // Меню можем строить только когда мы получили ID плагина, поэтому вызов InitializeMenu отложен до этого обращения
            if (pluginBuilder.Menu == null)
                pluginBuilder.InitializeMenu();
            return pluginBuilder.Menu.CreateMenuItem(index);
        }

        [DllExport("OnMenuClick", CallingConvention = CallingConvention.Cdecl)]
        public static void OnMenuClick(int index)
        {
            pluginBuilder.Menu.MenuClick(index);
        }

        [DllExport("RegisterCallback", CallingConvention = CallingConvention.Cdecl)]
        public static void RegisterCallback(int index, IntPtr function)
        {
            Callbacks.SetDelegate(index, function);
        }

        [DllExport("OnActivate", CallingConvention = CallingConvention.Cdecl)]
        public static void OnActivate()
        {
            NLog.LogManager.GetCurrentClassLogger().Debug("Вызов OnActivate");
            pluginBuilder.SetIcons();
        }

        [DllExport("Configure", CallingConvention = CallingConvention.Cdecl)]
        public static void Configure()
        {
            NLog.LogManager.GetCurrentClassLogger().Info("Вызов настроек Configure");
            PluginCommands.ShowSettingsWindow();
        }

        [DllExport("OnConnectionChange", CallingConvention = CallingConvention.Cdecl)]
        public static void OnConnectionChange()
        {
            NLog.LogManager.GetCurrentClassLogger().Info("Вызов OnConnectionChange");
        }
    }
}
