namespace ProgressBar.NET8
{
    public partial class FormProgressBarDotNET8 : Form
    {
        private CancellationTokenSource _cts; // Cancellation token source

        /// <summary>
        /// ProgressBar Form constructor
        /// </summary>
        public FormProgressBarDotNET8()
        {
            InitializeComponent();

            _cts = new CancellationTokenSource();
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            Text = "work status"; // Set the form title
        }

        /// <summary>
        /// Start button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            ControlBox = false; // Disable close button
            btnStart.Enabled = false;
            btnCancel.Enabled = true;

            progressBar.Value = 0;
            lblMessage.Text = "start...";// Initial message

            try
            {
                await Task.Run(() => DoWork(_cts.Token));
                lblMessage.Text = "work completed"; // Work completed message
            }
            catch (OperationCanceledException) // Handle cancellation exception
            {
                lblMessage.Text = $"{lblMessage.Text} cancelled working";

                // Ask user if they want to close the progress bar
                if (MessageBox.Show("do you want to close the progress bar?", "close", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Close();
                else
                    ControlBox = true; // Enable close button
            }
            finally
            {
                btnStart.Enabled = true;
                btnCancel.Enabled = false;
            }
        }

        /// <summary>
        /// Cancel button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _cts?.Cancel(); // Request cancellation
        }

        /// <summary>
        /// Perform the work in a separate task
        /// </summary>
        /// <param name="token"></param>
        private void DoWork(CancellationToken token)
        {
            for (int i = 0; i <= 100; i++)
            {
                token.ThrowIfCancellationRequested(); // Check for cancellation request

                if (lblMessage.IsDisposed) // Check if the control has been disposed
                    return;

                // Update the progress bar and label on the UI thread
                Invoke(new Action(() =>
                {
                    progressBar.Value = i;
                    lblMessage.Text = $"{i}% in progress...";
                }));

                Thread.Sleep(50); // Simulate work (replace with actual work)
            }
        }
    }
}
