namespace _04.CenturiesToMinute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCentury = int.Parse(Console.ReadLine());

            // 1 -> 100 years

            int years = numberCentury * 100;
            int days = (int) (years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{numberCentury} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
