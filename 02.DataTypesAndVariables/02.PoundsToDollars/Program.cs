namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            float britishPound = float.Parse(Console.ReadLine());
            float dollarUS = 1.31f;

            float covertion = britishPound * dollarUS;

            Console.WriteLine($"{covertion:f3}");
        }
    }
}
