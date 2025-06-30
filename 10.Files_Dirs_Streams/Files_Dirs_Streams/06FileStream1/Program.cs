string filePath = @"C:/data/Poetry.txt";

// FileStream fileStream = null;
StreamReader streamReader = null!;

try
{
    // fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
    streamReader = File.OpenText(filePath); //new StreamReader(fileStream);

    string? line;
    while ((line = streamReader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}
catch (FileNotFoundException)
{
    Console.WriteLine("The file was not found.");
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("You do not have permission to access this file.");
}
catch (IOException ex)
{
    Console.WriteLine($"An I/O error occurred: {ex.Message}");
}
catch (Exception)
{
    throw;
}
finally
{
    streamReader?.Close();
    // fileStream?.Close();
}

Console.ReadKey();
