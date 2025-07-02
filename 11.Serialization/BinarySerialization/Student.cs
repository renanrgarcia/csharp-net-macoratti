namespace BinarySerialization;
[Serializable]
internal class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    [NonSerialized]
    public int Age;

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}
