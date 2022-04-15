# _Animal Shelter API_

### _By Drew Henderson_

#### _This API lets you access information about the dogs and cats in a local animal shelter._

## Technologies Used

* _C#_
* _.NET_
* _cshtml_
* _Entity Framework_
* _MySQL_
* _Swagger_

## Endpoints

All Cat routes are identical to Dog routes, just replace ```cat``` with ```dog```.

_GET ```/api/Cats``` - Used for viewing cats data._

* _catId - int - Will return the cat with this ID if one exists._
* _name - string - Will include only cats that match the name._
* _breed - string - Will include only cats that match the breed._
* _minAge - int - Will remove cats with a lower age._
* _maxAge - int - Will remove cats with a higher age._
* _gender - string - either m or f._

_GET ```/api/Cats/Random``` - Returns a random cat._

* _amount - int - Will return that many random cats with a minumum of 1 and maximum of every cat._

_GET ```/api/Cats/{id}``` - Used for returning a cat of a specific ID if one exists._

* _id - int - Picks the cat to be returned._

_POST ```/api/Cats``` - Used for adding a new cat the the database._

_Request Body:_

>* _catId - int - The id of the cat._
>* _name - string, required, max length 50 - The name of the cat._
>* _breed - string, required, max length 50 - The breed of the cat._
>* _age - int, max value 50 - The age of the cat._
>* _gender - string, required - The gender of the cat, either m or f._

_PUT ```/api/Cats/{id}``` - Used for updating an existing cat's data._

* _id - int - Picks the cat to be returned._

_Request Body:_

>* _catId - int - The id of the cat._
>* _name - string, required, max length 50 - The name of the cat._
>* _breed - string, required, max length 50 - The breed of the cat._
>* _age - int, max value 50 - The age of the cat._
>* _gender - string, required - The gender of the cat, either m or f._

_DELETE ```/api/Cats/{id}``` - Used for removing a cat._

* _id - int - Picks the cat to be deleted._

## Description

_This API doesn't store any real world animals in it, just some names I made up. This project has full CRUD functionality. If you navigate to ```http://localhost:5000/swagger/index.html``` when you have the API running, then you can see a list of all endpoints and routes, and try them out by entering parameters and see the returned information._

## Setup/Installation Requirements

* _Make sure you have [.NET 5 SDK](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) and [MySQL Workbench](https://dev.mysql.com/downloads/mysql/) installed._
* _Install dotnet-ef if you haven't yet with ```dotnet tool install --global dotnet-ef```._
* _Download or clone ```https://github.com/DrewHendersonGitHub/animal-shelter-API``` to your computer._
* _In a terminal inside directory ```Bakery```, make a new file ```appsettings.json```._
* _Add the following code with ```{DATABASE}```, ```{USERNAME}```, and ```{PASSWORD}``` replaced with your choice._
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database={DATABASE};uid={USERNAME};pwd={PASSWORD};"
  }
}
```
* _Run `dotnet ef database update` inside the ```Factory``` directory to build your database._
* _Run ```dotnet restore``` and ```dotnet run``` in your terminal to build the project and open a local server._
* _CTRL click on the first listed URL, likely to be ```http://localhost:5000/``` to see the swagger page._
* _Interact with the API through a program like Postman or simply a web browser._

## Known Bugs

* _No known bugs at this time._

## License

[MIT](https://opensource.org/licenses/MIT)

_Copyright (c) 2022  Drew Henderson_