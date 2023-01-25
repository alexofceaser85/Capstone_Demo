using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;

namespace Tests.WinFormsClient.ViewModel.GradesViewModel
{
    [TestFixture]
    public class AddGradesTests
    {
        [SetUp]
        public void SetUp()
        {
            global::WinFormsClient.Endpoints.GradesEndpoints.RemoveGrades();
        }

        [TearDown]
        public void TearDown()
        {
            global::WinFormsClient.Endpoints.GradesEndpoints.RemoveGrades();
        }

        [TestCase("Alpha", "Math", 90)]
        [TestCase("Beta", "Computer Science", 20)]
        [TestCase("Charlie", "Physics", 80)]
        public void AddSingleGrade(string name, string subject, int gradeAmount)
        {
            global::WinFormsClient.ViewModel.GradesViewModel viewModel = new();
            viewModel.AddGrade(name, subject, gradeAmount);

            ObservableCollection<Grade> grades = viewModel.GetGrades();
            Assert.Multiple(() =>
                {
                    Assert.That(grades.Count, Is.EqualTo(1));
                    Assert.That(grades[0].Name, Is.EqualTo(name));
                    Assert.That(grades[0].Subject, Is.EqualTo(subject));
                    Assert.That(grades[0].GradeAmount, Is.EqualTo(gradeAmount));
                }
            );
        }
    }
}
