using ADM_DEV_TEST.DL.Services;
using ADM_DEV_TEST.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ADM_DEV_TEST.Pages
{
    public class ADM_Test4Model : PageModel
    {
        private readonly ITest4Service _service;

        public ADM_Test4Model(ITest4Service service)
        {
            _service = service;
            ModelTest4 = new();
        }

        [BindProperty]
        public Test4Model ModelTest4 { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            ModelTest4.Result = _service.TxtPalindrome(ModelTest4.Text);

            return Page();
        }
    }
}
