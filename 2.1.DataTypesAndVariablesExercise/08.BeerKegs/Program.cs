namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte count = byte.Parse(Console.ReadLine());
            decimal volumeHighest = decimal.MinValue;
            string nameModelBiggest = string.Empty;

            for (int i = 0; i < count; i++)
            {
                string nameModel = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                decimal volume = (decimal)Math.PI * (radius * radius) * height;
                if (volume > volumeHighest)
                {
                    volumeHighest = volume;
                    nameModelBiggest = nameModel;
                }
            }
            Console.WriteLine(nameModelBiggest);
        }
    }
}
