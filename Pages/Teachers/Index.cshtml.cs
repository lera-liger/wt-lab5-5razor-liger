using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_liger.Data;
using wt_lab5_5razor_liger.Models;

namespace wt_lab5_5razor_liger.Pages.Teachers;

public class IndexModel : PageModel
{
    public List<Teacher> Teachers { get; set; } = new();

    public void OnGet()
    {
        Teachers = TeacherStore.Teachers;
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