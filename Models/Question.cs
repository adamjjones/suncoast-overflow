using System;
using System.Collections.Generic;

namespace suncoast_overflow.Models
{
  public class Questions
  {
    public int id { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string UserName { get; set; }
    public int upvote { get; set; }
    public int downvote { get; set; }

    public List<Answers> Answers { get; set; } = new List<Answers>();
    // public Answers Answers { get; set; }
  }
}