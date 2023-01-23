namespace NumBubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number or 'stop' to end: ");
                var userInput = Console.ReadLine();
                if (userInput == "stop" || userInput == "Stop" || userInput == "STOP")
                {
                    break;
                }
                if (!int.TryParse(userInput, out int numUserInput))
                {
                    Console.WriteLine("This is not a number");
                    continue;
                }
                numberList.Add(numUserInput);
            }
            Console.WriteLine("The numbers you entered were... ");
            Console.WriteLine(String.Join(", ", numberList));
        }
        
    }
}