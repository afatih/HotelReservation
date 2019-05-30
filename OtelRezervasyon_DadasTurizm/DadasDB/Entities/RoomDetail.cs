using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon_DadasTurizm.DadasDB.Entities
{
    public partial class RoomDetail
    {
        public RoomDetail()
        {
            this.Rooms = new HashSet<Room>();
        }

        [Key]
        public int RoomTypeID { get; set; }

        public string RoomTypeDetails { get; set; }
        public string RoomDescription { get; set; }
        public byte? RoomCapacity { get; set; }
        public decimal? RoomPrice { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
