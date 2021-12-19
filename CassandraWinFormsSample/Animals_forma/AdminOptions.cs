using CassandraDataLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraDataLayer.QueryEntities;


namespace Animals_forma
{
    public partial class AdminOptions : Form
    {
        public AdminOptions()
        {
            InitializeComponent();
        }

        private void AdminOpcije_Load(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = DataProvider.GetVrste();

            dgvDisplay.Columns[0].HeaderText = "ID types";
            dgvDisplay.Columns[1].HeaderText = "Naziv types";
            dgvDisplay.Columns[2].HeaderText = "Maksimum hrane";
            dgvDisplay.Columns[3].HeaderText = "Maksimum tezine";
            dgvDisplay.Columns[4].HeaderText = "Maksimum vode";
            dgvDisplay.Columns[5].HeaderText = "Minimum hrane";
            dgvDisplay.Columns[6].HeaderText = "Minimum tezine";
            dgvDisplay.Columns[7].HeaderText = "Minimum vode";
            dgvDisplay.Columns[8].HeaderText = "Opis";
            dgvDisplay.Columns[9].HeaderText = "Standardna hrana";
            dgvDisplay.Columns[10].HeaderText = "Standardna tezina";
            dgvDisplay.Columns[11].HeaderText = "Standardna voda";
        }

        private void addNewAnimalTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeAddition form = new TypeAddition();
            
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dgvDisplay.DataBindings.Clear();
                dgvDisplay.DataSource = DataProvider.GetVrste();
            }
        }

        private void manageTheRisksForSelectedTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Vrsta> types = (List<Vrsta>)dgvDisplay.DataSource;

            Vrsta selectedType = null;

            if (dgvDisplay.SelectedRows.Count > 0)
            {
                selectedType = types.ElementAt(dgvDisplay.SelectedRows[0].Index);
                AdminOptionsRisks form = new AdminOptionsRisks(selectedType);
                form.Show();
            }
            else
                MessageBox.Show("Please choose a type from the list!");

        }

        private void changeSelectedTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Vrsta> types = (List<Vrsta>)dgvDisplay.DataSource;

            Vrsta selectedType = null;

            if (dgvDisplay.SelectedRows.Count > 0)
            {
                selectedType = types.ElementAt(dgvDisplay.SelectedRows[0].Index);

                TypeAddition form = new TypeAddition(selectedType);
                DialogResult dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    dgvDisplay.DataBindings.Clear();
                    dgvDisplay.DataSource = DataProvider.GetVrste();
                }
            }
            else
                MessageBox.Show("Please choose a type from the list!");
        }

        private void deleteSelectedTyoeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Vrsta> types = (List<Vrsta>)dgvDisplay.DataSource;

            Vrsta selectedType = types.ElementAt(dgvDisplay.SelectedRows[0].Index);

            DataProvider.DeleteVrsta(selectedType.vrstaID, selectedType.nazivvrste);

            dgvDisplay.DataBindings.Clear();
            dgvDisplay.DataSource = DataProvider.GetVrste();
        }
    }
}
