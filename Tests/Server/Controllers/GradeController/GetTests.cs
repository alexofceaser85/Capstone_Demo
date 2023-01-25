using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;
using Server.Dal;

namespace Tests.Server.Controllers.GradeController
{
    [TestFixture]
    public class GetTests
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
        public void GetSingleGrade()
        {
            global::Server.Controllers.GradesController controller = new();
            Grade grade = new Grade(null, "Alpha", "Math", 90);

            GradesDal.AddGrade(grade);
            Grade[] grades = controller.Get().ToArray();

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
