namespace ResturantPOS
{
    partial class UppMenu
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
            System.Windows.Forms.Label lblNameU;
            System.Windows.Forms.Label lblCategoryU;
            System.Windows.Forms.Label PriceU;
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.btnUpdateU = new System.Windows.Forms.Button();
            this.ClearU = new System.Windows.Forms.Button();
            this.CancelU = new System.Windows.Forms.Button();
            this.txtNameU = new System.Windows.Forms.TextBox();
            this.txtCategoryU = new System.Windows.Forms.TextBox();
            this.txtPriceU = new System.Windows.Forms.TextBox();
            lblNameU = new System.Windows.Forms.Label();
            lblCategoryU = new System.Windows.Forms.Label();
            PriceU = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameU
            // 
            lblNameU.AutoSize = true;
            lblNameU.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNameU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblNameU.Location = new System.Drawing.Point(53, 184);
            lblNameU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNameU.Name = "lblNameU";
            lblNameU.Size = new System.Drawing.Size(64, 25);
            lblNameU.TabIndex = 10;
            lblNameU.Text = "Name";
            // 
            // lblCategoryU
            // 
            lblCategoryU.AutoSize = true;
            lblCategoryU.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCategoryU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblCategoryU.Location = new System.Drawing.Point(53, 268);
            lblCategoryU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCategoryU.Name = "lblCategoryU";
            lblCategoryU.Size = new System.Drawing.Size(92, 25);
            lblCategoryU.TabIndex = 11;
            lblCategoryU.Text = "Category";
            // 
            // PriceU
            // 
            PriceU.AutoSize = true;
            PriceU.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            PriceU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            PriceU.Location = new System.Drawing.Point(60, 359);
            PriceU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PriceU.Name = "PriceU";
            PriceU.Size = new System.Drawing.Size(57, 25);
            PriceU.TabIndex = 12;
            PriceU.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Location = new System.Drawing.Point(-37, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 102);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(169, 28);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(172, 41);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Add Menu";
            // 
            // btnUpdateU
            // 
            this.btnUpdateU.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnUpdateU.FlatAppearance.BorderSize = 5;
            this.btnUpdateU.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateU.Location = new System.Drawing.Point(131, 505);
            this.btnUpdateU.Name = "btnUpdateU";
            this.btnUpdateU.Size = new System.Drawing.Size(116, 62);
            this.btnUpdateU.TabIndex = 4;
            this.btnUpdateU.Text = "Update";
            this.btnUpdateU.UseVisualStyleBackColor = true;
            this.btnUpdateU.Click += new System.EventHandler(this.btnUpdateU_Click);
            // 
            // ClearU
            // 
            this.ClearU.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.ClearU.FlatAppearance.BorderSize = 5;
            this.ClearU.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearU.Location = new System.Drawing.Point(253, 505);
            this.ClearU.Name = "ClearU";
            this.ClearU.Size = new System.Drawing.Size(116, 62);
            this.ClearU.TabIndex = 5;
            this.ClearU.Text = "Clear";
            this.ClearU.UseVisualStyleBackColor = true;
            this.ClearU.Click += new System.EventHandler(this.ClearU_Click);
            // 
            // CancelU
            // 
            this.CancelU.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.CancelU.FlatAppearance.BorderSize = 5;
            this.CancelU.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelU.Location = new System.Drawing.Point(374, 505);
            this.CancelU.Name = "CancelU";
            this.CancelU.Size = new System.Drawing.Size(116, 62);
            this.CancelU.TabIndex = 6;
            this.CancelU.Text = "Cancel";
            this.CancelU.UseVisualStyleBackColor = true;
            this.CancelU.Click += new System.EventHandler(this.CancelU_Click);
            // 
            // txtNameU
            // 
            this.txtNameU.Location = new System.Drawing.Point(253, 184);
            this.txtNameU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameU.Name = "txtNameU";
            this.txtNameU.Size = new System.Drawing.Size(141, 31);
            this.txtNameU.TabIndex = 1;
            // 
            // txtCategoryU
            // 
            this.txtCategoryU.Location = new System.Drawing.Point(253, 268);
            this.txtCategoryU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoryU.Name = "txtCategoryU";
            this.txtCategoryU.Size = new System.Drawing.Size(141, 31);
            this.txtCategoryU.TabIndex = 2;
            // 
            // txtPriceU
            // 
            this.txtPriceU.Location = new System.Drawing.Point(253, 359);
            this.txtPriceU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriceU.Name = "txtPriceU";
            this.txtPriceU.Size = new System.Drawing.Size(141, 31);
            this.txtPriceU.TabIndex = 3;
            // 
            // UppMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(521, 608);
            this.Controls.Add(this.txtPriceU);
            this.Controls.Add(this.txtCategoryU);
            this.Controls.Add(this.txtNameU);
            this.Controls.Add(this.CancelU);
            this.Controls.Add(this.ClearU);
            this.Controls.Add(this.btnUpdateU);
            this.Controls.Add(PriceU);
            this.Controls.Add(lblCategoryU);
            this.Controls.Add(lblNameU);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "UppMenu";
            this.Text = "UppMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lbl;
        private Button btnUpdateU;
        private Button ClearU;
        private Button CancelU;
        public TextBox txtNameU;
        public TextBox txtCategoryU;
        public TextBox txtPriceU;
    }
}