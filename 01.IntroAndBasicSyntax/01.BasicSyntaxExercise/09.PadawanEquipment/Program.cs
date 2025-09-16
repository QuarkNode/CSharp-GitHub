namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // 10% more based on student count for Lightsaber, rounded up to next int.
          // Every 6th belt is FREE.

            double moneyAmount = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            //Calculations

            double percent = (double)studentCount * 10 / 100;

            double saberCount = studentCount + Math.Ceiling(percent);
            double sabers = saberPrice * saberCount;

            double robes = robePrice * studentCount;

            double beltDiscount = studentCount - studentCount / 6; // To calculate the number of every 6th belt based on student count, we use INT division which will lose its remainder. 
            double belts = beltPrice * beltDiscount;

            double sumAll = sabers + robes + belts;
            double diff = sumAll - moneyAmount;

            if (sumAll > moneyAmount)
            {
                Console.WriteLine($"John will need {diff:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {sumAll:f2}lv.");
            }
            //double sumMoney
        }
    }
}
