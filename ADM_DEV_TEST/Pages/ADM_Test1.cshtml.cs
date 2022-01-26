using ADM_DEV_TEST.DL.Services;
using ADM_DEV_TEST.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ADM_DEV_TEST.Pages
{
    public class ADM_Test1Model : PageModel
    {
        private readonly ITest1Service _service;

        public ADM_Test1Model(ITest1Service service)
        {
            _service = service;
            ModelTest1 = new();
        }        

        [BindProperty]
        public Test1Model ModelTest1 { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            ModelTest1.MultiResult = _service.MultiplyNumbers(ModelTest1.Num1, ModelTest1.Num2);

            return Page();
        }
    }
}
