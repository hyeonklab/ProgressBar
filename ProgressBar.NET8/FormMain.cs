namespace ProgressBar.NET8
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event of the button to show the progress bar dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProgressBar_Click(object sender, EventArgs e)
        {
            // Show the progress bar dialog
            using FormProgressBarDotNET8 progressDialog = new FormProgressBarDotNET8(); // <--- Updated to use FormProgressBarDotNET8
            progressDialog.ShowDialog(this);
        }
    }
}
