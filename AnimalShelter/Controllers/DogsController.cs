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
  public class DogsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public DogsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/Dogs
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Dog>>> Get(int dogId, string name, string breed, int minAge, int maxAge, string gender)
    {
      var query = _db.Dogs.AsQueryable();

      if (dogId != 0)
      {
        query = query.Where(e => e.DogId == dogId);
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

      if (gender == "m" || gender == "f")
      {
        query = query.Where(e => e.Gender == gender);
      }

      return await query.ToListAsync();
    }
    
    // GET: api/Dogs/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Dog>> GetDog(int id)
    {
      var dog = await _db.Dogs.FindAsync(id);

      if (dog == null)
      {
        return NotFound();
      }
      return dog;
    }
    
    // GET: api/Dogs/Random
    [HttpGet]
    [Route("Random")]
    public async Task<ActionResult<IEnumerable<Dog>>> Random(int amount)
    {
      var query = _db.Dogs.AsQueryable();
      if (amount > query.Count())
      {
        amount = query.Count();
      }
      int first = query.OrderBy(d => d.DogId).FirstOrDefault().DogId;
      int last = query.OrderBy(d => d.DogId).LastOrDefault().DogId;
      List<int> dogList = new List<int>();
      do
      {
        Random random = new Random();
        int r = 0;
        while (!query.Any(d => d.DogId == r))
        {
          r = random.Next(first, (last + 1));
          if (!dogList.Contains(r))
          {
            dogList.Add(r);
          }
          else
          {
            r = 0;
          }
        }
        amount--;
      } while (amount > 0);
      query = query.Where(d => dogList.Contains(d.DogId));
      return await query.ToListAsync();
    }

    // POST api/Dogs
    [HttpPost]
    public async Task<ActionResult<Dog>> Post(Dog dog)
    {
      _db.Dogs.Add(dog);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post", new { id = dog.DogId }, dog);
    }
    
    // PUT: api/Dogs/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Dog dog)
    {
      if (id != dog.DogId)
      {
        return BadRequest();
      }

      _db.Entry(dog).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DogExists(id))
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
    
    // DELETE: api/Dogs/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDog(int id)
    {
      var dog = await _db.Dogs.FindAsync(id);
      if (dog == null)
      {
        return NotFound();
      }

      _db.Dogs.Remove(dog);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    private bool DogExists(int id)
    {
      return _db.Dogs.Any(e => e.DogId == id);
    }
  }
}