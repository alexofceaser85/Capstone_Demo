using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;
using Server.Dal;

namespace Tests.BlazorWinForms.ViewModel.GradesViewModel
{
    [TestFixture]
    public class GetGradesTests
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

        [TestCase("Alpha", "Math", 90)]
        [TestCase("Beta", "Computer Science", 20)]
        [TestCase("Charlie", "Physics", 80)]
        public void GetSingleGrade(string name, string subject, int gradeAmount)
        {
            global::BlazorWinForms.ViewModel.GradesViewModel viewModel = new();
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
