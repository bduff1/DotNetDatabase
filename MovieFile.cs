using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Library_BD
{
    class MovieFile
    {
        public string FilePath { get; set; }
        public char Delimiter { get; set; }

        public List<Movie> Movies { get; }

        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public MovieFile()
        {
            Delimiter = ',';
            Movies = new List<Movie>();
        }

        public void LoadFile()
        {
            logger.Info("Loading movie file {0}", FilePath);

            using (StreamReader sr = new StreamReader(FilePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string[] values = line.Split(',');
                    // Toy Story (1995)
                    string year = "2001";// values[1].Substring(values[1].IndexOf("(") + 1, values[1].IndexOf(")") - values[1].IndexOf("(") - 1);

                    //List<string> genList = new List<string>();
                    List<string> genList = values[values.Length - 1].Split('|').ToList();

                    /*
                     * string[] genres = values[values.Length-1].Split('|');
                    foreach (string val in genres)
                    {
                        genList.Add(val);
                    }*/
                    Movie record = new Movie(values[1], values[0], genList, year);
                    Movies.Add(record);


                }
            }

        }

    }
}
