using AccountClasses;
using System;
using System.Windows.Forms;

namespace BankAccountManager
{
    public partial class Main : Form
    {
        BankAccount account = new BankAccount("000302019", 1362.59M);

        public Main()
        {
            InitializeComponent();
            txtAccNum.Text = account.Number.ToString();
            txtAccBalance.Text = account.Balance.ToString("C2");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isValid = decimal.TryParse(txtTransAmt.Text, out decimal transAmt);

            if (!isValid)
            {
                txtStatus.Text = "Invalid amount entered. Transaction must be a dollar amount.";
                return;
            }
            if (radioDeposit.Checked)
            {
                BankAccount.AccountStatus status = account.Deposit(transAmt);
                txtStatus.Text = DisplayTransactionStatus(status);
            }
            else if (radioWithdrawal.Checked)
            {
                BankAccount.AccountStatus status = account.Withdrawal(transAmt);
                txtStatus.Text = DisplayTransactionStatus(status);
            }
            else
            {
                txtStatus.Text = "You must select either the Deposit or Withdrawal option.";
                return;
            }

            txtAccBalance.Text = account.Balance.ToString("C2");

            txtTransAmt.Text = "";
            radioDeposit.Checked = false;
            radioWithdrawal.Checked = false;
        }

        private string DisplayTransactionStatus(BankAccount.AccountStatus status)
        {
            string statusString = "";
            switch (status)
             {
                case BankAccount.AccountStatus.Ok:
                    statusString = "Transaction Successful";
                    break;
                case BankAccount.AccountStatus.Overdrawn:
                    statusString = "Your account is overdrawn. Please make a deposit.";
                    break;
                case BankAccount.AccountStatus.InsufficientFunds:
                    statusString = "Your account has insufficient funds for this transaction.";
                    break;
                case BankAccount.AccountStatus.DepositTooLarge:
                    statusString = "The transaction amount is too large and cannot be submitted";
                    break;
                case BankAccount.AccountStatus.Failed:
                    statusString = "Transaction Failed";
                    break;
            }
            return statusString;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            txtTransAmt.Text = "";
            txtStatus.Text = "";
            listTransactions.Items.Clear();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            for (int i = account.Transactions.Count - 1; i >= 0; i--)
            {
                listTransactions.Items.Add(account.Transactions[i].Amount.ToString("C2"));
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            switch (account.Status)
            {
                case BankAccount.AccountStatus.Ok:
                    MessageBox.Show("Your account is currently in good standing.");
                    break;
                case BankAccount.AccountStatus.Overdrawn:
                    MessageBox.Show("Your account is overdrawn. Please make a deposit.");
                    break;
                case BankAccount.AccountStatus.InsufficientFunds:
                    break;
                case BankAccount.AccountStatus.DepositTooLarge:
                    break;
                case BankAccount.AccountStatus.Failed:
                    break;
                default:
                    break;
            }
        }
    }
}
