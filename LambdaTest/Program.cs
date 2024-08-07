namespace LambdaTest
{
    internal class Program
    {
        static Random random => new Random();

        static double GetRandomDouble(int max) => max*random.NextDouble();

        static void PrintValue(double d) => Console.WriteLine($"Wartość wynosi {d:N2}.");

        static void Main(string[] args)
        {
            var value = Program.GetRandomDouble(100);
            string sformatowanaLiczba = string.Format("{0:N2}", value);
            Console.WriteLine($"{value:F2}");
            Console.WriteLine(sformatowanaLiczba);
        }
    }
}
