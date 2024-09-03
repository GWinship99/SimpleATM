namespace SimpleATM
{
    public partial class PINEntryForm : Form
    {
        CardDetails card = new CardDetails(); // initialise the card that will be used for this session
        
        public PINEntryForm()
        {
            //adding some dummy pins to this list just to prove this software works, will improve by using programmatically
            //generated pins or pins stored in a database oncce I know this basic version works
            card.AcceptedPins.Add("2459");
            card.AcceptedPins.Add("1111");
        }

        private void enterpINBtn_Click(object sender, EventArgs e)
        {
            //check whether a PIN has been entered
            if (PINEntryTxtBox.Text == null || PINEntryTxtBox.Text == string.Empty)
            {
                //show an error box here as the user must use a PIN
                MessageBox.Show("Please enter your PIN Number!","You must enter a PIN Number to continue!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            //perform checks that verify whether the entered PIN is one of the accepted ones
            foreach (var pin in card.AcceptedPins) {
                if (PINEntryTxtBox.Text == pin)
                {
                    //open ATM options form here
                }
                else
                {
                    // normal ATMS only 
                    int errorCounter = 0;
                    int maxErrors = 3;
                    errorCounter++;
                    int noOfTriesLeft = maxErrors - errorCounter;
                    if (errorCounter >= maxErrors) {
                        //if customer has failed 
                        MessageBox.Show("Card Blocked","You have failed too many times on this machine, please try again later.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    } else
                    {
                        MessageBox.Show("Incorrect PIN!", $"The PIN you entered is incorrect. You have {noOfTriesLeft} tries left!");
                    }
                }
            }
        }
    }
}
