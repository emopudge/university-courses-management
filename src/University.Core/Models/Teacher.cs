using System;


public class Teacher
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }

    // конструктор         
    public Teacher(string id, string name, string specialization)
    {        
        Id = id;
        Name = name;
        Specialization = specialization;
    }
}
