using System;


public class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public byte Year { get; set; }
    public string Specialization { get; set; }

    // конструктор
    public Student(string id, string name, byte year, string specialization)
    {
        Id = id;
        Name = name;
        Year = year;
        Specialization = specialization;
    }
}
