namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char text = char.Parse(Console.ReadLine());

            if (text >= 'A' && text <= 'Z')
            {
                Console.WriteLine("upper-case");
            }
            else if (text >= 'a' && text <= 'z')
            {
                Console.WriteLine("lower-case");
            }

        }
    }
}
