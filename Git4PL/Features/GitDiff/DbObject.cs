using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Git4PL.Features.GitDiff
{
    /// <summary>
    /// Характеристики объекта БД ассоциированного с файлом в локальном репозитории git
    /// </summary>
    public class DbObject
    {
        protected static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        protected static readonly Dictionary<dbObjectType, string> FileExtensionDicti = new Dictionary<dbObjectType, string>()
        {
            { dbObjectType.FUNCTION, "FNC" },
            { dbObjectType.PROCEDURE, "PRC" },
            { dbObjectType.PACKAGEBODY, "BDY" },
            { dbObjectType.PACKAGE, "SPC" },  // по факту spc относится к спецификации, а к пакету должен быть pck
            { dbObjectType.TRIGGER, "TRG" },
            { dbObjectType.VIEW, "VWS" },
            { dbObjectType.TYPE, "TPS" },
            { dbObjectType.TYPEBODY, "TPB" }
        };

        public string Schema { get; private set; }
        public string Name { get; private set; }
        public string FileName { get; private set; }
        public dbObjectType Type { get; private set; }
        public string FileExtension { get; private set; }

        public string FullName => string.Join(" ", Type.ToString(), string.Join(".", Schema, Name)).ToLower();
        public string RepName => string.Join("/", Schema, FileName);

        /// <summary>
        /// Путь расположения файла в локальном репозитории git
        /// RAW - так как не соблюдён CaseSensitive
        /// </summary>
        public string GetRawFilePath()
        {
            string GitRep = Properties.Settings.Default.GitLocalRepository;
            if (Directory.Exists(GitRep))
                return Path.Combine(GitRep, Schema, string.Join(".", Schema, Name, FileExtension)).ToLower();
            else
                throw new Git4PLException("Не указан локальный репозиторий GIT");
        }
        /// <summary>
        /// Путь расположения папки где должен находиться файл
        /// RAW - так как не соблюдён CaseSensitive
        /// </summary>
        public string GetRawDirPath()
        {
            string GitRep = Properties.Settings.Default.GitLocalRepository;
            if (Directory.Exists(GitRep))
                return Path.Combine(GitRep, Schema);
            else
                throw new Git4PLException("Не указан локальный репозиторий GIT");
        }
        public string TypeStr
        {
            get
            {
                return Type.ToString();
            }
        }

        public DbObject(string schema, string name, string type)
        {
            logger.Debug($"Создаём объект DbObject. schema={schema}, name={name}, type={type}");

            if (string.IsNullOrWhiteSpace(schema) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(type))
                throw new Git4PLException("Не удалось распознать объект БД");
                        
            Schema = schema.ToUpper();
            if (Directory.Exists(GetRawDirPath()))
                Schema = CommonExtensions.GetCaseSensitiveFolderName(GetRawDirPath());

            Name = name.ToUpper();

            try
            {
                Type = (dbObjectType)Enum.Parse(typeof(dbObjectType), type.Replace(" ", "").ToUpper(), true);
            }
            catch
            {
                throw new Git4PLException($"Тип объекта: {type} - не поддерживается");
            }

            FileExtension = FileExtensionDicti[Type];
            logger.Trace("FileExtension={0}", FileExtension);

            if (File.Exists(GetRawFilePath()))
                FileName = CommonExtensions.GetCaseSensitiveFileName(GetRawFilePath());

            logger.Trace($"Конец конструктора DbObject");
        }

        public DbObject(DbObject obj)
        {
            Schema = obj.Schema;
            Name = obj.Name;
            Type = obj.Type;
            FileExtension = obj.FileExtension;
        }

        public void DirectoriesChecks()
        {
            if (!Directory.Exists(Properties.Settings.Default.GitLocalRepository))
                throw new Git4PLException("Не указан локальный репозиторий GIT");

            string DirPath = GetRawDirPath();
            if (!Directory.Exists(DirPath))
            {
                DialogResult dialogResult = MessageBox.Show("Не найдена директория " + DirPath + ". Хотите создать?", "Отсутствует директория для схемы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                    Directory.CreateDirectory(DirPath);
                else
                    throw new Git4PLException($"В локальном репозитории GIT отсутствует директория для объекта БД({DirPath})");
            }

            if (!File.Exists(GetRawFilePath()))
            {
                DialogResult dialogResult = MessageBox.Show("Не найден файл " + GetRawFilePath() + ". Хотите создать его?", "Файл отсутствует в локальном репозитории", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                    File.WriteAllText(GetRawFilePath().ToUpper(), "\r\n/");
                else
                    throw new Git4PLException($"В локальном репозитории GIT отсутствует файл для сохранения объекта БД ({GetRawFilePath()})");
            }
        }
    }
}
