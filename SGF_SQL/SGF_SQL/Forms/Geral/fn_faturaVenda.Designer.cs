namespace SGF_SQL
{
    partial class fn_faturaVenda
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fn_faturaVenda));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_comercialDataSet = new SGF_SQL.db_comercialDataSet();
            this.fatura_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fatura_vendaTableAdapter = new SGF_SQL.db_comercialDataSetTableAdapters.fatura_vendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_comercialDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatura_vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Fatura_venda";
            reportDataSource1.Value = this.fatura_vendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGF_SQL.rp_fatura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(379, 634);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 103;
            // 
            // db_comercialDataSet
            // 
            this.db_comercialDataSet.DataSetName = "db_comercialDataSet";
            this.db_comercialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fatura_vendaBindingSource
            // 
            this.fatura_vendaBindingSource.DataMember = "fatura_venda";
            this.fatura_vendaBindingSource.DataSource = this.db_comercialDataSet;
            // 
            // fatura_vendaTableAdapter
            // 
            this.fatura_vendaTableAdapter.ClearBeforeFill = true;
            // 
            // fn_faturaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 634);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fn_faturaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATURA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fn_faturaVenda_FormClosing);
            this.Load += new System.EventHandler(this.fn_faturaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_comercialDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatura_vendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource fatura_vendaBindingSource;
        private db_comercialDataSet db_comercialDataSet;
        private db_comercialDataSetTableAdapters.fatura_vendaTableAdapter fatura_vendaTableAdapter;








    }
}