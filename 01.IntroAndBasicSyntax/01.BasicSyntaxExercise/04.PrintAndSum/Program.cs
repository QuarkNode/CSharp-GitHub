namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Start = int.Parse(Console.ReadLine());
            int End = int.Parse(Console.ReadLine());
            int sumCounter = 0;

            for (int i = Start; i <= End; i++)
            {
                sumCounter += i;
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sumCounter}");
        }
    }
}
