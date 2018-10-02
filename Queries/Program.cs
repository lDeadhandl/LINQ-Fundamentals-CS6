using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
            {
                new Movie { Title = "The Dark Knight", Rating = 8.9f, Year = 2008 },
                new Movie { Title = "The King's Speech", Rating = 8.0f, Year = 2010 },
                new Movie { Title = "Casablanca", Rating = 8.5f, Year = 1942 },
                new Movie { Title = "Star Wars V", Rating = 8.7f, Year = 1980 },
            };

            //Where uses "yield' keyword for deffered execution
            //If the iteration statement is commented out there is no output eventhough
            //movies.Year is being called 5 times
            var query = movies.Where(m => m.Year > 2000).ToList(); //By using To List

            Console.WriteLine(query.Count());
            var enumerator = query.GetEnumerator();
            while (enumerator.MoveNext())          
            {
                Console.WriteLine(enumerator.Current.Title);
            }
        }
    }
}
