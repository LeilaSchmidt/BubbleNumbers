namespace NumBubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numList = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number or 'stop' to end: ");
                var userInput = Console.ReadLine();
                if (userInput.Trim().ToLower() == "stop")
                {
                    break;
                }
                if (!int.TryParse(userInput, out int numUserInput))
                {
                    Console.WriteLine("This is not a number");
                    continue;
                }
                numList.Add(numUserInput);
            }
            Console.WriteLine("The numbers you entered were... ");
            Console.WriteLine(String.Join(", ", numList));

            int i = 0;
            while (i < numList.Count - 1)
            {
                int j = 0;
                while (j < numList.Count - 1)
                {
                    if (numList[j] > numList[j + 1])
                    {
                        var biggerNumber = numList[j];
                        numList[j] = numList[j + 1];
                        numList[j + 1] = biggerNumber;
                    }
                    j++;
                }
                i++;
            }
            Console.WriteLine("The numbers you entered in ascending order are");
            Console.WriteLine(String.Join(", ", numList));

        }
    }
}