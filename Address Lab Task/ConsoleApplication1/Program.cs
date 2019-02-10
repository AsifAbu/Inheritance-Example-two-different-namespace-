using System;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program : Address
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are going to open a bank account. Please follow the procedure below very carefully.\n");
            string accName, accId, gender;
            int balance;
            string b;
            Console.Write("Type Your Account Name: ");
            accName = Console.ReadLine();
            Console.Write("Your Deposit Balance(Numeric Digit only): ");
            x:
            b = Console.ReadLine();
            bool isNumerical = int.TryParse(b, out balance);
            if (isNumerical == false)
            {
                Console.Write(">>>>ERROR<<<<<(Numeric Digit only): ");
                goto x;
            }
            balance = int.Parse(b);
            Console.Write("Type your Gender (m/f): ");
            gender = Console.ReadLine();

            string houseNo, roadNo, area, city;
            Console.WriteLine("Type House Number: ");
            houseNo = Console.ReadLine();
            Console.WriteLine("Type Road Number: ");
            roadNo = Console.ReadLine();
            Console.WriteLine("Type Area: ");
            area = Console.ReadLine();
            Console.WriteLine("Type City: ");
            city = Console.ReadLine();

            Address ad = new Address(houseNo, roadNo, area, city);
            Account ac = new Account(ad);
            accId = accName + ac.CreateDate;
            Console.WriteLine("Your Account ID is: " + accId);
            
            ac.Acc2(accName,accId, balance,gender);
            ac.ShowAccountDetails();
            Console.ReadLine();
        }
    }
}
