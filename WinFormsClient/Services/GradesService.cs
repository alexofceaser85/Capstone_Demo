using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;
using WinFormsClient.Endpoints;

namespace WinFormsClient.Services
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
            this.grades = GradesEndpoints.GetGrades().ToList();
            return this.grades;
        }

        public void AddGrade(string name, string subject, int amount)
        {
            GradesEndpoints.AddGrade(new Grade(null, name, subject, amount));
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
