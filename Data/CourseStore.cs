using wt_lab5_5razor_liger.Models;

namespace wt_lab5_5razor_liger.Data;

public static class CourseStore
{
    public static List<Course> Courses { get; } = new()
    {
        new Course
        {
            Id = 1,
            Title = "Web-Технологии",
            Semester = 1,
            Hours = 120,
            TeacherId = 1
        },
        new Course
        {
            Id = 2,
            Title = "Гибкие методологии разработки ПО",
            Semester = 1,
            Hours = 100,
            TeacherId = 1
        },
        new Course
        {
            Id = 3,
            Title = "Управление информационной безопасностью",
            Semester = 1,
            Hours = 90,
            TeacherId = 2
        },
        new Course
        {
            Id = 4,
            Title = "Анализ хозяйственной деятельности",
            Semester = 1,
            Hours = 60,
            TeacherId = 4
        },
        new Course
        {
            Id = 5,
            Title = "Физическая культура",
            Semester = 4,
            Hours = 80,
            TeacherId = 3
        }
    };
}