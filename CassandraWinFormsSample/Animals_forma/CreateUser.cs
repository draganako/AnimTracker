using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;

namespace Animals_forma
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
               
                Korisnik temp = DataProvider.GetKorisnikPoKorImenu(tbxUsername.Text);
                if (temp != null)
                    MessageBox.Show("Username has to be unique!");
                else
                {
                    Korisnik k = new Korisnik();
                    k.ime = tbxName.Text;
                    k.prezime = tbxSurname.Text;
                    k.lozinka = tbxPass.Text;
                    k.korisnicko = tbxUsername.Text;

                    DataProvider.AddKorisnik(k);
                    MessageBox.Show("User successfully created.");
                    this.Close();
                }
            }
            else
                MessageBox.Show("Please fill in all of the obligatory fields!");
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            tbxPass.Clear();
            tbxPass.PasswordChar = '\u2022';
        }

        private bool ValidateInput()
        {
            if (String.IsNullOrEmpty(tbxUsername.Text) || String.IsNullOrEmpty(tbxName.Text)
                ||  String.IsNullOrEmpty(tbxSurname.Text) || String.IsNullOrEmpty(tbxPass.Text))
                return false;
            else
                return true;
        }
    }
}

