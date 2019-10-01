using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NLog;
using System.IO;
using TicketingSystemFile;
using Ticketing_With_Classes;

namespace TicketingSystemFile
{
    class Program
    {
        public static void Main(string[] args)
        {
            string file = "ticketData.txt";
            string choice;

            //NewTicketFile ticketList = new NewTicketFile();

            TicketFile ticketList = new TicketFile();

            ticketList.FilePath = file;

            ticketList.LoadFile();




            
            {
                // ask user a question
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");
                // input response
                choice = Console.ReadLine();



                if (choice == "1")
                {
                    if (File.Exists(file))
                    {


                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }

                }
                else if (choice == "2")
                {
                  


                    Console.WriteLine("Enter a ticket");

                    //using(StreamReader sr = new StreamReader(file))
                    //{
                    //    string line = sr.ReadLine();

                    //    string[] values = line.Split(',');


                    //}

                    using (StreamWriter sw = new StreamWriter(file, true))
                    {
                        string TicketID = "";
                        string SummaryIssue = "";
                        string Status = "";
                        string Priority = "";
                        string Submitter = "";
                        string Assigned = "";
                        string Watching = "";

                        sw.WriteLine("{0},{1},{2},{3},{4},{5}", TicketID, SummaryIssue, Status, Priority, Submitter, Assigned, Watching);

                        sw.Close();
                        Console.ReadLine();
                    }
                } while (choice == "1" || choice == "2") ;

            }
        }
    }
}

