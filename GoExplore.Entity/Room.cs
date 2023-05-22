using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoExplore.Entity
{
    public class Room
    {
        public int id { get; set; }

        public string Description { get; set; }
        public decimal price { get; set; }

        public RoomType type { get; set; }


    }
}
