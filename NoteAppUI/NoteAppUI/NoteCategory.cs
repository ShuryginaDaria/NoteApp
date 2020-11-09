using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TUSUR.NoteApp
{
    /// <summary>
    /// Содержит возможные категории заметок.
    /// </summary>
    /// <remarks>
    /// В качестве типа перечислителей используется тип byte, 
    /// поскольку это позволит сэкономить память при большом количестве заметок 	(порядка 200).
    /// </remarks>
    enum NoteСategory : byte
    {
        Work,
        Home,
        HealseAndSport,
        People,
        Document,
        Finance,
        Other
    };
}
