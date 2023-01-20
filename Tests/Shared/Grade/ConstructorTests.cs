using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;

namespace Tests.Shared.Grade
{
    [TestFixture]
    public class ConstructorTests
    {
        [TestCase(100, "Thomas", "Math", 92.5)]
        [TestCase(null, "Thomas", "Math", 92.5)]
        [TestCase(100, null, "Math", 92.5)]
        [TestCase(100, "Thomas", null, 92.5)]
        [TestCase(100, "Thomas", "Math", -1)]
        public void CreateValidGrade(int? id, string name, string subject, double gradeAmount)
        {
            CapstoneDemo.Shared.Grade grade = new CapstoneDemo.Shared.Grade(id, name, subject, gradeAmount);
            Assert.Multiple(() =>
            {
                Assert.That(grade.Id, Is.EqualTo(id));
                Assert.That(grade.Name, Is.EqualTo(name));
                Assert.That(grade.Subject, Is.EqualTo(subject));
                Assert.That(grade.GradeAmount, Is.EqualTo(gradeAmount));
            });
        }
    }
}
