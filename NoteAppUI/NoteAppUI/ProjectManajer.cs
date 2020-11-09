using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace TUSUR.NoteApp
{
    /// <summary>
    /// Класс, реализующий сохранение данных в файл и загрузки из него.
    /// </summary>
    internal class ProjectManager
    {
        private const string _externalPath = "C:\\Users\\User\\Documents\\NoteApp.notes";

        /// <summary>
        /// Метод, выполняющий запись в файл
        /// </summary>
        /// <param name="projectDictionary">Экземпляр проекта для сериализации</param>
        public static void ProjectSerialization(Project projectDictionary)
        {
            //var myDocumentsPath = Environment.GetFolderPath(SpecialFolder.MyDocuments);
            // Экземпляр сериалиатора
            JsonSerializer serializer = new JsonSerializer();

            // Преобразование string в System.IO.Stream
            byte[] byteArray = Encoding.UTF8.GetBytes(_externalPath);
            MemoryStream stream = new MemoryStream(byteArray);

            // Открытие потока для записи в файл
            using (StreamWriter sw = new StreamWriter(@stream))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                // Вызов сериализатора и передача объекта сеиализации
                serializer.Serialize(writer, projectDictionary);
            }
        }

        /// <summary>
        /// Метод, выполняющий чтение из файла
        /// </summary>
        /// <returns>Экземпляр проекта, считанный из файла</returns>
        public static Project ProjectDeserialization()
        {
            // Экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();

            // Переменная для помещения результата
            Project project = null;

            // Преобразование string в System.IO.Stream
            byte[] byteArray = Encoding.UTF8.GetBytes(_externalPath);
            MemoryStream stream = new MemoryStream(byteArray);

            // Открытие потока для чтения и файла
            using (StreamReader sr = new StreamReader(@stream))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                // Вызов десериализации
                project = (Project)serializer.Deserialize(reader);
            }

            return project;
        }
    }
}
