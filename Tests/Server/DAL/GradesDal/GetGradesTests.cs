using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;

namespace Tests.Server.DAL.GradesDal
{
    [TestFixture]
    public class GetGradesTests
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
            Grade[] grades = global::Server.Dal.GradesDal.GetGrades().ToArray();
            Assert.That(grades.Length, Is.EqualTo(0));
        }
    }
}
