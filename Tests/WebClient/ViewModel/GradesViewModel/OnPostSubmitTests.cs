using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;
using Server.Dal;
using WebClient.Model;

namespace Tests.WebClient.ViewModel.GradesViewModel
{
    [TestFixture]
    public class OnPostSubmitTests
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
        public void PostGrades()
        {
            global::WebClient.ViewModel.GradesViewModel viewModel = new();
            GradeBindingModel grade = new GradeBindingModel()
            {
                Name = "Alpha",
                Subject = "Math",
                GradeAmount = "90"
            };
            viewModel.OnPostSubmit(grade);

            int count = 0;
            foreach (Grade _ in viewModel)
            {
                count++;
            }

            Assert.That(count, Is.EqualTo(1));
        }
    }
}
