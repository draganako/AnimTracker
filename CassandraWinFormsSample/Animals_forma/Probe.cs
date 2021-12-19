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
    public partial class Probe : Form
    {
        public Probe()
        {
            InitializeComponent();
        }

        private void btnAddVrsta_Click(object sender, EventArgs e)
        {
            TypeAddition forma = new TypeAddition();
            forma.Show();
        }

        private void btnGetVrsta_Click(object sender, EventArgs e)
        {
            Vrsta v = DataProvider.GetVrsta(tbxVrstaID.Text);
            tbxPrikazi.Text = "vrstaID: " + v.vrstaID +
                                " max hrana: " + v.maximumHrana
                                +
                                " min hrana: " + v.minimumHrana
                                +
                                " standard hrana: " + v.standardHrana
                                +
                                " max voda: " + v.maximumVoda
                                +
                                " min voda: " + v.minimumVoda
                                +
                                " stand voda: " + v.standardVoda;
        }

        private void btnGetVrste_Click(object sender, EventArgs e)
        {
            List<Vrsta> vrstee = new List<Vrsta>();
            vrstee = DataProvider.GetVrste();

            string prikaaz = "";
            foreach(var v in vrstee)
            {
                prikaaz += "vrstaID: " + v.vrstaID +
                                " max hrana: " + v.maximumHrana
                                +
                                " min hrana: " + v.minimumHrana
                                +
                                " standard hrana: " + v.standardHrana
                                +
                                " max voda: " + v.maximumVoda
                                +
                                " min voda: " + v.minimumVoda
                                +
                                " stand voda: " + v.standardVoda;
                prikaaz += "\n";
            }
            tbxPrikazi.Text = prikaaz; 
        }

        private void btnAddKorisnik_Click(object sender, EventArgs e)
        {
            Korisnik k = new Korisnik(tbxKorisnikID.Text, btxImeKor.Text, tbxPrezimeKor.Text, tbxKorisnicko.Text, tbxLozinka.Text);
            DataProvider.AddKorisnik(k);
        }

        private void btnGet1Korisnik_Click(object sender, EventArgs e)
        {
            Korisnik k = DataProvider.GetKorisnik(tbxKorisnikID.Text);
            lbl1Kor.Text = k.korisnikID + " ime: " + k.ime;
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            Zivotinja z = new Zivotinja(tbxZivotinjaIme.Text, tbxVlasnikIDdodavanje.Text, tbxZivotinjaPocetna.Text, tbxZivotinjaID.Text, tbxVlasnikIDdodavanje.Text);
            DataProvider.AddAnimal(z);
        }

        private void btnGet1Animal_Click(object sender, EventArgs e)
        {
            Zivotinja k = DataProvider.GetZivotinja(tbxAnimalID.Text, tbxVlasnikID.Text);
            lbl1Animal.Text = k.animalID + " ime: " + k.ime;
        }

        private void btnGetAllAnimals_Click(object sender, EventArgs e)
        {
            List<Zivotinja> vrstee = new List<Zivotinja>();
            vrstee = DataProvider.GetZivotinje(tbxVlasnikID.Text);

            string prikaaz = "";
            foreach (var v in vrstee)
            {
                prikaaz += "animalid: " + v.animalID +
                                " vlasnik: " + v.ime
                                +
                                " vrsta: " + v.vrstaID;
                prikaaz += "\n";
            }
            tbxPrikazi.Text = prikaaz;
        }

        private void btwAddUnos_Click(object sender, EventArgs e)
        {
            Unos z = new Unos(tbxZivotinjaID.Text, Convert.ToDouble(tbxVodaUnos.Text), Convert.ToDouble(tbxHranaUnos.Text), Convert.ToDouble(tbxtezina.Text), 1, 21, 1, 1997);
            DataProvider.AddUnos(z);
        }

        private void btnGetUnosi_Click(object sender, EventArgs e)
        {
            List<Unos> vrstee = new List<Unos>();
            vrstee = DataProvider.GetUnos(tbxUnosID.Text);

            string prikaaz = "";
            foreach (var v in vrstee)
            {
                prikaaz += "vrstaID: " + v.zivotinjaID +
                                " dan: " + v.dan
                                +
                                " mesec: " + v.mesec;
                prikaaz += "\n";
            }
            tbxPrikazi.Text = prikaaz;
        }

        //ovo je za probu fje samo
        private void tbxPrikazi_TextChanged(object sender, EventArgs e)
        {
            DataProvider.GetPoslednjih30Unosa("1");

        }
    }
}
