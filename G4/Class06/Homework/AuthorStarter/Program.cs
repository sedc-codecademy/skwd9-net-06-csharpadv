using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;

namespace AuthorStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new AuthorRepo();
            var authors = repo.GetAuthors();

            //-How many books are collaborations(have more than one author)?
            //-Which book has the most authors(and how many) ?
            //-What author wrote most collaborations ? "

            //-In what year were published most books in a specific genre? Which genre ?
            //-Which author has most books nominated for an award?
            //-Which author has most books that won an award ?
            //-Which author has most books nominated for an award, without winning a single award ?
            //-Make a histogram of books published per decade per genre.
            //- Which author has a highest percentage of nominated books ?

        }
    }
}
