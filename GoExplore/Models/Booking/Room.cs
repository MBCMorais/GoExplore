using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoExplore.Models.Booking
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        public string? Description { get; set; } = null;
        public string? Number { get; set; }


        [RegularExpression(@"^\d+(\.\d{1,2})?$")]
        [Range(0, 9999999999999999.99)]
        public decimal Price { get; set; }

        [Range(0, 5, ErrorMessage = "Rate entre 0 e 5")]
        public int Rate { get; set; }



        //navigation prop
        public ICollection<Reservation> Reservations { get; set; }

        public ICollection<RoomType> RoomTypes { get; set; }

        //public virtual RoomType RoomType { get; set; }

    }
}
