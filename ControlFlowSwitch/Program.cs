namespace ControlFlowSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "Tim":
                    Console.WriteLine("This is my name");
                    break;
                case "Visual Studio":
                    Console.WriteLine("This is my IDE");
                    break;
                default:
                    Console.WriteLine("No match found");
                    break;
            }

        }
    }
}