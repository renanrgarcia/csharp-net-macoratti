using System.Diagnostics;

namespace _05TaskCancel
{

    internal class Program
    {
        static async Task Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                ////Task Cancellation Example
                //cancellationTokenSource = new CancellationTokenSource();
                //cancellationTokenSource.Cancel();

                //var result = await LongTermOperationCancellable(100, cancellationTokenSource.Token);

                //Console.WriteLine(result);

                ////Automatic cancellation example
                //Console.WriteLine("Automatic cancellation after 1.5 seconds");
                //await TimeoutCancellation(1500);

                //Manual cancellation example
                await ManualCancellation();
            }
            catch (Exception)
            {
                Console.WriteLine($"Task cancelled: expired timeout after {stopwatch.Elapsed}. \n");
            }
            Console.ReadKey();
        }

        private static async Task ManualCancellation()
        {
            using (var cancellationTokenSource = new CancellationTokenSource())
            {
                var keyboardTask = Task.Run(() =>
                {
                    Console.WriteLine("Press any key to cancel the operation...");
                    Console.ReadKey();
                    cancellationTokenSource.Cancel();
                });
                try
                {
                    var result = await LongTermOperationCancellable(500, cancellationTokenSource.Token);
                    Console.WriteLine($"Result: {result}");
                }
                catch (TaskCanceledException)
                {
                    throw;
                }
                await keyboardTask;
            }
        }

        private static async Task TimeoutCancellation(int time)
        {
            using (var cancellationTokenSource = new CancellationTokenSource())
            {
                cancellationTokenSource.CancelAfter(time);
                try
                {
                    var result = await LongTermOperationCancellable(100, cancellationTokenSource.Token);

                    Console.WriteLine($"Result: {result}");
                }
                catch (TaskCanceledException)
                {
                    throw;
                }
            }
        }

        private static Task<int> LongTermOperationCancellable(int value, CancellationToken cancellationToken = default)
        {
            Console.WriteLine("Operation started with value: {0}", value);

            Task<int> task = null!;

            task = Task.Run(() =>
            {
                int result = 0;
                for (int i = 0; i < value; i++)
                {
                    if (cancellationToken.IsCancellationRequested)
                        throw new TaskCanceledException(task);

                    Thread.Sleep(500);
                    result += value;
                }
                return result;
            });
            return task;
        }

        private static Task<int> LongTermOperation(int value)
        {
            Console.WriteLine("Operation started with value: {0}", value);
            return Task.Run(() =>
            {
                int result = 0;

                for (int i = 0; i < value; i++)
                {
                    // Simulate some work
                    Thread.Sleep(50);
                    result += value;
                }

                return result;
            });
        }
    }
}
