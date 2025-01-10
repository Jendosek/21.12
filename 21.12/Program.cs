namespace _21._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -5, 10, 0, -8, -5, 7, -15, 3, -8 };

            Func<int[], int[]> getUniqueNegativeNumbers = arr => arr.Where(num => num < 0).Distinct().ToArray();

            int[] uniqueNegativeNumbers = getUniqueNegativeNumbers(numbers);

            Console.WriteLine("Унікальні негативні числа:");
            Console.WriteLine(string.Join(", ", uniqueNegativeNumbers));
        }
    }
}