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
            this.btnManageDetails.Location = new System.Drawing.Point(59, 96);
            this.btnManageDetails.Name = "btnManageDetails";
            this.btnManageDetails.Size = new System.Drawing.Size(222, 29);
            this.btnManageDetails.TabIndex = 0;
            this.btnManageDetails.Text = "Manage Employee Details";
            this.btnManageDetails.UseVisualStyleBackColor = true;
            this.btnManageDetails.Click += new System.EventHandler(this.btnManageDetails_Click);
            // 
            // btnCashIn
            // 
            this.btnCashIn.Location = new System.Drawing.Point(324, 96);
            this.btnCashIn.Name = "btnCashIn";
            this.btnCashIn.Size = new System.Drawing.Size(94, 29);
            this.btnCashIn.TabIndex = 1;
            this.btnCashIn.Text = "CashIn";
            this.btnCashIn.UseVisualStyleBackColor = true;
            this.btnCashIn.Click += new System.EventHandler(this.btnCashIn_Click);
            // 
            // btncashout
            // 
            this.btncashout.Location = new System.Drawing.Point(59, 188);
            this.btncashout.Name = "btncashout";
            this.btncashout.Size = new System.Drawing.Size(104, 40);
            this.btncashout.TabIndex = 2;
            this.btncashout.Text = "CashOut";
            this.btncashout.UseVisualStyleBackColor = true;
            this.btncashout.Click += new System.EventHandler(this.btncashout_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(204, 188);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(94, 40);
            this.Home.TabIndex = 3;
            this.Home.Text = "LogOut";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // btnChangeMenu
            // 
            this.btnChangeMenu.Location = new System.Drawing.Point(341, 188);
            this.btnChangeMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeMenu.Name = "btnChangeMenu";
            this.btnChangeMenu.Size = new System.Drawing.Size(144, 40);
            this.btnChangeMenu.TabIndex = 4;
            this.btnChangeMenu.Text = "Change Menu";
            this.btnChangeMenu.UseVisualStyleBackColor = true;
            this.btnChangeMenu.Click += new System.EventHandler(this.btnChangeMenu_Click);
            // 
            // ManagerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 339);
            this.Controls.Add(this.btnChangeMenu);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.btncashout);
            this.Controls.Add(this.btnCashIn);
            this.Controls.Add(this.btnManageDetails);
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