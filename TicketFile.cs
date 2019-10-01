using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystemFile;


namespace Ticketing_With_Classes
{
    class TicketFile
    {
        public string FilePath { get; set; }
        public char Delimiter { get; set; }

        public List<Ticket> Tickets { get; }

        //nlog
        // private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public TicketFile()
        {
            Delimiter = ',';
            Tickets = new List<Ticket>();
        }


        public void LoadFile()
        {
            //  logger.Info("Loading Ticket File {0}", FilePath);

            using (StreamReader sr = new StreamReader(FilePath))
            {
                string line = sr.ReadLine();

                string[] values = line.Split(',');

                List<string> genList = values[values.Length - 1].Split('|').ToList();
                //List<string> = values.ToList();
                //List<string> genList = values[values];



                //Ticket record = new Ticket(values[1], values[0], genList);
                Ticket record = new Ticket(values[5], values[4], values[3], values[2], values[1], values[0], genList);

                Tickets.Add(record);
            }
        }


    }
}
