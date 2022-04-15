namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            if (player.Weapon == Weapons.Gun)
            {
                Console.WriteLine("Run");
            }
            else if (player.Weapon == Weapons.Sniper)
            {
                Console.WriteLine("Hide");
            }
            else if (player.Weapon == Weapons.Bazooka)
            {
                Console.WriteLine("Give up");
            }
        }
    }
}