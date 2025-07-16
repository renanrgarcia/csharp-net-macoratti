using System.Xml.Serialization;
using XMLSerialization;

Student student1 = new(1, "Alice", 20);

string filePath = @"c:\data\serialized\student.xml";

if (!Directory.Exists(Path.GetDirectoryName(filePath)))
{
    Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);
}

// Serialize the object
XmlSerializer serializer = new XmlSerializer(typeof(Student));

using (StreamWriter writer = new StreamWriter(filePath))
{
    serializer.Serialize(writer, student1);
}

Console.WriteLine("Object serialized to XML successfully. Press any key to deserialize.");
Console.ReadKey();

// Deserialize the object
using (StreamReader reader = new StreamReader(filePath))
{
    Student? student2 = (Student?)serializer.Deserialize(reader);
    if (student2 != null)
    {
        Console.WriteLine("Object deserialized from XML successfully.");
        Console.WriteLine($"Id: {student2.Id}, Name: {student2.Name}, Age: {student2.Age}");
    }
    else
    {
        Console.WriteLine("Deserialization failed.");
    }
}

Console.ReadKey();