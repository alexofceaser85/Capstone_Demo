using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;

namespace BlazorWinForms.Services
{
    public class GradesService : IEnumerable<Grade>
    {
        private List<Grade> grades;

        public GradesService()
        {
            this.grades = new List<Grade> {
                new(null, "John", "Math", 100),
                new(null, "John", "Science", 87),
                new(null, "John", "English", 75),
                new(null, "John", "History", 95),
                new(null, "John", "Art", 90),
                new(null, "John", "Music", 60),
                new(null, "John", "PE", 100),
                new(null, "John", "Computer Science", 80)
            };
        }

        public List<Grade> GetGrades()
        {
            return this.grades;
        }

        public void AddGrade(string name, string subject, int amount)
        {
           this.grades.Add(new Grade(null, name, subject, amount));
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
