namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameLog = Console.ReadLine();

            char[] charArray = nameLog.ToCharArray();
            Array.Reverse(charArray);
            string reversedName = new string(charArray);

            //int counter = 0;
            for (int i = 1; i <= 4; i++)
            {
                string nameCurrent = Console.ReadLine();

                if (nameCurrent == reversedName)
                {
                    Console.WriteLine($"User {nameLog} logged in.");
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine($"User {nameLog} blocked!");
                    break;
                }
                else if (nameCurrent != reversedName)
                {

                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

        }
    }
}
