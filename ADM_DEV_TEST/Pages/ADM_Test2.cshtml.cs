using ADM_DEV_TEST.DL.Services;
using ADM_DEV_TEST.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ADM_DEV_TEST.Pages
{
    public class ADM_Test2Model : PageModel
    {
        private readonly ITest2Service _service;

        public ADM_Test2Model(ITest2Service service)
        {
            _service = service;
            ModelTest2 = new();
        }

        [BindProperty]
        public Test2Model ModelTest2 { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            ModelTest2.Num = null;
            ModelTest2.Result = _service.MaxValue(ModelTest2.NumList.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            return Page();
        }
    }
}
