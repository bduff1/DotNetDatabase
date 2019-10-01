using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_With_Classes
{
    class Ticket
    {
        private string v1;
        private string v2;
        private List<string> genList;

        public string TicketID { get; set; }

        public string SummaryIssue { get; set; }

        public string Status { get; set; }

        public string Priority { get; set; }

        public string Submitter { get; set; }

        public string Assigned { get; set; }

        public string Watching { get; set; }


     

        public Ticket(string TicketID, string SummaryIssue, string Status, string Priority,
            string Submitter, string Assigned, string Watching, List<string> genList)
        {
            this.TicketID = TicketID;
            this.SummaryIssue = SummaryIssue;
            this.Status = Status;
            this.Priority = Priority;
            this.Submitter = Submitter;
            this.Assigned = Assigned;
            this.Watching = Watching;
            this.genList = genList;

        }



        //   public Ticket(string v1, string v2, List<string> genList)
        // {
        //  this.v1 = v1;
        //this.v2 = v2;
        //this.genList = genList;
        // }
    }
}
