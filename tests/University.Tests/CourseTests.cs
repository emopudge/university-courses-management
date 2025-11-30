using System;
using System.Collections.Generic;
using Xunit;

namespace University.Tests
{
    // онлайн-курс
    public class OnlineCourseTests
    {
        // тест для нормальных данных
        [Fact]
        public void Constructor_WithValidData_CreatesCourse()
        {
            var course = new OnlineCourse("C001", "IT", "Zoom", "https://www.zoom.com/");

            // проверяем свойства от Course
            Assert.Equal("C001", course.Id);
            Assert.Equal("IT", course.Title);
            Assert.Empty(course.Students);
            Assert.Null(course.Teacher);

            // проверяем свойства OnlineCourse
            Assert.Equal("Zoom", course.Platform);
            Assert.Equal("https://www.zoom.com/", course.Link);
        }

        // тест для добавления студентов
        [Fact]
        public void OnlineCourse_CanAddStudents()
        {
            var course = new OnlineCourse("C002", "C# OOP", "Backboost", "backboost.ru");
            var student1 = new Student("S001", "Regina George", 2, "IT");
            var student2 = new Student("S002", "Karen Smith", 3, "Marinist");

            course.Students.Add(student1);
            course.Students.Add(student2);

            Assert.Equal(2, course.Students.Count);
            Assert.Contains(student1, course.Students);
            Assert.Contains(student2, course.Students);
        }

        
    }



    // тесты для оффлайн-курсов
    public class OfflineCourseTests
    {
        // тест для назначения преподавателя
        [Theory]
        [InlineData("C001", "Mathematics", 3216, "8:00-9:30", "T001", "Leonard Euler",
        "Mathematics")]
        [InlineData("C002", "Astronomy", 2134, "10:00-11:30", "T002", "Mikhail Lomonosov",
        "Astronomy")]
        public void OfflineCourse_WithVariousValidData_CanAddTeachers(
            string courseId, string courseTitle, int courseClassroom, string courseSchedule,
            string teacherId, string teacherName, string teacherSpecialization
        )
        {
            var course = new OfflineCourse(courseId, courseTitle, courseClassroom, courseSchedule);
            var teacher = new Teacher(teacherId, teacherName, teacherSpecialization);

            course.Teacher = teacher;

            Assert.Equal(course.Id, courseId);
            Assert.NotNull(course.Teacher);
            Assert.Equal(teacherId, course.Teacher.Id);
        }
    }
}

