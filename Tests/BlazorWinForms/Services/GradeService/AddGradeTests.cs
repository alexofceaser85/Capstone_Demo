using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CapstoneDemo.Shared;
using Server.Dal;

namespace Tests.BlazorWinForms.Services.GradeService
{
    [TestFixture]
    public class AddGradeTests
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
        public void AddSingleGrade(string name, string subject, int gradeAmount)
        {
            global::BlazorWinForms.Services.GradesService service = new();
            service.AddGrade(name, subject, gradeAmount);

            List<Grade> grades = service.GetGrades();
            Assert.Multiple(() =>
                {
                    Assert.That(grades.Count, Is.EqualTo(1));
                    Assert.That(grades[0].Name, Is.EqualTo(name));
                    Assert.That(grades[0].Subject, Is.EqualTo(subject));
                    Assert.That(grades[0].GradeAmount, Is.EqualTo(gradeAmount));
                }
            );
        }

        [Test]
        public void AddManyGrades()
        {
            Grade[] grades = {
                new Grade(null, "Alpha", "Math", 90),
                new Grade(null, "Beta", "Computer Science", 90),
                new Grade(null, "Charlie", "Physics", 90),
            };
            global::BlazorWinForms.Services.GradesService service = new();


            foreach (Grade grade in grades)
            {
                service.AddGrade(grade.Name, grade.Subject, (int)grade.GradeAmount);
            }

            List<Grade> retrievedGrades = service.GetGrades();
            Assert.Multiple(() =>
            {
                Assert.That(retrievedGrades.Count, Is.EqualTo(grades.Length));
                for (int i = 0; i < retrievedGrades.Count; i++)
                {
                    Assert.That(retrievedGrades[i].Name, Is.EqualTo(grades[i].Name));
                    Assert.That(retrievedGrades[i].Subject, Is.EqualTo(grades[i].Subject));
                    Assert.That(retrievedGrades[i].GradeAmount, Is.EqualTo(grades[i].GradeAmount));
                }
            }
            );
        }
    }
}
