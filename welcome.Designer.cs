namespace ResturantPOS
{
    partial class welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDine = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnEmp = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCashin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(151, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to IndianTaste";
            // 
            // btnDine
            // 
            this.btnDine.BackColor = System.Drawing.Color.Olive;
            this.btnDine.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDine.Location = new System.Drawing.Point(180, 151);
            this.btnDine.Name = "btnDine";
            this.btnDine.Size = new System.Drawing.Size(171, 65);
            this.btnDine.TabIndex = 1;
            this.btnDine.Text = "DINE IN";
            this.btnDine.UseVisualStyleBackColor = false;
            this.btnDine.Click += new System.EventHandler(this.btnDine_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Olive;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdmin.Location = new System.Drawing.Point(180, 273);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(171, 63);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "ADMIN ";
            this.btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnEmp
            // 
            this.btnEmp.BackColor = System.Drawing.Color.Olive;
            this.btnEmp.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmp.Location = new System.Drawing.Point(375, 387);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(202, 69);
            this.btnEmp.TabIndex = 3;
            this.btnEmp.Text = "EMPLOYEE";
            this.btnEmp.UseVisualStyleBackColor = false;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.Olive;
            this.btnCash.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCash.Location = new System.Drawing.Point(375, 146);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(202, 70);
            this.btnCash.TabIndex = 4;
            this.btnCash.Text = "CASH OUT";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCashin
            // 
            this.btnCashin.BackColor = System.Drawing.Color.Olive;
            this.btnCashin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCashin.Location = new System.Drawing.Point(375, 273);
            this.btnCashin.Name = "btnCashin";
            this.btnCashin.Size = new System.Drawing.Size(202, 63);
            this.btnCashin.TabIndex = 5;
            this.btnCashin.Text = "CASH IN";
            this.btnCashin.UseVisualStyleBackColor = false;
            this.btnCashin.Click += new System.EventHandler(this.btnCashin_Click);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(793, 557);
            this.Controls.Add(this.btnCashin);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnDine);
            this.Controls.Add(this.label1);
            this.Name = "welcome";
            this.Text = "welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnDine;
        private Button btnAdmin;
        private Button btnEmp;
        private Button btnCash;
        private Button btnCashin;
    }
}