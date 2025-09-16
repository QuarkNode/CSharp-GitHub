namespace _07.ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            string result = firstname + delimiter + secondName;
            Console.WriteLine(result);
        }
    }
}
