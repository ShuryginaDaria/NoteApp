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
            List<Note> sortedList = _notesList;
            int listLength = sortedList.Count;
            Note tmp = new Note();


            for(int i = 0; i < listLength; i++)
            {
                for (int j = (listLength-1); j >= (i+1); j--)
                {
                    if (sortedList[j].LastChangeTime > sortedList[j-1].LastChangeTime)
                    {
                        tmp = sortedList[j];
                        sortedList[j] = sortedList[j - 1];
                        sortedList[j - 1] = tmp;
                    }
                }
            }

            return sortedList;
        }

        public List<Note> SortToLastChangeDate(NoteCategory category)
        {
            List<Note> sortedList = new List<Note>();

            for (int k = 0; k < _notesList.Count; k++)
            {
                if (_notesList[k].Category == category)
                    sortedList.Add(_notesList[k]);
            }
            
            int listLength = sortedList.Count;
            Note tmp = new Note();


            for (int i = 0; i < listLength; i++)
            {
                for (int j = (listLength - 1); j >= (i + 1); j--)
                {
                    if (sortedList[j].LastChangeTime > sortedList[j - 1].LastChangeTime)
                    {
                        tmp = sortedList[j];
                        sortedList[j] = sortedList[j - 1];
                        sortedList[j - 1] = tmp;
                    }
                }
            }

            return sortedList;
        }
    }
}