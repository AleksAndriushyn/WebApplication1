using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Impl
{
    public static class Storage
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();

            List<Book> books = new List<Book>()
            {
            new Book{Title = "War and peace", Pages = 200},
            new Book{Title ="The Old Man and the Sea", Pages = 550},
            new Book{Title="It", Pages = 1200},
            new Book{Title="Three comrades", Pages = 300},
            new Book{Title="The Picture of Dorian Grey", Pages = 720}
            };

            List<Author> authors = new List<Author>()
            {
            new Author{FirstName = "Lev", LastName = "Tolstoy", DateOfBirth = new DateTime(1828, 09, 9)},
            new Author{FirstName = "Ernest", LastName = "Hemingway", DateOfBirth = new DateTime(1899, 07, 21)},
            new Author{FirstName = "Stephen", LastName = "King", DateOfBirth = new DateTime(1947, 09, 21)},
            new Author{FirstName = "Erich", LastName = "Remark", DateOfBirth = new DateTime(1898, 06, 22)},
            new Author{FirstName = "Oscar", LastName = "Wilde", DateOfBirth = new DateTime(1854, 10, 16)}
            };

            List<Authors_Book> authors_books = new List<Authors_Book>()
            {
            new Authors_Book{FirstName = "Lev", LastName = "Tolstoy", AuthorId = 1, BookId = 1},
            new Authors_Book{FirstName = "Ernest", LastName = "Hemingway", AuthorId = 2, BookId = 2},
            new Authors_Book{FirstName = "Stephen", LastName = "King", AuthorId = 3, BookId = 3},
            new Authors_Book{FirstName = "Erich", LastName = "Remark", AuthorId = 4, BookId = 4},
            new Authors_Book{FirstName = "Oscar", LastName = "Wilde", AuthorId = 5, BookId = 5}
            };

            List<Chapter> chapters = new List<Chapter>()
            {
            new Chapter{Title = "The beginning of hero's life", BookId = 1},
            new Chapter{Title = "To the stars!", BookId = 2},
            new Chapter{Title = "New Life", BookId = 3},
            new Chapter{Title = "The God", BookId = 4},
            new Chapter{Title = "Adventure begins", BookId = 5}
            };

            List<Reader> readers = new List<Reader>()
            {
            new Reader{FirstName = "Dmitry", LastName = "Gordon"},
            new Reader{FirstName = "Elon", LastName = "Musk"},
            new Reader{FirstName = "Johnny", LastName = "Depp"},
            new Reader{FirstName = "Tom", LastName = "Hanks"},
            new Reader{FirstName = "Ariana", LastName = "Grande"}
            };

            List<Readers_Card> readers_cards = new List<Readers_Card>()
            {
            new Readers_Card{FirstName = "Dmitry", LastName = "Gordon", Date = new DateTime(1967, 10, 21), BookId = 1, ReaderId = 1},
            new Readers_Card{FirstName = "Elon", LastName = "Musk", Date = new DateTime(1967, 06, 28), BookId = 2, ReaderId = 2},
            new Readers_Card{FirstName = "Johnny", LastName = "Depp", Date = new DateTime(1963, 06, 09), BookId = 3, ReaderId = 3},
            new Readers_Card{FirstName = "Tom", LastName = "Hanks", Date = new DateTime(1956, 07, 09), BookId = 4, ReaderId = 4},
            new Readers_Card{FirstName = "Ariana", LastName = "Grande", Date = new DateTime(1993, 06, 26), BookId = 5, ReaderId = 5}
            };

            if (context.Books.Any())
            {
                return;   // DB has been seeded
            }

            if (context.Authors.Any())
            {
                return;   // DB has been seeded
            }

            if (context.Authors_Book.Any())
            {
                return;   // DB has been seeded
            }

            if (context.Chapters.Any())
            {
                return;   // DB has been seeded
            }

            if (context.Readers.Any())
            {
                return;   // DB has been seeded
            }

            if (context.Readers_Cards.Any())
            {
                return;   // DB has been seeded
            }

            foreach (var b in books)
            {
                context.Add(b);
            }

            context.SaveChanges();

            foreach (var a in authors)
            {
                context.Add(a);
            }

            context.SaveChanges();

            foreach (var ab in authors_books)
            {
                context.Add(ab);
            }

            context.SaveChanges();

            foreach (var c in chapters)
            {
                context.Add(c);
            }

            context.SaveChanges();

            foreach (var r in readers)
            {
                context.Add(r);
            }

            context.SaveChanges();

            foreach (var rc in readers_cards)
            {
                context.Add(rc);
            }

            context.SaveChanges();

            //AddEntities(builder, authors);
            //AddEntities(builder, authors_Book);
            //AddEntities(builder, Book);
            //AddEntities(builder, chapters);
            //AddEntities(builder, readers);
            //AddEntities(builder, readers_cards);
        }

        //private static void AddEntities<T>(ModelBuilder builder, List<T> entities) where T : class
        //{
        //    builder.Entity<T>().HasData(entities);
        //}
    }
}
