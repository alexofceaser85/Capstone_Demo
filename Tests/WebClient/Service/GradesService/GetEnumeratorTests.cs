using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;
using Server.Dal;

namespace Tests.WebClient.Services.GradeService
{
    [TestFixture]
    public class GetEnumeratorTests
    {
        [SetUp]
        public void SetUp()
        {
            GradesDal.RemoveGrades();
        }

        [TearDown]
        public void TearDown()
        {
            GradesDal.RemoveGrades();
        }

        [Test]
        public void GetEmptyEnumerator()
        {
            global::WebClient.Service.GradesService service = new();
            using var enumerator = service.GetEnumerator();

            Assert.That(enumerator.Current, Is.EqualTo(null));
        }

        [Test]
        public void GetEmptyGenericEnumerator()
        {
            global::WebClient.Service.GradesService service = new();
            IEnumerable enumerator = service;

            Assert.That(enumerator.GetEnumerator(), !Is.EqualTo(null));
        }
    }
}
