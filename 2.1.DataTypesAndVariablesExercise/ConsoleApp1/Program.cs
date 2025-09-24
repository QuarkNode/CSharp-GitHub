namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            byte Y = byte.Parse(Console.ReadLine());

            int pokedCounter = 0;
            double percent = N * 0.50d;

            // Untill N < M

            while (N >= M)
            {
                N -= M;
                pokedCounter++;
                if (percent == N && Y != 0)
                {
                        N /= Y;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(pokedCounter);

        }
    }
}
