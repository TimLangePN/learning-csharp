namespace LoopingWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;

            while (index <= 10)
            {
                Console.WriteLine($"The number is {index}");
                index++;
            }
        }
    }
}