namespace Constructor
{
    class Program
    {

        // Constructor 
        // 1. Default constructor
        // 2. User define constructor
        // 3. Parameterized Constructor

        string carModel;
        int carYear;
        public Program() // user define constructor 
        {
            Console.WriteLine("Hello I am constructor");
        }

        public Program(string model, int year) // parameter constructor 
        {
            carModel = model;
            carYear = year;
        }

        public static void Main(string[] args)
        {
            Program cons = new Program();
            Program cons2 = new Program("Mustang", 1969);
            Console.WriteLine($"Car Model: { cons2.carModel }");
            Console.WriteLine($"Car Year: { cons2.carYear }");
            Console.ReadLine();
        }

    }
}