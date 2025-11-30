using System;

public class OnlineCourse : ICourse // наследуемся от интерфейса
{    
    // свойства интерфейса
    public string Id { get; set; }
    public string Title { get; set; }
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; }
    
    // свойства онлайн-курса

    public string Platform { get; set; } // онлайн-платформа (zoom etc.)
    public string Link { get; set; }

    // конструктор
    public OnlineCourse(string id, string title, string platform, string link)
    {
        Id = id;
        Title = title;
        Platform = platform;
        Link = link;
        Students = new List<Student>(); // пустой
        Teacher = null;
    }
}
