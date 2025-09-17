namespace _11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double sum = (length * width * height) / 3.0;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {sum:f2}");
        }
    }
}
