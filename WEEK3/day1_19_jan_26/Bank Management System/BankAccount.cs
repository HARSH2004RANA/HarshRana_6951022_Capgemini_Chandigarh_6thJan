using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Management_System
{
    internal class BankAccount
    {
        readonly string Account_Number;
        string name;
        long Balance;
        public BankAccount(string Account_Number)
        {
            this.Account_Number = Account_Number;
        }
        protected string Account_No
        {
            get
            {
                return Account_Number;
            }
        }
        protected long Bal
        {
            get
            {
                return Balance;
            }
            set
            {
                Balance = value;
            }
        }
        protected string Name
        {
            get
            {
                return name;
            }
            set
            {
                 name= value;
            }
        }
    }
}
