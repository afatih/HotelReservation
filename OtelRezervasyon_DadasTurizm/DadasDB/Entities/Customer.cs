using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon_DadasTurizm.DadasDB.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            this.Books = new HashSet<Book>();
        }
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonID { get; set; }
        public string Phone { get; set; }
        public string Eposta { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
