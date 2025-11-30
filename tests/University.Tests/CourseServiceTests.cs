using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection;
using Microsoft.VisualBasic;
using Xunit;

namespace University.Tests
{
    public class CourseServiceTests
    {
        // тест добавления и удаления курса, проверенный через запись студента
        [Fact]
        public void CourseService_CanAddRemoveCourses()
        {
            var service = new CourseService();
            var course1 = new OnlineCourse("C001", "Kinology", "Zoom", "zoom.com");
            var course2 = new OfflineCourse("C002", "Baking", 2781, "18:00-19:30");

            service.AddCourse(course1);
            service.AddCourse(course2);
            service.RemoveCourse(course1.Id);

            // добавляем студента в существующий курс
            service.EnrollStudent("C002", new Student("S001", "John", 1, "Painter"));

            // добавляем в удаленный - ошибка
            var exception = Assert.Throws<ArgumentException>(() =>
            service.EnrollStudent("C001", new Student("S001", "John", 1, "CS")));
            Assert.Contains("не найден", exception.Message);
        }

        // тест просмотра курсов преподавателя, записи преподавателя на курс
        [Fact]
        public void CourseService_CanViewTeacherCourses()
        {
            var service = new CourseService();
            var teacher = new Teacher("T001", "Master Shifu", "Karate");

            var course1 = new OfflineCourse("C001", "Karate", 2178, "6:00-7:30");

            service.AddCourse(course1);
            service.AssignTeacher(course1.Id, teacher);

            var teacherCourses = service.ViewTeacherCourses(teacher.Id);

            Assert.Single(teacherCourses);
            Assert.Equal("C001", teacherCourses[0].Id);
        }

        // тест просмотра всех студентов на курсе
        public void CourseService_CanViewCourseStudents()
        {
            var service = new CourseService();
            var course = new OnlineCourse("C001", "Dota 2", "Discord", "discord.com");
            var student1 = new Student("S001", "Mellstroy", 1, "Streamer");
            var student2 = new Student("S002", "Lyudmurik", 8, "Trash blogger");

            service.AddCourse(course);
            service.EnrollStudent(course.Id, student1);
            service.EnrollStudent(course.Id, student2);

            var students = service.ViewCourseStudents(course.Id);

            Assert.Equal(3, students.Count);
            Assert.Contains(students, s => s.Id == "S001");
            Assert.Contains(students, s => s.Name == "Lyudmurik");
        }

    }
}