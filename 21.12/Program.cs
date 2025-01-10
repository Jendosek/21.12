namespace _21._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -5, 10, 0, 23, -8, 7, 19, -15, 3 };
            
            Func<int[], int> countPositiveNumbers = arr => arr.Count(num => num > 0);
            
            int count = countPositiveNumbers(numbers);

            Console.WriteLine($"Кількість позитивних чисел: {count}");
        }
    }
}