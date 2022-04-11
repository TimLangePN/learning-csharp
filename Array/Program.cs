namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 2];
            array[0, 0] = 1;
            array[0, 1] = 2;
            array[1, 0] = 3;
            array[1, 1] = 4;
            array[2, 0] = 5;
            array[2, 1] = 6;
            array[3, 0] = 7;
            array[3, 1] = 8;
            array[4, 0] = 9;
            array[4, 1] = 10;

            Console.Write(array[0, 0]);
            Console.Write(array[0, 1]);

            Console.WriteLine();

            Console.Write(array[1, 0]);
            Console.Write(array[1, 1]);

            Console.WriteLine();


            Console.Write(array[2, 0]);
            Console.Write(array[2, 1]);

            Console.WriteLine();


            Console.Write(array[3, 0]);
            Console.Write(array[3, 1]);

            Console.WriteLine();

            Console.Write(array[4, 0]);
            Console.Write(array[4, 1]);

        }
    }
}