namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int number = 1; number <= count; number++)

            {
                int digit = number;
                int sum = 0;

                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }
                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                if (isSpecial)
                {
                    Console.WriteLine($"{number} -> True");
                }
                else
                {
                    Console.WriteLine($"{number} -> False");
                }

            }
        }
    }
}
