using wt_lab5_5razor_liger.Models;

namespace wt_lab5_5razor_liger.Data;

public static class TeacherStore
{
    public static List<Teacher> Teachers { get; } = new()
    {
        new Teacher
        {
            Id = 1,
            FullName = "Шаститко Дмитрий Витальевич",
            Department = "Кафедра управление информационными ресурсами",
            ExperienceYears = 15,
            HasDegree = false
        },
        new Teacher
        {
            Id = 2,
            FullName = "Чаган Никита Федорович",
            Department = "Кафедра управление информационными ресурсами",
            ExperienceYears = 5,
            HasDegree = false
        },
        new Teacher
        {
            Id = 3,
            FullName = "Жамойдин Денис Вячеславович",
            Department = "Кафедра физической культуры",
            ExperienceYears = 10,
            HasDegree = true
        },
        new Teacher
        {
            Id = 4,
            FullName = "Короткевич Лариса Михайловна",
            Department = "Кафедра экономического развития и менеджмента",
            ExperienceYears = 20,
            HasDegree = true
        }
    };
}