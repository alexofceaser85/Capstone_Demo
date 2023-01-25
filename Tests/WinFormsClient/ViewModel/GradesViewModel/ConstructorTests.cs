using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.WinFormsClient.ViewModel.GradesViewModel
{
    [TestFixture]
    public class ConstructorTests
    {
        [Test]
        public void CreateValidViewModel()
        {
            global::WinFormsClient.ViewModel.GradesViewModel viewModel = new();
            Assert.That(viewModel, !Is.EqualTo(null));
        }
    }
}
