namespace Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        // void means it doesn't return a value
        public void Introduce()
        {
            System.Console.WriteLine($"Hello, my name is {FirstName} {LastName}!");
            System.Console.WriteLine("Hello, my name is " + FirstName + " " + LastName + "!");
        }
    }
}