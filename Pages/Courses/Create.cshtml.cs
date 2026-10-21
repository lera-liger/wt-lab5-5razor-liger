using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using wt_lab5_5razor_liger.Data;
using wt_lab5_5razor_liger.Models;

namespace wt_lab5_5razor_liger.Pages.Courses;

public class CreateModel : PageModel
{
    [BindProperty]
    public Course Course { get; set; } = new();

    // Список преподавателей для выпадающего списка
    public SelectList TeachersList { get; set; } = default!;

    public void OnGet()
    {
        // Заполняем выпадающий список преподавателями
        TeachersList = new SelectList(TeacherStore.Teachers, nameof(Teacher.Id), nameof(Teacher.FullName));
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            // Если ошибка — снова заполняем список, иначе выпадающий список будет пуст
            TeachersList = new SelectList(TeacherStore.Teachers, nameof(Teacher.Id), nameof(Teacher.FullName));
            return Page();
        }

        Course.Id = CourseStore.Courses.Any()
            ? CourseStore.Courses.Max(c => c.Id) + 1
            : 1;

        CourseStore.Courses.Add(Course);

        return RedirectToPage("./Index");
    }
}