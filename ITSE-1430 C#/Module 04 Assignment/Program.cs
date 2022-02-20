/*  Programmer : John-David Rodriguez
    Course: ITSE-1430
    Date: 2/20/2022
    IDE: Microsoft Visual Studio
    Description:   (Account Modification) Modify class Account (Fig. 4.11) to provide a Withdraw method that withdraws money from an Account. 
                    Ensure that the withdrawal amount doesn’t exceed the balance. If it does, the balance should not be changed and the method 
                    should display a message indicating "Withdrawal amount exceeded account balance.
                  " Modify class AccountTest (Fig. 4.12) to test method Withdraw.
*/

using System;
namespace Module_04_Assignment_Rodriguez
{
    class Account
    {
        public string Name { get; set; } //auto-implemented property
        private decimal balance; //instance variable

        public Account(string accountName,decimal intialBalance)
        {
            Name = accountName;
            balance = intialBalance; // Balance's set accessor validates
        }

        //Balance property 
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set //can be used only within the class
            {
                balance = value;
            }
        }

        //method that deposits(adds) only a valid amount to the balance
        public void Deposit(decimal depositAmount)
        {
            if(depositAmount > 0.0m) //if the depositAmount is valid
            {
                Balance = Balance + depositAmount; // add it to the balance
            }
        }
        //create withdraw function
        public void Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount > balance)
            {
                Console.WriteLine("Withdrawal amount exceeded account balance");
            }
            else
            {
                Balance = Balance - withdrawAmount;
            }
        }

    }
    class AccountTest
    {
        static void Main()
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", 10.00m);

            //display initial balance of each object
            Console.WriteLine(
                $"{account1.Name}'s balance : {account1.Balance:C}");
            Console.WriteLine(
                $"{account2.Name}'s balance : {account2.Balance:C}");

            //prompt for then read input
            Console.Write("\nEnter withdrawal amount for account1: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
                $"withdrawing {withdrawAmount:C} from account1 balance\n");
            account1.Withdraw(withdrawAmount); //withdraw from  account1's balance

            //display balances
            Console.WriteLine(
                $"{account1.Name}'s balance : {account1.Balance:C}");
            Console.WriteLine(
                $"{account2.Name}'s balance : {account2.Balance:C}");

            //prompt for then read input
            Console.Write("\nEnter withdrawal amount for account2: ");
            withdrawAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
                $"withdrawing {withdrawAmount:C} from account2 balance\n");
            account2.Withdraw(withdrawAmount); //add to account2 balance

            //display balances
            Console.WriteLine(
                $"{account1.Name}'s balance: {account1.Balance}");
            Console.WriteLine(
                $"{account2.Name}'s balance: {account2.Balance}");
        }
    }
}
