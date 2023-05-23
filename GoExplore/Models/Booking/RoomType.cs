using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoExplore.Models.Booking
{
    public class RoomType
    {
        [Key, ForeignKey("RoomTypeId")]
        public int Id { get; set; }
        public string? Name { get; set; }
        //apartament,etc

        //public virtual Room Room { get; set; }


        //navigation properties
        public virtual ICollection<Room> Room { get; set; }

    }
}
