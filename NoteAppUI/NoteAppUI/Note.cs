using System;

public Note()
{
    _title = "";
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
