using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Headers;
using CapstoneDemo.Shared;
using WebClient.Endpoints;
using WebClient.Model;
using System.Collections;

namespace WebClient.Service
{
    public class GradesService : IEnumerable<Grade>
    {
        private List<Grade> grades;

        public GradesService()
        {
            this.grades = new List<Grade>();
        }

        public void OnGet()
        {
            this.grades = GradesEndpoints.GetGrades().ToList();
        }

        public void OnPostSubmit(GradeBindingModel gradeModel)
        {
            GradesEndpoints.AddGrade(gradeModel);
            OnGet();
        }

        public IEnumerator<Grade> GetEnumerator()
        {
            return this.grades.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
