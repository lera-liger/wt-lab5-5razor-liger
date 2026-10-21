using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_liger.Data;
using wt_lab5_5razor_liger.Models;

namespace wt_lab5_5razor_liger.Pages.Students;

public class CreateModel : PageModel
{
    // [BindProperty] связывает поля формы с этим свойством
    [BindProperty]
    public Student Student { get; set; } = new();

    // GET: /Students/Create
    public void OnGet()
    {
        // Ничего не делаем — просто показываем пустую форму
    }

    // POST: /Students/Create
    public IActionResult OnPost()
    {
        // Если валидация не прошла — возвращаем форму с ошибками
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Генерируем новый ID
        Student.Id = StudentStore.Students.Any()
            ? StudentStore.Students.Max(s => s.Id) + 1
            : 1;

        // Добавляем в общее хранилище
        StudentStore.Students.Add(Student);

        // Перенаправляем на список
        return RedirectToPage("./Index");
    }
}