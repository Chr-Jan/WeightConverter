using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class BankAccount
    {

        //Exercise 2

        private double balance;
        public string Name { get; set; }
        public double Balance
        {
            get
            {
                return balance; 
            }
        }
        private bool locked;

        public BankAccount(double balance)
        {
            this.balance = balance;
        }
        public BankAccount(string name, double balance)
        {
            Name = name;
            this.balance = balance;
        }
        public BankAccount(string name, double balance, bool locked)
        {
            Name = name;
            this.balance = balance;
            this.locked = locked;
        }

        public void Deposit(double deposit)
        {
            if(locked==false)
            {
                balance = balance + deposit;
            }
        }
        public void Withdraw(double amount)
        {
            if (Balance >= amount && locked == false)
            {
                this.balance = Balance - amount;

            }
            else if (Balance < amount)
            {
                Console.WriteLine("Sorry buddy, you are poor");
            }
            else if (locked == true)
            {
                Console.WriteLine("Sorry buddy, your account is locked");
            }
        }
        public void ChangeLockState()
        {
            if(locked == true)
            {   
                locked = false;
            }
            else
            {
                locked = true;
            }

        }
        public override string ToString()
        {

            return "Name: " + Name + ", Balance: " + Balance;
        }

    }
}
