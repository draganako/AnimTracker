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
    public partial class WelcomeForm : Form
    {
        Korisnik loggedUser;
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //logovanje zookeeper-a
            //if (!provereOK())
            //{
            //    MessageBox.Show("Sva polja moraju biti popunjena!");
            //    return;//ovde ostaje oko login dugmeta plavo sada :/
            //}

            if (tbxUsername.Text.Equals("admin") && UserExists())
            {
                AdminOptions ao = new AdminOptions();
                ao.Show();
            }
            else if (UserExists())
            {
                AnimalChoice odb = new AnimalChoice(loggedUser);
                odb.Show();
            }
            else
            {
                MessageBox.Show("Wrong log-in credentials!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //loguje se admin
            //ne mora da bude posebno dugme, samo za sad
            AdminOptions odb = new AdminOptions();
            odb.Show();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUser odb = new CreateUser();
            odb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Probe p = new Probe();
            p.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxPass.PasswordChar = '\u2022';

            tbxUsername.Text = "neki1234";
            tbxPass.Text = "jasamNeki";
        }

        private bool UserExists()
        {
            loggedUser = DataProvider.UserExists(tbxUsername.Text, tbxPass.Text);
            //loggedUser = DataProvider.UserExists("neki1234", "jasamNeki");
            if (loggedUser != null)
                return true;
            else
                return false;
        }

        //private bool provereOK()
        //{
        //    if (tbxUsername.Text != "" && tbxPass.Text != "")
        //        return true;
        //    else
        //        return false;
        //}
    }
}
