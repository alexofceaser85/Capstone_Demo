using CapstoneDemo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClient.Endpoints
{
    public class GradesEndpoints
    {
        public static Grade[] GetGrades()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7113/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client.GetFromJsonAsync<Grade[]>("WeatherForecast").Result;
            }
        }

        public static void AddGrade(Grade gradeToAdd)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7113/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var grade = new CapstoneDemo.Shared.Grade(null, gradeToAdd.Name, gradeToAdd.Subject, gradeToAdd.GradeAmount);
                var _ = client.PostAsJsonAsync("WeatherForecast", grade).Result;
            }
        }
    }
}
