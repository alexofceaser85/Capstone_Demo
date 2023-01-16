using System.Net.Http.Headers;
using System.Net.Http.Json;
using CapstoneDemo.Shared;
using static System.Net.WebRequestMethods;

namespace CapstoneDemo.WinformsClient
{
    public partial class Form1 : Form
    {
        private WeatherForecast[]? forecasts;

        public Form1()
        {
            InitializeComponent();
            this.get();
        }

        private void get()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7113/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                this.forecasts = client.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast").Result;
                this.label1.Text = "";
                foreach (var forecast in this.forecasts)
                {
                    this.label1.Text += $"Forecast for: {forecast.Date} Summary: {forecast.Summary} Temp F: {forecast.TemperatureF} Temp C: {forecast.TemperatureC}\n";
                }
            }
        }
    }
}