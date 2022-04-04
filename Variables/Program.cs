namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountOfCars = 1;
            string myName = "Tim";
            bool IsCompatible = true;
            string Number = "2";
            int NumberConverted = Convert.ToInt32(Number);

            Console.WriteLine(CountOfCars);
            Console.WriteLine(myName);
            Console.WriteLine(IsCompatible);
            Console.WriteLine(Number);
            Console.WriteLine(NumberConverted);

        }
    }
}