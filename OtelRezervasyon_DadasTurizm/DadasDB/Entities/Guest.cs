using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon_DadasTurizm.DadasDB.Entities
{
    public partial class Guest
    {
        [Key]
        public int GuestID { get; set; }
        public int BookDetailsID { get; set; }
        public string GuestFirstName { get; set; }
        public string GuestLastName { get; set; }
        public string GuestPersonelID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsDelete { get; set; }

        public virtual BookDetail BookDetail { get; set; }
    }
}
