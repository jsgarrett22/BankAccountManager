using System;

namespace AccountClasses
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }

        public Transaction(DateTime date, decimal amount, TransactionType type)
        {
            Date = date;
            Amount = amount;
            Type = type;
        }

        public override string ToString()
        {
            return $"Date: {Date.ToShortDateString()}\t\tAmount: {Amount}\t\tType: {Type}";
        }
    }
    public enum TransactionType
    {
        Withdrawal, Deposit, InitialDeposit, OverWithdrawal
    }
}

