using System;
using System.Windows.Forms;
using System.Collections.Generic;
using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;
using System.Linq;

namespace Animals_forma
{
    public partial class AdminOptionsRisks : Form
    {
        private Vrsta selectedVrsta;
        public AdminOptionsRisks()
        {
            InitializeComponent();
        }

        public AdminOptionsRisks(Vrsta selectedVrsta)
        {
            InitializeComponent();
            this.selectedVrsta = selectedVrsta;
        }

        private void AdminOpcijeBolesti_Load(object sender, EventArgs e)
        {
            dgvRisks.DataSource = DataProvider.GetBolestiVrste(selectedVrsta);

            dgvRisks.Columns[0].HeaderText = "Risk ID";
            dgvRisks.Columns[1].HeaderText = "Name";
            dgvRisks.Columns[2].HeaderText = "Water quantity";
            dgvRisks.Columns[3].HeaderText = "Food quantity";
            dgvRisks.Columns[4].HeaderText = "Weight";
            dgvRisks.Columns[5].HeaderText = "Type ID";
            dgvRisks.Columns[6].HeaderText = "Description";

        }

        private void addNewRiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RiskAddition forma = new RiskAddition(selectedVrsta.vrstaID);

            DialogResult dr = forma.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dgvRisks.DataBindings.Clear();
                dgvRisks.DataSource = DataProvider.GetBolestiVrste(selectedVrsta);
            }
            
        }

        private void changeSelectedRiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Bolest> allRisks = (List<Bolest>)dgvRisks.DataSource;

            Bolest selected = null;

            if (dgvRisks.SelectedRows.Count > 0)
            {
                selected = allRisks.ElementAt(dgvRisks.SelectedRows[0].Index);
                RiskAddition forma = new RiskAddition(selected);

                DialogResult dr = forma.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    dgvRisks.DataBindings.Clear();
                    dgvRisks.DataSource = DataProvider.GetBolestiVrste(selectedVrsta);
                }
            }
            else
                MessageBox.Show("Please choose a risk from the list!");
            
        }

        private void deleteSelectedRiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Bolest> sve = (List<Bolest>)dgvRisks.DataSource;

            Bolest selected = null;

            if (dgvRisks.SelectedRows.Count > 0)
            {
                selected = sve.ElementAt(dgvRisks.SelectedRows[0].Index);
                DataProvider.DeleteBolest(selected.bolestID, selected.vrstaId);

                dgvRisks.DataBindings.Clear();
                dgvRisks.DataSource = DataProvider.GetBolestiVrste(selectedVrsta);
            }
            else
                MessageBox.Show("Please choose a risk from the list!");
        }
    }
}
