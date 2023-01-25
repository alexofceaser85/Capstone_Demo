using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;
using WebClient.Model;

namespace Tests.WebClient.Endpoints.GradesEndpoints
{
    [TestFixture]
    public class AddGradeTests
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
        public void AddGrade(string name, string course, int gradeAmount)
        {
            GradeBindingModel grade = new GradeBindingModel() 
            {
                Name = name,
                Subject = course,
                GradeAmount = gradeAmount.ToString()
            };
            global::WebClient.Endpoints.GradesEndpoints.AddGrade(grade);

            Grade[] grades = global::WebClient.Endpoints.GradesEndpoints.GetGrades();
            Assert.Multiple( () => {
                    Assert.That(grades.Length, Is.EqualTo(1));
                    Assert.That(grades[0].Name, Is.EqualTo(grade.Name));
                    Assert.That(grades[0].Subject, Is.EqualTo(grade.Subject));
                    Assert.That(grades[0].GradeAmount.ToString(), Is.EqualTo(grade.GradeAmount));
                }
            );
            
        }
    }
}
