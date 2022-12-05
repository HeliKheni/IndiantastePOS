namespace ResturantPOS
{
    partial class cashOut
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtTips = new System.Windows.Forms.TextBox();
            this.btncashOut = new System.Windows.Forms.Button();
            this.btnTotalcashOut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalCashout = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(321, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Cash Out Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(102, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Debit Card :";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lable3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable3.Location = new System.Drawing.Point(519, 121);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(146, 32);
            this.lable3.TabIndex = 2;
            this.lable3.Text = "Credit Card :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(102, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cash :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(524, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tips:";
            // 
            // txtDebit
            // 
            this.txtDebit.BackColor = System.Drawing.SystemColors.Info;
            this.txtDebit.Location = new System.Drawing.Point(248, 121);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(196, 39);
            this.txtDebit.TabIndex = 5;
            this.txtDebit.TextChanged += new System.EventHandler(this.txtDebit_TextChanged);
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.SystemColors.Info;
            this.txtCash.Location = new System.Drawing.Point(248, 213);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(196, 39);
            this.txtCash.TabIndex = 6;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // txtCredit
            // 
            this.txtCredit.BackColor = System.Drawing.SystemColors.Info;
            this.txtCredit.Location = new System.Drawing.Point(671, 114);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(191, 39);
            this.txtCredit.TabIndex = 7;
            this.txtCredit.TextChanged += new System.EventHandler(this.txtCredit_TextChanged);
            // 
            // txtTips
            // 
            this.txtTips.BackColor = System.Drawing.SystemColors.Info;
            this.txtTips.Location = new System.Drawing.Point(671, 206);
            this.txtTips.Name = "txtTips";
            this.txtTips.Size = new System.Drawing.Size(191, 39);
            this.txtTips.TabIndex = 8;
            this.txtTips.TextChanged += new System.EventHandler(this.txtTips_TextChanged);
            // 
            // btncashOut
            // 
            this.btncashOut.BackColor = System.Drawing.Color.Khaki;
            this.btncashOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncashOut.Location = new System.Drawing.Point(422, 526);
            this.btncashOut.Name = "btncashOut";
            this.btncashOut.Size = new System.Drawing.Size(140, 49);
            this.btncashOut.TabIndex = 9;
            this.btncashOut.Text = "CASHOUT";
            this.btncashOut.UseVisualStyleBackColor = false;
            // 
            // btnTotalcashOut
            // 
            this.btnTotalcashOut.BackColor = System.Drawing.Color.Khaki;
            this.btnTotalcashOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTotalcashOut.Location = new System.Drawing.Point(422, 326);
            this.btnTotalcashOut.Name = "btnTotalcashOut";
            this.btnTotalcashOut.Size = new System.Drawing.Size(146, 51);
            this.btnTotalcashOut.TabIndex = 11;
            this.btnTotalcashOut.Text = "TOTAL";
            this.btnTotalcashOut.UseVisualStyleBackColor = false;
            this.btnTotalcashOut.Click += new System.EventHandler(this.btnTotalcashOut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total :";
            // 
            // txtTotalCashout
            // 
            this.txtTotalCashout.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalCashout.Location = new System.Drawing.Point(408, 416);
            this.txtTotalCashout.Name = "txtTotalCashout";
            this.txtTotalCashout.Size = new System.Drawing.Size(213, 39);
            this.txtTotalCashout.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(739, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cashOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(925, 618);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotalCashout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTotalcashOut);
            this.Controls.Add(this.btncashOut);
            this.Controls.Add(this.txtTips);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.txtDebit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cashOut";
            this.Text = "cashOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lable3;
        private Label label4;
        private Label label5;
        private TextBox txtDebit;
        private TextBox txtCash;
        private TextBox txtCredit;
        private TextBox txtTips;
        private Button btncashOut;
        private Button btnTotalcashOut;
        private Label label6;
        private TextBox txtTotalCashout;
        private Button button1;
    }
}