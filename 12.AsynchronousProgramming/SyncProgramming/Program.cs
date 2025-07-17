Console.WriteLine("### Synchronous Programming Example ###");

int wait = 4000; // milliseconds or 4 seconds

Console.WriteLine("Type anything to start");
Console.ReadLine();

CallTask(wait);

Console.WriteLine("Time elapsed: {0} seconds", wait / 1000);
Console.WriteLine("End of synchronous programming example");

Console.ReadKey();

static void CallTask(int wait)
{
    Console.WriteLine("Starting task...");
    //Task.Delay(TimeSpan.FromSeconds(wait));
    Thread.Sleep(wait);
    Console.WriteLine("Task completed.");
}