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
    public class RemoveGradesTests
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
        public void AddGrade(string name, string course, double gradeAmount)
        {
            Grade grade = new Grade(null, name, course, gradeAmount);
            global::WinFormsClient.Endpoints.GradesEndpoints.AddGrade(grade);

            global::WinFormsClient.Endpoints.GradesEndpoints.RemoveGrades();
            Grade[] grades = global::WinFormsClient.Endpoints.GradesEndpoints.GetGrades();
            
            Assert.That(grades.Length, Is.EqualTo(0));
            
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
                global::WinFormsClient.Endpoints.GradesEndpoints.AddGrade(grade);
            }

            global::WinFormsClient.Endpoints.GradesEndpoints.RemoveGrades();
            Grade[] retrievedGrades = global::WinFormsClient.Endpoints.GradesEndpoints.GetGrades();
            Assert.That(retrievedGrades.Length, Is.EqualTo(0));
        }
    }
}
