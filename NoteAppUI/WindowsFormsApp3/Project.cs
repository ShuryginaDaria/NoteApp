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
        private List <Note> _notesList = new List<Note>();

        private Note _currentNote;

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

        public List<Note> SortToLastChangeDate()
        {
            var sortedList = NotesList
                .OrderByDescending(i => i.LastChangeTime)
                .ToList();

            return sortedList;
        }

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