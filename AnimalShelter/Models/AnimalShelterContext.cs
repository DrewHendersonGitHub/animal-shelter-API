using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
      .HasData(
        new Cat { CatId = 1, Name = "Joe", Breed = "Siamese", Age = 2, Gender = "M" },
        new Cat { CatId = 2, Name = "Jim", Breed = "Tabby", Age = 6, Gender = "F" },
        new Cat { CatId = 3, Name = "Bob", Breed = "Big", Age = 3, Gender = "F" },
        new Cat { CatId = 4, Name = "Frank", Breed = "Small", Age = 1, Gender = "M" },
        new Cat { CatId = 5, Name = "Larry", Breed = "Tall", Age = 4, Gender = "M" },
        new Cat { CatId = 6, Name = "Whiskers", Breed = "Fat", Age = 5, Gender = "M" },
        new Cat { CatId = 7, Name = "Geraldo", Breed = "Old", Age = 7, Gender = "F" },
        new Cat { CatId = 8, Name = "Mittens", Breed = "Normal", Age = 6, Gender = "M" },
        new Cat { CatId = 9, Name = "Cat", Breed = "Cat", Age = 2, Gender = "F" },
        new Cat { CatId = 10, Name = "Meow", Breed = "Loud", Age = 4, Gender = "F" }
      );
      builder.Entity<Dog>()
      .HasData(
        new Dog { DogId = 1, Name = "Spot", Breed = "Dalmation", Age = 6, Gender = "F" },
        new Dog { DogId = 2, Name = "Mike", Breed = "Hound", Age = 9, Gender = "M" },
        new Dog { DogId = 3, Name = "Jerry", Breed = "Lab", Age = 10, Gender = "M" },
        new Dog { DogId = 4, Name = "Jesse", Breed = "Fast", Age = 4, Gender = "F" },
        new Dog { DogId = 5, Name = "Michael", Breed = "old", Age = 13, Gender = "M" },
        new Dog { DogId = 6, Name = "Bark", Breed = "Blue", Age = 6, Gender = "F" },
        new Dog { DogId = 7, Name = "Fetch", Breed = "Big", Age = 6, Gender = "M" },
        new Dog { DogId = 8, Name = "Arf", Breed = "Small", Age = 1, Gender = "M" },
        new Dog { DogId = 9, Name = "Ronald", Breed = "Cool", Age = 6, Gender = "F" },
        new Dog { DogId = 10, Name = "Dog", Breed = "Dog", Age = 1, Gender = "M" }
      );
    }

    public DbSet<Cat> Cats { get; set; }
    public DbSet<Dog> Dogs { get; set; }
  }
}