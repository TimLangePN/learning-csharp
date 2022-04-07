namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person defaultPerson = new Person();

            Person person1 = new Person("Tim", "Lange");
            Person person2 = new Person("Tim", 23);
            Person person3  = new Person("Tim", "Lange", 23);

            Console.WriteLine(defaultPerson.GetFullNameWithAge());

            Console.WriteLine(person1.GetFullNameWithAge());
            Console.WriteLine(person1.GetFullNameWithAge(12));

            Console.WriteLine(person2.GetFullNameWithAge());
            Console.WriteLine(person3.GetFullNameWithAge());
        }
    }
}