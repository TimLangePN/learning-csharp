namespace ClassesAndObjects
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
            
        public void GetFullName()
        {
            Console.WriteLine($"Fullname = {FirstName}{LastName}");
        }

        public void Eat()
        {
            Console.WriteLine($"{FirstName}{LastName} Is eating!");
        }


        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName}{LastName} Is eating {food}!");
        }

        
    }
}
