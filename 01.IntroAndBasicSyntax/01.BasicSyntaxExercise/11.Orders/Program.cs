namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //N Order = ((daysInMonth * capsulesCount) * pricePerCapsule)


            int orderCount = int.Parse(Console.ReadLine());

            double sumOrder = 0;
            double sumOrderAll = 0;

            double pricePerCapsule = 0;
            int daysInMonth = 0 ;
            int capsulesCount = 0;

            for (int start = 1; start <= orderCount; start++)
            {
                
                    pricePerCapsule = double.Parse(Console.ReadLine());
                    daysInMonth = int.Parse(Console.ReadLine());
                    capsulesCount = int.Parse(Console.ReadLine());

                    sumOrder = pricePerCapsule * (daysInMonth * capsulesCount);
                    sumOrderAll += sumOrder;

                    Console.WriteLine($"The price for the coffee is: ${sumOrder:f2}");

                    sumOrder = 0;
                
            }
                Console.WriteLine($"Total: ${sumOrderAll:f2}");

        }
    }
}
