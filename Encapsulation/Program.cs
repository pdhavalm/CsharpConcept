
namespace Encapsulation;
//class Program // Encapsulation concept method 1
//{
//    // Encapsulartion concept in oops
//    class Bank
//    {
//        int accountBalance = 1000; // use enclapsulate conecept to hide main accountBalance variable
//        public void SetAccountBalance(int amount) // Set update account balance
//        {
//            if (amount < 0)
//            {
//                Console.WriteLine("Amount should not less then zero");
//            }
//            else
//            {
//                accountBalance = amount;
//            }
//        }
//        public int GetAccountBalance() //Get balance and return private encapsulated variable
//        {
//            return accountBalance;
//        }
//    }
//    //static void Main(string[] args)
//    //{
//    //    Bank bank = new Bank();
//    //    bank.SetAccountBalance(500000); // set account balance
//    //    Console.WriteLine($"Account balance is:{bank.GetAccountBalance()}"); // get account balance
//    //    Console.ReadLine();
//    //}
//}

class Program1 //Encapsulation concept method 2
{
    class Bank
    {
        int accountBalance = 1000; // use enclapsulate conecept to hide main accountBalance variable
        public int AccBalance {
            set {
                if (value < 0)
                {
                    Console.WriteLine("Amount should not less then zero"); // Set update account balance
                }
                else
                {
                    accountBalance = value;
                }
            }
            get { 
                return accountBalance; //Get balance and return private encapsulated variable
            } 
        }    
    }
    public static void Main(string[] args)
    {
        Bank b = new Bank();    // instat of class  
        b.AccBalance = 5000; // update(set) encapsulated variable
        Console.WriteLine($"Account balance is: {b.AccBalance}"); //get encapsulated variable
        Console.ReadLine();
    }
}