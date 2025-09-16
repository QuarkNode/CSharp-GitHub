namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceHeadphones = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            double damage = 0;

            //Calculations

            double trashedHeadphones = priceHeadphones * (lostGames / 2);
            double trashedMouse = priceMouse * (lostGames / 3);
            double trashedKeyboard = priceKeyboard * (lostGames / 6);
            double trashedDisplay = priceDisplay * (lostGames / 12);

            damage = trashedHeadphones + trashedMouse + trashedKeyboard + trashedDisplay;
            Console.WriteLine($"Rage expenses: {damage:f2} lv.");
        }
    }
}
