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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerHomePage));
            this.btnManageDetails = new System.Windows.Forms.Button();
            this.btnCashIn = new System.Windows.Forms.Button();
            this.btncashout = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.btnChangeMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManageDetails
            // 
            this.btnManageDetails.Location = new System.Drawing.Point(371, 126);
            this.btnManageDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageDetails.Name = "btnManageDetails";
            this.btnManageDetails.Size = new System.Drawing.Size(322, 50);
            this.btnManageDetails.TabIndex = 0;
            this.btnManageDetails.Text = "Manage Employee Details";
            this.btnManageDetails.UseVisualStyleBackColor = true;
            this.btnManageDetails.Click += new System.EventHandler(this.btnManageDetails_Click);
            // 
            // btnCashIn
            // 
            this.btnCashIn.Location = new System.Drawing.Point(371, 271);
            this.btnCashIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCashIn.Name = "btnCashIn";
            this.btnCashIn.Size = new System.Drawing.Size(167, 50);
            this.btnCashIn.TabIndex = 1;
            this.btnCashIn.Text = "CashIn";
            this.btnCashIn.UseVisualStyleBackColor = true;
            this.btnCashIn.Click += new System.EventHandler(this.btnCashIn_Click);
            // 
            // btncashout
            // 
            this.btncashout.Location = new System.Drawing.Point(371, 341);
            this.btncashout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncashout.Name = "btncashout";
            this.btncashout.Size = new System.Drawing.Size(157, 50);
            this.btncashout.TabIndex = 2;
            this.btncashout.Text = "CashOut";
            this.btncashout.UseVisualStyleBackColor = true;
            this.btncashout.Click += new System.EventHandler(this.btncashout_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(371, 420);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(159, 54);
            this.Home.TabIndex = 3;
            this.Home.Text = "LogOut";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // btnChangeMenu
            // 
            this.btnChangeMenu.Location = new System.Drawing.Point(371, 203);
            this.btnChangeMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeMenu.Name = "btnChangeMenu";
            this.btnChangeMenu.Size = new System.Drawing.Size(167, 50);
            this.btnChangeMenu.TabIndex = 4;
            this.btnChangeMenu.Text = "Change Menu";
            this.btnChangeMenu.UseVisualStyleBackColor = true;
            this.btnChangeMenu.Click += new System.EventHandler(this.btnChangeMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(371, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome Manager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManagerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeMenu);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.btncashout);
            this.Controls.Add(this.btnCashIn);
            this.Controls.Add(this.btnManageDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerHomePage";
            this.Text = "ManagerHomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnManageDetails;
        private Button btnCashIn;
        private Button btncashout;
        private Button Home;
        private Button btnChangeMenu;
        private Label label1;
    }
}