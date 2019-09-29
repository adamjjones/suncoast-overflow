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
  public class AnswersController : ControllerBase
  {
    private DatabaseContext context;
    public AnswersController(DatabaseContext _context)
    {
      this.context = _context;
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<Answers>> GetAllResults()
    {
      var Allresults = context.Answers.OrderByDescending(results => results.id);

      return Allresults.ToList();
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult GetOneEntry(int id)
    {
      var OneResult = context.Answers.FirstOrDefault(r => r.id == id);
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
    public ActionResult<Answers> InsertData([FromBody]Answers insertion)
    {
      context.Answers.Add(insertion);
      context.SaveChanges();
      return insertion;
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public ActionResult<Answers> Update(int id, [FromBody]Answers newDetails)
    {
      context.Entry(newDetails).State = EntityState.Modified;
      context.SaveChanges();
      return newDetails;
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult<Answers> DeleteEntry(int id)
    {
      var DeleteResult = context.Answers.FirstOrDefault(r => r.id == id);
      context.Answers.Remove(DeleteResult);
      context.SaveChanges();
      return Ok();

    }
  }
}