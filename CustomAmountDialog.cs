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
    public partial class CustomAmountDialog : Form
    {
        public CustomAmountDialog()
        {
            InitializeComponent();
        }

        private void enterAmountBtn_Click(object sender, EventArgs e)
        {
            if (customAmountTxtBox.Text != string.Empty)
            {
                DialogResult = DialogResult.OK;

            }
            
        }
    }
}
