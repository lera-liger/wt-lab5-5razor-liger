using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_liger.Data;
using wt_lab5_5razor_liger.Models;

namespace wt_lab5_5razor_liger.Pages.Courses;

public class IndexModel : PageModel
{
    public List<Course> Courses { get; set; } = new();

    public void OnGet()
    {
        Courses = CourseStore.Courses;
    }

    public IActionResult OnPostDelete(int id)
    {
        var course = CourseStore.Courses.FirstOrDefault(c => c.Id == id);

        if (course != null)
        {
            CourseStore.Courses.Remove(course);
        }

        return RedirectToPage("./Index");
    }
}