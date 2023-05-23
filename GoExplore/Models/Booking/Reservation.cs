using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GoExplore.Entity.Booking
{
    public class Reservation
    {

        public int Id { get; set; }

        [Required]
        public DateTime DateIn { get; set; }

        [Required]
        public DateTime DateOut { get; set; }


        //navigation prop
        public virtual Room? Room { get; set; }

        public virtual Customer Customer { get; set; }


    }
}
