using System;
using System.Windows.Forms;
using CassandraDataLayer;
using CassandraDataLayer.QueryEntities;

namespace Animals_forma
{
    public partial class RiskAddition : Form
    {
        private Bolest tempRisk;
        
        public RiskAddition()
        {
            InitializeComponent();
        }

        public RiskAddition(string idofType) //zove se pri kreiranju nove
        {
            InitializeComponent();
            tempRisk = new Bolest();
            tempRisk.vrstaId = idofType;
        }

        public RiskAddition(Bolest b) //konstruktor koji se zove pri azuriranju postojece bolesti
        {
            InitializeComponent();

            btnAddRisk.Text = "Change risk";

            tempRisk = b;
            tbxRiskName.Text = b.naziv;
            tbxDailyFood.Text = b.kolicinaHrane.ToString();
            tbxDailyWater.Text = b.kolicinaVode.ToString();
            tbxWeight.Text = b.tezina.ToString();
            tbxRiskDesc.Text = b.opis;
            
        }

        private bool ValidateUnos()////////////////////////////////
        {

            if (String.IsNullOrEmpty(tbxRiskName.Text))
            {
                return false;
            }

            if (String.IsNullOrEmpty(tbxDailyFood.Text))
                return false;
            else
            {
                if (!Double.TryParse(tbxDailyFood.Text, out double unos))
                    return false;
            }

            if (String.IsNullOrEmpty(tbxDailyWater.Text))
                return false;
            else
            {
                if (!Double.TryParse(tbxDailyWater.Text, out double unoss))
                    return false;
            }

            if (String.IsNullOrEmpty(tbxWeight.Text))
                return false;
            else
            {
                if (!Double.TryParse(tbxWeight.Text, out double unos2))
                    return false;
            }

            return true;
        }

        private void btnDodajBolest_Click(object sender, EventArgs e)
        {
            if (!ValidateUnos())
                MessageBox.Show("Please fill in all of the fields. Type of data has to be correct for each!");
            else
            {

                //kod azuriranja se menjaju ove vrednosti - samo njih smemo da menjamo, primary key ostaje
                //kod dodavanja je prosledjen idVrste u formi, pa se ovde samo ostale vrednosti menjaju, a idBolesti je null
                tempRisk.naziv = tbxRiskName.Text;
                tempRisk.kolicinaHrane = Convert.ToDouble(tbxDailyFood.Text);
                tempRisk.kolicinaVode = Convert.ToDouble(tbxDailyWater.Text);
                tempRisk.tezina = Convert.ToDouble(tbxWeight.Text);
                tempRisk.opis = tbxRiskDesc.Text;

                DataProvider.AddOrUpdateBolest(tempRisk);

                this.DialogResult = DialogResult.OK;
                this.Close(); //klikom na dugme se zatvara forma

            }
            
        }
    }
}
