using System;
namespace DZ02.Structs
{
    public struct BankAccount
    {
        public string AccountNumber;
        public string AccountType;
        public decimal Balance;
        public BankAccount(string accountNumber, string accountType, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            Balance = balance;
        }
    }
}
                       