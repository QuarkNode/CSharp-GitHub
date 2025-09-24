namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                char firstChar = (char)('a' + i);

                //Console.Write(thirdChar);

                for (int j = 0; j < count; j++)
                {
                    char secondChar = (char)('a' + j);

                    //Console.Write(secondChar);

                    for (int k = 0; k < count; k++)
                    {
                        char thirdChar = (char)('a' + k);

                        Console.Write($"{firstChar}{secondChar}{thirdChar}" );
                        Console.WriteLine(string.Empty);
                    }
                }

            }
        }
    }
}
