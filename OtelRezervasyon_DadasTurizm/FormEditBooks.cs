using OtelRezervasyon_DadasTurizm.DadasDB;
using OtelRezervasyon_DadasTurizm.DadasDB.Entities;
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
    public partial class FormEditBooks : Form
    {
        DadasDBEntities _db;
        List<Book> books = new List<Book>();
        List<string> gonderileceklerListesi = new List<string>();
        Book book = new Book();
        public string _guestID;
        public string _guestFirstName;
        public string _guestLastName;
        public string _guestPersonelId;
        string _kullanici;


        public FormEditBooks(string kullanici)
        {
            InitializeComponent();
            _db = new DadasDBEntities();
            gbEdit.Visible = false;
            grpGuests.Visible = false;
            _kullanici = kullanici;
        }

        private void FormEditBooks_Load(object sender, EventArgs e)
        {
            btnHardDelete.BackColor = Color.Red;
            var listbooks = (from b in _db.Books select b).ToList();
            dgvEditBooks.DataSource = ListBooks();
        }
        public object ListBooks()
        {
            return (from b in _db.Books
                    select new
                    {
                        b.BookID,
                        b.CustomerID,
                        CustomerName = (from c in _db.Customers where c.CustomerID == b.CustomerID select c.FirstName + " " + c.LastName).FirstOrDefault(),
                        b.CheckInDate,
                        b.CheckOutDate,
                        b.NightStay,
                        b.TotalCost,
                        b.IsDeleted,
                        b.CreatedBy,
                        b.CreatedDate
                    }).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEditBooks.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvEditBooks.SelectedCells[0].Value);
                var deleted = (from b in _db.Books
                               where b.BookID == id
                               select b).SingleOrDefault();

                DialogResult result = MessageBox.Show("Are you sure want to delete the selected reservation?", "Warning !", MessageBoxButtons.YesNo);

                var change = _db.Books.Where(b => b.BookID == id).FirstOrDefault();
                if (result == DialogResult.Yes && change.IsDeleted == false)
                {
                    change.IsDeleted = true;
                    change.CreatedBy = _kullanici;
                    _db.SaveChanges();
                    dgvEditBooks.DataSource = ListBooks();
                    MessageBox.Show("The selected reservation deleted successfully.");
                }
                else if (change.IsDeleted == true)
                {
                    MessageBox.Show("The selected reservation has already deleted.");
                }

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            #region Reservation&Guests Information

            gbEdit.Visible = true;
            grpGuests.Visible = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

            if (dgvEditBooks.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvEditBooks.SelectedCells[0].Value);
                txtCustomerName.Text= (from b in _db.Books where b.BookID == id
                                       select (from c in _db.Customers where c.CustomerID == b.CustomerID select c.FirstName + " " + c.LastName).FirstOrDefault())
                                       .FirstOrDefault()
                                       .ToString();
                dtpCheckIn.Value = (from b in _db.Books where b.BookID == id select b.CheckInDate).FirstOrDefault().Value;
                dtpCheckOut.Value = (from b in _db.Books where b.BookID == id select b.CheckOutDate).FirstOrDefault().Value;
                txtNightStay.Text = (from b in _db.Books where b.BookID == id select b.NightStay).FirstOrDefault().ToString();
                txtTotalCost.Text= (from b in _db.Books where b.BookID == id select b.TotalCost).FirstOrDefault().ToString();

                var guests = (from g in _db.Guests
                             where g.BookDetail.Book.BookID == id
                             select new
                             {
                                 g.GuestID,
                                 g.GuestFirstName,
                                 g.GuestLastName,
                                 g.GuestPersonelID,
                             }).ToList();
                dgvGuests.DataSource = guests;
            }
            #endregion



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grpGuests.Visible = false;
            gbEdit.Visible = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;

            if (dgvEditBooks.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dgvEditBooks.SelectedCells[0].Value);
                    var update = _db.Books.First(b => b.BookID == id);

                    string[] dizi;
                    dizi=txtCustomerName.Text.Split(' ');
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        if (i != dizi.Length - 1)
                        {
                            update.Customer.FirstName = dizi[i] + " "; // Diziye aktardığımız ad değerlerini databese e yazdırıyoruz. 
                        }
                        else
                        {
                            update.Customer.LastName = dizi[i]; // Diziye aktardığımız Soyadı değerini database e yazdırıyoruz. 
                        }
                    }

                    update.CheckInDate = dtpCheckIn.Value;
                    update.CheckOutDate = dtpCheckOut.Value;
                 
                    update.NightStay = Convert.ToInt16(txtNightStay.Text);
                    update.TotalCost = Convert.ToDecimal(txtTotalCost.Text);
                    _db.SaveChanges();
                    MessageBox.Show("The selected reservation updated successfully.");
                    dgvEditBooks.DataSource = ListBooks();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("An error occurred.");
                }

            }
        }

        private void btnEditGuest_Click(object sender, EventArgs e)
        {
            if (dgvGuests.SelectedRows.Count>0)
            {
                try
                {
                    _guestID = dgvGuests.SelectedCells[0].Value.ToString();
                    gonderileceklerListesi.Add(_guestID);
                    _guestFirstName= dgvGuests.SelectedCells[1].Value.ToString();
                    gonderileceklerListesi.Add(_guestFirstName);
                    _guestLastName = dgvGuests.SelectedCells[2].Value.ToString();
                    gonderileceklerListesi.Add(_guestLastName);
                    _guestPersonelId = dgvGuests.SelectedCells[3].Value.ToString();
                    gonderileceklerListesi.Add(_guestPersonelId);

                    FormEditGuests editGuest = new FormEditGuests(gonderileceklerListesi);
                    editGuest.ShowDialog();
                }
                catch (Exception)
                {

                    MessageBox.Show("An error occurred.");
                }

            }
           
        }

        private void gbEdit_Enter(object sender, EventArgs e)
        {

        }

        private void btnHardDelete_Click(object sender, EventArgs e)
        {
            if (dgvEditBooks.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvEditBooks.SelectedCells[0].Value);
                var deleted = (from b in _db.Books
                               where b.BookID == id
                               select b).SingleOrDefault();

                DialogResult result = MessageBox.Show("Are you sure want to delete the selected reservation COMPLETELY?", "Warning !", MessageBoxButtons.YesNo);

                var deletingBook = _db.Books.Where(b => b.BookID == id).FirstOrDefault();
                if (result == DialogResult.Yes )
                {
                    deletingBook.CreatedBy = _kullanici;

                    var bookIDsiSilinenBookDetailsler = _db.BookDetails.Where(x => x.BookID == deletingBook.BookID).ToList();
                    foreach (var item in bookIDsiSilinenBookDetailsler)
                    {
                        _db.BookDetails.Remove(item);
                    }

                    foreach (var item in bookIDsiSilinenBookDetailsler)
                    {
                        var bookDetailsIDsiSilinenGuestler = _db.Guests.Where(x => x.BookDetailsID == item.BookDetailsID).ToList();
                        foreach (var item2 in bookDetailsIDsiSilinenGuestler)
                        {
                            _db.Guests.Remove(item2);
                        }

                    }

                    _db.SaveChanges();
                    _db.Books.Remove(deletingBook);
                    _db.SaveChanges();

                    dgvEditBooks.DataSource = ListBooks();
                    MessageBox.Show("The selected reservation deleted successfully.");
                }
                else if (deletingBook.IsDeleted == true)
                {
                    MessageBox.Show("The selected reservation has already deleted.");
                }

            }
        }
    }
}
