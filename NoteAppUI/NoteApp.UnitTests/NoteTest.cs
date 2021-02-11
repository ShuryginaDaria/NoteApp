using System;
using System.Threading;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    /// <summary>
    /// Класс юнит-тестов Note
    /// </summary>
    [TestFixture]
    public class NoteTests
    {
        private Note _note;
        
        [SetUp]
        public void Setup()
        {
            _note = new Note();
        }

        [TestCase(Description = "Позитивный тест NoteCategory")]
        public void NoteCategoryTest()
        {
            var category = NoteCategory.Home;
            _note.Category = category;
            Assert.AreEqual(_note.Category, category, "Неправильная категория заметки");
        }

        [TestCase(Description = "Позитивный тест Text")]
        public void TextPositiveTest()
        {
            var text = "Text test";
            _note.Text = text;
            Assert.AreEqual(_note.Text, text, "Неправильный текст заметки");
        }
        
        [TestCase(Description = "Позитивный тест сеттера Title")]
        public void TitleTest()
        {
            var title = "title";
            _note.Title = title;
            Assert.AreEqual(_note.Title, title, "Значения Title не совпали");
        }

        [TestCase(Description = "Негативный тест Title, проверка на null")]
        public void TitleNullExceptionTest()
        {
            Assert.Throws<NullReferenceException>(() => _note.Title = null,
                "Не было брошено NullReferenceException");
        }

        [TestCase(Description = "Негативный тест Title, проверка на длинное значение")]
        public void TitleArgumentExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => _note.Title = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1",
                "Не было брошено ArgumentException");
        }

        [TestCase(Description = "Позитивный тест CreationTime")]
        public void CreationTimeTest()
        {
            var creation = DateTime.Now;
            _note.CreationTime = creation;
            Assert.AreEqual(_note.CreationTime, creation, "Неправильная дата создания");
        }

        [TestCase(Description = "Позитивный тест LastModifiedAt")]
        public void LastChangeTimeTest()
        {
            var changed = DateTime.Now;
            _note.LastChangeTime = changed;
            Assert.AreEqual(_note.LastChangeTime, changed, "Неправильная дата изменения");
        }
    }
}