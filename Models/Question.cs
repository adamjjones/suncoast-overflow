using System;

namespace suncoast_overflow.Models
{
  public class Question
  {
    public int id { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string UserName { get; set; }
    public int upvote { get; set; }
    public int downvote { get; set; }

  }
}