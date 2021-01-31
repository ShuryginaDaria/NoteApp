using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp;

namespace NoteApp
{
    /// <summary>
    /// Класс, содержащий словарь всех заметок.
    /// </summary>
    public class Project
    {
        private Dictionary<int, Note> _projectDictionary { get; set; } = new Dictionary<int, Note>();
    }
}