using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[] {

             new ComicBook(){
                    SeriesTitle = "bone-50",
                    IssueNumber = 656,
                    DescriptionHtml = "<p>Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</stong></p>",
                    Artists = new Artist[]
                    {
                        new Artist(){ Name="Ali Naser" ,Role="Script"},
                        new Artist(){ Name="Shady Morgan" ,Role="Pencils"},
                        new Artist(){ Name="Sara Alen" ,Role="Inks"},
                        new Artist(){ Name="Tomas Shilpy" ,Role="Colors"},
                        new Artist(){ Name="Eliopoulos" ,Role="Letters"},
                    }
                },
               new ComicBook(){
                    SeriesTitle = "The Amazing Spider-Man",
                    IssueNumber = 700,
                    DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</stong></p>",
                    Artists = new Artist[]
                    {
                        new Artist(){ Name="Dan Slott" ,Role="Script"},
                        new Artist(){ Name="Humberto Ramos" ,Role="Pencils"},
                        new Artist(){ Name="Victor Olazaba" ,Role="Inks"},
                        new Artist(){ Name="Edger Delgado" ,Role="Colors"},
                        new Artist(){ Name="Chis Eliopoulos" ,Role="Letters"},
                    }
                },
        };

        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = new ComicBook();

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