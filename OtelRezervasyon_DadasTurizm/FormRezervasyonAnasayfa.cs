using OtelRezervasyon_DadasTurizm.DadasDB;
using OtelRezervasyon_DadasTurizm.DadasDB.Entities;
using System;
using System.Collections;
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
    public partial class FormRezervasyonAnasayfa : Form
    {
        int _CurrentRoomID;
        int _CurrentDeletingRoomID;
        List<int> SelectedRooms;
        List<int?> MusaitOlmayanOdalar;
        List<int> OdaFiltreSi;
        DadasDBEntities _db;
        DateTime _checkInDate;
        DateTime _checkOutDate;
        int _kalınanGeceSayisi;
        int _roomNumber;
        int _allRoomCapacities;
        int _personCount;
        int _totalCost;
        string _kullanici;

        public FormRezervasyonAnasayfa(string kullanici)
        {
            InitializeComponent();
            _CurrentRoomID = 0;
            _CurrentDeletingRoomID = 0;
            _db = new DadasDBEntities();
            MusaitOlmayanOdalar = new List<int?>();
            SelectedRooms = new List<int>();
            _kalınanGeceSayisi = 0;
            _roomNumber = 0;
            _allRoomCapacities = 0;
            _personCount = 0;
            _totalCost = 0;
            _kullanici = kullanici;

        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            flwPnl.Controls.Clear();

            _personCount = (int)(numericUpDownPerson.Value);
            lblPersonNumber.Text = _personCount.ToString();

            grpInformation.Visible = true;
            grpReservationDetails.Visible = true;
            lblwarning.Visible = true;

            var sorgu5 = _db.Rooms.Select(x => x.RoomNumber).ToList();

           
            foreach (var item in sorgu5)
            {
                flwPnl.Visible = true;
                Button btnRooms = new Button();
                btnRooms.Text = item.ToString();
                btnRooms.Height = 40;
                btnRooms.Width = 90;
                btnRooms.Click += buttonRoom_Click;
                flwPnl.Controls.Add(btnRooms);
             
            }
            _checkInDate = dtpCheckIn.Value.Date;
            _checkOutDate = dtpCheckOut.Value.Date;

            MusaitOlmayanOdalar = (from b in _db.Books
                                   join bd in _db.BookDetails
                                   on b.BookID equals bd.BookID
                                   where (_checkInDate >= b.CheckInDate && _checkInDate <= b.CheckOutDate) ||
                                   (_checkOutDate >= b.CheckInDate && _checkOutDate <= b.CheckOutDate) ||
                                   (_checkInDate <= b.CheckInDate && _checkOutDate >= b.CheckOutDate) ||
                                   (_checkInDate >= b.CheckInDate && _checkOutDate <= b.CheckOutDate)
                                   select
                                      bd.RoomNumber

                         ).ToList();

            foreach (Button item in flwPnl.Controls)
            {
                item.BackColor = Color.Green;

            }
            foreach (Button item in flwPnl.Controls)
            {
                if (MusaitOlmayanOdalar.Contains(Convert.ToInt32(item.Text)))
                {
                    item.BackColor = Color.Red;

                }
            }
        }

     

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            btnFilter.Enabled = true;
            dtpCheckOut.Enabled = true;
            dtpCheckOut.MinDate = dtpCheckIn.Value.AddDays(1);
            flwPnl.Controls.Clear();
        }

        private void FormRezervasyonAnasayfa_Load_1(object sender, EventArgs e)
        {
            btnRemoveRoom.Enabled = false;
            dtpCheckIn.MinDate = DateTime.Now.Date;
            btnFilter.Enabled = false;

            var filteredRooms = _db.RoomDetails
                .Select
                (x =>
                new RoomIDDTO
                {
                    id = x.RoomTypeID,
                    allType = x.RoomTypeDetails
                }
                ).ToList();
            RoomIDDTO allClas = new RoomIDDTO();
            allClas.id = 0;
            allClas.allType = "All Types";
            filteredRooms.Add(allClas);

            cmbRoomTypes.DisplayMember = "allType";
            cmbRoomTypes.ValueMember = "id";
            cmbRoomTypes.DataSource = filteredRooms;
            cmbRoomTypes.SelectedItem = null;

        }

        private void cmbRoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //flwPnl.Controls.Clear();
            int RoomTypeID = Convert.ToInt32(cmbRoomTypes.SelectedValue);
            OdaFiltreSi = _db.Rooms
               .Where(x => x.RoomTypeID == RoomTypeID)
               .Select(x => x.RoomNumber).ToList();
            if (RoomTypeID != 0)
            {

                foreach (Button item in flwPnl.Controls)
                {
                    if (OdaFiltreSi.Contains(Convert.ToInt32(item.Text)))
                    {
                        item.Visible = true;
                    }
                    else
                    {
                        item.Visible = false;
                    }

                }
            }
            else
            {
                foreach (Button item in flwPnl.Controls)
                {
                    item.Visible = true;
                }
            }
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            cmbRoomTypes.Enabled = true;
            flwPnl.Controls.Clear();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            _CurrentRoomID = Convert.ToInt32(btn.Text);

            _kalınanGeceSayisi = (_checkOutDate - _checkInDate).Days;

            if (MusaitOlmayanOdalar.Contains(_CurrentRoomID))
            {
                lblRoomType.Text = "Bu oda seçilen tarihler arasında rezerve edilmiştir.";
                lblRoomDescription.Text = "";
                lblRoomPrice.Text = "";
                pcbOdaResmi.Image = null;
                return;
            }

            var RoomTypeQuery = _db.Rooms
                .Where(r => r.RoomNumber == _CurrentRoomID)
                .Select(r => r.RoomTypeID).SingleOrDefault();

            var roomInformations = _db.RoomDetails
                .Where(rd => rd.RoomTypeID == RoomTypeQuery)
                .Select(rd => new RoomDetailsDTO
                {
                    RoomTypeDetails = rd.RoomTypeDetails,
                    RoomPrice = rd.RoomPrice,
                    RoomDescription = rd.RoomDescription

                }).ToList();
            foreach (RoomDetailsDTO item in roomInformations)
            {
                lblRoomType.Text = item.RoomTypeDetails;
                lblRoomDescription.Text = item.RoomDescription;
                lblRoomPrice.Text = ((int)item.RoomPrice * _kalınanGeceSayisi).ToString() + " TL " + "(" + _kalınanGeceSayisi + " gece)";
            }

            if (RoomTypeQuery == 1)
            {
                pcbOdaResmi.Image = OtelRezervasyon_DadasTurizm.Properties.Resources._1;
            }
            else if (RoomTypeQuery == 2)
            {
                pcbOdaResmi.Image = OtelRezervasyon_DadasTurizm.Properties.Resources._2;
            }
            else if (RoomTypeQuery == 3)
            {
                pcbOdaResmi.Image = OtelRezervasyon_DadasTurizm.Properties.Resources._3;
            }
            else if (RoomTypeQuery == 4)
            {
                pcbOdaResmi.Image = OtelRezervasyon_DadasTurizm.Properties.Resources._4;
            }
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            #region Validations
            if (_CurrentRoomID == 0)
            {
                MessageBox.Show("Lütfen bir oda seçiniz");
                return;
            }
            if (MusaitOlmayanOdalar.Contains(_CurrentRoomID))
            {
                MessageBox.Show("Seçtiğiniz oda istediğiniz tarihler dolu.Lütfen başka bir oda seçiniz");
                return;
            }
            if (flpReservations.Controls.Count>=Convert.ToInt32(numericUpDownPerson.Value))
            {
                MessageBox.Show("Oda kapasitesi kişi sayısı ile uyumlu değildir.Oda eklemek için lütfen kişi sayısını arttırınız.");
                return;
            }
            //if (_roomNumber > 4)
            //{
            //    MessageBox.Show("Tek rezervasyonda en fazla 5 oda seçebilirsiniz.");
            //    return;
            //}
            if (SelectedRooms.Contains(_CurrentRoomID))
            {
                MessageBox.Show("Bu odayı zaten seçtiniz lütfen başka bir oda seçiniz.");
                return;
            }
            #endregion


            Button btn = new Button();
            btn.Text = _CurrentRoomID.ToString();
            btn.Height = 40;
            btn.Width = 70;
            btn.Click += buttonDeletingRoom_Click;


            flpReservations.Controls.Add(btn);
            SelectedRooms.Add(_CurrentRoomID);
            _roomNumber++;

            foreach (Button item in flwPnl.Controls)
            {
                if (item.Text == _CurrentRoomID.ToString())
                {
                    item.BackColor = Color.Blue;
                }
            }

            byte? currentRoomCapacity = 0;
            decimal? currentPrice = 0;

            // var srogu = _db.Rooms.Where()

            foreach (Room item in _db.Rooms)
            {
                if (item.RoomNumber == _CurrentRoomID)
                {
                    currentRoomCapacity = item.RoomDetail.RoomCapacity;
                    currentPrice = item.RoomDetail.RoomPrice;
                }
            }
            _allRoomCapacities = _allRoomCapacities + Convert.ToInt32(currentRoomCapacity);
            lblRoomCapacities.Text = _allRoomCapacities.ToString();
            _totalCost = (int)(_totalCost + currentPrice * _kalınanGeceSayisi);
            lblTotalCost.Text = _totalCost.ToString() + " TL";

            if (flpReservations.Controls.Count > 0)
            {
                btnRemoveRoom.Enabled = true;
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!(_allRoomCapacities >= _personCount))
            {
                MessageBox.Show("Toplam oda kapasitesi ile kişi sayısı uyuşmuyor lütfen başka oda ekleyiniz rezervasyon listenize");
                return;
            }
            else if (SelectedRooms.Count()>_personCount)
            {
                MessageBox.Show(_personCount+" Kişi için maxsimum "+ _personCount+" adet oda seçebilirsiniz lütfen seçilen oda sayısını azaltınız. ");
                return;
            }
            else
            {
                this.Hide();
                FormUserInformation frmCustomSave = new FormUserInformation(SelectedRooms, _checkInDate, _checkOutDate, _totalCost, _personCount,_kullanici);
                frmCustomSave.ShowDialog();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeletingRoom_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            _CurrentDeletingRoomID = Convert.ToInt32( btn.Text);

            #region ButtonRoomClick ile aynı işlevdeki kodlar sadece currentRoomID ye göre değil de currentDeletingRoomID ye göre bilgi veriyor
            _kalınanGeceSayisi = (_checkOutDate - _checkInDate).Days;

            if (MusaitOlmayanOdalar.Contains(_CurrentDeletingRoomID))
            {
                lblRoomType.Text = "Bu oda seçilen tarihler arasında rezerve edilmiştir.";
                lblRoomDescription.Text = "";
                lblRoomPrice.Text = "";
                pcbOdaResmi.Image = null;
                return;
            }

            var RoomTypeQuery = _db.Rooms
                .Where(r => r.RoomNumber == _CurrentDeletingRoomID)
                .Select(r => r.RoomTypeID).SingleOrDefault();

            var roomInformations = _db.RoomDetails
                .Where(rd => rd.RoomTypeID == RoomTypeQuery)
                .Select(rd => new RoomDetailsDTO
                {
                    RoomTypeDetails = rd.RoomTypeDetails,
                    RoomPrice = rd.RoomPrice,
                    RoomDescription = rd.RoomDescription

                }).ToList();
            foreach (RoomDetailsDTO item in roomInformations)
            {
                lblRoomType.Text = item.RoomTypeDetails;
                lblRoomDescription.Text = item.RoomDescription;
                lblRoomPrice.Text = ((int)item.RoomPrice * _kalınanGeceSayisi).ToString() + " TL " + "(" + _kalınanGeceSayisi + " gece)";
            }

            if (RoomTypeQuery == 1)
            {
                pcbOdaResmi.Image = OtelRezervasyon_DadasTurizm.Properties.Resources._1;
            }
            else if (RoomTypeQuery == 2)
            {
                pcbOdaResmi.Image = OtelRezervasyon_DadasTurizm.Properties.Resources._2;
            }
            else if (RoomTypeQuery == 3)
            {
                pcbOdaResmi.Image = OtelRezervasyon_DadasTurizm.Properties.Resources._3;
            }
            else if (RoomTypeQuery == 4)
            {
                pcbOdaResmi.Image = OtelRezervasyon_DadasTurizm.Properties.Resources._4;
            }
            #endregion

        }
        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            
            if (flpReservations.Controls.Count==0)
            {
                MessageBox.Show("Silinecek oda bulunmamaktadır.");
                btnRemoveRoom.Enabled = false;
            }
                
            foreach (Button item in flpReservations.Controls)
            {
                if (item.Text==_CurrentDeletingRoomID.ToString())
                {
                    flpReservations.Controls.Remove(item);
                    SelectedRooms.Remove(Convert.ToInt32(item.Text));



                    var capasity = (from r in _db.Rooms
                                    where r.RoomNumber == _CurrentDeletingRoomID
                                    select r.RoomDetail.RoomCapacity).FirstOrDefault();

                    var cost = (from r in _db.Rooms
                                where r.RoomNumber == _CurrentDeletingRoomID
                                select r.RoomDetail.RoomPrice).FirstOrDefault();

                    _allRoomCapacities = _allRoomCapacities - capasity.Value;
                    lblRoomCapacities.Text = _allRoomCapacities.ToString();

                    _totalCost = _totalCost - Convert.ToInt32(cost.Value);
                    lblTotalCost.Text = _totalCost.ToString() + " TL";

                    _roomNumber--;

                    foreach (Button item2 in flwPnl.Controls)
                    {
                        if (item2.Text == item.Text)
                        {
                            item2.BackColor = Color.Green;
                        }

                    }
                }

              
                }

            }

        private void numericUpDownPerson_ValueChanged(object sender, EventArgs e)
        {
            flwPnl.Controls.Clear();
        }

        private void numericUpDownChild_ValueChanged(object sender, EventArgs e)
        {
            flwPnl.Controls.Clear();
        }
    }
    public class RoomDetailsDTO
        {
            public string RoomTypeDetails { get; set; }
            public string RoomDescription { get; set; }
            public decimal? RoomPrice { get; set; }

        }
        public class RoomIDDTO
        {
            public int id { get; set; }
            public string allType { get; set; }
        }
    }

