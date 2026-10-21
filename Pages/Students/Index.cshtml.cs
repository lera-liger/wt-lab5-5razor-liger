using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_liger.Data;
using wt_lab5_5razor_liger.Models;

namespace wt_lab5_5razor_liger.Pages.Students;

public class IndexModel : PageModel
{
    public List<Student> Students { get; set; } = new();

    public void OnGet()
    {
        Students = StudentStore.Students;
    }

    // Обработчик удаления из списка
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