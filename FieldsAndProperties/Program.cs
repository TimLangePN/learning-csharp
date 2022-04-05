namespace FieldsAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Lives = 100;

            Console.WriteLine(player.Lives);
        }
    }
}