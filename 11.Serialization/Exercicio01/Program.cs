using Exercicio01;
using System.Text.Json;
using System.Xml.Serialization;

IEnumerable<Student> students =
[
    new(1, "Alice", "alice@email.com", 20),
    new(2, "Bob", "bob@email.com", 22),
    new(3, "Charlie", "charlie@email.com", 21)
];

string jsonFilePath = @"c:\data\serialized\students.json";
string xmlFilePath = @"c:\data\serialized\students.xml";

if (!Directory.Exists(Path.GetDirectoryName(jsonFilePath)))
{
    Directory.CreateDirectory(Path.GetDirectoryName(jsonFilePath)!);
}

// Serialize to JSON
{
    using FileStream jsonFileStream = new(jsonFilePath, FileMode.Create, FileAccess.Write);
    JsonSerializer.Serialize(jsonFileStream, students);
}

Console.WriteLine("Students serialized to JSON successfully. Press any key to continue.");
Console.ReadKey();

// Serialize to XML
{
    using FileStream xmlFileStream = new(xmlFilePath, FileMode.Create, FileAccess.Write);
    XmlSerializer xmlSerializer = new(typeof(List<Student>));
    using StreamWriter xmlWriter = new(xmlFileStream);
    xmlSerializer.Serialize(xmlWriter, students.ToList());
}

Console.WriteLine("Students serialized to XML successfully. Press any key to continue.");
Console.ReadKey();

// Deserialize from JSON
IEnumerable<Student>? deserializedStudentsJson;
{
    using FileStream jsonFileStream2 = new(jsonFilePath, FileMode.Open, FileAccess.Read);
    deserializedStudentsJson = JsonSerializer.Deserialize<IEnumerable<Student>>(jsonFileStream2);
}
if (deserializedStudentsJson != null)
{
    Console.WriteLine("Students deserialized from JSON successfully.");
    foreach (var student in deserializedStudentsJson)
    {
        Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Email: {student.Email}, Age: {student.Age}");
    }
}
else
{
    Console.WriteLine("Deserialization from JSON failed.");
}

// Deserialize from XML
IEnumerable<Student>? deserializedStudentsXml;
{
    XmlSerializer xmlSerializer = new(typeof(List<Student>));
    using FileStream xmlFileStream2 = new(xmlFilePath, FileMode.Open, FileAccess.Read);
    deserializedStudentsXml = xmlSerializer.Deserialize(xmlFileStream2) as IEnumerable<Student>;
}
if (deserializedStudentsXml != null)
{
    Console.WriteLine("Students deserialized from XML successfully.");
    foreach (var student in deserializedStudentsXml)
    {
        Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Email: {student.Email}, Age: {student.Age}");
    }
}
else
{
    Console.WriteLine("Deserialization from XML failed.");
}