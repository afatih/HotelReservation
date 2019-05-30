using OtelRezervasyon_DadasTurizm.DadasDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon_DadasTurizm
{
    public partial class FormListBooks : Form
    {
        DadasDBEntities _db;
        public FormListBooks()
        {
            InitializeComponent();
            _db = new DadasDBEntities();
        }

        private void FormListBooks_Load(object sender, EventArgs e)
        {
            var listbooks = (from b in _db.Books select b).ToList();
            dgvListBooks.DataSource = ListBooks();
        }
        public object ListBooks()
        {
            var sorgu = (from g in _db.Guests
                         join bd in _db.BookDetails on g.BookDetailsID equals bd.BookDetailsID
                         join b in _db.Books on bd.BookID equals b.BookID
                         where b.IsDeleted != true
                         select new
                         {
                             ReservationNumber=b.BookID,
                             ReservationName = (from c in _db.Customers where c.CustomerID == b.CustomerID select c.FirstName + " " + c.LastName).FirstOrDefault(),
                             g.GuestFirstName,
                             g.GuestLastName,
                             b.CheckInDate,
                             b.CheckOutDate,
                             bd.RoomNumber
                         });

            return sorgu.ToList();
        }
    }
}
