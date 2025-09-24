namespace _11.Сновбаллс
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte snowballNum = sbyte.Parse(Console.ReadLine());

            double highestValue = double.MinValue;

            ushort snowballSnow = 0;
            ushort snowballSnowHighest = 0;

            ushort snowballTime = 0;
            ushort snowballTimeHighest = 0;

            sbyte snowballQuality = 0;
            sbyte snowballQualityHighest = 0;

            double snowballValue = 0;

            for (int i = 1; i <= snowballNum; i++)
            {
                snowballSnow = ushort.Parse(Console.ReadLine());
                snowballTime = ushort.Parse(Console.ReadLine());
                snowballQuality = sbyte.Parse(Console.ReadLine());
                snowballValue = Math.Pow((double)snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > highestValue)
                {
                    highestValue = snowballValue;

                    snowballSnowHighest = snowballSnow;
                    snowballTimeHighest = snowballTime;
                    snowballQualityHighest = snowballQuality;
                }
            }

            Console.WriteLine($"{snowballSnowHighest} : {snowballTimeHighest} = {highestValue} ({snowballQualityHighest})");

        }
    }
}
