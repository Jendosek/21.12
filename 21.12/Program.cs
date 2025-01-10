namespace _21._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, (int R, int G, int B)> getRainbowColor = color =>
            {
                return color.ToLower() switch
                {
                    "червоний" => (255, 0, 0),
                    "оранжевий" => (255, 165, 0),
                    "жовтий" => (255, 255, 0),
                    "зелений" => (0, 255, 0),
                    "блакитний" => (0, 127, 255),
                    "синій" => (0, 0, 255),
                    "фіолетовий" => (139, 0, 255),
                    _ => (-1, -1, -1) // Значення для невідомого кольору
                };
            };

            Console.WriteLine("Введіть колір веселки:");
            string colorInput = Console.ReadLine();

            var (R, G, B) = getRainbowColor(colorInput);
            if (R == -1 && G == -1 && B == -1)
            {
                Console.WriteLine("Невідомий колір.");
            }
            else
            {
                Console.WriteLine($"RGB для кольору \"{colorInput}\": ({R}, {G}, {B})");
            }
        }
    }
}