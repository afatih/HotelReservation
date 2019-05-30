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
    public partial class FormEditGuests : Form
    {
        DadasDBEntities _db;
        List<string> gelenlerListesi = new List<string>();
        
        int _guestID;
        string _guestFirstName;
        string _guestLastName;
        string _guestPersonelID;

        public FormEditGuests(List<string> gelenlerListesi)
        {
            InitializeComponent();
            _db = new DadasDBEntities();

            _guestID = Convert.ToInt32(gelenlerListesi[0]);
            _guestFirstName = gelenlerListesi[1];
            _guestLastName = gelenlerListesi[2];
            _guestPersonelID = gelenlerListesi[3];
        }


        private void FormEditGuests_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = _guestFirstName;
            txtLastName.Text = _guestLastName;
            txtPersonelID.Text = _guestPersonelID;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var update = _db.Guests.First(g => g.GuestID == _guestID);
                update.GuestFirstName = txtFirstName.Text;
                update.GuestLastName = txtLastName.Text;
                update.GuestPersonelID = txtPersonelID.Text;

                DialogResult result = MessageBox.Show("Are you sure want to save ?", "Warning !", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    _db.SaveChanges();
                    MessageBox.Show("The selected guest registration completed successfully.");
                }
                else
                {
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error accured.");

            }
            finally
            {
                this.Close();
            }

         

        }
    }
}
