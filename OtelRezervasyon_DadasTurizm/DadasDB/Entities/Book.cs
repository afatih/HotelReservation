using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon_DadasTurizm.DadasDB.Entities
{
    public partial class Book
    {
        public Book()
        {
            this.BookDetails = new HashSet<BookDetail>();
        }

        [Key]
        public int BookID { get; set; }
        public int CustomerID { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public short? NightStay { get; set; }
        public decimal? TotalCost { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<BookDetail> BookDetails { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
