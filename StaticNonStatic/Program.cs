namespace StaticNonStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Tim", "Lange");

            Console.WriteLine(person.FormatFullname());
        }
    }
}