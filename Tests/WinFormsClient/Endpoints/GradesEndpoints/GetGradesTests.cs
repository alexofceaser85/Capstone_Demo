using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;

namespace Tests.WinFormsClient.Endpoints.GradesEndpoints
{
    [TestFixture]
    public class GetGradesTests
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

        [Test]
        public void EmptyTable()
        {
            Grade[] grades = global::WinFormsClient.Endpoints.GradesEndpoints.GetGrades();
            Assert.That(grades.Length, Is.EqualTo(0));
        }

        [Test]
        public void TableWithSingleRow()
        {
            Grade grade = new Grade(null, "Alpha", "Math", 90);
            global::WinFormsClient.Endpoints.GradesEndpoints.AddGrade(grade);

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
        public void TableWithMultipleRow()
        {
            Grade[] grades = {
                new Grade(null, "Alpha", "Math", 90),
                new Grade(null, "Beta", "Computer Science", 90),
                new Grade(null, "Charlie", "Physics", 90),
            };

            foreach (Grade grade in grades)
            {
                global::WinFormsClient.Endpoints.GradesEndpoints.AddGrade(grade);
            }
            
            Grade[] retrievedGrades = global::WinFormsClient.Endpoints.GradesEndpoints.GetGrades();
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
