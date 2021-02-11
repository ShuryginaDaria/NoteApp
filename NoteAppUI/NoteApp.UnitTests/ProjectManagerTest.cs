using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    /// <summary>
    /// Класс юнит-тестов ProjectManager
    /// </summary>
    [TestFixture]
    public class ProjectManagerTest
    {
        [SetUp]
        public void Setup()
        {
            // Бэкап
            if (File.Exists(ProjectManager.StringMyDocumentsPath))
                File.Move(ProjectManager.StringMyDocumentsPath, 
                    ProjectManager.StringMyDocumentsPath + ".test");
        }

        [TearDown]
        public void Teardown()
        {
            // Восстановление из бэкапа
            if (!File.Exists(ProjectManager.StringMyDocumentsPath + ".test")) return;
            File.Delete(ProjectManager.StringMyDocumentsPath);
            File.Move(ProjectManager.StringMyDocumentsPath  + ".test", 
                ProjectManager.StringMyDocumentsPath);
        }

        [TestCase(Description = "Тест создания проекта")]
        public void CreateProjectTest()
        {
            if (File.Exists(ProjectManager.StringMyDocumentsPath))
                File.Delete(ProjectManager.StringMyDocumentsPath);
            ProjectManager.CheckFile();
            var project = ProjectManager.LoadFromFile();
            Assert.IsTrue(project == null, "Созданный проект не пуст");
        }

        [TestCase(Description = "Тест загрузки проекта")]
        public void LoadProjectTest()
        {
            var testNote = new Note()
            {
                Title = "note"
            };
            var project = new Project()
            {
                CurrentNote = testNote,
                NotesList = new List<Note>()
                {
                    testNote
                }
            };
            if (File.Exists(ProjectManager.StringMyDocumentsPath))
                File.Delete(ProjectManager.StringMyDocumentsPath);
            File.WriteAllText(ProjectManager.StringMyDocumentsPath,
                JsonConvert.SerializeObject(project),
                Encoding.UTF8);
            var loaded = ProjectManager.LoadFromFile();
            Assert.AreEqual(project, loaded, "Загруженный проект отличается от сохранённого");
        }

        [TestCase(Description = "Тест сохранения проекта")]
        public void SaveTest()
        {
            var testNote = new Note()
            {
                Title = "note"
            };
            var project = new Project()
            {
                CurrentNote = testNote,
                NotesList = new List<Note>()
                {
                    testNote
                }
            };
            if (File.Exists(ProjectManager.StringMyDocumentsPath))
                File.Delete(ProjectManager.StringMyDocumentsPath);
            ProjectManager.SaveToFile(project);
            Assert.AreEqual(File.ReadAllText(ProjectManager.StringMyDocumentsPath, Encoding.UTF8),
                JsonConvert.SerializeObject(project),
                "Проект сохранён с ошибками");
        }
    }
}