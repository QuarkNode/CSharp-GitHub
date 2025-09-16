namespace _01.MetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float kilometer = meters / 1000f;
            Console.WriteLine($"{kilometer:f2}");
        }
    }
}
