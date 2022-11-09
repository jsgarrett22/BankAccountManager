﻿using AccountClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void NewBankAccountTest()
        {
            BankAccount account = new BankAccount("000302019", 1362.59M);

            Assert.IsNotNull(account);
            Assert.IsInstanceOfType(account, typeof(BankAccount));
            Assert.AreEqual("000302019", account.Number);
        }

        [TestMethod]
        public void TestInitialDeposit()
        {
            BankAccount account = new BankAccount("000302019", 1362.59M);
            Assert.IsTrue(account.Transactions.Count == 1);
            Assert.AreEqual(1362.59M, account.Transactions[0].Amount);
            Assert.AreEqual(TransactionType.InitialDeposit, account.Transactions[0].Type);
            //Assert.IsTrue(account.Balance == 1362.59M);
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
            Assert.ThrowsException<ArgumentException>(() => account.Deposit(0));
            Assert.ThrowsException<ArgumentException>(() => account.Deposit(-10000M));
        }
    }
}
