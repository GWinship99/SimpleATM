﻿namespace SimpleATM
{
    partial class RecentTransactionsForm
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
            transactionBox = new ListBox();
            transactionsOkBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 40);
            label1.Name = "label1";
            label1.Size = new Size(373, 32);
            label1.TabIndex = 0;
            label1.Text = "Here are your recent transactions:";
            // 
            // transactionBox
            // 
            transactionBox.FormattingEnabled = true;
            transactionBox.Location = new Point(269, 89);
            transactionBox.Name = "transactionBox";
            transactionBox.Size = new Size(240, 164);
            transactionBox.TabIndex = 1;
            // 
            // transactionsOkBtn
            // 
            transactionsOkBtn.Location = new Point(283, 276);
            transactionsOkBtn.Name = "transactionsOkBtn";
            transactionsOkBtn.Size = new Size(150, 46);
            transactionsOkBtn.TabIndex = 2;
            transactionsOkBtn.Text = "OK";
            transactionsOkBtn.UseVisualStyleBackColor = true;
            transactionsOkBtn.Click += transactionsOkBtn_Click;
            // 
            // RecentTransactionsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(transactionsOkBtn);
            Controls.Add(transactionBox);
            Controls.Add(label1);
            Name = "RecentTransactionsForm";
            Text = "RecentTransactionsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox transactionBox;
        private Button transactionsOkBtn;
    }
}