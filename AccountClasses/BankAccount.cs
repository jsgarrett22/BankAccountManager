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
        public AccountStatus Status
        {
            get
            {
                if (OverWithdrawn)
                {
                    return AccountStatus.Overdrawn;
                }
                else
                {
                    return AccountStatus.Ok;
                }
            }
        }
        public bool OverWithdrawn { get; set; }
        public List<Transaction> Transactions = new List<Transaction>();

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            this.Number = accountNumber;
            Deposit(initialBalance);
        }

        public AccountStatus Withdrawal(decimal amount)
        {
            AccountStatus status;
            if (amount > 0)
            {
                if (Balance - amount <= -100.00M)
                {
                    status = AccountStatus.InsufficientFunds;
                }
                else if (Balance - amount < 0)
                {
                    OverWithdrawn = true;
                    status = AccountStatus.Overdrawn;
                    Transactions.Add(new Transaction(DateTime.Now, -amount, TransactionType.OverWithdrawal));
                    // applyFee();
                }
                else
                {
                    status = AccountStatus.Ok;
                    Transactions.Add(new Transaction(DateTime.Now, -amount, TransactionType.Withdrawal));
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Amount to withdrawal must be greater than 0.");
            }
            return status;
        }

        public AccountStatus Deposit(decimal amount)
        {
            AccountStatus status;

            if (amount >= 10000)
            {
                status = AccountStatus.DepositTooLarge;
            }
            else if (amount <= 0)
            {
                status = AccountStatus.Failed;
                throw new ArgumentOutOfRangeException("Amount to deposit must be greater than 0.");
            }
            else
            {
                if (Transactions.Count <= 0)
                {
                    status = AccountStatus.Ok;
                    Transactions.Add(new Transaction(DateTime.Now, amount, TransactionType.InitialDeposit));
                }
                else
                {
                    status = AccountStatus.Ok;
                    Transactions.Add(new Transaction(DateTime.Now, amount, TransactionType.Deposit));
                }
            }
            return status;
        }

        public enum AccountStatus
        {
            Ok, Overdrawn, InsufficientFunds, DepositTooLarge, Failed
        }
    }
}
