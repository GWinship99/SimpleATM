using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleATM
{
    public partial class DepositWithdrawForm : Form
    {
        ATMFunctionsForm form = new ATMFunctionsForm();
        public CardDetails card = new CardDetails();
        public DepositWithdrawForm()
        {
            InitializeComponent();
        }

        private void TwentyPoundsBtn_Click(object sender, EventArgs e)
        {
            if (form.depositWithdraw == false)
            {
                card.Balance = card.Balance + 20;
                MessageBox.Show("Deposit Succeeded", "Thank you for your service!", MessageBoxButtons.OK);
            }
            else
            {
                card.Balance = card.Balance - 20;
                MessageBox.Show("Withdraw Succeeded", "Thank you for your service!", MessageBoxButtons.OK);
            }
        }

        private void FiftyPoundsBtn_Click(object sender, EventArgs e)
        {
            if (form.depositWithdraw == false)
            {
                card.Balance = card.Balance + 50;
                MessageBox.Show("Deposit Succeeded", "Thank you for your service!", MessageBoxButtons.OK);
            }
            else
            {
                card.Balance = card.Balance - 50;
                MessageBox.Show("Withdraw Succeeded", "Thank you for your service!", MessageBoxButtons.OK);
            }
        }

        private void EightyPoundsBtn_Click(object sender, EventArgs e)
        {
            if (form.depositWithdraw == false)
            {
                card.Balance = card.Balance + 80;
                MessageBox.Show("Deposit Succeeded", "Thank you for your service!", MessageBoxButtons.OK);
            }
            else
            {
                card.Balance = card.Balance - 80;
                MessageBox.Show("Withdraw Succeeded", "Thank you for your service!", MessageBoxButtons.OK);
            }
        }

        private void HundredPoundsBtn_Click(object sender, EventArgs e)
        {
            if (form.depositWithdraw == false)
            {
                card.Balance = card.Balance + 100;
                MessageBox.Show("Deposit Succeeded", "Thank you for your service!", MessageBoxButtons.OK);
            }
            else
            {
                card.Balance = card.Balance - 100;
                MessageBox.Show("Withdraw Succeeded", "Thank you for your service!", MessageBoxButtons.OK);
            }
        }

        private void CustomPoundsBtn_Click(object sender, EventArgs e)
        {
            CustomAmountDialog customAmountDialog = new CustomAmountDialog();
            customAmountDialog.ShowDialog();
        }
    }
}
