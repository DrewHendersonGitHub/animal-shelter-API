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
    public async Task<ActionResult<IEnumerable<Dog>>> Get()
    {
      return await _db.Dogs.ToListAsync();
    }

    // POST api/Dogs
    [HttpPost]
    public async Task<ActionResult<Dog>> Post(Dog dog)
    {
      _db.Dogs.Add(dog);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post", new { id = dog.DogId }, dog);
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