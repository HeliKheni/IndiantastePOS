namespace ResturantPOS
{
    partial class AdminHomePage
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
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(216, 123);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(112, 34);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Name = "AdminHomePage";
            this.Text = "AdminHomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReport;
    }
}