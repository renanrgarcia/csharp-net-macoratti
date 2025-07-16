using System.Text.Json.Serialization;

namespace JSONSerialization;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    [JsonIgnore]
    public int Age { get; set; }

    public Student() { }

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}
