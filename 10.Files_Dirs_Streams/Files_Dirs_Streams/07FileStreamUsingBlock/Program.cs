string filePath = @"C:/data/Poetry.txt";
try
{
    //using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
    //{
    //    using (StreamReader streamReader = new StreamReader(fileStream))
    //    {
    //        string? line;
    //        while ((line = streamReader.ReadLine()) != null)
    //        {
    //            Console.WriteLine(line);
    //        }
    //    }
    //}

    // After C# 8.0, you can use the using declaration
    using StreamReader streamReader = File.OpenText(filePath); // new StreamReader(fileStream);
    string? line;
    while ((line = streamReader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}
catch (IOException ex)
{
    Console.WriteLine($"An I/O error occurred: {ex.Message}");
}
catch (Exception)
{
    throw;
}

Console.ReadKey();
