using System;

public class OfflineCourse : Course
{
    // номер аудитории
    public int Classroom { get; set; }
    public string Schedule { get; set; }

    // конструктор
    public OfflineCourse(string id, string title, int classroom, string schedule) : base(id, title)
    {
        Classroom = classroom;
        Schedule = schedule;
    }
}