namespace SimpleATM
{
    partial class ATMFunctionsForm
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
            label1 = new Label();
            depositBtn = new Button();
            WithdrawBtn = new Button();
            currentBalanceBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 35);
            label1.Name = "label1";
            label1.Size = new Size(278, 32);
            label1.TabIndex = 0;
            label1.Text = "Pick your desired option:";
            // 
            // depositBtn
            // 
            depositBtn.Location = new Point(308, 103);
            depositBtn.Name = "depositBtn";
            depositBtn.Size = new Size(150, 46);
            depositBtn.TabIndex = 1;
            depositBtn.Text = "Deposit";
            depositBtn.UseVisualStyleBackColor = true;
            depositBtn.Click += button1_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(308, 155);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(150, 46);
            WithdrawBtn.TabIndex = 2;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += button2_Click;
            // 
            // currentBalanceBtn
            // 
            currentBalanceBtn.Location = new Point(287, 207);
            currentBalanceBtn.Name = "currentBalanceBtn";
            currentBalanceBtn.Size = new Size(217, 46);
            currentBalanceBtn.TabIndex = 3;
            currentBalanceBtn.Text = "Current Balance";
            currentBalanceBtn.UseVisualStyleBackColor = true;
            currentBalanceBtn.Click += button3_Click;
            // 
            // ATMFunctionsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(currentBalanceBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(depositBtn);
            Controls.Add(label1);
            Name = "ATMFunctionsForm";
            Text = "ATMFunctionsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button depositBtn;
        private Button WithdrawBtn;
        private Button currentBalanceBtn;
    }
}