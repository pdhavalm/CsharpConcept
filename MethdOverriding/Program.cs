namespace MethodOverrding;

class Program
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    class Dog:Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
    }

    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Eat();
        Console.ReadLine();
    }
}