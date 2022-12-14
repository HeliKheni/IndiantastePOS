namespace ResturantPOS
{
    partial class janki
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddM = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.CombosearchMenu = new System.Windows.Forms.ComboBox();
            this.txtSearchMenu = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(154, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(623, 430);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.celClick);
            // 
            // btnAddM
            // 
            this.btnAddM.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnAddM.FlatAppearance.BorderSize = 5;
            this.btnAddM.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddM.Location = new System.Drawing.Point(12, 15);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(146, 75);
            this.btnAddM.TabIndex = 11;
            this.btnAddM.Text = "Add";
            this.btnAddM.UseVisualStyleBackColor = true;
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.FlatAppearance.BorderSize = 5;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(164, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 75);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearch.Location = new System.Drawing.Point(487, 40);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(97, 25);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search By";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // CombosearchMenu
            // 
            this.CombosearchMenu.FormattingEnabled = true;
            this.CombosearchMenu.Items.AddRange(new object[] {
            "ID",
            "Category",
            "Name",
            "Price",
            "All"});
            this.CombosearchMenu.Location = new System.Drawing.Point(592, 37);
            this.CombosearchMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CombosearchMenu.Name = "CombosearchMenu";
            this.CombosearchMenu.Size = new System.Drawing.Size(151, 33);
            this.CombosearchMenu.TabIndex = 14;
            // 
            // txtSearchMenu
            // 
            this.txtSearchMenu.Location = new System.Drawing.Point(751, 37);
            this.txtSearchMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchMenu.Name = "txtSearchMenu";
            this.txtSearchMenu.Size = new System.Drawing.Size(141, 31);
            this.txtSearchMenu.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnSearch.FlatAppearance.BorderSize = 5;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(899, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 75);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnDelete.FlatAppearance.BorderSize = 5;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(316, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 75);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(832, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 75);
            this.button1.TabIndex = 18;
            this.button1.Text = "Change Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // janki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1046, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchMenu);
            this.Controls.Add(this.CombosearchMenu);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddM);
            this.Controls.Add(this.dataGridView1);
            this.Name = "janki";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.janki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView dataGridView1;
        private Button btnAddM;
        private Button btnUpdate;
        private Label lblSearch;
        private ComboBox CombosearchMenu;
        private TextBox txtSearchMenu;
        private Button btnSearch;
        private Button btnDelete;
        private Button button1;
    }
}