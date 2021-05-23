namespace Cambios
{
    using Servicos;
    using Modelos;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    
    public partial class Form1 : Form
    {

        #region Atributos

        private List<Rate> Rates;

        private NetworkService networkService;

        private ApiService apiService;

        private DialogService dialogService;

        private DataService dataService;

        #endregion

        public Form1()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            dialogService = new DialogService();
            dataService = new DataService();
            LoadRates();
        }

        private async void LoadRates()
        {

            bool load;

            labelResultado.Text = "A atualizar taxas...";

            var connection = networkService.CheckConnection();

            if (!connection.IsSuccess)
            {
                LoadLocalRates();
                load = false;
            }
            else
            {
                await LoadApiRates();
                load = true;
            }

            if(Rates.Count == 0)
            {
                labelResultado.Text = "não há ligação à net e não foram previamente carregadas as taxas.";

                labelStatus.Text = "primeira inicialização precisa de ter net";

                return;
            }

            comboBoxOrigem.DataSource = Rates;
            comboBoxOrigem.DisplayMember = "Name";

            //corrige bug da microsoft
            comboBoxDestino.BindingContext = new BindingContext();

            comboBoxDestino.DataSource = Rates;
            comboBoxDestino.DisplayMember = "Name";

            labelResultado.Text = "Taxas atualizadas...";

            if (load)
            {
                labelStatus.Text = string.Format("Taxas carregadas da net em {0:F}", DateTime.Now);
            }
            else
            {
                labelStatus.Text = string.Format("Taxas carregadas da BD");
            }

            progressBar1.Value = 100;

            buttonConverter.Enabled = true;
            buttonTroca.Enabled = true;

        }

        private void LoadLocalRates()
        {
            Rates = dataService.GetData();
        }

        private async Task LoadApiRates()
        {
            progressBar1.Value = 0;

            var response = await apiService.GetRate("http://cambios.somee.com", "/api/rates");

            Rates = (List<Rate>) response.Result;

            dataService.DeleteData();

            dataService.SaveData(Rates);

        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private void Convert()
        {
            if (string.IsNullOrEmpty(textBoxValor.Text))
            {
                dialogService.ShowMessage("Erro","Insira um valor a converter");
                return;
            }

            decimal valor;

            if(!decimal.TryParse(textBoxValor.Text, out valor))
            {
                dialogService.ShowMessage("Erro de conversão", "o valor tem que ser numerico");
                return;
            }

            if(comboBoxOrigem.SelectedItem == null)
            {
                dialogService.ShowMessage("Erro","tem  que escolher uma moeda a converter");
                return;
            }

            if (comboBoxDestino.SelectedItem == null)
            {
                dialogService.ShowMessage("Erro", "tem  que escolher uma moeda de destino a converter");
                return;
            }

            var taxaOrigem = (Rate) comboBoxOrigem.SelectedItem;

            var taxaDestino = (Rate)comboBoxDestino.SelectedItem;

            var valorConvertido = valor / (decimal)taxaOrigem.TaxRate * (decimal)taxaDestino.TaxRate;

            labelResultado.Text = string.Format("{0} {1:C2} = {2} {3:C2}", taxaOrigem.Code, valor, taxaDestino.Code, valorConvertido);

        }

        private void buttonTroca_Click(object sender, EventArgs e)
        {
            Troca();
        }

        private void Troca()
        {
            var aux = comboBoxOrigem.SelectedItem;

            comboBoxOrigem.SelectedItem = comboBoxDestino.SelectedItem;

            comboBoxDestino.SelectedItem = aux;

            Convert();

        }
    }
}
