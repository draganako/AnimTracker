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
    public partial class AnimalAddition : Form
    {
        List<Vrsta> temp;
        Korisnik loggedUser;
        public AnimalAddition()
        {
            InitializeComponent();
        }

        public AnimalAddition(Korisnik k)
        {
            InitializeComponent();
            loggedUser = k;
        }

        private bool ValidateUnos()////////////////////////////////
        {
            //ime i startweight ne smeju da budu null, opis moze

            if (String.IsNullOrEmpty(tbxName.Text))
            {
                return false;
            }

            if (String.IsNullOrEmpty(tbxStartWeight.Text))
            {
                return false;
            }
            else
            {
                if (!Double.TryParse(tbxStartWeight.Text, out double unos))
                    return false;
            }

            if (comboType.SelectedIndex < 0)
                return false; //mora da bude odabrana vrsta

            return true;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (ValidateUnos())
            {
                Zivotinja z = new Zivotinja(tbxName.Text, loggedUser.korisnikID, tbxStartWeight.Text, "1", temp[comboType.SelectedIndex].vrstaID);
                DataProvider.AddAnimal(z);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all of the obligatory fields!");
            }
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kada se promeni ovo da se iz baze ucita opis vrste
            //i upise u onaj text box
            tbxDesc.Text = temp[comboType.SelectedIndex].opis;
            
        }

        private void PrikazUnos_Load(object sender, EventArgs e)
        {
            temp = DataProvider.GetVrste();

            for (int i = 0; i < temp.Count; i++)
            {
                comboType.Items.Add(temp[i].nazivvrste);
            }
        }
    }
}
