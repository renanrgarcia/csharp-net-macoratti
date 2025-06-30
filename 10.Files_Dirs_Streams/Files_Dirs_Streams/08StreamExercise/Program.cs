string filePath = @"C:/data/Exercise.txt";

Console.Write("\nPath for the new file: ");
Console.Write(filePath);

while (true)
{
    Console.WriteLine("\nSelect an option:");
    Console.WriteLine("1. Create a file");
    Console.WriteLine("2. Write a file");
    Console.WriteLine("3. Read a file");
    Console.WriteLine("4. Find text on file");
    Console.WriteLine("0. Exit");

    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            CreateFile(filePath);
            break;
        case 2:
            WriteFile(filePath);
            break;
        case 3:
            ReadFile(filePath);
            break;
        case 4:
            FindText(filePath);
            break;
        case 0:
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

static void CreateFile(string filePath)
{
    try
    {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            Console.WriteLine($"\nFile {filePath} created successfully.");
        }
    }
    catch (IOException ex)
    {
        Console.WriteLine($"An I/O error occurred: {ex.Message}");
    }
    return;
}

static void WriteFile(string filePath)
{
    Console.Write("Enter text to write to the file: ");
    string? text = Console.ReadLine();

    try
    {
        using StreamWriter writer = new StreamWriter(filePath, append: true);
        writer.WriteLine(text);
        Console.WriteLine($"Text written successfully on {filePath}.");
    }
    catch (IOException ex)
    {
        Console.WriteLine($"An I/O error occurred: {ex.Message}");
    }
}

static void ReadFile(string filePath)
{
    if (!File.Exists(filePath))
    {
        Console.WriteLine($"File {filePath} does not exist. Please create the file first.");
        return;
    }
    try
    {
        using StreamReader reader = new(filePath);
        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
    catch (IOException ex)
    {
        Console.WriteLine($"An I/O error occurred: {ex.Message}");
    }
}

static void FindText(string filePath)
{
    Console.Write("Enter text to find in the file: ");
    string? searchText = Console.ReadLine();

    try
    {        
        using StreamReader reader = new(filePath);
        string? line;
        int numLine = 0;
        bool found = false;
        while ((line = reader.ReadLine()) != null)
        {
            if (line.Contains(searchText, StringComparison.CurrentCultureIgnoreCase))
            {
                numLine++;
                Console.WriteLine($"Found on line {numLine}: {line}");
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Text not found in the file.");
        }
    }
    catch (IOException ex)
    {
        Console.WriteLine($"An I/O error occurred: {ex.Message}");
    }
}