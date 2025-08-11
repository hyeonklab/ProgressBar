
namespace ProgressBar.NET8
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProgressBar = new Button();
            SuspendLayout();
            // 
            // btnProgressBar
            // 
            btnProgressBar.Location = new Point(333, 187);
            btnProgressBar.Name = "btnProgressBar";
            btnProgressBar.Size = new Size(114, 23);
            btnProgressBar.TabIndex = 0;
            btnProgressBar.Text = "ProgressBar";
            btnProgressBar.UseVisualStyleBackColor = true;
            btnProgressBar.Click += BtnProgressBar_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProgressBar);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProgressBar;
    }
}
