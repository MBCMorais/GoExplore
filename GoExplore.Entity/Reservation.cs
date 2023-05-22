using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GoExplore.Entity
{
    public class Reservation
    {
        public int Id { get; set; }

        public string ReservationDate { get; set; }

        public int Duration { get; set; }

        public Room roomId { get; set; }

        public Customer CustomerId { get; set; }


    }
}
