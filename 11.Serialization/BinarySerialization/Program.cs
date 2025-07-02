using BinarySerialization;
using System.Runtime.Serialization.Formatters.Binary;

Student student = new Student(1, "John Doe", 20);

var pathFile = @"C:\\temp\\student.bin";

using (FileStream fileStream = new FileStream(pathFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
#pragma warning disable SYSLIB0011 // BinaryFormatter is obsolete
    BinaryFormatter formatter = new BinaryFormatter();
    formatter.Serialize(fileStream, student); // Error: SYSLIB0011: BinaryFormatter is obsolete
#pragma warning disable SYSLIB0011

    Console.WriteLine("Type anything to Deserialize the object...");
    Console.ReadKey();
    fileStream.Seek(0, SeekOrigin.Begin);
    var deserializedStudent = (Student)formatter.Deserialize(fileStream);
    Console.WriteLine(deserializedStudent.Name);
}

Console.WriteLine("Student object serialized successfully.");