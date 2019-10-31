using System;
using System.Collections.Generic;

namespace suncoast_overflow.Models
{

  public class Answers
  {
    public string title { get; set; }
    public DateTime date { get; set; } = DateTime.Now;
    public int? id { get; set; }
    public string author { get; set; }
    public int? upvote { get; set; }
    public int? downvote { get; set; }
    public string content { get; set; }
    public int? QuestionsId { get; set; }
    public Questions Questions { get; set; }
  }
}