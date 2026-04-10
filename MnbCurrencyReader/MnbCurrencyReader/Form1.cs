using MnbServiceReference;

namespace MnbCurrencyReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var mnbService = new MNBArfolyamServiceSoapClient();

                var request = new GetExchangeRatesRequestBody()
                {
                    currencyNames = "EUR",
                    startDate = "2020-01-01",
                    endDate = "2020-06-30"
                };

                var response = mnbService.GetExchangeRates(request);

                if (response != null)
                {
                    var result = response.GetExchangeRateResult;
                    // Használd az eredményt
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba: {ex.Message}");
            }
        }
    }
}
