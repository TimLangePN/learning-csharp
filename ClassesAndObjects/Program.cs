namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instances of an object

            Person me = new Person();
            me.FirstName = "Tim";
            me.LastName = "Lange";

            me.GetFullName();
            me.Eat();

            SuperPerson superman = new SuperPerson();
            me.FirstName = "Clark";
            me.LastName = "Kent";

            superman.GetFullName();
            superman.Eat();
            superman.Fly();

        }
    }
}