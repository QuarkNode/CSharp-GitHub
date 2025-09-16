using System.Globalization;

namespace _04.CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                int sum = 0;
                int digit = i;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit /= 10;
                }
                bool isSpecialNumber = sum == 5 || sum == 7 || sum == 11;

                if (isSpecialNumber)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }

        }
    }
}
