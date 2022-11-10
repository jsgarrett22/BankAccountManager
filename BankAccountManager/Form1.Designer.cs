namespace BankAccountManager
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTransAmt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioWithdrawal = new System.Windows.Forms.RadioButton();
            this.radioDeposit = new System.Windows.Forms.RadioButton();
            this.listTransactions = new System.Windows.Forms.ListView();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.txtAccBalance = new System.Windows.Forms.TextBox();
            this.BottomGroupPanel = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.Transactions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.BottomGroupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account History:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtTransAmt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioWithdrawal);
            this.groupBox1.Controls.Add(this.radioDeposit);
            this.groupBox1.Location = new System.Drawing.Point(41, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 296);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Type:";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Info;
            this.txtStatus.Location = new System.Drawing.Point(129, 261);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(308, 20);
            this.txtStatus.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Transaction Status:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(21, 123);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTransAmt
            // 
            this.txtTransAmt.Location = new System.Drawing.Point(129, 90);
            this.txtTransAmt.Name = "txtTransAmt";
            this.txtTransAmt.Size = new System.Drawing.Size(100, 20);
            this.txtTransAmt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Transaction Amount:";
            // 
            // radioWithdrawal
            // 
            this.radioWithdrawal.AutoSize = true;
            this.radioWithdrawal.Location = new System.Drawing.Point(21, 60);
            this.radioWithdrawal.Name = "radioWithdrawal";
            this.radioWithdrawal.Size = new System.Drawing.Size(78, 17);
            this.radioWithdrawal.TabIndex = 1;
            this.radioWithdrawal.TabStop = true;
            this.radioWithdrawal.Text = "Withdrawal";
            this.radioWithdrawal.UseVisualStyleBackColor = true;
            // 
            // radioDeposit
            // 
            this.radioDeposit.AutoSize = true;
            this.radioDeposit.Location = new System.Drawing.Point(21, 37);
            this.radioDeposit.Name = "radioDeposit";
            this.radioDeposit.Size = new System.Drawing.Size(61, 17);
            this.radioDeposit.TabIndex = 0;
            this.radioDeposit.TabStop = true;
            this.radioDeposit.Text = "Deposit";
            this.radioDeposit.UseVisualStyleBackColor = true;
            // 
            // listTransactions
            // 
            this.listTransactions.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Transactions});
            this.listTransactions.GridLines = true;
            this.listTransactions.HideSelection = false;
            this.listTransactions.LabelWrap = false;
            this.listTransactions.Location = new System.Drawing.Point(535, 57);
            this.listTransactions.Name = "listTransactions";
            this.listTransactions.Size = new System.Drawing.Size(228, 296);
            this.listTransactions.TabIndex = 4;
            this.listTransactions.UseCompatibleStateImageBehavior = false;
            // 
            // txtAccNum
            // 
            this.txtAccNum.BackColor = System.Drawing.SystemColors.Info;
            this.txtAccNum.Location = new System.Drawing.Point(134, 17);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.ReadOnly = true;
            this.txtAccNum.Size = new System.Drawing.Size(136, 20);
            this.txtAccNum.TabIndex = 5;
            this.txtAccNum.Text = "000302019";
            // 
            // txtAccBalance
            // 
            this.txtAccBalance.BackColor = System.Drawing.SystemColors.Info;
            this.txtAccBalance.Location = new System.Drawing.Point(389, 17);
            this.txtAccBalance.Name = "txtAccBalance";
            this.txtAccBalance.ReadOnly = true;
            this.txtAccBalance.Size = new System.Drawing.Size(126, 20);
            this.txtAccBalance.TabIndex = 6;
            this.txtAccBalance.Text = "1362.59";
            // 
            // BottomGroupPanel
            // 
            this.BottomGroupPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.BottomGroupPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BottomGroupPanel.Controls.Add(this.btnReset);
            this.BottomGroupPanel.Controls.Add(this.btnClose);
            this.BottomGroupPanel.Controls.Add(this.btnStatus);
            this.BottomGroupPanel.Controls.Add(this.btnHistory);
            this.BottomGroupPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BottomGroupPanel.Location = new System.Drawing.Point(41, 372);
            this.BottomGroupPanel.Name = "BottomGroupPanel";
            this.BottomGroupPanel.Size = new System.Drawing.Size(722, 62);
            this.BottomGroupPanel.TabIndex = 7;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(515, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(619, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(107, 19);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 1;
            this.btnStatus.Text = "Get Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(26, 19);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 23);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.Text = "Get History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Transactions
            // 
            this.Transactions.Text = "Transactions";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BottomGroupPanel);
            this.Controls.Add(this.txtAccBalance);
            this.Controls.Add(this.txtAccNum);
            this.Controls.Add(this.listTransactions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Bank Account Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BottomGroupPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtTransAmt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioWithdrawal;
        private System.Windows.Forms.RadioButton radioDeposit;
        private System.Windows.Forms.ListView listTransactions;
        private System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.TextBox txtAccBalance;
        private System.Windows.Forms.Panel BottomGroupPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ColumnHeader Transactions;
    }
}

