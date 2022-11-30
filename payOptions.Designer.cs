namespace ResturantPOS
{
    partial class payOptions
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
            this.btnCash = new System.Windows.Forms.Button();
            this.Visa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(93, 186);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(94, 29);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            // 
            // Visa
            // 
            this.Visa.Location = new System.Drawing.Point(209, 186);
            this.Visa.Name = "Visa";
            this.Visa.Size = new System.Drawing.Size(94, 29);
            this.Visa.TabIndex = 1;
            this.Visa.Text = "button2";
            this.Visa.UseVisualStyleBackColor = true;
            // 
            // payOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.Visa);
            this.Controls.Add(this.btnCash);
            this.Name = "payOptions";
            this.Text = "payOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCash;
        private Button Visa;
    }
}