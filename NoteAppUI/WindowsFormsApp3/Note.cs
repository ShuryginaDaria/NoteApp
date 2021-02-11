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
    public class Note : ICloneable, IEquatable<Note>
    {
        /// <summary>
        /// Текст названия.
        /// </summary>
        private string _title;

        /// <summary>
        /// Категория заметки.
        /// </summary>
        private NoteCategory _category;

        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _text;

        /// <summary>
        /// Время создания.
        /// </summary>
        private DateTime _creationTime;

        /// <summary>
        /// Время последнего изменения.
        /// </summary>
        private DateTime _lastChangeTime;

        public Note()
        {
            _title = "Новая запись";
            _category = NoteCategory.Other;
            _text = "";
            _creationTime = DateTime.Now;
            _lastChangeTime = DateTime.Now;
        }

        public Note(string title, NoteCategory category, string text)
        {
            _title = title;
            _category = category;
            _text = text;
            _creationTime = DateTime.Now;
            _lastChangeTime = DateTime.Now;
        }

        /// <summary>
        /// Выполняет копирование объекта класса Note.
        /// </summary>
        public object Clone()
        {
            return new Note
            {
                _title = this._title,
                _category = this._category,
                _text = this._text,
                _creationTime = this._creationTime,
                _lastChangeTime = this._lastChangeTime
            };
        }

        /// <summary>
        /// Возвращает или задает текст названия заметки.
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length > 50)
                    throw new ArgumentException("Заголовок должен иметь длину не более 50 символов.");
                else
                    _title = value;
            }
        }

        /// <summary>
        /// Возвращает или задает категорию заметки.
        /// </summary>
        public NoteCategory Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        /// <summary>
        /// Возвращает или задает основной текст заметки.
        /// </summary>
        public string Text
        {
            set
            {
                _text = value;
            }
            get
            {
                return _text;
            }
        }

        /// <summary>
        /// Возвращает время создания заметки.
        /// </summary>
        public DateTime CreationTime
        {
            set
            {
                _creationTime = value;
            }
            get
            {
                return _creationTime;
            }
        }

        /// <summary>
        /// Возвращает время последнего изменения заметки.
        /// </summary>
        public DateTime LastChangeTime
        {
            set
            {
                _lastChangeTime = value;
            }

            get
            {
                return _lastChangeTime;
            }
        }

        public bool Equals(Note other)
        {
            if (other == null)
                return false;
            return other.Category == Category &&
                   other.Text == Text &&
                   other.Title == Title &&
                   other.CreationTime == CreationTime &&
                   other.LastChangeTime == LastChangeTime;
        }
    }
}