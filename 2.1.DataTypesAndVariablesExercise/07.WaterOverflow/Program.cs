namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waterTank = 255;
            int count = int.Parse(Console.ReadLine());
            int sumAdd = 0;

            for (int i = 1; i <= count; i++)
            {
                int waterIncome = int.Parse(Console.ReadLine());
                sumAdd += waterIncome;
                if (sumAdd > waterTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumAdd -= waterIncome;
                }
            }
            Console.WriteLine(sumAdd);

        }
    }
}
