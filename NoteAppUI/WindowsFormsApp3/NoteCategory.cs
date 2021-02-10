using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Содержит возможные категории заметок.
    /// </summary>
    public enum NoteCategory : byte
    {
        Document,
        Finance,
        HealthAndSport,
        Home,
        Other,
        People,
        Work,
    };
}