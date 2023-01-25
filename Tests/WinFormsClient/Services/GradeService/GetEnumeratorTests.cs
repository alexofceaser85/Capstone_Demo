using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;

namespace Tests.WinFormsClient.Services.GradeService
{
    [TestFixture]
    public class GetEnumeratorTests
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
        public void GetEmptyEnumerator()
        {
            global::WinFormsClient.Services.GradesService service = new();
            using var enumerator = service.GetEnumerator();

            Assert.That(enumerator.Current, Is.EqualTo(null));
        }

        [TestCase("Alpha", "Math", 90)]
        [TestCase("Beta", "Computer Science", 20)]
        [TestCase("Charlie", "Physics", 80)]
        public void SingleItemInEnumerator(string name, string subject, int gradeAmount)
        {
            global::WinFormsClient.Services.GradesService service = new();
            service.AddGrade(name, subject, gradeAmount);
            service.GetGrades();

            int index = 0;

            Assert.Multiple(() =>
            {
                foreach (Grade grade in service)
                {
                    index++;
                    Assert.That(grade.Name, Is.EqualTo(name));
                    Assert.That(grade.Subject, Is.EqualTo(subject));
                    Assert.That(grade.GradeAmount, Is.EqualTo(gradeAmount));
                }
                Assert.That(index, Is.EqualTo(1));
            });
        }

        [TestCase("Alpha", "Math", 90)]
        [TestCase("Beta", "Computer Science", 20)]
        [TestCase("Charlie", "Physics", 80)]
        public void SingleItemInGenericEnumerator(string name, string subject, int gradeAmount)
        {
            global::WinFormsClient.Services.GradesService service = new();
            service.AddGrade(name, subject, gradeAmount);
            service.GetGrades();

            int index = 0;

            IEnumerable enumerable = service;

            Assert.Multiple(() =>
            {
                foreach (Grade grade in enumerable)
                {
                    index++;
                    Assert.That(grade.Name, Is.EqualTo(name));
                    Assert.That(grade.Subject, Is.EqualTo(subject));
                    Assert.That(grade.GradeAmount, Is.EqualTo(gradeAmount));
                }
                Assert.That(index, Is.EqualTo(1));
            });
        }


    }
}
