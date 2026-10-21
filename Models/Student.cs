using System.ComponentModel.DataAnnotations;

namespace wt_lab5_5razor_liger.Models;

public class Student
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Введите ФИО")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "ФИО от 3 до 100 символов")]
    [Display(Name = "ФИО")]
    public string FullName { get; set; } = string.Empty;

    [Range(1, 4, ErrorMessage = "Курс от 1 до 4")]
    [Display(Name = "Курс")]
    public int Course { get; set; }

    [Required(ErrorMessage = "Введите специальность")]
    [StringLength(100, MinimumLength = 2)]
    [Display(Name = "Специальность")]
    public string Specialty { get; set; } = string.Empty;

    [Range(0.0, 10.0, ErrorMessage = "Средний балл от 0 до 10")]
    [Display(Name = "Средний балл")]
    public double AverageGrade { get; set; }

    [Display(Name = "Зачислен")]
    public bool IsEnrolled { get; set; }
}