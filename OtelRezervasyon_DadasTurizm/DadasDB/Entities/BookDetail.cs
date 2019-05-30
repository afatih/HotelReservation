using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon_DadasTurizm.DadasDB.Entities
{
    public partial class BookDetail
    {
        public BookDetail()
        {
            this.Guests = new HashSet<Guest>();
        }
        [Key]
        public int BookDetailsID { get; set; }
        public int? BookID { get; set; }
        public int? RoomNumber { get; set; }
        public decimal? RoomPayment { get; set; }

        public virtual Book Book { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<Guest> Guests { get; set; }
    }
}
