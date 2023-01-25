using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;

namespace Tests.Server.Service.GradesService
{
    [TestFixture]
    public class RemoveGradesTests
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
        public void GetEmptyGradesTable()
        {
            global::Server.Service.GradesService service = new();
            global::Server.Dal.GradesDal.AddGrade(new Grade(null, "Alpha", "Math", 90));
            service.RemoveGrades();

            Grade[] grades = global::Server.Dal.GradesDal.GetGrades().ToArray();

            Assert.That(grades.Length, Is.EqualTo(0));
        }
    }
}
