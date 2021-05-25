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
            Console.WriteLine($"There are {authors.Count()} total authors");
            Console.WriteLine($"with {authors.SelectMany(a => a.Books).Count()} total books");

            Console.WriteLine("How many books are collaborations (have more than one author)?");
            var collaborations = authors.SelectMany(a => a.Books).GroupBy(b => b.ID).Where(g => g.Count() > 1);
            Console.WriteLine($"There are {collaborations.Count()} collaborations in the dabatase");
            Console.WriteLine("--------------------");

            Console.WriteLine("Which book has the most authors (and how many)?");
            var mostAuthors = collaborations.Select(g => new
            {
                ID = g.Key,
                Title = g.First().Title,
                NumAuthors = g.Count()
            }).OrderByDescending(c => c.NumAuthors).First();
            Console.WriteLine($"The book {mostAuthors.ID}: {mostAuthors.Title} has most authors with {mostAuthors.NumAuthors} different authors");
            Console.WriteLine("--------------------");

            Console.WriteLine("What author wrote most collaborations?");
            var booksWithAuthors = authors.SelectMany(a => a.Books.Select(b => new
            {
                BookID = b.ID,
                BookTitle = b.Title,
                AuthorID = a.ID,
                AuthorName = a.Name
            }));

            var authorCollaborations = booksWithAuthors
                .GroupBy(ba => ba.BookID)
                .Where(g => g.Count() > 1)
                .SelectMany(g => g)
                .GroupBy(ba => ba.AuthorID)
                .OrderByDescending(g => g.Count())
                .First();

            var authorData = authorCollaborations.First();
            Console.WriteLine($"The author with most collaborations is {authorData.AuthorName} with ${authorCollaborations.Count()} collaborations");
            Console.WriteLine("--------------------");


            Console.WriteLine("In what year were published most books in a specific genre? Which genre?");
            var allBooks = authors.SelectMany(a => a.Books);
            var genres = Enum.GetValues(typeof(Genre)) as Genre[];
            var mostBooksByGenre = genres.Select(g => new
            {
                Genre = g,
                Books = allBooks.Where(b => b.Genres.Contains(g)).GroupBy(b => b.Year).OrderByDescending(g => g.Count()).First()
            }).OrderByDescending(bg => bg.Books.Count()).First();

            Console.WriteLine($"Most books in a genre were published in {mostBooksByGenre.Genre} in {mostBooksByGenre.Books.Key}, total {mostBooksByGenre.Books.Count()}");
            Console.WriteLine("--------------------");

            Console.WriteLine("Which author has most books nominated for an award?");
            var mostNominatedBooks = authors.OrderByDescending(a => a.Books.Count(b => b.Nominations > 0)).First();
            Console.WriteLine($"The author with most nominated books is {mostNominatedBooks.Name} with {mostNominatedBooks.Books.Count(b => b.Nominations > 0)} nominated books");
            Console.WriteLine("--------------------");

            Console.WriteLine("Which author has most books that won an award?");
            var mostWinningBooks = authors.OrderByDescending(a => a.Books.Count(b => b.Wins > 0)).First();
            Console.WriteLine($"The author with most books that won an award is {mostWinningBooks.Name} with {mostWinningBooks.Books.Count(b => b.Wins > 0)} winners");
            Console.WriteLine("--------------------");

            Console.WriteLine("Which author has most books nominated for an award, without winning a single award?");
            var bestLoser = authors.Where(a => a.Wins == 0).OrderByDescending(a => a.Books.Count(b => b.Nominations > 0)).First();
            Console.WriteLine($"The author with most nominated non-winner books is {bestLoser.Name} with {bestLoser.Books.Count(b => b.Nominations > 0)} nominated books");
            Console.WriteLine("--------------------");

            Console.WriteLine("Make a histogram of books published per decade per genre.");
            var booksByGenreByDecade = genres.Select(g => new
            {
                Genre = g,
                Books = allBooks.Where(b => b.Genres.Contains(g)).GroupBy(b => b.Year / 10 * 10).Select(g => new
                {
                    Decade = g.Key,
                    Published = g.Count()
                }).OrderBy(db => db.Decade)
            }).ToDictionary(bgd => bgd.Genre, bgd => bgd.Books);

            var decades = booksByGenreByDecade.SelectMany(bgd => bgd.Value.Select(bd => bd.Decade)).Distinct().OrderBy(d => d);

            Console.Write("\t");
            foreach (var genre in genres)
            {
                Console.Write($"\t{genre}");
            }
            Console.WriteLine();

            foreach (var decade in decades)
            {
                Console.Write(decade);
                Console.Write("\t\t");
                foreach (var genre in genres)
                {
                    var genreBooks = booksByGenreByDecade[genre].FirstOrDefault(bd => bd.Decade == decade);
                    if (genreBooks == null)
                    {
                        Console.Write($"\t ");
                    }
                    else
                    {
                        Console.Write($"\t{genreBooks.Published}");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------");

            Console.WriteLine("Which author has a highest percentage of nominated books?");
            Console.WriteLine("  Tiebreakers: more total books");
            Console.WriteLine("             : more wins");

            var authorBooks = authors.Select(a => new
            {
                AuthorID = a.ID,
                AuthorName = a.Name,
                TotalBooks = a.Books.Count(),
                NominatedBooks = a.Books.Count(b => b.Nominations > 0),
                Wins = a.Wins
            });

            var highestPercentage = authorBooks
                .OrderByDescending(ab => ab.NominatedBooks * 100 / ab.TotalBooks)
                .ThenByDescending(ab => ab.TotalBooks)
                .ThenByDescending(ab => ab.Wins)
                .First();

            Console.WriteLine($"Highest percentage is {highestPercentage.NominatedBooks * 100  / highestPercentage.TotalBooks}%");
            Console.WriteLine($"  for the author {highestPercentage.AuthorName}, ({highestPercentage.AuthorID})");
            Console.ReadLine();
        }
    }
}
