using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        class BanckAccount
        {
            private double account_number;
            private string account_owner_name;
            private  double account_balance;
            private string pin_code;
            private string pin_pattern = @"^[4-9]{1}[0-9]{3}$";

            public BanckAccount(double acc_num, string account_owner_name, double account_balance,string pin_code)
            {
                this.account_number = acc_num;
                this.account_owner_name = account_owner_name;
                this.account_balance = account_balance;
                this.pin_code = pin_code;
            }

            public double getBalance()
            {

                return this.account_balance;

            }

            public void deposit(double amount)
            {
                this.account_balance += amount;
                Console.WriteLine(" Amount added..");
            }
            public void withdraw(double amount)
            {
                if(this.account_balance >= amount)
                {
                    this.account_balance -= amount;
                    Console.WriteLine("withdraw is completed ");
                }
                else
                {
                    Console.WriteLine("you  have not  sufficent balance..");
                }
            }
            public void changePinCode(string newPin)
            {
                if(pin_code != newPin)
                {
                    if (Regex.IsMatch(newPin,pin_pattern))
                    {
                        pin_code = newPin;
                    }
                    else
                    {
                        Console.WriteLine("Enter the valide pin ");
                    }
                }
                else
                {
                    Console.WriteLine("you enter same pin try again..");
                }
                 
            }
            public void checkpin(string pin)
            {
                if (pin_code == pin)
                {
                    Console.WriteLine("your pin is correct");
                }
                else
                {
                    Console.WriteLine("you entered wrong pin");
                }
            }



        }
        static void Main(string[] args)
        {
            BanckAccount acc1 = new BanckAccount(4567,"vicky",110045000,"4043");
            
            Console.WriteLine("your balance is"+acc1.getBalance());
            Console.Write("enter amount to deposite :");
            acc1.deposit(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("your balance is " + acc1.getBalance());
            while(true)
            {

            Console.WriteLine("Enter your pin :");
            acc1.checkpin(Console.ReadLine());
            Console.WriteLine("Enter your new pin :");
            acc1.changePinCode(Console.ReadLine());
            }



        }
    }
}
