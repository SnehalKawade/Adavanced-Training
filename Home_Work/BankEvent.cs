using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    //1.Create a class Bank with Withdraw method, which accept the debit amount from the parameter.
    //2.Track balance & based on that if balance is zero raise an event zero bal.If debit amount is
    //greater than balance than less balance event should be raise
    //bal=5000   debit = 5000
    //Bal → raise an event zero bal
    //Debit 6000
    //Raise an event → low bal
    //It should perform the operation , display the last bal of account


    public delegate void bankDel();
    class BankEventD
    {
        private double balance;
        public event bankDel CreditInAcc;
        public event bankDel LowBal;
        public event bankDel ZeroBal;

        public BankEventD()
        {
            balance = 5000;
        }

        public void CreditAmount(double amt)
        {
            balance = balance + amt;
            CreditInAcc();  //raise an event
        }

        public void Debit(double debit)
        {
            if(balance==0)
            {
                ZeroBal();
            }
            else if(balance<debit)
            {
                LowBal();
            }
            else
            {
                balance = balance - debit;
            }
            Console.WriteLine($"Current balance {balance}");
        }
    }

        public class Msg
        {
            public void CreditMsg()
            {
                Console.WriteLine("You account has been credited");
            }
            public void LowBalMsg()
            {
                Console.WriteLine("You account have no balance to debit the amount");
            }

            public void ZeroBalMsg()
            {
                Console.WriteLine("You account has zero balance");
            }
        }
   
        class BankEvent
        {
        static void Main(string[] args)
        {
            BankEventD bank = new BankEventD();
            Msg msg = new Msg();
            bank.CreditInAcc += new bankDel(msg.CreditMsg);
            bank.LowBal+= new bankDel(msg.LowBalMsg); 
            bank.ZeroBal+= new bankDel(msg.ZeroBalMsg);
            bank.CreditAmount(1000);
            bank.Debit(7000);
        }
    }
}
