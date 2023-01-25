﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;

namespace Tests.Server.Service.GradesService
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
        public void GetSingleGrade()
        {
            global::Server.Service.GradesService service = new();
            Grade grade = new Grade(null, "Alpha", "Math", 90);

            service.AddGrade(grade);
            Grade[] grades = service.GetGrades().ToArray();

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
