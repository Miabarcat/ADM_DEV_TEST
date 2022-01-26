using ADM_DEV_TEST.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ADM_DEV_TEST.Pages
{
    public class ADM_Test5Model : PageModel
    {
        public ADM_Test5Model()
        {
            ModelTest5 = new();
        }

        [BindProperty]
        public Test5Model ModelTest5 { get; set; }


        public void OnGet()
        {
        }
    }
}
