namespace TechForum.NET6
{
    internal class WaitAsync
    {
        internal static async Task Run()
        {
            Task operationTask = DoSomethingLongAsync();

            try
            {
                await operationTask.WaitAsync(TimeSpan.FromSeconds(5));
            }
            catch (TimeoutException e)
            {
                Console.WriteLine(e.Message);
            }

            async Task DoSomethingLongAsync()
            {
                Console.WriteLine("DoSomethingLongAsync started.");
                await Task.Delay(TimeSpan.FromSeconds(1));
                Console.WriteLine("DoSomethingLongAsync ended.");
            }
        }
    }
}
