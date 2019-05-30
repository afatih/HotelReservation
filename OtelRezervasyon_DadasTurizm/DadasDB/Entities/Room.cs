using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon_DadasTurizm.DadasDB.Entities
{
    public partial class Room
    {
        public Room()
        {
            this.BookDetails = new HashSet<BookDetail>();
        }
        [Key]
        public int RoomNumber { get; set; }
        public int RoomTypeID { get; set; }


        public virtual ICollection<BookDetail> BookDetails { get; set; }
        public virtual RoomDetail RoomDetail { get; set; }
    }
}
