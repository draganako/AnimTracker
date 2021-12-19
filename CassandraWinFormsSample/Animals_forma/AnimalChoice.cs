using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals_forma
{
    public partial class AnimalChoice : Form
    {
        Korisnik loggedUser;
        Vrsta temp;
        List<Zivotinja> usersAnimals;
        List<Unos> fromTempAnimal;
        Unos u;
        public AnimalChoice()
        {
            InitializeComponent();
        }

        public AnimalChoice(Korisnik ulogovan)
        {
            InitializeComponent();
            this.loggedUser = ulogovan;
            ShowElementsIfCheckBoxSelected();/////////////////////////////////////////
        }

        private void ShowElementsIfCheckBoxSelected()
        {///////////////////////////////
            if (comboAnimals.SelectedIndex < 0)
            {
                //kad nije selektovana nijedna zivotinja
                groupBox2.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                btnDetails.Visible = false;
            }
            else
            {
                groupBox2.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                btnDetails.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimalAddition odb = new AnimalAddition(loggedUser);
            DialogResult dr = odb.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //samo tad treba ponoviti ucitavanje iz baze:
                UcitajZivotinje();
                comboAnimals.SelectedIndex = comboAnimals.Items.Count - 1;
                //poslednji sa spiska se selektuje ----- da li ce uvek biti najnoviji????
            }
            ShowElementsIfCheckBoxSelected();
            
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (u == null)
            {
                MessageBox.Show("Dodajte dnevni unos za zivotinju!");
                //za sada ovako, ali mislim da je bolje da u ovom slucaju obradu vrsimo sa poslednjim unosom
                //na primer mozda da se izmeni funkcija koja vraca poslednjih 30 unosa 
                //tako da joj se prosledi int limit - za koliko dana unazad da vraca, ovde bi onda bio 1
            }
            else
            {
                GraphForm odb =new GraphForm(temp, loggedUser, u, usersAnimals[comboAnimals.SelectedIndex]);
                odb.Show();
            }
        }

        private bool ValidateUnos()//////////////
        {
            if (String.IsNullOrEmpty(tbxFood.Text))
            {
                return false;
            }
            else
            {
                if (!Double.TryParse(tbxFood.Text, out double unos)) //uneta vrednost nije double
                    return false;
            }

            if (String.IsNullOrEmpty(tbxWater.Text))
            {
                return false;
            }
            else
            {
                if (!Double.TryParse(tbxWater.Text, out double unos))
                    return false;
            }

            if (String.IsNullOrEmpty(tbxWeight.Text))
            {
                return false;
            }
            else
            {
                if (!Double.TryParse(tbxWeight.Text, out double unos))
                    return false;
            }
            return true;
        }

        private void btnAddToday_Click(object sender, EventArgs e)
        {
            if (ValidateUnos())
            {
                ////////////////////////

                //poziva se da se doda novi unos za tu zivotinju
                u = new Unos();
                u.hrana = Convert.ToDouble(tbxFood.Text);
                u.voda = Convert.ToDouble(tbxWater.Text);
                u.tezina = Convert.ToDouble(tbxWeight.Text);
                DateTime today = System.DateTime.Now;
                u.dan = today.Date.Day.ToString();
                u.mesec = today.Date.Month.ToString();
                u.godina = today.Date.Year.ToString();

                u.zivotinjaID = usersAnimals[comboAnimals.SelectedIndex].animalID;
               // u.vreme = today.Date.ToString();

                DataProvider.AddUnos(u);

                fromTempAnimal = DataProvider.GetPoslednjih30Unosa(usersAnimals[comboAnimals.SelectedIndex].animalID);

                IscrtajChart();

                if (u.tezina > Convert.ToDouble(temp.maximumTezina) || u.tezina < Convert.ToDouble(temp.minimumTezina))
                {
                    MessageBox.Show("Weight is a bit concerning");
                }
                if (u.hrana > Convert.ToDouble(temp.maximumHrana) || u.hrana < Convert.ToDouble(temp.minimumHrana))
                {
                    MessageBox.Show("Food is a bit concerning");
                }
                if (u.voda > Convert.ToDouble(temp.maximumVoda) || u.voda < Convert.ToDouble(temp.minimumVoda))
                {
                    MessageBox.Show("Water is a bit concerning");
                }

            }
            else //////////////////////////////////////
            {
                MessageBox.Show("Please fill in all fields for daily input!");
            }
            
        }

        private void UcitajZivotinje()
        {
            comboAnimals.Items.Clear();
            usersAnimals = DataProvider.GetZivotinje(loggedUser.korisnikID);

            foreach (Zivotinja z in usersAnimals)
            {
                comboAnimals.Items.Add(z.ime);
            }
        }

        private void OdabirZivotinje_Load(object sender, EventArgs e)
        {
            UcitajZivotinje();///////////////////////////////////

        }

        private void comboZivotinje_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowElementsIfCheckBoxSelected();//////////////////////////////////////

            fromTempAnimal = DataProvider.GetPoslednjih30Unosa(usersAnimals[comboAnimals.SelectedIndex].animalID);
            IscrtajChart();
            temp = DataProvider.GetVrsta(usersAnimals[comboAnimals.SelectedIndex].vrstaID);
        }

        private void IscrtajChart()
        {


            chartMain.Series[0].Points.Clear();
            chartMain.Series[1].Points.Clear();
            chartMain.Series[2].Points.Clear();


            foreach (Unos uu in fromTempAnimal)
            {
                chartMain.Series[0].Points.AddXY(uu.dan, uu.voda);
                chartMain.Series[1].Points.AddXY(uu.dan, uu.hrana);
                chartMain.Series[2].Points.AddXY(uu.dan, uu.tezina);
            }

            if (rbType1.Checked == true)
            {
                chartMain.Series[0].Enabled = true;
                chartMain.Series[1].Enabled = false;
                chartMain.Series[2].Enabled = false;
            }

            else if (rbType2.Checked == true)
            {
                chartMain.Series[0].Enabled = false;
                chartMain.Series[1].Enabled = true;
                chartMain.Series[2].Enabled = false;
            }
            else if (rbType3.Checked == true)
            {
                chartMain.Series[0].Enabled = false;
                chartMain.Series[1].Enabled = false;
                chartMain.Series[2].Enabled = true;
            }

        }

        private void rbTip2_CheckedChanged(object sender, EventArgs e)
        {
            IscrtajChart();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close(); ///////////////////mozda zatvoriti sve forme ovde???
        }
    }
}
