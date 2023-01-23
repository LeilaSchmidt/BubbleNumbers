namespace NumBubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            bool noMoreNums = false;
            while (noMoreNums == false)
            {
                Console.WriteLine("Enter a number or 'stop' to end: ");
                var input = Console.ReadLine();
                if (noMoreNums = true)
                {
                    break;
                }
                numbers.Add(int.Parse(input));
            }

        }
    }
}