using System.Text.Json;

namespace AppMoedaHoje
{
    public class ApiConnector
    {

        private const string ApiUrl = "https://economia.awesomeapi.com.br/json/last/USD-BRL,EUR-BRL,BTC-BRL";
        private decimal highestValue = 0;
        private string highestCurrency = "";

        public async Task<Tuple<string, List<CurrencyData>>> FetchAndMonitorCurrencyDataAsync()
        {
            try
            {
                string sMensagem = string.Empty;
                using HttpClient client = new HttpClient();
                string response = await client.GetStringAsync(ApiUrl);

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var vdata = new List<CurrencyData>();
                var data = JsonSerializer.Deserialize<Dictionary<string, CurrencyData>>(response, options);

                if (data == null)
                    return new Tuple<string, List<CurrencyData>>("Não foi possível conectar a API", null);

                foreach (var currency in data.Values)
                {
                    vdata.Add(currency);
                }
                return new Tuple<string, List<CurrencyData>>("", vdata);
                //return sMensagem;
            }
            catch (Exception ex)
            {
                return new Tuple<string, List<CurrencyData>>($"Erro ao conectar à API: {ex.Message}", null);
            }
        }
    }

    // Uso:
    // var apiConnector = new ApiConnector();
    // await apiConnector.FetchAndMonitorCurrencyDataAsync();
}

