namespace SimpleATM
{
    public partial class PINEntryForm : Form
    {
        CardDetails card = new CardDetails(); // initialise the card that will be used for this session

        public PINEntryForm()
        {
            InitializeComponent();
            
        }

        private void enterpINBtn_Click(object sender, EventArgs e)
        {
            //check whether a PIN has been entered
            if (PINEntryTxtBox.Text == null || PINEntryTxtBox.Text == string.Empty)
            {
                //show an error box here as the user must use a PIN
                MessageBox.Show("Please enter your PIN Number!", "You must enter a PIN Number to continue!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                if (PINEntryTxtBox.Text == card.PIN)
                {
                    //open ATM options form here
                    ATMFunctionsForm optionsForm = new ATMFunctionsForm();
                    optionsForm.Show();
                }
                else
                {
                    // normal ATMS only 
                    int errorCounter = 0;
                    int maxErrors = 3;
                    errorCounter++;
                    int noOfTriesLeft = maxErrors - errorCounter;
                    if (errorCounter >= maxErrors)
                    {
                        //if customer has failed 
                        MessageBox.Show("Card Blocked", "You have failed too many times on this machine, please try again later.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorCounter = 0;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect PIN!", $"The PIN you entered is incorrect. Number of tries remaining: {noOfTriesLeft}!");
                    }
                }
            
        }

        private void NumberZeroBtn_Click(object sender, EventArgs e)
        {
            //add/enter zero into textbox
            PINEntryTxtBox.Text += "0";
        }

        private void Number1Btn_Click(object sender, EventArgs e)
        {
            PINEntryTxtBox.Text += "1";
        }

        private void Number2Btn_Click(object sender, EventArgs e)
        {
            PINEntryTxtBox.Text += "2";
        }

        private void Number3Btn_Click(object sender, EventArgs e)
        {
            PINEntryTxtBox.Text += "3";
        }

        private void Number4Btn_Click(object sender, EventArgs e)
        {
            PINEntryTxtBox.Text += "4";
        }

        private void Number5Btn_Click(object sender, EventArgs e)
        {
            PINEntryTxtBox.Text += "5";
        }

        private void Number6Btn_Click(object sender, EventArgs e)
        {
            PINEntryTxtBox.Text += "6";
        }

        private void Number7Btn_Click(object sender, EventArgs e)
        {
            PINEntryTxtBox.Text += "7";
        }

        private void Number8Btn_Click(object sender, EventArgs e)
        {
            PINEntryTxtBox.Text += "8";
        }

        private void Number9Btn_Click(object sender, EventArgs e)
        {
            PINEntryTxtBox.Text += "9";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            PINEntryTxtBox.Text = string.Empty;
        }
    }
}
