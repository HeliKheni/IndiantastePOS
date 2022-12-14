namespace ResturantPOS
{
    partial class ManagerHomePage
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
            this.btnManageDetails = new System.Windows.Forms.Button();
            this.btnCashIn = new System.Windows.Forms.Button();
            this.btncashout = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.btnChangeMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageDetails
            // 
            this.btnManageDetails.Location = new System.Drawing.Point(74, 120);
            this.btnManageDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageDetails.Name = "btnManageDetails";
            this.btnManageDetails.Size = new System.Drawing.Size(278, 36);
            this.btnManageDetails.TabIndex = 0;
            this.btnManageDetails.Text = "Manage Employee Details";
            this.btnManageDetails.UseVisualStyleBackColor = true;
            this.btnManageDetails.Click += new System.EventHandler(this.btnManageDetails_Click);
            // 
            // btnCashIn
            // 
            this.btnCashIn.Location = new System.Drawing.Point(405, 120);
            this.btnCashIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCashIn.Name = "btnCashIn";
            this.btnCashIn.Size = new System.Drawing.Size(118, 36);
            this.btnCashIn.TabIndex = 1;
            this.btnCashIn.Text = "CashIn";
            this.btnCashIn.UseVisualStyleBackColor = true;
            this.btnCashIn.Click += new System.EventHandler(this.btnCashIn_Click);
            // 
            // btncashout
            // 
            this.btncashout.Location = new System.Drawing.Point(74, 235);
            this.btncashout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncashout.Name = "btncashout";
            this.btncashout.Size = new System.Drawing.Size(118, 36);
            this.btncashout.TabIndex = 2;
            this.btncashout.Text = "CashOut";
            this.btncashout.UseVisualStyleBackColor = true;
            this.btncashout.Click += new System.EventHandler(this.btncashout_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(255, 235);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(118, 36);
            this.Home.TabIndex = 3;
            this.Home.Text = "LogOut";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // btnChangeMenu
            // 
            this.btnChangeMenu.Location = new System.Drawing.Point(426, 235);
            this.btnChangeMenu.Name = "btnChangeMenu";
            this.btnChangeMenu.Size = new System.Drawing.Size(112, 34);
            this.btnChangeMenu.TabIndex = 4;
            this.btnChangeMenu.Text = "Change Menu";
            this.btnChangeMenu.UseVisualStyleBackColor = true;
            this.btnChangeMenu.Click += new System.EventHandler(this.btnChangeMenu_Click);
            // 
            // ManagerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 424);
            this.Controls.Add(this.btnChangeMenu);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.btncashout);
            this.Controls.Add(this.btnCashIn);
            this.Controls.Add(this.btnManageDetails);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerHomePage";
            this.Text = "ManagerHomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnManageDetails;
        private Button btnCashIn;
        private Button btncashout;
        private Button Home;
        private Button btnChangeMenu;
    }
}