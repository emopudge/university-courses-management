using System.Collections.Generic; // Без этого не будет работать List<Student>. 
// generic позволяет попасть в список только объектам класса студент


public abstract class Course // абстрактный, чтобы нельзя было создать просто курс,
// не указывая, онлайн он или оффлайн. чертеж класса, можно только наследовать
{
    public string Id { get; set; }
    public string Title { get; set; }
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();
    // new List<Student>() - сразу создаем пустой список студентов при создании курса

    // конструктор
    public Course(string id, string title)
    {
        Id = id;
        Title = title;
        // teacher, students пока пустые и заполняются позже
    }
}
