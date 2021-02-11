using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    /// <summary>
    /// Класс юнит-тестов Project
    /// </summary>
    [TestFixture]
    public class ProjectTest
    {
        private Project _project;
        
        [SetUp]
        public void Setup()
        {
            _project = new Project
            {
                NotesList = new List<Note>()
                {
                    new Note()
                    {
                        Title = "note1",
                        Category = NoteCategory.People,
                        Text = "text1",
                        CreationTime = new DateTime(2021, 01, 01),
                        LastChangeTime = new DateTime(2021, 01, 02)
                    },
                    new Note()
                    {
                        Title = "note 2",
                        Category = NoteCategory.People,
                        Text = "note2text",
                        CreationTime = new DateTime(2020, 01, 01),
                        LastChangeTime = new DateTime(2020, 01, 02)
                    },
                    new Note()
                    {
                        Title = "note 3",
                        Category = NoteCategory.Other,
                        Text = "text 3",
                        CreationTime = new DateTime(2019, 01, 01),
                        LastChangeTime = new DateTime(2019, 01, 02)
                    }
                }
            };
        }

        [TestCase(Description = "Позитивный тест CurrentNote")]
        public void CurrentNotePositiveTest()
        {
            var note = new Note {Title = "note"};
            _project.CurrentNote = note;
            Assert.AreEqual(_project.CurrentNote, note, "Неправильная текущая заметка");
        }

        [TestCase(Description = "Позитивный тест Notes")]
        public void NotesPositiveTest()
        {
            var note = new List<Note>()
            {
                new Note()
                {
                    Title = "note",
                    Category = NoteCategory.Finance,
                    CreationTime = DateTime.Today,
                    LastChangeTime = DateTime.Now,
                    Text = "text"
                }
            };
            _project.NotesList = note;
            Assert.AreEqual(_project.NotesList, note, "Неправильный список заметок");
        }

        [TestCase(Description = "Тест сортировки заметок")]
        public void SortByDateTest()
        {
            Assert.AreEqual(_project.NotesList
                .OrderByDescending(i => i.LastChangeTime)
                .ToList(), _project.SortToLastChangeDate(),
                "Неправильно сортируются заметки");
        }

        [TestCase(Description = "Тест сортировки пустого списка")]
        public void SortByDateEmptyListTest()
        {
            _project = new Project()
            {
                NotesList = new List<Note>()
            };
            Assert.AreEqual(_project.NotesList
                    .OrderByDescending(i => i.LastChangeTime)
                    .ToList(), _project.SortToLastChangeDate(),
                "Ошибка сортировки пустого списка");
        }

        [TestCase(Description = "Тест сортировки заметок по категориям")]
        public void SortByDateFromCategoryTest()
        {
            Assert.AreEqual(_project
                .NotesList
                .Where(i => i.Category == NoteCategory.Document)
                .OrderByDescending(j => j.LastChangeTime)
                .ToList(), _project.SortToLastChangeDate(NoteCategory.Document),
                "Неправильно сортируются заметки по категориям");
        }
        
        [TestCase(Description = "Тест сортировки заметок по категориям")]
        public void SortByDateFromCategoryEmptyListTest()
        {
            _project = new Project()
            {
                NotesList = new List<Note>()
            };
            Assert.AreEqual(_project
                    .NotesList
                    .Where(i => i.Category == NoteCategory.Document)
                    .OrderByDescending(j => j.LastChangeTime)
                    .ToList(), _project.SortToLastChangeDate(NoteCategory.Document),
                "Ошибка сортировки категории из пустого списка");
        }
    }
}