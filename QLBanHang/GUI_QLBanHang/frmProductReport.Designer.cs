namespace GUI_QLBanHang
{
    partial class frmProductReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductReport));
            this.HangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductDataSet = new GUI_QLBanHang.ProductDataSet();
            this.HangTableAdapter = new GUI_QLBanHang.ProductDataSetTableAdapters.HangTableAdapter();
            this.rptProductViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.HangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // HangBindingSource
            // 
            this.HangBindingSource.DataMember = "Hang";
            this.HangBindingSource.DataSource = this.ProductDataSet;
            // 
            // ProductDataSet
            // 
            this.ProductDataSet.DataSetName = "ProductDataSet";
            this.ProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HangTableAdapter
            // 
            this.HangTableAdapter.ClearBeforeFill = true;
            // 
            // rptProductViewer
            // 
            this.rptProductViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptProductViewer.Location = new System.Drawing.Point(0, 0);
            this.rptProductViewer.Name = "rptProductViewer";
            this.rptProductViewer.ServerReport.BearerToken = null;
            this.rptProductViewer.Size = new System.Drawing.Size(800, 450);
            this.rptProductViewer.TabIndex = 0;
            // 
            // frmProductReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptProductViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource HangBindingSource;
        private ProductDataSet ProductDataSet;
        private ProductDataSetTableAdapters.HangTableAdapter HangTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rptProductViewer;
    }
}