using ADM_DEV_TEST.DL.Services;
using ADM_DEV_TEST.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ADM_DEV_TEST.Pages
{
    public class ADM_Test3Model : PageModel
    {
        private readonly ITest3Service _service;

        public ADM_Test3Model(ITest3Service service)
        {
            _service = service;
            ModelTest3 = new();
        }

        [BindProperty]
        public Test3Model ModelTest3 { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            ModelTest3.Result = _service.NbRepeatWord(ModelTest3.Text,ModelTest3.Word);

            return Page();
        }
    }
}
