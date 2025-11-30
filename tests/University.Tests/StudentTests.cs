using System;
using Xunit;

namespace University.Tests
{
    public class StudentTests
    {
        // тест для нормальных данных
        [Fact]
        public void Constructor_WithValidData_CreatesStudent()
        {
            var student = new Student("S002", "Harry Potter", 3, "IT");

            Assert.Equal("S002", student.Id);
            Assert.Equal("Harry Potter", student.Name);
            Assert.Equal(3, student.Year);
            Assert.Equal("IT", student.Specialization);
        }

        // тест с разными нормальными данными
        [Theory]
        [InlineData("S001", "Ron Weasley", 2, "Biochemistry")]
        [InlineData("S002", "Draco Malfoy", 6, "Potions")]
        [InlineData("S003", "Neville Longbottom", 1, "Herbology")]
        public void Constructor_WithVariousValidData_CreatesStudent(string id, string name, byte year, string specialization)
        {
            var student = new Student(id, name, year, specialization);

            Assert.Equal(id, student.Id);
            Assert.Equal(name, student.Name);
            Assert.Equal(year, student.Year);
            Assert.Equal(specialization, student.Specialization);
        }        

    }
}