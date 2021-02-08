using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;

namespace NoteApp
{
    /// <summary>
    /// Класс, содержащий список всех заметок.
    /// </summary>
    public class Project
    {
        private List <Note> _notesList { get; set; } = new List<Note>();

        /// <summary>
        /// Возвращает или задает список всех заметок.
        /// </summary>
        public List<Note> NotesList
        {
            get
            {
                return _notesList;
            }
            set
            {
                _notesList = value;
            }
        }
    }
}