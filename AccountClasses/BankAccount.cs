using System;
using System.Collections.Generic;

namespace AccountClasses

/**
 *  Deposits - a single deposit over 10,000 is not allowed.
 *  Withdrawals - any amount is allowed
 *  if a withdrawal results in a positive balance, the withdrawal is accepted
 *  if a withdrawal results in a negative balance, but not less than $100.00, the withdrawal is allowed
 *  but the user is charged an overdraft fee of $35.75
 *  if a withdrawal results in a negative balance of $100.00 or more, the withdrawal is not allowed and
 *  the user will not be a charged a fee.
 */
{
    public class BankAccount
    {
        public string Number { get; set; }
        public decimal Balance 
        {
            get
            {
                decimal balance = 0;
                foreach (var transaction in Transactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }
        }
        public bool OverWithdrawn { get; set; }
        public List<Transaction> Transactions = new List<Transaction>();

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            this.Number = accountNumber;
            Deposit(initialBalance);
        }

        public void Withdraw(decimal amount)
        {
            // if amount is positive
            if (amount > 0)
            {
                if (Balance - amount <= -100.00M)
                {
                    throw new ArgumentException("Amount to withdrawal must not exceed balance + $100.00.");
                } 
                else if (Balance - amount < 0)
                {
                    OverWithdrawn = true;
                    Transactions.Add(new Transaction(DateTime.Now, -amount, TransactionType.OverWithdrawal));
                    // applyFee();
                }
                else
                {
                    Transactions.Add(new Transaction(DateTime.Now, -amount, TransactionType.Deposit));
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Amount to withdrawal must be greater than 0.");
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount >= 10000)
            {
                throw new ArgumentException("Amount to deposit must be under 10,000.");
            }
            else if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount to deposit must be greater than 0.");
            }
            else
            {
                if (Transactions.Count <= 0)
                {
                    Transactions.Add(new Transaction(DateTime.Now, amount, TransactionType.InitialDeposit));
                }
                else
                {
                    Transactions.Add(new Transaction(DateTime.Now, amount, TransactionType.Deposit));
                }
            }
        }

        public override string ToString()
        {
            return $"Balance:\t\t{Balance}" +
                $"\nOverWithdrawn?\t\t{OverWithdrawn}";
        }
    }
}
