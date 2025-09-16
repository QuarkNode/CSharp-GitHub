namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            switch (typeGroup)
            {
                case "Students":
                    {
                        if (day == "Friday")
                        {
                            price = 8.45;
                        }
                        else if (day == "Saturday")
                        {
                            price = 9.80;
                        }
                        else if (day == "Sunday")
                        {
                            price = 10.46;
                        }
                     break;
                    }

                case "Business":
                    {
                        if (day == "Friday")
                        {
                            price = 10.90;
                        }
                        else if (day == "Saturday")
                        {
                            price = 15.60;
                        }
                        else if (day == "Sunday")
                        {
                            price = 16;
                        }
                        break;
                    }
                case "Regular":
                    {
                        if (day == "Friday")
                        {
                            price = 15;
                        }
                        else if (day == "Saturday")
                        {
                            price = 20;
                        }
                        else if (day == "Sunday")
                        {
                            price = 22.50;
                        }
                        break;
                    }
            }

            //Calculations

            double sumDiscount = 0;
            double sumRaw = peopleCount * price;
            if (peopleCount >= 30 && typeGroup == "Students")
            {
                sumDiscount = sumRaw - sumRaw * 0.15;
                sumRaw = sumDiscount;
            }
            else if (peopleCount >= 100 && typeGroup == "Business")
            {
                sumDiscount = sumRaw - (10 * price);
                sumRaw = sumDiscount;
            }
            else if (peopleCount >= 10 && peopleCount <= 20 && typeGroup == "Regular")
            {
                sumDiscount = sumRaw - sumRaw * 0.05;
                sumRaw = sumDiscount;
            }

            Console.WriteLine($"Total price: {sumRaw:f2}");

        }
    }
}
