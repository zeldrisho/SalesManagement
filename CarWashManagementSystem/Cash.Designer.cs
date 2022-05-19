
namespace CarWashManagementSystem
{
    partial class Cash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cash));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.panelCash = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTransno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.dgvCash = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCash)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddService);
            this.panel1.Controls.Add(this.btnAddCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnAddService
            // 
            this.btnAddService.Enabled = false;
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Image = ((System.Drawing.Image)(resources.GetObject("btnAddService.Image")));
            this.btnAddService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddService.Location = new System.Drawing.Point(159, 3);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(126, 50);
            this.btnAddService.TabIndex = 4;
            this.btnAddService.Text = "Services";
            this.btnAddService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.Image")));
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.Location = new System.Drawing.Point(3, 3);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(126, 50);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Customer";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // panelCash
            // 
            this.panelCash.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCash.Location = new System.Drawing.Point(0, 60);
            this.panelCash.Name = "panelCash";
            this.panelCash.Size = new System.Drawing.Size(967, 1);
            this.panelCash.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(967, 10);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lblTransno);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnCash);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 424);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(967, 61);
            this.panel4.TabIndex = 29;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(741, 22);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 19);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "0.00";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.label3.Location = new System.Drawing.Point(539, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Price:";
            // 
            // lblTransno
            // 
            this.lblTransno.AutoSize = true;
            this.lblTransno.Location = new System.Drawing.Point(189, 21);
            this.lblTransno.Name = "lblTransno";
            this.lblTransno.Size = new System.Drawing.Size(89, 20);
            this.lblTransno.TabIndex = 7;
            this.lblTransno.Text = "0000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Transaction no :";
            // 
            // btnCash
            // 
            this.btnCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCash.Enabled = false;
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Image = ((System.Drawing.Image)(resources.GetObject("btnCash.Image")));
            this.btnCash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCash.Location = new System.Drawing.Point(869, 6);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(86, 50);
            this.btnCash.TabIndex = 5;
            this.btnCash.Text = "Cash";
            this.btnCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // dgvCash
            // 
            this.dgvCash.AllowUserToAddRows = false;
            this.dgvCash.AllowUserToDeleteRows = false;
            this.dgvCash.AllowUserToResizeColumns = false;
            this.dgvCash.AllowUserToResizeRows = false;
            this.dgvCash.BackgroundColor = System.Drawing.Color.White;
            this.dgvCash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCash.ColumnHeadersHeight = 35;
            this.dgvCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column11,
            this.Column3,
            this.Column5,
            this.Column10,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column4,
            this.Column9,
            this.Delete});
            this.dgvCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCash.EnableHeadersVisualStyles = false;
            this.dgvCash.Location = new System.Drawing.Point(0, 71);
            this.dgvCash.Name = "dgvCash";
            this.dgvCash.RowHeadersVisible = false;
            this.dgvCash.Size = new System.Drawing.Size(967, 353);
            this.dgvCash.TabIndex = 30;
            this.dgvCash.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCash_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 53;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 49;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.HeaderText = "Transno";
            this.Column11.Name = "Column11";
            this.Column11.Width = 86;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Customer";
            this.Column3.Name = "Column3";
            this.Column3.Width = 102;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Car No.";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            this.Column5.Width = 90;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "Car Model";
            this.Column10.Name = "Column10";
            this.Column10.Width = 111;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Vehicle Type";
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Class";
            this.Column7.Name = "Column7";
            this.Column7.Width = 69;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column8.HeaderText = "Services";
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.Width = 69;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "Date";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            this.Column9.Width = 70;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // Cash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(967, 485);
            this.Controls.Add(this.dgvCash);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelCash);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cash";
            this.Text = "Cash";
            this.Load += new System.EventHandler(this.Cash_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panelCash;
        public System.Windows.Forms.Label lblTransno;
        public System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        public System.Windows.Forms.DataGridView dgvCash;
        public System.Windows.Forms.Button btnAddService;
        public System.Windows.Forms.Button btnAddCustomer;
        public System.Windows.Forms.Label lblTotal;
    }
}