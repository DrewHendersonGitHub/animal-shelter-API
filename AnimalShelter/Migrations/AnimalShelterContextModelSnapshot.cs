// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CatId");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            CatId = 1,
                            Age = 2,
                            Breed = "Siamese",
                            Gender = "M",
                            Name = "Joe"
                        },
                        new
                        {
                            CatId = 2,
                            Age = 6,
                            Breed = "Tabby",
                            Gender = "F",
                            Name = "Jim"
                        },
                        new
                        {
                            CatId = 3,
                            Age = 3,
                            Breed = "Big",
                            Gender = "F",
                            Name = "Bob"
                        },
                        new
                        {
                            CatId = 4,
                            Age = 1,
                            Breed = "Small",
                            Gender = "M",
                            Name = "Frank"
                        },
                        new
                        {
                            CatId = 5,
                            Age = 4,
                            Breed = "Tall",
                            Gender = "M",
                            Name = "Larry"
                        },
                        new
                        {
                            CatId = 6,
                            Age = 5,
                            Breed = "Fat",
                            Gender = "M",
                            Name = "Whiskers"
                        },
                        new
                        {
                            CatId = 7,
                            Age = 7,
                            Breed = "Old",
                            Gender = "F",
                            Name = "Geraldo"
                        },
                        new
                        {
                            CatId = 8,
                            Age = 6,
                            Breed = "Normal",
                            Gender = "M",
                            Name = "Mittens"
                        },
                        new
                        {
                            CatId = 9,
                            Age = 2,
                            Breed = "Cat",
                            Gender = "F",
                            Name = "Cat"
                        },
                        new
                        {
                            CatId = 10,
                            Age = 4,
                            Breed = "Loud",
                            Gender = "F",
                            Name = "Meow"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DogId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogId = 1,
                            Age = 6,
                            Breed = "Dalmation",
                            Gender = "F",
                            Name = "Spot"
                        },
                        new
                        {
                            DogId = 2,
                            Age = 9,
                            Breed = "Hound",
                            Gender = "M",
                            Name = "Mike"
                        },
                        new
                        {
                            DogId = 3,
                            Age = 10,
                            Breed = "Lab",
                            Gender = "M",
                            Name = "Jerry"
                        },
                        new
                        {
                            DogId = 4,
                            Age = 4,
                            Breed = "Fast",
                            Gender = "F",
                            Name = "Jesse"
                        },
                        new
                        {
                            DogId = 5,
                            Age = 13,
                            Breed = "old",
                            Gender = "M",
                            Name = "Michael"
                        },
                        new
                        {
                            DogId = 6,
                            Age = 6,
                            Breed = "Blue",
                            Gender = "F",
                            Name = "Bark"
                        },
                        new
                        {
                            DogId = 7,
                            Age = 6,
                            Breed = "Big",
                            Gender = "M",
                            Name = "Fetch"
                        },
                        new
                        {
                            DogId = 8,
                            Age = 1,
                            Breed = "Small",
                            Gender = "M",
                            Name = "Arf"
                        },
                        new
                        {
                            DogId = 9,
                            Age = 6,
                            Breed = "Cool",
                            Gender = "F",
                            Name = "Ronald"
                        },
                        new
                        {
                            DogId = 10,
                            Age = 1,
                            Breed = "Dog",
                            Gender = "M",
                            Name = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
