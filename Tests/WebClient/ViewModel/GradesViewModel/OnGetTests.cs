using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;
using Server.Dal;

namespace Tests.WebClient.ViewModel.GradesViewModel
{
    [TestFixture]
    public class OnGetTests
    {
        [SetUp]
        public void SetUp()
        {
            GradesDal.RemoveGrades();
        }

        [TearDown]
        public void TearDown()
        {
            GradesDal.RemoveGrades();
        }

        [Test]
        public void GetGrades()
        {
            GradesDal.AddGrade(new Grade(null, "Alpha", "Math", 90));
            global::WebClient.ViewModel.GradesViewModel viewModel = new();

            viewModel.OnGet();
            int count = 0;
            foreach (Grade grade in viewModel)
            {
                count++;
            }

            Assert.That(count, Is.EqualTo(1));
        }
    }
}
