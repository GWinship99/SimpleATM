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
    public partial class ATMFunctionsForm : Form
    {
        // false = deposit, true = withdraw, the flag is changed depending on what button is clicked
        public bool depositWithdraw = false; // will be using a flag to set whether the functionality is deposit/withdraw
        public ATMFunctionsForm()
        {
            InitializeComponent();
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            DepositWithdrawForm depositWithdrawForm = new DepositWithdrawForm();
            depositWithdrawForm.Show();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            depositWithdraw = true;
            DepositWithdrawForm depositWithdrawForm = new DepositWithdrawForm();
            depositWithdrawForm.Show();
        }

        private void currentBalanceBtn_Click(object sender, EventArgs e)
        {
            CurrentBalanceForm currentBalanceForm = new CurrentBalanceForm();
            currentBalanceForm.Show();
        }

        private void recentTransactions_Click(object sender, EventArgs e)
        {

        }
    }
}
