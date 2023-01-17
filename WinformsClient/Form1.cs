using CapstoneDemo.Shared;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        private Grade[]? forecasts;

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
                this.forecasts = client.GetFromJsonAsync<Grade[]>("WeatherForecast").Result;
                this.label1.Text = "";
                foreach (var forecast in this.forecasts)
                {
                    this.label1.Text += $"Forecast for: {forecast.Id} Summary: {forecast.Subject} Temp F: {forecast.Name} Temp C: {forecast.GradeAmount}\n";
                }
            }
        }
    }
}