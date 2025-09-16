namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Valid coins: 0.1, 0.2, 0.5, 1 and 5
            string command;
            double coins;
            double sumCoins = 0;
            while ((command = Console.ReadLine()) != "Start")
            {
                
                coins = double.Parse(command);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sumCoins += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                //command = Console.ReadLine();
            }

            //Calculations 

            //Menu:   Nuts - 2.0; Water - 0.7; Crisps - 1.5; Soda - 0.8; Coke - 1.0;

            string purchase;
            double priceNuts = 2;
            double priceWater = 0.7;
            double priceCrisps = 1.5;
            double priceSoda = 0.8;
            double priceCoke = 1;

            while ((purchase = Console.ReadLine()) != "End")
            {
                switch (purchase)
                {
                    case "Nuts":
                        {   if (sumCoins >= priceNuts)
                            {
                                sumCoins -= priceNuts;
                                Console.WriteLine($"Purchased nuts");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                                break;
                        }
                    case "Water":
                        {
                            if (sumCoins >= priceWater)
                            {
                                sumCoins -= priceWater;
                                Console.WriteLine($"Purchased water");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        }
                    case "Crisps":
                        {
                            if (sumCoins >= priceCrisps)
                            {
                                sumCoins -= priceCrisps;
                                Console.WriteLine($"Purchased crisps");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        }
                    case "Soda":
                        {
                            if (sumCoins >= priceSoda)
                            {
                                sumCoins -= priceSoda;
                                Console.WriteLine($"Purchased soda");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        }
                    case "Coke":
                        {
                            if (sumCoins >= priceCoke)
                            {
                                sumCoins -= priceCoke;
                                Console.WriteLine($"Purchased coke");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid product");
                            break;
                        }

                }
            }

            Console.WriteLine($"Change: {sumCoins:f2}");


        }
    }
}
