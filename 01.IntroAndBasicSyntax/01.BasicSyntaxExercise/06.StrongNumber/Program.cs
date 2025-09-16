namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // factorials -> 42:  4x3x2x1 + 2x1 = XYZ

            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            int totalSum = 0;

            for (int i = 0; i < numberString.Length; i++)
            {
                int digit = int.Parse(numberString[i].ToString());
                int factorial = 1;
                //int factorialSum = 0;

                for (int j = 1; j <= digit; j++)
                {
                    factorial *= j;
                    //factorialSum += factorial;
                }

                totalSum += factorial;
            }

            if (totalSum == number)
            {
                Console.WriteLine("yes");
            }
            else if (totalSum != number)
            {
                Console.WriteLine ("no");
            }


        }
    }
}
