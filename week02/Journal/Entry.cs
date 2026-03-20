using System;


public class Entry
{
  public string _randomPromptText;
  public string _date;
  public string _textInput;
  public string _myMood;

  public void Display()
  {
    Console.WriteLine($"Date: {_date}");
    Console.WriteLine($"Prompt: {_randomPromptText}");
    Console.WriteLine($"Response: {_textInput}");  
    Console.WriteLine($"Mood: {_myMood}");
  }

  public string ToFileString()
  {
    return $"{_date} | {_randomPromptText} | {_textInput} | {_myMood}";
  }

  public static Entry FromFileString(string line)
  {
    string[] parts = line.Split("|");

    Entry note = new Entry();
    note._date = parts[0];
    note._randomPromptText = parts[1];
    note._textInput = parts[2];
    note._myMood = parts[3];

    return note;
    


  }

}