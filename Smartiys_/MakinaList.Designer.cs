namespace Smartiys_
{
    partial class MakinaList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.smartDataSet5 = new Smartiys_.SmartDataSet5();
            this.makinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makinaTableAdapter = new Smartiys_.SmartDataSet5TableAdapters.MakinaTableAdapter();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ozellikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodDataGridViewTextBoxColumn,
            this.seriNoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.cinsDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn,
            this.ozellikDataGridViewTextBoxColumn,
            this.grupDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.makinaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // smartDataSet5
            // 
            this.smartDataSet5.DataSetName = "SmartDataSet5";
            this.smartDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // makinaBindingSource
            // 
            this.makinaBindingSource.DataMember = "Makina";
            this.makinaBindingSource.DataSource = this.smartDataSet5;
            // 
            // makinaTableAdapter
            // 
            this.makinaTableAdapter.ClearBeforeFill = true;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            // 
            // seriNoDataGridViewTextBoxColumn
            // 
            this.seriNoDataGridViewTextBoxColumn.DataPropertyName = "SeriNo";
            this.seriNoDataGridViewTextBoxColumn.HeaderText = "SeriNo";
            this.seriNoDataGridViewTextBoxColumn.Name = "seriNoDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // cinsDataGridViewTextBoxColumn
            // 
            this.cinsDataGridViewTextBoxColumn.DataPropertyName = "Cins";
            this.cinsDataGridViewTextBoxColumn.HeaderText = "Cins";
            this.cinsDataGridViewTextBoxColumn.Name = "cinsDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // ozellikDataGridViewTextBoxColumn
            // 
            this.ozellikDataGridViewTextBoxColumn.DataPropertyName = "Ozellik";
            this.ozellikDataGridViewTextBoxColumn.HeaderText = "Ozellik";
            this.ozellikDataGridViewTextBoxColumn.Name = "ozellikDataGridViewTextBoxColumn";
            // 
            // grupDataGridViewTextBoxColumn
            // 
            this.grupDataGridViewTextBoxColumn.DataPropertyName = "Grup";
            this.grupDataGridViewTextBoxColumn.HeaderText = "Grup";
            this.grupDataGridViewTextBoxColumn.Name = "grupDataGridViewTextBoxColumn";
            // 
            // MakinaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 437);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MakinaList";
            this.Text = "MakinaList";
            this.Load += new System.EventHandler(this.MakinaList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makinaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SmartDataSet5 smartDataSet5;
        private System.Windows.Forms.BindingSource makinaBindingSource;
        private SmartDataSet5TableAdapters.MakinaTableAdapter makinaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ozellikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupDataGridViewTextBoxColumn;
    }
}