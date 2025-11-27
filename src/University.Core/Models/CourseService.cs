using System.Collections.Generic; // для List<Course>
using System.Linq; // для FirstOrDefault()

public class CourseService
{
    // приватное хранилище всех курсов - _courses
    private List<Course> _courses = new List<Course>();

    // добавление курсов. void ничего не возвращает
    public void AddCourse(Course course)
    {
        _courses.Add(course);
    }

    // удаление курса по его ID
    public void RemoveCourse(string courseId)
    {
        var course = _courses.FirstOrDefault(c => c.Id == courseId);
        if (course == null)
        {
            throw new ArgumentException($"курс с id {courseId} не найден");
        }
        _courses.Remove(course);
    }

    // назначение преподавателя на курс по ID курса
    public void AssignTeacher(string courseId, Teacher teacher)
    {
        var course = _courses.FirstOrDefault(c => c.Id == courseId); // c for c in _courses...
        if (course == null)
        {
            throw new ArgumentException($"курс с id {courseId} не найден");
        }
        course.Teacher = teacher;
    }

    // записать студента
    public void EnrollStudent(string courseId, Student student)
    {
        var course = _courses.FirstOrDefault(c => c.Id == courseId);
        if (course == null)
        {
            throw new ArgumentException($"курс с id {courseId} не найден");
        }
        course.Students.Add(student);
    }

    // посмотреть курсы преподавателя. вернется generic список с курсами
    public List<Course> ViewTeacherCourses(string teacherId)
    {        
        return _courses
        .Where(c => c.Teacher.Id == teacherId)
        .ToList();
    }
}