namespace LoopingDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Difference between do while and normal while loop:
            //A "While" Loop is used to repeat a specific block of code an unknown number of times, until a condition is met.
            //The do...while loop executes at least once i.e. the first iteration runs without checking the condition.

            string input = string.Empty;

            do
            {
                input = Console.ReadLine();
                Console.WriteLine($"Your input is {input}.");

            } while (!input.Equals(string.Empty));

        }
    }
}