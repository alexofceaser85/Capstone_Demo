using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;
using WinFormsClient.Endpoints;

namespace WinFormsClient.Services
{
    public class GradesService
    {
        public Grade[] GetGrades()
        {
            return GradesEndpoints.GetGrades();
        }

        public void AddGrade(string name, string subject, int amount)
        {
            GradesEndpoints.AddGrade(new Grade(null, name, subject, amount));
        }
    }
}
