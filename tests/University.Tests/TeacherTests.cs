using System;
using Xunit;

namespace University.Tests
{

    public class TeacherTests
    {
        // тест для нормальных данных
        [Fact] // атрибут тестирования
        public void Constructor_WithValidData_CreatesTeacher()
        {
            var teacher = new Teacher("T002", "Severus Snape", "Potions");

            Assert.Equal("T002", teacher.Id);
            Assert.Equal("Severus Snape", teacher.Name);
            Assert.Equal("Potions", teacher.Specialization);
        }

        // тест для пустых и пробельных значений
        [Fact]
        public void Constructor_WithNull_CreatesTeacher()
        {
            var teacher = new Teacher(null, "", " ");

            Assert.Equal(null, teacher.Id);
            Assert.Equal("", teacher.Name);
            Assert.Equal(" ", teacher.Specialization);
        }

        // свойства можно менять
        [Fact]
        public void Properties_CanBeModified()
        {
            // arrange
            var teacher = new Teacher("T003", "John Keating", "English Literature");

            // act
            teacher.Specialization = "Biology";

            // assert
            Assert.Equal("T003", teacher.Id);
            Assert.Equal("John Keating", teacher.Name);
            Assert.Equal("Biology", teacher.Specialization);
        }
    }
}