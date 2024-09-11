namespace SimpleATM
{
    partial class CustomAmountDialog
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
            customAmountTxtBox = new TextBox();
            enterAmountBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 27);
            label1.Name = "label1";
            label1.Size = new Size(611, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter the custon amount you want to deposit/withdraw ";
            // 
            // customAmountTxtBox
            // 
            customAmountTxtBox.Location = new Point(199, 86);
            customAmountTxtBox.Name = "customAmountTxtBox";
            customAmountTxtBox.Size = new Size(389, 39);
            customAmountTxtBox.TabIndex = 1;
            // 
            // enterAmountBtn
            // 
            enterAmountBtn.Location = new Point(311, 134);
            enterAmountBtn.Name = "enterAmountBtn";
            enterAmountBtn.Size = new Size(150, 46);
            enterAmountBtn.TabIndex = 2;
            enterAmountBtn.Text = "Enter";
            enterAmountBtn.UseVisualStyleBackColor = true;
            enterAmountBtn.Click += enterAmountBtn_Click;
            // 
            // CustomAmountDialog
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(enterAmountBtn);
            Controls.Add(customAmountTxtBox);
            Controls.Add(label1);
            Name = "CustomAmountDialog";
            Text = "CustomAmountDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox customAmountTxtBox;
        private Button enterAmountBtn;
    }
}