using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_rppoon.Memento
{
    class BankMemento
    {
        public string OwnerName { get; private set; }
        public string OwnerAddress { get; private set; }
        public decimal Balance { get; private set; }

        public BankMemento(string ownerName, string ownerAddress, decimal balance)
        {
            this.OwnerName = ownerName;
            this.OwnerAddress = ownerAddress;
            this.Balance = balance;
        }
        public BankMemento(BankAccount myAccount)
        {
            this.OwnerName = myAccount.OwnerName;
            this.OwnerAddress = myAccount.OwnerAddress;
            this.Balance = myAccount.Balance;
        }
        public void RestorePreviousState(BankAccount myAccount)
        {
            Balance = myAccount.Balance;
        }
    }
}
