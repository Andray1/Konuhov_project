namespace Konuhov_project
{
    partial class Form3
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VkladuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Konuhov_projectDataSet = new Konuhov_project.Konuhov_projectDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VkladuTableAdapter = new Konuhov_project.Konuhov_projectDataSetTableAdapters.VkladuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VkladuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Konuhov_projectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VkladuBindingSource
            // 
            this.VkladuBindingSource.DataMember = "Vkladu";
            this.VkladuBindingSource.DataSource = this.Konuhov_projectDataSet;
            // 
            // Konuhov_projectDataSet
            // 
            this.Konuhov_projectDataSet.DataSetName = "Konuhov_projectDataSet";
            this.Konuhov_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.VkladuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Konuhov_project.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(677, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // VkladuTableAdapter
            // 
            this.VkladuTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 420);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form3";
            this.Text = "Виды вкладов ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VkladuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Konuhov_projectDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VkladuBindingSource;
        private Konuhov_projectDataSet Konuhov_projectDataSet;
        private Konuhov_projectDataSetTableAdapters.VkladuTableAdapter VkladuTableAdapter;
    }
}