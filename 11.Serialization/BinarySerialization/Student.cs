namespace BinarySerialization;
[Serializable]
internal class Student(int id, string name, int age)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;

    [NonSerialized]
    public int Age = age;
}
