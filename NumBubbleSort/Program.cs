namespace NumBubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number or 'stop' to end: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "stop") break;
                numbers.Add(int.Parse(input));
            }
            Console.WriteLine("Original list: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = 0; j < numbers.Count - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted list: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}