using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_liger.Data;
using wt_lab5_5razor_liger.Models;

namespace wt_lab5_5razor_liger.Pages.Teachers;

public class CreateModel : PageModel
{
    [BindProperty]
    public Teacher Teacher { get; set; } = new();

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Teacher.Id = TeacherStore.Teachers.Any()
            ? TeacherStore.Teachers.Max(t => t.Id) + 1
            : 1;

        TeacherStore.Teachers.Add(Teacher);

        return RedirectToPage("./Index");
    }
}