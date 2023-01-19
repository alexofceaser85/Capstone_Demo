using System.Collections;
using CapstoneDemo.Shared;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebClient.Model;
using WebClient.Service;

namespace WebClient.ViewModel
{
    public class GradesViewModel : PageModel, IEnumerable<Grade>
    {
        private GradesService gradesService;

        public GradesViewModel()
        {
            this.gradesService = new GradesService();
        }

        public void OnGet()
        {
            this.gradesService.OnGet();
        }

        public void OnPostSubmit(GradeBindingModel gradeModel)
        {
            this.gradesService.OnPostSubmit(gradeModel);
        }

        public IEnumerator<Grade> GetEnumerator()
        {
            return this.gradesService.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
