using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // ATTEMPT TO ESTABLISH AN ACCOUNT
            try
            {
                // CREATE NEW ACCOUNT

                // TRY TO PARSE 
                decimal.TryParse(txtTransAmt.Text, out decimal transAmt);
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            txtAccBalance.Text = "";
            txtAccNum.Text = "";
            txtTransAmt.Text = "";
            txtStatus.Text = "";
            listTransactions.Items.Clear();
        }
    }
}
