using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_liger.Data;
using wt_lab5_5razor_liger.Models;

namespace wt_lab5_5razor_liger.Pages.Students;

public class DetailsModel : PageModel
{
    public Student? Student { get; set; }

    public IActionResult OnGet(int id)
    {
        Student = StudentStore.Students.FirstOrDefault(s => s.Id == id);

        if (Student == null)
        {
            return NotFound();
        }

        return Page();
    }

    // Обработчик удаления со страницы Details
    public IActionResult OnPostDelete(int id)
    {
        var student = StudentStore.Students.FirstOrDefault(s => s.Id == id);

        if (student != null)
        {
            StudentStore.Students.Remove(student);
        }

        return RedirectToPage("./Index");
    }
}