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

    /// В качестве типа перечислителей используется тип byte, 
    /// потому что это позволит сэкономить память при большом количестве заметок 	(порядка 200).
   
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
