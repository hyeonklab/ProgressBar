namespace ProgressBar.NET8
{
    partial class FormProgressBarDotNET8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar = new System.Windows.Forms.ProgressBar();
            lblMessage = new Label();
            btnStart = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 104);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(776, 23);
            progressBar.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(12, 86);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(53, 15);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "message";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(305, 38);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(405, 38);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // FormProgressBarDotNET8
            // 
            AcceptButton = btnStart;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 130);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnStart);
            Controls.Add(lblMessage);
            Controls.Add(progressBar);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProgressBarDotNET8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProgressBar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private Label lblMessage;
        private Button btnStart;
        private Button btnCancel;
    }
}