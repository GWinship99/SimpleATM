namespace SimpleATM
{
    partial class DepositWithdrawForm
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
            TwentyPoundsBtn = new Button();
            FiftyPoundsBtn = new Button();
            EightyPoundsBtn = new Button();
            HundredPoundsBtn = new Button();
            CustomPoundsBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 19);
            label1.Name = "label1";
            label1.Size = new Size(525, 32);
            label1.TabIndex = 0;
            label1.Text = "Select amount of money to deposit or withdraw";
            // 
            // TwentyPoundsBtn
            // 
            TwentyPoundsBtn.Location = new Point(55, 88);
            TwentyPoundsBtn.Name = "TwentyPoundsBtn";
            TwentyPoundsBtn.Size = new Size(150, 46);
            TwentyPoundsBtn.TabIndex = 1;
            TwentyPoundsBtn.Text = "£20";
            TwentyPoundsBtn.UseVisualStyleBackColor = true;
            TwentyPoundsBtn.Click += TwentyPoundsBtn_Click;
            // 
            // FiftyPoundsBtn
            // 
            FiftyPoundsBtn.Location = new Point(500, 88);
            FiftyPoundsBtn.Name = "FiftyPoundsBtn";
            FiftyPoundsBtn.Size = new Size(150, 46);
            FiftyPoundsBtn.TabIndex = 2;
            FiftyPoundsBtn.Text = "£50";
            FiftyPoundsBtn.UseVisualStyleBackColor = true;
            FiftyPoundsBtn.Click += FiftyPoundsBtn_Click;
            // 
            // EightyPoundsBtn
            // 
            EightyPoundsBtn.Location = new Point(55, 173);
            EightyPoundsBtn.Name = "EightyPoundsBtn";
            EightyPoundsBtn.Size = new Size(150, 46);
            EightyPoundsBtn.TabIndex = 3;
            EightyPoundsBtn.Text = "£80";
            EightyPoundsBtn.UseVisualStyleBackColor = true;
            EightyPoundsBtn.Click += EightyPoundsBtn_Click;
            // 
            // HundredPoundsBtn
            // 
            HundredPoundsBtn.Location = new Point(500, 173);
            HundredPoundsBtn.Name = "HundredPoundsBtn";
            HundredPoundsBtn.Size = new Size(150, 46);
            HundredPoundsBtn.TabIndex = 4;
            HundredPoundsBtn.Text = "£100";
            HundredPoundsBtn.UseVisualStyleBackColor = true;
            HundredPoundsBtn.Click += HundredPoundsBtn_Click;
            // 
            // CustomPoundsBtn
            // 
            CustomPoundsBtn.Location = new Point(278, 252);
            CustomPoundsBtn.Name = "CustomPoundsBtn";
            CustomPoundsBtn.Size = new Size(150, 46);
            CustomPoundsBtn.TabIndex = 5;
            CustomPoundsBtn.Text = "Custom";
            CustomPoundsBtn.UseVisualStyleBackColor = true;
            CustomPoundsBtn.Click += CustomPoundsBtn_Click;
            // 
            // DepositWithdrawForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CustomPoundsBtn);
            Controls.Add(HundredPoundsBtn);
            Controls.Add(EightyPoundsBtn);
            Controls.Add(FiftyPoundsBtn);
            Controls.Add(TwentyPoundsBtn);
            Controls.Add(label1);
            Name = "DepositWithdrawForm";
            Text = "DepositWithdrawForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button TwentyPoundsBtn;
        private Button FiftyPoundsBtn;
        private Button EightyPoundsBtn;
        private Button HundredPoundsBtn;
        private Button CustomPoundsBtn;
    }
}