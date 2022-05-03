using System;
using System.Windows.Forms;

namespace TestRegDotnetBar
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //------------------------Begin Registeration ---------------------------//
        private void buttonX1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful registration");
        }
        //------------------------End Registeration ---------------------------//
    }
}
