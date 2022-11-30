namespace ResturantPOS
{
    partial class EmployeeHomePage
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnDineIn = new System.Windows.Forms.Button();
            this.btnChangeMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(90, 45);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(115, 45);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.Location = new System.Drawing.Point(90, 126);
            this.btnOrderHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(115, 42);
            this.btnOrderHistory.TabIndex = 1;
            this.btnOrderHistory.Text = "Order History";
            this.btnOrderHistory.UseVisualStyleBackColor = true;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnDineIn
            // 
            this.btnDineIn.Location = new System.Drawing.Point(254, 45);
            this.btnDineIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnDineIn.Name = "btnDineIn";
            this.btnDineIn.Size = new System.Drawing.Size(90, 45);
            this.btnDineIn.TabIndex = 2;
            this.btnDineIn.Text = "Dine IN";
            this.btnDineIn.UseVisualStyleBackColor = true;
            this.btnDineIn.Click += new System.EventHandler(this.btnDineIn_Click);
            // 
            // btnChangeMenu
            // 
            this.btnChangeMenu.Location = new System.Drawing.Point(254, 130);
            this.btnChangeMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeMenu.Name = "btnChangeMenu";
            this.btnChangeMenu.Size = new System.Drawing.Size(134, 35);
            this.btnChangeMenu.TabIndex = 3;
            this.btnChangeMenu.Text = "Change Menu";
            this.btnChangeMenu.UseVisualStyleBackColor = true;
            this.btnChangeMenu.Click += new System.EventHandler(this.btnChangeMenu_Click);
            // 
            // EmployeeHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.btnChangeMenu);
            this.Controls.Add(this.btnDineIn);
            this.Controls.Add(this.btnOrderHistory);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeHomePage";
            this.Text = "EmployeeHomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLogOut;
        private Button btnOrderHistory;
        private Button btnDineIn;
        private Button btnChangeMenu;
    }
}