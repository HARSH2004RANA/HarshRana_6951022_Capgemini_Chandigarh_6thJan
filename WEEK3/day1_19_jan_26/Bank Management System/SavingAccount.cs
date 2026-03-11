using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Transactions;

namespace Bank_Management_System
{
    internal class SavingAccount:BankAccount
    {
        public SavingAccount(string Account_no,string name):base(Account_no) {
            this.Bal = 0;
            this.Name = name;
        }
        public void Credit(long bal)
        {
            this.Bal += bal;
        }
        public void Debit(long bal)
        {
            if (this.Bal > bal)
            {
                this.Bal -= bal;
            }
            else
            {
                Console.WriteLine("insufficient Balance");
            }
        }
        public long Check_Balance()
        {
            return this.Bal;
        }
        public string GetSummary()
        {
            return string.Format("The Account Holder {0} having Account Number {1} has {2} balance",
    this.Name, this.Account_No, this.Bal);
        }
    }
}
