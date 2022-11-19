using PlatformGameLevelGeneratorCore;

namespace PlatformGameLevelGeneratorPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var length = 10;

            var level = new PlatformGameLevel(length);

            Console.WriteLine($"Length of the level: {level.Length}");
        }
    }
}