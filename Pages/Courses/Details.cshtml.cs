using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_liger.Data;
using wt_lab5_5razor_liger.Models;

namespace wt_lab5_5razor_liger.Pages.Courses;

public class DetailsModel : PageModel
{
    public Course? Course { get; set; }
    public string TeacherName { get; set; } = string.Empty;

    public IActionResult OnGet(int id)
    {
        Course = CourseStore.Courses.FirstOrDefault(c => c.Id == id);

        if (Course == null)
        {
            return NotFound();
        }

        var teacher = TeacherStore.Teachers.FirstOrDefault(t => t.Id == Course.TeacherId);
        if (teacher != null)
        {
            TeacherName = teacher.FullName;
        }

        return Page();
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