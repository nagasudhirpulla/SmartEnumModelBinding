using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartEnumBinding.Entities;
using SmartEnumBinding.Enums;

namespace SmartEnumBinding.Pages.Users
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public AppUser Usr { get; set; }
        public IActionResult OnGet()
        {
            Usr = new()
            {
                UserName = "XYZ",
                Gender = GenderEnum.Female,
                UsrRole = RoleEnum.Employee
            };
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // you can set a break point here to watch the "Usr" binding values
            return Page();
        }
    }
}
