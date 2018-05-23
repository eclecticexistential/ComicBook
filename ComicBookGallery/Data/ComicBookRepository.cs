using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
            {
                Id = 0,
                SeriesTitle = "Black Panther",
                IssueNumber = 1,
                Description = "Flags are burning.",
                Artists = new Artist[]
                {
                    new Artist() {Name= "Ta-Nehisi Coates", Role = ""},
                    new Artist() {Name= "Brian Stelfreeze", Role = ""},
                    new Artist() {Name= "Laura Martin", Role = ""}
                },
                Favorite = true
            },
            new ComicBook()
            {
                Id = 1,
                SeriesTitle = "Captain America",
                IssueNumber = 695,
                Description = "Fight more!",
                Artists = new Artist[]
                {
                    new Artist() {Name= "Mark Waid", Role = ""},
                    new Artist() {Name= "Chris Samnee", Role = ""},
                    new Artist() {Name= "Matthew Wilson", Role = ""}
                }
            },
            new ComicBook()
            {
                Id = 2,
                SeriesTitle = "Captain Marvel",
                IssueNumber = 4,
                Description = "Battle across the skies.",
                Artists = new Artist[]
                {
                    new Artist() {Name= "Fazekas", Role = ""},
                    new Artist() {Name= "Butters", Role = ""},
                    new Artist() {Name= "Anka", Role = ""},
                    new Artist() {Name= "Wilson", Role = ""}
                }
            },
            new ComicBook()
            {
                Id = 3,
                SeriesTitle = "Moon Knight",
                IssueNumber = 1,
                Description = "Battle across the skies.",
                Artists = new Artist[]
                {
                    new Artist() {Name= "Lemire", Role = ""},
                    new Artist() {Name= "Smallwood", Role = ""},
                    new Artist() {Name= "Bellaire", Role = ""}
                }
            },
            new ComicBook()
            {
                Id = 4,
                SeriesTitle = "The Amazing Spiderman",
                IssueNumber = 316,
                Description = "The non-mutant superhero!",
                Artists = new Artist[]
                {
                    new Artist() {Name= "", Role = ""},
                    new Artist() {Name= "", Role = ""},
                    new Artist() {Name= "", Role = ""}
                }
            },
            new ComicBook()
            {
                Id = 5,
                SeriesTitle = "Rick & Morty",
                IssueNumber = 30,
                Description = "The non-mutant superhero!",
                Artists = new Artist[]
                {
                    new Artist() {Name= "Starks", Role = ""},
                    new Artist() {Name= "Dewey", Role = ""},
                    new Artist() {Name= "Ellerby", Role = ""}
                },
                Favorite = true
            }
        };
        public ComicBook[] GetComicBooks()
        {
            return _comicBooks;
        }
        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;
            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }
            return comicBookToReturn;
        }
    }
}