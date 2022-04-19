namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @""; //path
            string text = "Some info";

            System.IO.File.AppendAllText(path, text);
            string[] lines = System.IO.File.ReadAllLines(path);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}