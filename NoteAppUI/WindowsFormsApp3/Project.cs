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
    public class Project : IEquatable<Project>
    {
        /// <summary>
        /// Список всех заметок, создаваемых в программе.
        /// </summary>
        private List <Note> _notesList = new List<Note>();

        /// <summary>
        /// Последняя выбранная пользователем заметка.
        /// </summary>
        private Note _currentNote;

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

        /// <summary>
        /// Возвращает или задает последнюю выбранную заметку.
        /// </summary>
        public Note CurrentNote
        {
            set
            {
                _currentNote = value;
            }
            get
            {
                return _currentNote;
            }
        }

        /// <summary>
        /// Возвращает список всех заметок, отсортированный по дате последнего изменения.
        /// </summary>
        public List<Note> SortToLastChangeDate()
        {
            var sortedList = NotesList
                .OrderByDescending(i => i.LastChangeTime)
                .ToList();

            return sortedList;
        }

        /// <summary>
        /// Возвращает список всех заметок выбранной категории, 
        /// отсортированный по дате последнего изменения.
        /// </summary>
        public List<Note> SortToLastChangeDate(NoteCategory category)
        {
            var sortedList = NotesList
                .Where(j => j.Category == category)
                .OrderByDescending(i => i.LastChangeTime)
                .ToList();

            return sortedList;
        }

        public bool Equals(Project other)
        {
            if (other == null)
                return false;
            var notesEqual = NotesList.SequenceEqual(other.NotesList);
            var currentNoteEqual = CurrentNote.Equals(other.CurrentNote);
            return notesEqual && currentNoteEqual;
        }
    }
}