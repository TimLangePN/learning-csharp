namespace ControlFlowDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();

            if (user.Equals("Robot"))
            {
                Console.WriteLine("You are a robot");
            }
            else if (user.Equals("Human"))
            {
                Console.WriteLine("You are a Human");
            }
            else
            {
                Console.WriteLine(user);
            }
            if (user.Equals(String.Empty))
            {
                Console.WriteLine("no value given");
            }
        }
    }
}