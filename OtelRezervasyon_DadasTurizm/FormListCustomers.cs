using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using OtelRezervasyon_DadasTurizm.DadasDB;

namespace OtelRezervasyon_DadasTurizm
{
    public partial class FormListCustomers : Form
    {
        DadasDBEntities _db;
        int _id;
        string _kullanici;
        public FormListCustomers(string kul)
        {
            InitializeComponent();
            _db = new DadasDBEntities();
            _kullanici = kul;
        }

        private void FormListCustomers_Load(object sender, EventArgs e)
        {
            CustomersShow();
        }



        public void CustomerSearch()//Müşteri ada göre arama 
        {
            string ara = txtSearch.Text;
            var liste = from c in _db.Customers
                        where c.FirstName.Contains(ara)
                        orderby c.CustomerID
                        select new
                        {
                            c.CustomerID,
                            c.FirstName,
                            c.LastName,
                            c.Phone,
                            c.Eposta
                        };
            dgwEditCustomers.DataSource = liste.ToList();
        }
        public void CustomersShow()//Müşterileri Data Gridviewe Listelemeyi yapan metod
        {
            var customers = _db.Customers
                .Select
                (x =>
                new
                {
                    x.CustomerID,
                    x.FirstName,
                    x.LastName,
                    x.PersonID,
                    x.Phone,
                    x.Eposta,
                    x.IsDeleted
                }
                ).ToList();
            dgwEditCustomers.DataSource = customers;
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            CustomerSearch();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            grpbxUpdate.Visible = true;

            _id = int.Parse(dgwEditCustomers.CurrentRow.Cells[0].Value.ToString());
            txtFirstName.Text = dgwEditCustomers.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgwEditCustomers.CurrentRow.Cells[2].Value.ToString();
            txtPersonID.Text = dgwEditCustomers.CurrentRow.Cells[3].Value.ToString();
            txtPhoneNum.Text = dgwEditCustomers.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgwEditCustomers.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            bool emailKontrol = EmailKontrol(txtEmail.Text);
            if (emailKontrol != true)
            {
                // Tüm KOdlar Burada 
                MessageBox.Show("Mail Adresi Doğru Değil");
                return;
            }

            bool bosVarMi = false;
            foreach (var item in grpbxUpdate.Controls)
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
                MessageBox.Show("Lütfen müşteri bilgileriyle alakalı tüm alanları doldurunuz");
                return;
            }
            var secilenKisi = _db.Customers.Where(b => b.CustomerID == _id).FirstOrDefault();
            secilenKisi.FirstName = txtFirstName.Text;
            secilenKisi.LastName = txtLastName.Text;
            secilenKisi.Phone = txtPhoneNum.Text;
            secilenKisi.Eposta = txtEmail.Text;
            secilenKisi.CreatedBy = _kullanici;
            _db.SaveChanges();
            CustomersShow();
        }



        private void btnDel_Click(object sender, EventArgs e)
        {
            customerDel();
        }

        private void customerDel()
        {
            if (dgwEditCustomers.SelectedRows.Count > 0)
            {


                DialogResult result = MessageBox.Show("Are you sure want to delete the selected customer?", "Warning !", MessageBoxButtons.YesNo);

                var delcustomer = _db.Customers.Where(b => b.CustomerID == _id).FirstOrDefault();
                if (result == DialogResult.Yes && delcustomer.IsDeleted == false)
                {
                    delcustomer.IsDeleted = true;
                    _db.SaveChanges();
                    CustomersShow();
                    MessageBox.Show("The selected customer deleted successfully.");
                }
                else if (delcustomer.IsDeleted == true)
                {
                    MessageBox.Show("The selected customer has already deleted.");
                }

            }
        }

        private void dgwEditCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwEditCustomers_SelectionChanged(object sender, EventArgs e)
        {

        }
        private bool EmailKontrol(string email)
        {

            var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            bool isValid = Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
            return isValid;

        }

        private void txtPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void grpbxUpdate_Enter(object sender, EventArgs e)
        {

        }
        #region Hard delete vazgeçilen kısım
        //private void btnHardDelete_Click(object sender, EventArgs e)
        //{
        //    if (dgwEditCustomers.SelectedRows.Count > 0)
        //    {


        //        DialogResult result = MessageBox.Show("Are you sure want to delete the selected customer COMPLETELY ?", "Warning !", MessageBoxButtons.YesNo);

        //        _id = int.Parse(dgwEditCustomers.CurrentRow.Cells[0].Value.ToString());
        //        var delcustomer = _db.Customers.Where(b => b.CustomerID == _id).FirstOrDefault();
        //        if (result == DialogResult.Yes)
        //        {
        //            delcustomer.CreatedBy = _kullanici;
        //            _db.SaveChanges();
        //            _db.Customers.Remove(delcustomer);
        //            _db.SaveChanges();
        //            CustomersShow();
        //            MessageBox.Show("The selected customer deleted successfully.");
        //        }
        //        else if (delcustomer.IsDeleted == true)
        //        {
        //            MessageBox.Show("The selected customer has already deleted.");
        //        }

        //    }
        #endregion
    }
}

