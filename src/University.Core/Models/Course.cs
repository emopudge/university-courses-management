using System.Collections.Generic; // для List<Student>


public interface ICourse // интерфейс
{
    public string Id { get; set; }
    public string Title { get; set; }
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; }
}
