using JSONSerialization;
using System.Text.Json;

Student student = new(1, "Alice", 20);

string filePath = @"c:\data\serialized\student.json";

if (!Directory.Exists(Path.GetDirectoryName(filePath)))
{
    Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);
}

// Serialize the object
using (FileStream fileStream = new(filePath, FileMode.Create, FileAccess.Write))
{
    JsonSerializer.Serialize(fileStream, student);
}

Console.WriteLine("Object serialized to JSON successfully. Press any key to deserialize.");
Console.ReadKey();

// Deserialize the object
Console.WriteLine("Deserializing the object...");

using FileStream fileStream2 = new(filePath, FileMode.Open, FileAccess.Read);
Student? deserializedStudent = JsonSerializer.Deserialize<Student>(fileStream2);
if (deserializedStudent != null)
{
    Console.WriteLine("Object deserialized from JSON successfully.");
    Console.WriteLine($"Id: {deserializedStudent.Id}, Name: {deserializedStudent.Name}");
}
else
{
    Console.WriteLine("Deserialization failed.");
}
