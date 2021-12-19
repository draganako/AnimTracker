using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;
using System;
using System.Windows.Forms;

namespace Animals_forma
{
    public partial class TypeAddition : Form
    {
        Vrsta tempType;

        public TypeAddition()
        {
            InitializeComponent();

            tempType = new Vrsta();
        }

        public TypeAddition(Vrsta v)
        {
            InitializeComponent();
            
            tempType = v;
            tbxDesc.Text = tempType.opis;
            tbxTypeName.Text = tempType.nazivvrste;
            tbxTypeName.Enabled = false; ///////posto je naziv deo primarnog kljuca ne sme da se menja pri azuriranju vrste
            tbxMaxWeight.Text = tempType.maximumTezina;
            tbxMaxWater.Text = tempType.maximumVoda;
            tbxMaxFood.Text = tempType.maximumHrana;
            tbxMinFood.Text = tempType.minimumHrana;
            tbxMinWater.Text = tempType.minimumVoda;
            tbxMinWeight.Text = tempType.minimumTezina;
            tbxStanFood.Text = tempType.standardHrana;
            tbxstandWeight.Text = tempType.standardTezina;
            tbxStanWater.Text = tempType.standardVoda;
            btnAddType.Text = "Change animal type";
            
        }

        private bool ValidateUnos()////////////////////////////////
        {

            if (String.IsNullOrEmpty(tbxTypeName.Text))
            {
                return false;
            }

            if (String.IsNullOrEmpty(tbxstandWeight.Text))
                return false;
            else
            {
                if (!Double.TryParse(tbxstandWeight.Text, out double unos))
                    return false;
            }

            if (String.IsNullOrEmpty(tbxMinWeight.Text))
                return false;
            else
            {
                if (!Double.TryParse(tbxMinWeight.Text, out double unoss))
                    return false;
            }

            if (String.IsNullOrEmpty(tbxMaxWeight.Text))
                return false;
            else
            {
                if (!Double.TryParse(tbxMaxWeight.Text, out double unos2))
                    return false;
            }

            if (String.IsNullOrEmpty(tbxStanFood.Text))
                return false;
            else
            {
                if (!Double.TryParse(tbxStanFood.Text, out double unos))
                    return false;
            }

            if (String.IsNullOrEmpty(tbxMaxFood.Text))
                return false;
            else
            {
                if (!Double.TryParse(tbxMaxFood.Text, out double unoss))
                    return false;
            }

            if (String.IsNullOrEmpty(tbxMinFood.Text))
                return false;
            else
            {
                if (!Double.TryParse(tbxMinFood.Text, out double unos2))
                    return false;
            }

            if (String.IsNullOrEmpty(tbxStanWater.Text))
                return false;
            else
            {
                if (!Double.TryParse(tbxStanWater.Text, out double unos))
                    return false;
            }

            if (String.IsNullOrEmpty(tbxMinWater.Text))
                return false;
            else
            {
                if (!Double.TryParse(tbxMinWater.Text, out double unoss))
                    return false;
            }

            if (String.IsNullOrEmpty(tbxMaxWater.Text))
                return false;
            else
            {
                if (!Double.TryParse(tbxMaxWater.Text, out double unos2))
                    return false;
            }

            //ako ne izbrisemo measurement
            //if (comboMeas.SelectedIndex < 0)
            //return false; 

            return true;
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            if (!ValidateUnos())
                MessageBox.Show("Please fill in all of the fields. Type of data has to be correct for each!");
            else
            {
                tempType.standardTezina = tbxstandWeight.Text;
                tempType.minimumTezina = tbxstandWeight.Text;
                tempType.maximumTezina = tbxMaxWeight.Text;
                tempType.standardHrana = tbxStanFood.Text;
                tempType.minimumHrana = tbxMinFood.Text;
                tempType.maximumHrana = tbxMaxFood.Text;
                tempType.standardVoda = tbxStanWater.Text;
                tempType.minimumVoda = tbxMinWater.Text;
                tempType.maximumVoda = tbxMaxWater.Text;
                tempType.nazivvrste = tbxTypeName.Text;
                tempType.opis = tbxDesc.Text;
                
                DataProvider.AddOrUpdateVrsta(tempType);

                this.DialogResult = DialogResult.OK; ////////////
                this.Close();
            }
        }
    }
}
