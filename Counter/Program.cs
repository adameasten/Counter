namespace Counter
{
    internal class Program
    {
        static async void Main(string[] args)
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