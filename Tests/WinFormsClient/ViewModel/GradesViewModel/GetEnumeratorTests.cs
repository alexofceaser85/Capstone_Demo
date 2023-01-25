using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapstoneDemo.Shared;

namespace Tests.WinFormsClient.ViewModel.GradesViewModel
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
            global::WinFormsClient.ViewModel.GradesViewModel viewModel = new();
            using var enumerator = viewModel.GetEnumerator();

            Assert.That(enumerator.Current, Is.EqualTo(null));
        }

        [Test]
        public void GetEmptyGenericEnumerator()
        {
            global::WinFormsClient.ViewModel.GradesViewModel viewModel = new();
            IEnumerable enumerator = viewModel;
            Assert.That(enumerator.GetEnumerator(), !Is.EqualTo(null));
        }
    }
}
