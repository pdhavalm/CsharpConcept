
namespace MethodOverloading;
class Program
{

    // Method Overloading concept
    // Same name but different parameter 

    void Sum(int a, decimal b) // parameter
    {
        Console.WriteLine(a + b);
    }
    void Sum(decimal b, int a) // sequence different parameter
    {
        Console.WriteLine(a + b);
    }
    void Sum(float a, float b) // data type change parameter
    {
        Console.WriteLine(a* b);     
    }
    void Sum(double a, int b, int c) // different data type paramter
    {
        Console.WriteLine(a / b);
    }
    static void Main(String[] args)
    {
        Program obj= new Program();
        obj.Sum(20, 10.3f);
        obj.Sum(10.3f, 20);
        obj.Sum(10.5f, 20.5f);
        obj.Sum(90.5,5,2);
        Console.ReadLine();
    }

}