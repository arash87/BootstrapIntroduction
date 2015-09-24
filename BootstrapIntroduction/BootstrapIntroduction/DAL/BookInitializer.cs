using BootstrapIntroduction.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BootstrapIntroduction.DAL
{
    public class BookInitializer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var author = new Author
            {
                Biography = "...",
                FirstName = "Jamie",
                LastName = "Munro"
            };

            var books = new List<Book>{
                new Book{
                    Author = author,
                    Description = "....",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51T%2BWt430bL._AA160_.jpg",
                    Isbn = "1491919191645",
                    Synopsis = ".......",
                    Title = "Jende Az Ghafas Parid"
                },
                 new Book{
                    Author = author,
                    Description = "....",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51T%2BWt430bL._AA160_.jpg",
                    Isbn = "1491944791645",
                    Synopsis = ".......",
                    Title = "Jende Az Ghafas Parid 2"
                },
                 new Book{
                    Author = author,
                    Description = "....",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51T%2BWt430bL._AA160_.jpg",
                    Isbn = "1531919191645",
                    Synopsis = ".......",
                    Title = "Homofob"
                }, 
                new Book{
                    Author = author,
                    Description = "....",
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51T%2BWt430bL._AA160_.jpg",
                    Isbn = "14910007645",
                    Synopsis = ".......",
                    Title = "HetrofilFob"
                }
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
        }

    }
}