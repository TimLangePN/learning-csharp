namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] {1, 10, 100, 1000, 10000 };

            List<int> list = new List<int> { 2, 20, 200, 2000, 20000 };
            list.Add(10);

            list.RemoveAt(5);

            foreach (var arrayItem in array)
            {
                Console.WriteLine(arrayItem);
            }
            foreach (var listItem in list)
            {
                Console.WriteLine(listItem);
            }
        }
    }
}