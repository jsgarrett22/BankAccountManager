using AccountClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class BankAccountTest
    {
        // ACCOUNT CREATION TEST 
        [TestMethod]
        public void NewBankAccountTest()
        {
            BankAccount account = new BankAccount("000302019", 1362.59M);

            Assert.IsNotNull(account);
            Assert.IsInstanceOfType(account, typeof(BankAccount));
            Assert.AreEqual("000302019", account.Number);
        }

        // BALANCE TESTS
        [TestMethod]
        public void InitialBalanceTest()
        {
            BankAccount account = new BankAccount("000302019", 1362.59M);
            Assert.AreEqual(1362.59M, account.Balance);
        }

        // WITHDRAWAL TESTS
        [TestMethod]
        public void InvalidWithdrawalTest()
        {
            BankAccount account = new BankAccount("000302019", 1362.59M);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Withdrawal(0M));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Withdrawal(-10000M));
        }

        [TestMethod]
        public void PositiveBalanceWithdrawalTest()
        {
            // Withdrawal $100.00
            BankAccount account = new BankAccount("000302019", 1362.59M);
            account.Withdrawal(100.00M);
            Assert.AreEqual(1262.59M, account.Balance);
        }

        [TestMethod]
        public void OverWithdrawalWithFeeTest()
        {
            BankAccount account = new BankAccount("000302019", 1362.59M);
            BankAccount account2 = new BankAccount("000302019", 1362.59M);
            account.Withdrawal(1412.59M);
            account2.Withdrawal(1462.58M);
            Assert.AreEqual(-50.00M, account.Balance);
            Assert.AreEqual(-99.99M, account2.Balance);
        }

        [TestMethod]
        public void OverWithdrawalFailureTest()
        {
            // Over-Withdrawal of at least $100.00
            BankAccount account = new BankAccount("000302019", 1362.59M);
            Assert.ThrowsException<ArgumentException>(() => account.Withdrawal(1462.59M));
        }

        // DEPOSIT TESTS
        [TestMethod]
        public void TestInitialDeposit()
        {
            BankAccount account = new BankAccount("000302019", 1362.59M);
            Assert.IsTrue(account.Transactions.Count == 1);
            Assert.AreEqual(1362.59M, account.Transactions[0].Amount);
            Assert.AreEqual(TransactionType.InitialDeposit, account.Transactions[0].Type);
            Assert.IsTrue(account.Balance == 1362.59M);
        }

        [TestMethod]
        public void MultipleDepositsTest()
        {
            // Deposit $100 4 times
            BankAccount account = new BankAccount("000302019", 1362.59M);
            for (int i = 0; i < 4; i++)
                account.Deposit(100M);
            Assert.IsTrue(account.Transactions.Count == 5);
            Assert.IsTrue(account.Balance == 1762.59M);
        }

        [TestMethod]
        public void Over10000Test()
        {
            BankAccount account = new BankAccount("000302019", 1362.59M);
            Assert.ThrowsException<ArgumentException>(() => account.Deposit(10000M));
        }

        [TestMethod]
        public void NegativeDepositTest()
        {
            BankAccount account = new BankAccount("000302019", 1362.59M);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Deposit(0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Deposit(-10000M));
        }
    }
}
