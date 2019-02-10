using System;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Account : Address
    {
        string name, accountId;
        double balance;
        static int count = 1;
        DateTime createDate;
        Gender gen;
        public Account(Address a) : base(a)
        {
            this.name = "Guest-"+count;
            this.accountId = "GuestID-"+count;
            this.balance = 0;
            this.createDate = DateTime.Now;
            count++;
        }
        public Account(string name, string accountid, float balance, string address,string gender,Address a): base(a)
        {
            this.name = name;
            this.accountId =accountid;
            this.balance = balance;
            this.createDate = DateTime.Now;
            if (gender.ToUpper().Equals("F"))
            {
                this.gen = Gender.female;
            }
            else if (gender.ToUpper().Equals("M"))
            {
                this.gen = Gender.male;
            }
            else if (gender.ToUpper().Equals("B"))
            {
                this.gen = Gender.both;
            }
            else
                this.gen = Gender.none;
        }
        public void Acc2(string name, string accountid, double balance, string gender)
        {
            this.name = name;
            this.accountId = accountid;
            this.balance = balance;
            this.createDate = DateTime.Now;
            if (gender.ToUpper().Equals("F"))
            {
                this.gen = Gender.female;
            }
            else if (gender.ToUpper().Equals("M"))
            {
                this.gen = Gender.male;
            }
            else if (gender.ToUpper().Equals("B"))
            {
                this.gen = Gender.both;
            }
            else
                this.gen = Gender.none;
        }
        private enum Gender : byte
        {
            female,
            male,
            both,
            none
        }
        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }
        public string AccountId
        {
            set { this.accountId = value; }
            get { return accountId; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return balance; }
        }
        public DateTime CreateDate
        {
            get { return createDate; }
        }
        
        public byte AccessGender
        {
            set
            {
                if (value == 1)
                    gen = Gender.female;
                else
                    gen = Gender.male;
            }
            get
            {
                return (byte)gen;
            }
        }
        public void ShowAccountDetails()
        {
            //Console.Clear();
            Console.WriteLine("Accont name: " + name);
            Console.WriteLine("Account Id: " + accountId);
            Console.WriteLine("Accont Balance: " + balance);
            Console.WriteLine("Account open DateTime: " + createDate);
            Console.WriteLine("Gender: " + gen);
            Console.WriteLine("Address: " + AddressReturn());
        }
        public void Withdraw(double ammount)
        {
            if (balance >= ammount)
            {
                this.balance -= ammount;
                Console.WriteLine("Your ammount Is Updated. Your Current balance Is: " + balance);
            }
            else
            {
                Console.WriteLine("Your ammount Is Law. Your Current Balance Is: " + balance);
            }
        }
        public void Deposit(float ammount)
        {
            this.balance += ammount;
            Console.WriteLine("Deposit SuccessFull. Current Accont Balance Is: " + balance);
        }
        public void Transfer(float ammount, Account a)
        {
            if (balance >= ammount)
            {
                a.Balance += ammount;
                this.Balance -= ammount;
                Console.WriteLine("Your ammount Is Tranfared. Your Current balance Is: " + balance);
            }
            else
            {
                Console.WriteLine("Your ammount Is Law. Your Current Balance Is: " + balance);
            }
        }
        
    }
}
