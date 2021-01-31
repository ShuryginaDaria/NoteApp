using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс заметок.
    /// </summary>
    internal class Note : ICloneable
    {
        /// <summary>
        /// Текст названия.
        /// </summary>
        /// <remarks>
        /// Доступно для изменений.
        /// </remarks>
        private string _title { get; set; }
        /// <summary>
        /// Категория заметки.
        /// </summary>
       
        private NoteСategory _category { get; set; }
        /// <summary>
        /// Текст заметки.
        /// </summary>
       
        private string _text { get; set; }
        /// <summary>
        /// Время создания.
        /// </summary>
       
        private readonly DateTime _creationTime;
        /// <summary>
        /// Время последнего изменения.
        /// </summary>
        
        private DateTime _lastChangeTime { get; }

        public Note()
        {
            _title = "Новая запись";
            _category = NoteСategory.Other;
            _text = "";
            _creationTime = DateTime.Now;
            _lastChangeTime = DateTime.Now;
        }

        public Note(string title, NoteСategory category, string text)
        {
            _title = title;
            _category = category;
            _text = text;
            _creationTime = DateTime.Now;
            _lastChangeTime = DateTime.Now;
        }

        /// <summary>
        /// Метод, выполняющий копирование объекта.
        /// </summary>
        public object Clone()
        {
            return new Note
            {
                _title = this._title,
                _category = this._category,
                _text = this._text
            };
        }

        /// <summary>
        /// Возвращает и задает текст названия.
        /// </summary>
        internal string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length > 50)
                    _title = value.Substring(0, 50);
                else
                    _title = value;
            }
        }

        /// <summary>
        /// Возвращает время создания заметки.
        /// </summary>
        internal DateTime CreationTime
        {
            get
            {
                return _creationTime;
            }
        }

    }
}