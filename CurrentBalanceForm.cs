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
    public partial class CurrentBalanceForm : Form
    {
        DepositWithdrawForm form = new DepositWithdrawForm();
        public CurrentBalanceForm()
        {
            InitializeComponent();
            balanceLbl.Text = balanceLbl.Text + form.card.Balance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
