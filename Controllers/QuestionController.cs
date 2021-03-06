using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using suncoast_overflow.Models;
using suncoast_overflow;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace suncoast_overflow.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class QuestionsController : ControllerBase
  {
    private DatabaseContext context;
    public QuestionsController(DatabaseContext _context)
    {
      this.context = _context;
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<Questions>> GetAllResults()
    {
      var Allresults = context.Questions.OrderByDescending(results => results.id);

      return Allresults.ToList();
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult GetOneEntry(int id)
    {
      var OneResult = context.Questions.FirstOrDefault(r => r.id == id);
      if (OneResult == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(OneResult);
      }
    }

    // POST api/values
    [HttpPost]
    public ActionResult<Questions> InsertData([FromBody]Questions insertion)
    {
      context.Questions.Add(insertion);
      context.SaveChanges();
      return insertion;
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public ActionResult<Questions> Update(int id, [FromBody]Questions newDetails)
    {
      context.Entry(newDetails).State = EntityState.Modified;
      context.SaveChanges();
      return newDetails;
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult<Questions> DeleteEntry(int id)
    {
      var DeleteResult = context.Questions.FirstOrDefault(r => r.id == id);
      context.Questions.Remove(DeleteResult);
      context.SaveChanges();
      return Ok();

    }
  }
}