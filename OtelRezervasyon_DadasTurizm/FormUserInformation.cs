using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;//Regex İçin SInıf
using OtelRezervasyon_DadasTurizm.DadasDB.Entities;
using OtelRezervasyon_DadasTurizm.DadasDB;

namespace OtelRezervasyon_DadasTurizm
{

    public partial class FormUserInformation : Form
    {
        DadasDBEntities _db = new DadasDBEntities();
        DateTime _checkInDate;
        DateTime _checkOutDate;
        List<int> _selectedRoomss;
        List<int> _bookDetailsIDs;
        int _totalCost;
        int _personCount;
        string _kullanici;
        int _odalaraEklenenKisiSayisi;

        public FormUserInformation(List<int> SelectedRooms, DateTime checkInDate, DateTime checkOutDate, int totalcost, int personCount, string kullanici)
        {
            InitializeComponent();
            _selectedRoomss = SelectedRooms;
            _checkInDate = checkInDate;
            _checkOutDate = checkOutDate;
            _totalCost = totalcost;
            _personCount = personCount;
            _bookDetailsIDs = new List<int>();
            _odalaraEklenenKisiSayisi = 0;
            _kullanici = kullanici;
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            //BEGİN TRAN
            #region Validations


            bool emailKontrol = EmailKontrol(txtEmail.Text);



            if (emailKontrol != true)
            {
                // Tüm KOdlar Burada 
                MessageBox.Show("Mail Adresi Doğru Değil");
                return;
            }

            if (mtxtPersonID == null || mtxtPersonID.TextLength != 11)
            {

                MessageBox.Show("Tc Numarasını eksik ve ya hatalı girdiniz....");
                return;
            }
            if (mtxtPhone == null || mtxtPhone.TextLength != 10)
            {

                MessageBox.Show("Telefon Numarası eksik ve ya hatalı girdiniz....");
                return;
            }

            #endregion
            using (var transaction = _db.Database.BeginTransaction())
            {
                try
                {
                    Customer customer = new Customer();

                    var sorgu2 = _db.Customers.Select(x => x.PersonID).ToList();

                    if (sorgu2.Contains(mtxtPersonID.Text))
                    {
                        var CustomerID = _db.Customers
                            .Where(x => x.PersonID == mtxtPersonID.Text)
                            .Select(x => x.CustomerID).FirstOrDefault();
                        customer.CustomerID = CustomerID;
                        MessageBox.Show(customer.CustomerID + " ID numarası ile müşteri işlemleri devam ediyor");
                    }
                    else
                    {
                        customer.CreatedBy = _kullanici;
                        customer.FirstName = txtFirstName.Text;
                        customer.LastName = txtLastName.Text;
                        customer.Eposta = txtEmail.Text;
                        customer.PersonID = mtxtPersonID.Text;
                        customer.Phone = mtxtPhone.Text;
                        _db.Customers.Add(customer);
                        _db.SaveChanges();
                        MessageBox.Show(customer.CustomerID + " ID numarası ile müşteri kaydı başarıyla oluşturuldu");
                    }


                    


                    Book book = new Book();
                    book.CreatedBy = _kullanici;
                    book.CreatedDate = DateTime.Now;
                    book.CustomerID = customer.CustomerID;
                    book.CheckInDate = _checkInDate.Date;
                    book.CheckOutDate = _checkOutDate;
                    book.NightStay = (short)(_checkOutDate - _checkInDate).Days;
                    book.TotalCost = _totalCost;
                    book.IsDeleted = false;
                    _db.SaveChanges();
                    _db.Books.Add(book);
                    _db.SaveChanges();
                    foreach (int item in _selectedRoomss)
                    {
                        BookDetail bd1 = new BookDetail();
                        //Odanın Fiyatı 

                        var RoomPrice = _db.Rooms
                            .Join(_db.RoomDetails, x => x.RoomTypeID, x => x.RoomTypeID,
                            (x, y) => new
                            {
                                x.RoomNumber,
                                y.RoomPrice
                            })
                            .Where(x => x.RoomNumber == item).Select(x => x.RoomPrice).FirstOrDefault();
                        bd1.BookID = book.BookID;

                        bd1.RoomNumber = item;
                        bd1.RoomPayment = RoomPrice * ((short)(_checkOutDate - _checkInDate).Days);

                        _db.BookDetails.Add(bd1);
                        _db.SaveChanges();
                        _bookDetailsIDs.Add(bd1.BookDetailsID);
                    }
                    transaction.Commit();
                    MessageBox.Show("Reservation completed successfully...");


                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Warning ! Reservation cancelled.");
                    return;
                }
            }

            cmbRooms.DataSource = _selectedRoomss;
            cmbRooms.SelectedItem = _selectedRoomss[0];
            grpGuestsAdd.Visible = true;

        }

        private bool EmailKontrol(string email)
        {

            var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            bool isValid = Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
            return isValid;

        }

        private void FormUserInformation_Load(object sender, EventArgs e)
        {

        }


        private void cmbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstGuests.Items.Clear();
            TextBoxsClear();


            int secilenOdaNumarasi = Convert.ToInt32(cmbRooms.SelectedValue);
            int BookDetailsID = _bookDetailsIDs[cmbRooms.SelectedIndex];
            lblRoomInformation.Text = secilenOdaNumarasi + " numaralı odada kalacak kişilerin bilgilerini giriniz.";

            var GuestList = _db.Guests.Where(x => x.BookDetailsID == BookDetailsID).ToList();
            foreach (Guest item in GuestList)
            {
                lstGuests.Items.Add(item.GuestPersonelID);
            }

        }

        private void btnAddGuests_Click(object sender, EventArgs e)
        {

            int secilenOdaNumarasi = Convert.ToInt32(cmbRooms.SelectedValue);
            int BookDetailsID = _bookDetailsIDs[cmbRooms.SelectedIndex];
            #region Validations
            bool bosVarMi = false;
            foreach (var item in grpAddGuestInfo.Controls)
            {
                if (item is TextBox)
                {
                    if ((item as TextBox).Text == "")
                    {
                        bosVarMi = true;
                    }
                }
            }

            if (bosVarMi == true)
            {
                MessageBox.Show("Lütfen misafir bilgileriyle alakalı tüm alanları doldurunuz");
                return;
            }

            var OdadakiKisilerinTCNumaraları = _db.Guests.Where(x => x.BookDetailsID == BookDetailsID).Select(x => x.GuestPersonelID).ToList();
            if (OdadakiKisilerinTCNumaraları.Contains(txtGuestPersonID.Text))
            {
                MessageBox.Show("Aynı TC numarasıyla sadece 1 adet misafir kaydı yapılabilir");
                return;
            }

            var rezervasyonIDsi = _db.BookDetails.Where(x => x.BookDetailsID == BookDetailsID).Select(x => x.BookID).FirstOrDefault();
            var rezervasyonYapılanTümKisilerinIDleri = _db.BookDetails
                .Join(_db.Guests, bd => bd.BookDetailsID, g => g.BookDetailsID,
                (bd, g) => new { bd, g })
                .Where(x => x.bd.BookID == rezervasyonIDsi)
                .Select(x => x.g.GuestPersonelID).ToList();

            if (txtGuestPersonID.TextLength != 11)
            {
                MessageBox.Show("Tc Numarasını eksik ve ya hatalı girdiniz....");
                return;
            }
            if (rezervasyonYapılanTümKisilerinIDleri.Contains(txtGuestPersonID.Text))
            {
                MessageBox.Show("Bu kişinin odalardan birine zaten kaydı var lütfen başka bir TC numaralı kişi ekleyiniz ");
                return;
            }
            if (_odalaraEklenenKisiSayisi >= _personCount)
            {
                MessageBox.Show("İstediğiniz gibi" + _personCount + " kişilik rezervasyon tamamlanmıştır.Yeni bir misafir eklemek istiyorsanız lütfen rezervasyon işlemini yeniden başlatıp kişi sayısını arttırınız. ");
                return;
            } 


            #endregion

            var aynıOdadaKayıtlıKisiSayisi = _db.Guests.Where(x => x.BookDetailsID == BookDetailsID).Count();

            var seciliOdaTipi = _db.Rooms.Where(x => x.RoomNumber == secilenOdaNumarasi).Select(x => x.RoomTypeID).FirstOrDefault();

            var seciliOdaKapasitesi = _db.RoomDetails.Where(x => x.RoomTypeID == seciliOdaTipi).Select(x => x.RoomCapacity).FirstOrDefault();



            if (seciliOdaKapasitesi > aynıOdadaKayıtlıKisiSayisi)
            {
                Guest g1 = new Guest();
                g1.BookDetailsID = BookDetailsID;
                g1.GuestFirstName = txtGuestName.Text;
                g1.GuestLastName = txtGuestSurname.Text;
                g1.GuestPersonelID = txtGuestPersonID.Text;
                _db.Guests.Add(g1);
                lstGuests.Items.Add(g1.GuestPersonelID);
                _db.SaveChanges();
                _odalaraEklenenKisiSayisi++;
            }
            else
            {
                MessageBox.Show("Oda kapasitesi dolmuştur");
                return;
            }
            TextBoxsClear();

        }


        private void grpGuestsAdd_Enter(object sender, EventArgs e)
        {

        }



        private void mtxtPersonID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void grpTCNo_Enter(object sender, EventArgs e)
        {

        }

        private void mtxtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        public void TextBoxsClear()
        {
            foreach (var item in grpAddGuestInfo.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Text = "";
                }
            }
        }

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            string secilenTCNumarası = lstGuests.SelectedItem.ToString();

            var secilenGuest = _db.Guests.Where(x => x.GuestPersonelID == secilenTCNumarası).FirstOrDefault();

            _db.Guests.Remove(secilenGuest);
            _odalaraEklenenKisiSayisi--;
            MessageBox.Show(secilenTCNumarası + " TC numarasına sahip kişi bu oda kaydından silinmiştir");

            _db.SaveChanges();

            lstGuests.Items.Clear();
            TextBoxsClear();


            int secilenOdaNumarasi = Convert.ToInt32(cmbRooms.SelectedValue);
            int BookDetailsID = _bookDetailsIDs[cmbRooms.SelectedIndex];
            lblRoomInformation.Text = secilenOdaNumarasi + " numaralı odada kalacak kişilerin bilgilerini giriniz.";

            var GuestList = _db.Guests.Where(x => x.BookDetailsID == BookDetailsID).ToList();
            foreach (Guest item in GuestList)
            {
                lstGuests.Items.Add(item.GuestPersonelID);
            }



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string personID = mtxtPersonID.Text;
            var personQuery = (from c in _db.Customers
                               where c.PersonID == personID
                               select c).FirstOrDefault();
            try
            {
                if (personQuery.PersonID == personID)
                {
                    txtFirstName.Text = personQuery.FirstName;
                    txtLastName.Text = personQuery.LastName;
                    mtxtPhone.Text = personQuery.Phone;
                    txtEmail.Text = personQuery.Eposta;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt bulunamamıştır.");
                txtFirstName.Text = "";
                txtLastName.Text = "";
                mtxtPhone.Text = "";
                txtEmail.Text = "";
            }


        }


    }


}

