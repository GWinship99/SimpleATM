namespace SimpleATM
{
    partial class PINEntryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            welcomeMsgLbl = new Label();
            label1 = new Label();
            PINEntryTxtBox = new TextBox();
            enterpINBtn = new Button();
            NumberZeroBtn = new Button();
            Number1Btn = new Button();
            Number2Btn = new Button();
            Number3Btn = new Button();
            Number4Btn = new Button();
            Number5Btn = new Button();
            Number6Btn = new Button();
            Number7Btn = new Button();
            Number8Btn = new Button();
            Number9Btn = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // welcomeMsgLbl
            // 
            welcomeMsgLbl.AutoSize = true;
            welcomeMsgLbl.Location = new Point(261, 26);
            welcomeMsgLbl.Name = "welcomeMsgLbl";
            welcomeMsgLbl.Size = new Size(246, 32);
            welcomeMsgLbl.TabIndex = 0;
            welcomeMsgLbl.Text = "Welcome to the ATM!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 87);
            label1.Name = "label1";
            label1.Size = new Size(246, 32);
            label1.TabIndex = 1;
            label1.Text = "Please Enter Your PIN:";
            // 
            // PINEntryTxtBox
            // 
            PINEntryTxtBox.BackColor = SystemColors.Window;
            PINEntryTxtBox.Location = new Point(246, 133);
            PINEntryTxtBox.Name = "PINEntryTxtBox";
            PINEntryTxtBox.PasswordChar = '*';
            PINEntryTxtBox.ReadOnly = true;
            PINEntryTxtBox.Size = new Size(249, 39);
            PINEntryTxtBox.TabIndex = 2;
            // 
            // enterpINBtn
            // 
            enterpINBtn.Location = new Point(375, 283);
            enterpINBtn.Name = "enterpINBtn";
            enterpINBtn.Size = new Size(115, 46);
            enterpINBtn.TabIndex = 3;
            enterpINBtn.Text = "Enter";
            enterpINBtn.UseVisualStyleBackColor = true;
            enterpINBtn.Click += enterpINBtn_Click;
            // 
            // NumberZeroBtn
            // 
            NumberZeroBtn.Location = new Point(257, 179);
            NumberZeroBtn.Name = "NumberZeroBtn";
            NumberZeroBtn.Size = new Size(63, 46);
            NumberZeroBtn.TabIndex = 4;
            NumberZeroBtn.Text = "0";
            NumberZeroBtn.UseVisualStyleBackColor = true;
            NumberZeroBtn.Click += NumberZeroBtn_Click;
            // 
            // Number1Btn
            // 
            Number1Btn.Location = new Point(326, 179);
            Number1Btn.Name = "Number1Btn";
            Number1Btn.Size = new Size(47, 46);
            Number1Btn.TabIndex = 5;
            Number1Btn.Text = "1";
            Number1Btn.UseVisualStyleBackColor = true;
            Number1Btn.Click += Number1Btn_Click;
            // 
            // Number2Btn
            // 
            Number2Btn.Location = new Point(375, 182);
            Number2Btn.Name = "Number2Btn";
            Number2Btn.Size = new Size(56, 46);
            Number2Btn.TabIndex = 6;
            Number2Btn.Text = "2";
            Number2Btn.UseVisualStyleBackColor = true;
            Number2Btn.Click += Number2Btn_Click;
            // 
            // Number3Btn
            // 
            Number3Btn.Location = new Point(437, 179);
            Number3Btn.Name = "Number3Btn";
            Number3Btn.Size = new Size(55, 46);
            Number3Btn.TabIndex = 7;
            Number3Btn.Text = "3";
            Number3Btn.UseVisualStyleBackColor = true;
            Number3Btn.Click += Number3Btn_Click;
            // 
            // Number4Btn
            // 
            Number4Btn.Location = new Point(266, 231);
            Number4Btn.Name = "Number4Btn";
            Number4Btn.Size = new Size(53, 46);
            Number4Btn.TabIndex = 8;
            Number4Btn.Text = "4";
            Number4Btn.UseVisualStyleBackColor = true;
            Number4Btn.Click += Number4Btn_Click;
            // 
            // Number5Btn
            // 
            Number5Btn.Location = new Point(325, 231);
            Number5Btn.Name = "Number5Btn";
            Number5Btn.Size = new Size(50, 46);
            Number5Btn.TabIndex = 9;
            Number5Btn.Text = "5";
            Number5Btn.UseVisualStyleBackColor = true;
            Number5Btn.Click += Number5Btn_Click;
            // 
            // Number6Btn
            // 
            Number6Btn.Location = new Point(383, 236);
            Number6Btn.Name = "Number6Btn";
            Number6Btn.Size = new Size(48, 46);
            Number6Btn.TabIndex = 10;
            Number6Btn.Text = "6";
            Number6Btn.UseVisualStyleBackColor = true;
            Number6Btn.Click += Number6Btn_Click;
            // 
            // Number7Btn
            // 
            Number7Btn.Location = new Point(447, 230);
            Number7Btn.Name = "Number7Btn";
            Number7Btn.Size = new Size(45, 46);
            Number7Btn.TabIndex = 11;
            Number7Btn.Text = "7";
            Number7Btn.UseVisualStyleBackColor = true;
            Number7Btn.Click += Number7Btn_Click;
            // 
            // Number8Btn
            // 
            Number8Btn.Location = new Point(276, 287);
            Number8Btn.Name = "Number8Btn";
            Number8Btn.Size = new Size(43, 46);
            Number8Btn.TabIndex = 12;
            Number8Btn.Text = "8";
            Number8Btn.UseVisualStyleBackColor = true;
            Number8Btn.Click += Number8Btn_Click;
            // 
            // Number9Btn
            // 
            Number9Btn.Location = new Point(323, 290);
            Number9Btn.Name = "Number9Btn";
            Number9Btn.Size = new Size(46, 46);
            Number9Btn.TabIndex = 13;
            Number9Btn.Text = "9";
            Number9Btn.UseVisualStyleBackColor = true;
            Number9Btn.Click += Number9Btn_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(292, 342);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(150, 46);
            clearButton.TabIndex = 14;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // PINEntryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(Number9Btn);
            Controls.Add(Number8Btn);
            Controls.Add(Number7Btn);
            Controls.Add(Number6Btn);
            Controls.Add(Number5Btn);
            Controls.Add(Number4Btn);
            Controls.Add(Number3Btn);
            Controls.Add(Number2Btn);
            Controls.Add(Number1Btn);
            Controls.Add(NumberZeroBtn);
            Controls.Add(enterpINBtn);
            Controls.Add(PINEntryTxtBox);
            Controls.Add(label1);
            Controls.Add(welcomeMsgLbl);
            Name = "PINEntryForm";
            Text = "Simple ATM - PIN Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeMsgLbl;
        private Label label1;
        private TextBox PINEntryTxtBox;
        private Button enterpINBtn;
        private Button NumberZeroBtn;
        private Button Number1Btn;
        private Button Number2Btn;
        private Button Number3Btn;
        private Button Number4Btn;
        private Button Number5Btn;
        private Button Number6Btn;
        private Button Number7Btn;
        private Button Number8Btn;
        private Button Number9Btn;
        private Button clearButton;
    }
}
