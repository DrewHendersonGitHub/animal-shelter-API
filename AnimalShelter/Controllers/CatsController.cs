using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public CatsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/Cats
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cat>>> Get(int catId, string name, string breed, int minAge, int maxAge, string gender)
    {
      var query = _db.Cats.AsQueryable();

      if (catId != 0)
      {
        query = query.Where(e => e.CatId == catId);
      }

      if (name != null)
      {
        query = query.Where(e => e.Name == name);
      }

      if (breed != null)
      {
        query = query.Where(e => e.Breed == breed);
      }

      if (minAge > 0)
      {
        query = query.Where(e => e.Age >= minAge);
      }

      if (maxAge != 0)
      {
        query = query.Where(e => e.Age <= maxAge);
      }

      if (gender != null)
      {
        query = query.Where(e => e.Gender == gender);
      }

      return await query.ToListAsync();
    }

    // GET: api/Cats/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Cat>> GetCat(int id)
    {
      var cat = await _db.Cats.FindAsync(id);

      if (cat == null)
      {
        return NotFound();
      }
      return cat;
    }
    
    // GET: api/Cats/Random
    [HttpGet]
    [Route("Random")]
    public async Task<ActionResult<IEnumerable<Cat>>> Random(int amount)
    {
      var query = _db.Cats.AsQueryable();
      if (amount > query.Count())
      {
        amount = query.Count();
      }
      int first = query.OrderBy(e => e.CatId).FirstOrDefault().CatId;
      int last = query.OrderBy(e => e.CatId).LastOrDefault().CatId;
      List<int> catList = new List<int>();
      while (amount > 0)
      {
        Random random = new Random();
        int r = 0;
        while (!query.Any(c => c.CatId == r))
        {
          r = random.Next(first, (last + 1));
          if (!catList.Contains(r))
          {
            catList.Add(r);
          }
          else
          {
            r = 0;
          }
        }
        amount--;
      }
      query = query.Where(entry => catList.Contains(entry.CatId));
      return await query.ToListAsync();
    }

    // POST api/Cats
    [HttpPost]
    public async Task<ActionResult<Cat>> Post(Cat cat)
    {
      _db.Cats.Add(cat);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post", new { id = cat.CatId }, cat);
    }
    
    // PUT: api/Cats/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Cat cat)
    {
      if (id != cat.CatId)
      {
        return BadRequest();
      }

      _db.Entry(cat).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CatExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }
    
    // DELETE: api/Cats/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCat(int id)
    {
      var cat = await _db.Cats.FindAsync(id);
      if (cat == null)
      {
        return NotFound();
      }

      _db.Cats.Remove(cat);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    private bool CatExists(int id)
    {
      return _db.Cats.Any(e => e.CatId == id);
    }
  }
}