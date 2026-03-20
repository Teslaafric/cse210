using System.Collections.Generic;


public class PromptGenerator
{
  Random rand = new Random();
  public List<string> _prompts = new List<string>()
  {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "Task i didn't get to do today?",
    "Did i manage my time effectively, and how?",
    "Did i spend on budget today?"
  };
  public string GetRandomPrompt()
  {
    return _prompts[rand.Next(_prompts.Count)];
  }
}