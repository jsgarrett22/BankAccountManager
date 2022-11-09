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
        public decimal Balance { get; set; }
        public bool OverWithdrawn { get; set; }
        public List<Transaction> Transactions = new List<Transaction>();

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            this.Number = accountNumber;
            Deposit(initialBalance);
            
        }

        public void Withdraw(decimal amount)
        {
            Transaction newTransaction = new Transaction(DateTime.Now, amount, TransactionType.Withdrawal);
            if (amount > 0)
            {
                if (Balance - amount < 0)
                {
                    OverWithdrawn = true;
                    // applyFee();
                    if (Balance - amount <= -100.00M)
                    {
                        throw new Exception("Amount to withdrawal must not exceed balance + $100.00.");
                    }
                }
                Balance -= amount;
            }
            else
            {
                throw new Exception("Amount to withdrawal must be greater than 0.");
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount >= 10000)
            {
                throw new Exception("Amount to deposit must be under 10,000.");
            }
            else if (amount <= 0)
            {
                throw new Exception("Amount to deposit must be greater than 0.");
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
