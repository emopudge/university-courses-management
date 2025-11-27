using System;

public class OnlineCourse : Course // наследуемся от Course
{
    // онлайн-платформа (zoom etc.)
    public string Platform { get; set; }
    public string Link { get; set; }

    // конструктор, использующий атрибуты класса-родителя
    public OnlineCourse(string id, string title, string platform, string link) : base(id, title)
    {
        Platform = platform;
        Link = link;
    }
}
