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

            for (int i = 0; i < numList.Count - 1; i++)
            {
                for (int j = 0; j < numList.Count - 1; j++)
                {
                    if (numList[j] > numList[j + 1])
                    {
                        var biggerNumber = numList[j];
                        numList[j] = numList[j + 1];
                        //var justChecking = numList[j];
                        numList[j + 1] = biggerNumber;
                    }
                    Console.WriteLine(String.Join(", ", numList));
                }
                Console.WriteLine(String.Join(", ", numList));
            }

        }
    }
}