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
            PINEntryTxtBox.Location = new Point(246, 133);
            PINEntryTxtBox.Name = "PINEntryTxtBox";
            PINEntryTxtBox.Size = new Size(249, 39);
            PINEntryTxtBox.TabIndex = 2;
            // 
            // enterpINBtn
            // 
            enterpINBtn.Location = new Point(284, 191);
            enterpINBtn.Name = "enterpINBtn";
            enterpINBtn.Size = new Size(150, 46);
            enterpINBtn.TabIndex = 3;
            enterpINBtn.Text = "Enter";
            enterpINBtn.UseVisualStyleBackColor = true;
            enterpINBtn.Click += enterpINBtn_Click;
            // 
            // PINEntryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
