using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorStarter
{
    public enum BookType
    {
        Novel,
        Novella,
        Novelette,
        ShortStory,
        Collection,
        Omnibus,
        Anthology,
        NonFiction,
        GraphicNovel,
        Miscellaneous,
        LightNovel
    }

    public enum Genre
    {
        ScienceFiction,
        Fantasy,
        Horror
    }
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Nominations { get; set; }
        public int Wins { get; set; }
        public List<Book> Books { get; set; }
    }

    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public BookType Type { get; set; }
        public int Year { get; set; }
        public int Nominations { get; set; }
        public int Wins { get; set; }
        public Genre[] Genres { get; set; }
    }

}
