using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;
using Server.Dal;

namespace Tests.BlazorWinForms.ViewModel.GradesViewModel
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
            global::BlazorWinForms.ViewModel.GradesViewModel viewModel = new();
            using var enumerator = viewModel.GetEnumerator();

            Assert.That(enumerator.Current, Is.EqualTo(null));
        }

        [Test]
        public void GetEmptyGenericEnumerator()
        {
            global::BlazorWinForms.ViewModel.GradesViewModel viewModel = new();
            IEnumerable enumerator = viewModel;
            Assert.That(enumerator.GetEnumerator(), !Is.EqualTo(null));
        }
    }
}
