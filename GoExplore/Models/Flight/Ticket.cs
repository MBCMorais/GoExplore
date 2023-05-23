using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoExplore.Entity
{
    public class Ticket
    {

        public int ticketId { get; set; }

        public DateTime dateOfJourney { get; set; }

        public int seatNo { get; set; }

        public string passengerName { get; set; }
        public string address { get; set;}

        public string phone { get; set; }



    }
}
