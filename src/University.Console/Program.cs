using System;
using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {

        // Используем конструктор - создаем преподавателя
        var teacher = new Teacher("T001", "Иванов Иван Иванович", "IT");

        // Теперь можно работать с данными:
        Console.WriteLine("TEACHER:");
        Console.WriteLine(teacher.Id);    // Выведет "T001"
        Console.WriteLine(teacher.Name);  // Выведет "Иванов Иван Иванович"
        Console.WriteLine(teacher.Specialization);

        // Можно изменить имя:
        teacher.Name = "Петров Петр Петрович";
        Console.WriteLine($"Новое имя: {teacher.Name}");

        // студент
        Console.WriteLine("STUDENT");
        var student = new Student("S001", "John Doe", 1, "IT");
        Console.WriteLine(student.Id);

        // онлайн-курс
        Console.WriteLine("ONLINE COURSE");
        var onlineCourse = new OnlineCourse("C001", "IT", "Zoom", "https:zoom.com");
        Console.WriteLine(onlineCourse.Title);      

        // офлайн-курс
        Console.WriteLine("OFFLINE COURSE");
        var offlineCourse = new OfflineCourse("C001", "IT", 4342, "8:00 - 9:00");
        Console.WriteLine(offlineCourse.Schedule);

        // CourseService
        Console.WriteLine("");
        Console.WriteLine("COURSE SERVICE");
        var courseService = new CourseService();
        courseService.AddCourse(onlineCourse);
        courseService.AssignTeacher(onlineCourse.Id, teacher);
        var teacherCourses = courseService.ViewTeacherCourses(teacher.Id);
        foreach (var course in teacherCourses)
        {
            Console.WriteLine($"course.Title");
            if (course is OnlineCourse online)
            {                
                Console.WriteLine($"у препода с ID {teacher.Id} онлайн курс {online.Title} на платформе {online.Platform}");
            }
        }

    }
}