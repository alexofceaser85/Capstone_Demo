using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;
using Server.Dal;

namespace Tests.BlazorWinForms.Endpoints.GradesEndpoints
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
        public void AddGrade(string name, string course, double gradeAmount)
        {
            Grade grade = new Grade(null, name, course, gradeAmount);
            global::BlazorWinForms.Endpoints.GradeEndpoints.AddGrade(grade);

            Grade[] grades = global::WinFormsClient.Endpoints.GradesEndpoints.GetGrades();
            Assert.Multiple( () => {
                    Assert.That(grades.Length, Is.EqualTo(1));
                    Assert.That(grades[0].Name, Is.EqualTo(grade.Name));
                    Assert.That(grades[0].Subject, Is.EqualTo(grade.Subject));
                    Assert.That(grades[0].GradeAmount, Is.EqualTo(grade.GradeAmount));
                }
            );
            
        }

        [Test]
        public void AddManyGrade()
        {
            Grade[] grades = {
                new Grade(null, "Alpha", "Math", 90),
                new Grade(null, "Beta", "Computer Science", 90),
                new Grade(null, "Charlie", "Physics", 90),
            };

            foreach (Grade grade in grades)
            {
                global::BlazorWinForms.Endpoints.GradeEndpoints.AddGrade(grade);
            }

            Grade[] retrievedGrades = global::BlazorWinForms.Endpoints.GradeEndpoints.GetGrades();
            Assert.Multiple(() => {
                    Assert.That(retrievedGrades.Length, Is.EqualTo(grades.Length));
                    for (int i = 0; i < retrievedGrades.Length; i++)
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
