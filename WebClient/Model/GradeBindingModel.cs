using Microsoft.AspNetCore.Mvc;

namespace WebClient.Model
{
    public class GradeBindingModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Subject { get; set; }
        [BindProperty]
        public string GradeAmount { get; set; }
    }
}
