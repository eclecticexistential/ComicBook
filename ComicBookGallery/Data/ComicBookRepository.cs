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
                SeriesTitle = "",
                IssueNumber = 0,
                Description = "",
                Artists = new Artist[]
                {
                    new Artist() {Name= "", Role = ""},
                    new Artist() {Name= "", Role = ""},
                    new Artist() {Name= "", Role = ""},
                    new Artist() {Name= "", Role = ""}
                }
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