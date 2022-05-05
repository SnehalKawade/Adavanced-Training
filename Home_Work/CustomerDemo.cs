using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    //2.Create a class Customer → number of Accounts(saving & current) & loan(home loan, car loan) taken by
    //the customer → Display List of customer with their list of accounts & loan taken

    public class Customer
    {
        public int Cid { get; set; }
        public string Cname { get; set; }   
        public string CAddress { get; set; }

        public List<Accounts> AccList = new List<Accounts>();
    }
    public class Accounts
    {
        public string AccountType { get; set; }
        public long Accno { get; set; }

        public List<Loan> LoanList = new List<Loan>();

    }
    public class Loan
    {
        public string LoanType { get; set; }
    }
    class CustomerDemo
    {
        static void Main(string[] args)
        {
            List<Customer> Clist = new List<Customer>()
            {
                new Customer
                {
                    Cid=101,Cname="Snehal",CAddress="Solapur",AccList={new Accounts{Accno=12345,AccountType="Saving"
                    ,LoanList={ new Loan { LoanType="Home Loan"} } } }
                },
                new Customer
                {
                    Cid=102,Cname="Sayali",CAddress="Pune",AccList={new Accounts{Accno=54321,AccountType="Saving"
                    ,LoanList={ new Loan { LoanType="Car Loan"} } } }
                }
            };

            foreach (Customer c in Clist)
            {
                Console.WriteLine($"ID: {c.Cid} Name: {c.Cname} Location: {c.CAddress}");
                foreach(Accounts a in c.AccList)
                {
                    Console.WriteLine($"\n\tAccno: {a.Accno} \t AccountType: {a.AccountType}");
                    foreach(Loan l in a.LoanList)
                    {
                        Console.WriteLine($"\n\t Loan: {l.LoanType}");
                    }
                }
            }
        }
    }
}
