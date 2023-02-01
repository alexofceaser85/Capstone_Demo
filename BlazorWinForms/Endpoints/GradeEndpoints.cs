using CapstoneDemo.Shared;
using System.Net.Http.Headers;
using System.Net.Http;
using System;
using System.Net.Http.Json;

namespace BlazorWinForms.Endpoints;

public class GradeEndpoints
{
    public static Grade[] GetGrades()
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://localhost:7113/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client.GetFromJsonAsync<Grade[]>("GetGrades").Result;
        }
    }

    public static void AddGrade(Grade gradeToAdd)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://localhost:7113/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var grade = new Grade(null, gradeToAdd.Name, gradeToAdd.Subject, gradeToAdd.GradeAmount);
            var _ = client.PostAsJsonAsync("PostGrades", grade).Result;
        }
    }
}