using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Library_BD
{
    class Movie
    {
        public string Title { get; set; }
        public string MovieID { get; set; }
        public List<string> Genres { get; set; }
        public string Year { get; set; }

        public Movie(string Title, string movieID, List<string> gen, string year)
        {
            this.Title = Title;
            MovieID = movieID;
            this.Genres = gen;
            this.Year = year;
        }

        public void DisplayGenres()
        {
            Console.WriteLine("Genres:");

            foreach(string g in this.Genres)
            {
                Console.WriteLine(g);
            }
            
        }
    }
}
