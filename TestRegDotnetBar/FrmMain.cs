using System;
using System.Windows.Forms;

namespace TestRegDotnetBar
{
    public partial class Form1 : Form
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
