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
    public partial class FormBaslangicSayfasi : Form
    {
        string _kullanici;
        public FormBaslangicSayfasi(string _userName)
        {
            InitializeComponent();
            _kullanici = _userName;
        }
        

        private void FormBaslangicSayfasi_Load(object sender, EventArgs e)
        {
            lblKullanici.Text =_kullanici;
            pcbOnline.Visible = true;
        }

        private void pcbEditBook_Click(object sender, EventArgs e)
        {
            FormEditBooks formEditBooks = new FormEditBooks(_kullanici);
        
            formEditBooks.ShowDialog();
        }

        private void pcbBookRoom_Click(object sender, EventArgs e)
        {
            FormRezervasyonAnasayfa formRezervasyonAnasayfa = new FormRezervasyonAnasayfa(_kullanici);
            
            formRezervasyonAnasayfa.ShowDialog();
        }

        private void pcbListBook_Click(object sender, EventArgs e)
        {
            FormListBooks formListBooks = new FormListBooks();
            
            formListBooks.ShowDialog();
        }

        private void pcbListCustomer_Click_1(object sender, EventArgs e)
        {
            FormListCustomers showCustomer = new FormListCustomers(_kullanici);
           
            showCustomer.ShowDialog();
        }

        private void pcbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
