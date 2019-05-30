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
    public partial class AppLogin : Form
    {
        DadasDBEntities _db;
        public string _userName;
        public AppLogin()
        {
            InitializeComponent();
            _db = new DadasDBEntities();
        }

        private void AppLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            _userName = userName;
            string password = txtPassword.Text.TrimEnd().TrimStart();

            var userNameList = (from u in _db.Users
                                where u.IsDeleted == false
                                select u.UserName).ToList();
            var passwordQuery = (from u in _db.Users
                                 where u.UserName == userName
                                 select u.UserPassword).FirstOrDefault();

            if (userNameList.Contains(userName) && password == passwordQuery)
            {
                MessageBox.Show("Login successful...");
                txtUserName.Text = "";
                txtPassword.Text = "";
                FormBaslangicSayfasi formRezervasyonAnasayfa = new FormBaslangicSayfasi(_userName);
                formRezervasyonAnasayfa.ShowDialog();

            }
            else if (!userNameList.Contains(userName))
            {
                MessageBox.Show("Wrong Username or Password!");
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
            else if (password != passwordQuery)
            {
                MessageBox.Show("Wrong Password!");
                txtPassword.Text = "";
            }

        }
    }
}
