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
    public partial class GraphForm : Form
    {
        Korisnik loggedUser;
        Vrsta vrsta;
        Unos u;
        Zivotinja z;
        List<Unos> fromTempAnimal;

        List<Bolest> potentialRisks;

        public GraphForm()
        {
            InitializeComponent();
        }

        public GraphForm(Vrsta trenutnaVrsta, Korisnik loggedUser, Unos u, Zivotinja z)
        {
            InitializeComponent();
            this.loggedUser = loggedUser;
            this.vrsta = trenutnaVrsta;
            this.u = u;
            this.z = z;
            potentialRisks = new List<Bolest>();

            
        }

        private void Grafoviforma_Load(object sender, EventArgs e)
        {
            List<Bolest> sviProblemi = DataProvider.GetBolestiVrste(vrsta);

            bool add;

            foreach (Bolest bol in sviProblemi)
            {
                add = false;

                if ((bol.tezina != 0) && (bol.tezina < Convert.ToDouble(vrsta.standardTezina)) && (u.tezina <= bol.tezina)) //ova stavka je navedena (!=0) i manja je od standarda, pa proveravamo da li je iz unosa vrednost manja od toga
                {
                        add = true;
                }
                else if ((bol.tezina != 0) && (bol.tezina > Convert.ToDouble(vrsta.standardTezina)) && (u.tezina >= bol.tezina))
                {
                        add = true;
                }

                if ((bol.kolicinaHrane != 0) && (bol.kolicinaHrane < Convert.ToDouble(vrsta.standardHrana)) && (u.hrana <= bol.kolicinaHrane))
                {
                    add = true;
                }
                else if ((bol.kolicinaHrane != 0) && (bol.kolicinaHrane > Convert.ToDouble(vrsta.standardHrana)) && (u.hrana >= bol.kolicinaHrane))
                {
                    add = true;
                }

                if ((bol.kolicinaVode != 0) && (bol.kolicinaVode < Convert.ToDouble(vrsta.standardVoda)) && (u.voda <= bol.kolicinaVode))
                {
                    add = true;
                }
                else if ((bol.kolicinaVode != 0) && (bol.kolicinaVode > Convert.ToDouble(vrsta.standardVoda)) && (u.voda >= bol.kolicinaVode))
                    {
                    add = true;
                }

                if (add)
                    potentialRisks.Add(bol);
            }

            for (int i = 0; i < potentialRisks.Count; i++)
            {
                lbxReasons.Items.Add(potentialRisks[i].naziv);
            }

            fromTempAnimal = DataProvider.GetPoslednjih30Unosa(z.animalID);
            IscrtajChart();
        }


        private void IscrtajChart()
        {
            chartMain.Series[0].LegendText = "Water";
            chartMain.Series[1].LegendText = "Food";
            chartMain.Series[2].LegendText = "Weight";

            chartMain.Series[0].Points.Clear();
            chartMain.Series[1].Points.Clear();
            chartMain.Series[2].Points.Clear();


            foreach (Unos uu in fromTempAnimal)
            {
                chartMain.Series[0].Points.AddXY(uu.dan, uu.voda);
                chartMain.Series[1].Points.AddXY(uu.dan, uu.hrana);
                chartMain.Series[2].Points.AddXY(uu.dan, uu.tezina);
            }

            if (rbWater.Checked == true)
            {
                chartMain.Series[0].Enabled = true;
                chartMain.Series[1].Enabled = false;
                chartMain.Series[2].Enabled = false;
            }

            else if (rbFood.Checked == true)
            {
                chartMain.Series[0].Enabled = false;
                chartMain.Series[1].Enabled = true;
                chartMain.Series[2].Enabled = false;
            }
            else if (rbWeight.Checked == true)
            {
                chartMain.Series[0].Enabled = false;
                chartMain.Series[1].Enabled = false;
                chartMain.Series[2].Enabled = true;
            }

            if (rbDispColumns.Checked == true)
            {
                chartMain.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chartMain.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chartMain.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            }

            else if (rbDispPoints.Checked == true)
            {
                chartMain.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
                chartMain.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
                chartMain.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            }
            else if (rbDispLines.Checked == true)
            {
                chartMain.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chartMain.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chartMain.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }

        }

        private void rbPrikazTacke_CheckedChanged(object sender, EventArgs e)
        {
            IscrtajChart();
        }

        private void rbTip1_CheckedChanged(object sender, EventArgs e)
        {
            IscrtajChart();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            int vremeOd = 0, vremeDo = 0;
            vremeDo = dtpTo.Value.Date.Year * 10000 + dtpTo.Value.Date.Month * 100 + dtpTo.Value.Date.Day;
            vremeOd = dtpFrom.Value.Date.Year * 10000 + dtpFrom.Value.Date.Month * 100 + dtpFrom.Value.Date.Day;
            fromTempAnimal = DataProvider.GetPoslednjih30Unosa(z.animalID, vremeOd-1, vremeDo+1);

            IscrtajChart();
        }

        private void lbxReasons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxReasons.SelectedIndex >= 0)
                tbxDescription.Text = potentialRisks[lbxReasons.SelectedIndex].opis;
            else
                tbxDescription.Text = String.Empty;
        }
    }
}
