using System.Net.Http.Headers;
using CapstoneDemo.Shared;
using WebClient.Model;

namespace WebClient.Endpoints
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

        public static void AddGrade(GradeBindingModel gradeToAdd)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7113/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var grade = new CapstoneDemo.Shared.Grade(null, gradeToAdd.Name, gradeToAdd.Subject, int.Parse(gradeToAdd.GradeAmount));
                var _ = client.PostAsJsonAsync("WeatherForecast", grade).Result;
            }
        } 
    }
}
