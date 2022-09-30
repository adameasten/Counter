namespace Counter
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var counter = 0;
            while (true)
            {
                Console.WriteLine($"Counting.. {counter}!");
                counter++;

                await Task.Delay(1000);
            }
        }
    }
}