using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Headers;
using CapstoneDemo.Shared;
using WebClient.Endpoints;
using WebClient.Model;

namespace WebClient.Service
{
    public class GradesService : PageModel
    {
        public Grade[]? Grades { get; set; }

        public void OnGet()
        {
            Grades = GradesEndpoints.GetGrades();
        }

        public void OnPostSubmit(GradeBindingModel gradeModel)
        {
            GradesEndpoints.AddGrade(gradeModel);
            OnGet();
        }
    }
}
