using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    /// <summary>
    /// Класс, реализующий методы сохранения
    /// и загрузки проекта через файл.
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Путь к файлу сохранения и загрузки.
        /// </summary>
        private static string _stringMyDocumentsPath = 
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NoteApp.notes";

        /// <summary>
        /// Проверка существования файла. Если файл не будет найден, то создастся новый.
        /// </summary>
        public static void CheckFile()
        {
            if (!File.Exists(_stringMyDocumentsPath))
                File.Create(_stringMyDocumentsPath).Close();
        }

        /// <summary>
        /// Метод, выполняющий сохранение проекта в файл.
        /// </summary>
        public static void Serialization(Project notes)
        {
            JsonSerializer serializer = new JsonSerializer();

            CheckFile();
            using (StreamWriter sw = new StreamWriter(_stringMyDocumentsPath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, notes);
            }
        }

        /// <summary>
        /// Метод, выполняющий загрузку проекта из файла
        /// </summary>
        public static Project Deserialization()
        {
            Project project = null;
            JsonSerializer serializer = new JsonSerializer();

            CheckFile();
            using (StreamReader sr = new StreamReader(_stringMyDocumentsPath))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = (Project)serializer.Deserialize<Project>(reader);
            }

            return project;
        }
    }
}