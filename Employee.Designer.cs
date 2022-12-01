namespace ResturantPOS
{
    partial class Employee
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
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnAddEmp.FlatAppearance.BorderSize = 5;
            this.btnAddEmp.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddEmp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddEmp.Location = new System.Drawing.Point(1, 0);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(102, 45);
            this.btnAddEmp.TabIndex = 2;
            this.btnAddEmp.Text = "Add ";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(107, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(213, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearch.Location = new System.Drawing.Point(356, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 15);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search By";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(444, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(589, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EId,
            this.EName,
            this.EEmail,
            this.EPhone,
            this.EHours});
            this.dataGridView1.Location = new System.Drawing.Point(85, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(543, 271);
            this.dataGridView1.TabIndex = 9;
            // 
            // EId
            // 
            this.EId.HeaderText = "ID";
            this.EId.Name = "EId";
            // 
            // EName
            // 
            this.EName.HeaderText = "Name";
            this.EName.Name = "EName";
            // 
            // EEmail
            // 
            this.EEmail.HeaderText = "Email";
            this.EEmail.Name = "EEmail";
            // 
            // EPhone
            // 
            this.EPhone.HeaderText = "Phone";
            this.EPhone.Name = "EPhone";
            // 
            // EHours
            // 
            this.EHours.HeaderText = "Hours";
            this.EHours.Name = "EHours";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddEmp);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddEmp;
        private Button button2;
        private Button button1;
        private Label lblSearch;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn EId;
        private DataGridViewTextBoxColumn EName;
        private DataGridViewTextBoxColumn EEmail;
        private DataGridViewTextBoxColumn EPhone;
        private DataGridViewTextBoxColumn EHours;
    }
}