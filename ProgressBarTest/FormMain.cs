using System;
using System.Windows.Forms;

namespace ProgressBarTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnProgressBar_Click(object sender, EventArgs e)
        {
            using (FormProgressBar progressDialog = new FormProgressBar()) 
            {
                progressDialog.ShowDialog(this); 
            }
        }
    }
}
