using wt_lab5_5razor_liger.Models;

namespace wt_lab5_5razor_liger.Data;

public static class StudentStore
{
    public static List<Student> Students { get; } = new()
    {
        new Student
        {
            Id = 1,
            FullName = "Лигер Валерия Валерьевна",
            Course = 4,
            Specialty = "УИР",
            AverageGrade = 9.7,
            IsEnrolled = true
        },
        new Student
        {
            Id = 2,
            FullName = "Ясковец Александра Дмитривена",
            Course = 4,
            Specialty = "УИР",
            AverageGrade = 10,
            IsEnrolled = true
        },
        new Student
        {
            Id = 3,
            FullName = "Сидоров Пётр Алексеевич",
            Course = 3,
            Specialty ="ГУЭ",
            AverageGrade = 3.7,
            IsEnrolled = false
        },
        new Student
        {
            Id = 4,
            FullName = "Кузнецова Мария Дмитриевна",
            Course = 4,
            Specialty ="ГУЭ",
            AverageGrade = 4.9,
            IsEnrolled = true
        },
        new Student
        {
            Id = 5,
            FullName = "Смирнов Алексей Викторович",
            Course = 1,
            Specialty ="ГУП",
            AverageGrade = 3.9,
            IsEnrolled = true
        }
    };
}