namespace ProgressBarTest
{
    partial class FormMain
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
            this.btnProgressBar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProgressBar
            // 
            this.btnProgressBar.Location = new System.Drawing.Point(339, 187);
            this.btnProgressBar.Name = "btnProgressBar";
            this.btnProgressBar.Size = new System.Drawing.Size(116, 23);
            this.btnProgressBar.TabIndex = 0;
            this.btnProgressBar.Text = "ProgressBar";
            this.btnProgressBar.UseVisualStyleBackColor = true;
            this.btnProgressBar.Click += new System.EventHandler(this.BtnProgressBar_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProgressBar);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProgressBar;
    }
}