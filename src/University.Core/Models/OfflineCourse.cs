using System;

public class OfflineCourse : ICourse
{
    // свойства интерфейса
    public string Id { get; set; }
    public string Title { get; set; }
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; }

    // свойства оффлайн-курса
    public int Classroom { get; set; } // номер аудитории
    public string Schedule { get; set; }

    // конструктор
    public OfflineCourse(string id, string title, int classroom, string schedule)
    {
        Id = id;
        Title = title;
        Classroom = classroom;
        Schedule = schedule;
        Students = new List<Student>();
        Teacher = null;
    }
}