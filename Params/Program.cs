namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSumImproved(1, 2, 3, 8));   
        }
        //static int GetSum(int number1, int number2, int number3)
        //{
        //    return number1 + number2 + number3;
        //}

        static int GetSumImproved(params int[] numbersToSum)
        {
            int sum = 0;

            foreach (var number in numbersToSum) sum = sum + number;

            return sum;
        }
    }
}