using System;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    /// <summary>
    /// Класс, реализующий методы сохранения и загрузки объекта класса Project.
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Путь к файлу.
        /// </summary>
        public static string StringMyDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NoteApp.notes";

        
        /// <summary>
        /// Проверяет существование файла. Если файл не будет найден, то создается новый.
        /// </summary>
        public static void CheckFile()
        {
            if (!File.Exists(StringMyDocumentsPath))
                File.Create(StringMyDocumentsPath).Close();
        }

        /// <summary>
        /// Сохраняет объекта класса Project в файл.
        /// </summary>
        public static void SaveToFile (Project notes)
        {
            JsonSerializer serializer = new JsonSerializer();

            CheckFile();
            using (StreamWriter sw = new StreamWriter(StringMyDocumentsPath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, notes);
            }
        }

        /// <summary>
        /// Загружает объекта класса Project из файла.
        /// </summary>
        public static Project LoadFromFile()
        {
            JsonSerializer serializer = new JsonSerializer();
            Project project = null;

            CheckFile();
            using (StreamReader sr = new StreamReader(StringMyDocumentsPath))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = (Project)serializer.Deserialize<Project>(reader);
            }

            return project;
        }
    }
}