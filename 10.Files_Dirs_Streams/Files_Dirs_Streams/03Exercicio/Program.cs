string filePath = @"C:/data/Exercise03.txt";

FileInfo fileInfo = new(filePath);

if (!fileInfo.Exists)
{
    fileInfo.Create().Close();
}

Console.Write("\nWrite some text to the file: ");
string? text = Console.ReadLine();

if (text == null)
{
    Console.WriteLine("No text provided. Exiting.");
    return;
}

using (StreamWriter writer = new(fileInfo.FullName, true))
{
    writer.WriteLine(text);
}

Console.WriteLine($"Reading the text from {fileInfo.FullName}:");

using StreamReader reader = new(fileInfo.FullName);
while (!reader.EndOfStream)
{
    string line = reader.ReadLine() ?? string.Empty;
    Console.WriteLine(line);
}
