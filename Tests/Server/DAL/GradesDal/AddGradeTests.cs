using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;

namespace Tests.Server.DAL.GradesDal
{
    [TestFixture]
    public class AddGradeTest
    {
        [SetUp]
        public void SetUp()
        {
            global::Server.Dal.GradesDal.RemoveGrades();
        }

        [TearDown]
        public void TearDown()
        {
            global::Server.Dal.GradesDal.RemoveGrades();
        }

        [Test]
        public void AddSingleGrade()
        {
            bool result = global::Server.Dal.GradesDal.AddGrade(new Grade(null, "Alpha", "Math", 90));
            Grade[] grades = global::Server.Dal.GradesDal.GetGrades().ToArray();

            Assert.Multiple(() =>
            {
                Assert.That(grades.Length, Is.EqualTo(1));
                Assert.That(grades[0].Name, Is.EqualTo("Alpha"));
                Assert.That(grades[0].Subject, Is.EqualTo("Math"));
                Assert.That(grades[0].GradeAmount, Is.EqualTo(90));
            });
        }
    }
}
