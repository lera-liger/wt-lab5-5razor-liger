using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_liger.Data;
using wt_lab5_5razor_liger.Models;

namespace wt_lab5_5razor_liger.Pages.Teachers;

public class DetailsModel : PageModel
{
    public Teacher? Teacher { get; set; }

    public IActionResult OnGet(int id)
    {
        Teacher = TeacherStore.Teachers.FirstOrDefault(t => t.Id == id);

        if (Teacher == null)
        {
            return NotFound();
        }

        return Page();
    }

    public IActionResult OnPostDelete(int id)
    {
        var teacher = TeacherStore.Teachers.FirstOrDefault(t => t.Id == id);

        if (teacher != null)
        {
            TeacherStore.Teachers.Remove(teacher);
        }

        return RedirectToPage("./Index");
    }
}