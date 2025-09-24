namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int yield = int.Parse(Console.ReadLine());
            int sumSpice = 0;
            int daysCount = 0;
            int minedSpice = 0;

            while (yield >= 100)
            {
                minedSpice += yield;
                minedSpice -= 26;
                yield -= 10;
                daysCount++;
            }

            minedSpice -= 26;
            if (minedSpice < 0)
            {
                minedSpice = 0;
            }

            Console.WriteLine(daysCount);
            Console.WriteLine(minedSpice);
        }
    }
}
