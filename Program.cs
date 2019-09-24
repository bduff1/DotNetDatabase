using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.IO;

namespace Movie_Library_BD
{
    class Program
    {
        string file { get; set; }

        static void Main(string[] args)
        {
            string filepath = "..\\..\\movies.csv";


            DisplayMenu(true);
            string userSelection = Console.ReadLine();


            MovieFile movieList = new MovieFile();

            movieList.FilePath = filepath;

            movieList.LoadFile();

            do
            {
                if (userSelection == "1")
                {
                    // display from movies.csv file
                    int recordCount = 0;


                    foreach (var movie in movieList.Movies)
                    {
                        recordCount++;


                        Console.WriteLine("Title: {0}", movie.Title);
                        movie.DisplayGenres();
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                }
                else if (userSelection == "2")
                {
                    // add a movie, if duplicated, throw exception
                    Console.WriteLine("Enter a title");
                    string movieTitle = Console.ReadLine();

                    
                    string genreName = "";
                    string genre = "";
                    do
                    {
                        Console.WriteLine("Enter a Genre, enter done when finished");
                        genre = Console.ReadLine();
                        genreName += genre + "|";

                    } while (genre.ToLower() != "done");
                    genreName = genreName.Substring(0);

                    bool duplicate = false;
                    // check for duplicate title
                    using (StreamReader sr = new StreamReader(filepath))
                    {
                        while (!sr.EndOfStream && !duplicate)
                        {
                            string line = sr.ReadLine();

                            string[] values = line.Split(',');
                            if (values[1] == movieTitle)
                            {
                                
                                duplicate = true;
                                throw new Exception("You entered a duplicate item");
                            }
                        }
                    }
                    if (!duplicate)
                    {
                        // write to the file
                        using (StreamWriter sw = new StreamWriter(filepath, true))
                        {
                         
                            int movieID = 500000;
                            sw.WriteLine("{0},{1},{2}", movieID, movieTitle, genreName);
                        }
                    }
                }
                else if (userSelection == "3")
                {
                    // end the application
                }
             

               DisplayMenu(false);
               userSelection = Console.ReadLine();

            } while (userSelection != "3");


            Console.ReadLine();

        }

        public static void DisplayMenu(bool firstTime)
        {
            
            Console.WriteLine("1) Display Movies");
            Console.WriteLine("2) Add a movie");
            Console.WriteLine("3) Exit application");
        }

    }
}
