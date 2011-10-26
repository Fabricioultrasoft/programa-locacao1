namespace NovaOpcao
{
    partial class Relatorio_Produto
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NOVAOPCAODBDataSet = new NovaOpcao.NOVAOPCAODBDataSet();
            this.PRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRODUTOSTableAdapter = new NovaOpcao.NOVAOPCAODBDataSetTableAdapters.PRODUTOSTableAdapter();
            this.NOVAOPCAODBDataSet4 = new NovaOpcao.NOVAOPCAODBDataSet4();
            ((System.ComponentModel.ISupportInitialize)(this.NOVAOPCAODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOVAOPCAODBDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.DarkGray;
            reportDataSource1.Name = "Produtos";
            reportDataSource1.Value = this.PRODUTOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NovaOpcao.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(790, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // NOVAOPCAODBDataSet
            // 
            this.NOVAOPCAODBDataSet.DataSetName = "NOVAOPCAODBDataSet";
            this.NOVAOPCAODBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PRODUTOSBindingSource
            // 
            this.PRODUTOSBindingSource.DataMember = "PRODUTOS";
            this.PRODUTOSBindingSource.DataSource = this.NOVAOPCAODBDataSet;
            // 
            // PRODUTOSTableAdapter
            // 
            this.PRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // NOVAOPCAODBDataSet4
            // 
            this.NOVAOPCAODBDataSet4.DataSetName = "NOVAOPCAODBDataSet4";
            this.NOVAOPCAODBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Relatorio_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 446);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Relatorio_Produto";
            this.Text = "Relatorio_Produto";
            this.Load += new System.EventHandler(this.Relatorio_Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NOVAOPCAODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOVAOPCAODBDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PRODUTOSBindingSource;
        private NOVAOPCAODBDataSet NOVAOPCAODBDataSet;
        private NOVAOPCAODBDataSetTableAdapters.PRODUTOSTableAdapter PRODUTOSTableAdapter;
        private NOVAOPCAODBDataSet4 NOVAOPCAODBDataSet4;
    }
}