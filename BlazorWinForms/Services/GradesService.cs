using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorWinForms.Endpoints;
using CapstoneDemo.Shared;

namespace BlazorWinForms.Services
{
    public class GradesService : IEnumerable<Grade>
    {
        private List<Grade> grades;

        public GradesService()
        {
            this.grades = new List<Grade>();
        }

        public List<Grade> GetGrades()
        {
            this.grades = GradeEndpoints.GetGrades().ToList();
            return this.grades;
        }

        public void AddGrade(string name, string subject, int amount)
        {
            GradeEndpoints.AddGrade(new Grade(null, name, subject, amount));
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
