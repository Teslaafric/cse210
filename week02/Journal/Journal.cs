using System;
using System.Collections.Generic;
using System.IO;



public class Journal
{
  public List<Entry> _myEntries = new List<Entry>();
  
  public void AddEntry(Entry entry)
  {
    _myEntries.Add(entry);
  }

  public void Display()
  {
    foreach (Entry note in _myEntries)
    {
      note.Display();
    }
  }
  
  public void Save(string file)
  {
    using (StreamWriter output = new StreamWriter(file))
    {
      foreach (Entry note in _myEntries)
      {
        output.WriteLine(note.ToFileString());
      }
    }
  }

  public void Load(string file)
  {
    _myEntries.Clear();

    string[] lines = File.ReadAllLines(file);

    foreach (string line in lines)
    {
      Entry note = Entry.FromFileString(line);
      _myEntries.Add(note);
    }

  }
  
}


