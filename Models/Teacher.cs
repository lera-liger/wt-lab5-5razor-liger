using System.ComponentModel.DataAnnotations;

namespace wt_lab5_5razor_liger.Models;

public class Teacher
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Введите ФИО")]
    [StringLength(100, MinimumLength = 3)]
    [Display(Name = "ФИО")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Введите кафедру")]
    [StringLength(100)]
    [Display(Name = "Кафедра")]
    public string Department { get; set; } = string.Empty;

    [Range(0, 60, ErrorMessage = "Стаж от 0 до 60 лет")]
    [Display(Name = "Стаж (лет)")]
    public int ExperienceYears { get; set; }

    [Display(Name = "Учёная степень")]
    public bool HasDegree { get; set; }
}