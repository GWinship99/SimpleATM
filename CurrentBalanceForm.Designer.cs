namespace SimpleATM
{
    partial class CurrentBalanceForm
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
            balanceLbl = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // balanceLbl
            // 
            balanceLbl.AutoSize = true;
            balanceLbl.Location = new Point(234, 61);
            balanceLbl.Name = "balanceLbl";
            balanceLbl.Size = new Size(281, 32);
            balanceLbl.TabIndex = 0;
            balanceLbl.Text = "Your current balance is: £";
            // 
            // button1
            // 
            button1.Location = new Point(307, 129);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CurrentBalanceForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(balanceLbl);
            Name = "CurrentBalanceForm";
            Text = "CurrentBalanceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label balanceLbl;
        private Button button1;
    }
}