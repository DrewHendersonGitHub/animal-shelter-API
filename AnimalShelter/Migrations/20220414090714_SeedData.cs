using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Breed", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, 2, "Siamese", "M", "Joe" },
                    { 9, 2, "Cat", "F", "Cat" },
                    { 8, 6, "Normal", "M", "Mittens" },
                    { 7, 7, "Old", "F", "Geraldo" },
                    { 6, 5, "Fat", "M", "Whiskers" },
                    { 10, 4, "Loud", "F", "Meow" },
                    { 4, 1, "Small", "M", "Frank" },
                    { 3, 3, "Big", "F", "Bob" },
                    { 2, 6, "Tabby", "F", "Jim" },
                    { 5, 4, "Tall", "M", "Larry" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "Gender", "Name" },
                values: new object[,]
                {
                    { 9, 6, "Cool", "F", "Ronald" },
                    { 1, 6, "Dalmation", "F", "Spot" },
                    { 2, 9, "Hound", "M", "Mike" },
                    { 3, 10, "Lab", "M", "Jerry" },
                    { 4, 4, "Fast", "F", "Jesse" },
                    { 5, 13, "old", "M", "Michael" },
                    { 6, 6, "Blue", "F", "Bark" },
                    { 7, 6, "Big", "M", "Fetch" },
                    { 8, 1, "Small", "M", "Arf" },
                    { 10, 1, "Dog", "M", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 10);
        }
    }
}
