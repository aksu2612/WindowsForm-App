namespace Smartiys_
{
    partial class PersonelLiist
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
            this.smartDataSet4 = new Smartiys_.SmartDataSet4();
            this.calisanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calisanTableAdapter = new Smartiys_.SmartDataSet4TableAdapters.CalisanTableAdapter();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.askerlikDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mezuniyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanGrubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.askerlikDataGridViewCheckBoxColumn,
            this.mezuniyetDataGridViewTextBoxColumn,
            this.tCDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.kanGrubuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calisanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(927, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // smartDataSet4
            // 
            this.smartDataSet4.DataSetName = "SmartDataSet4";
            this.smartDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calisanBindingSource
            // 
            this.calisanBindingSource.DataMember = "Calisan";
            this.calisanBindingSource.DataSource = this.smartDataSet4;
            // 
            // calisanTableAdapter
            // 
            this.calisanTableAdapter.ClearBeforeFill = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // askerlikDataGridViewCheckBoxColumn
            // 
            this.askerlikDataGridViewCheckBoxColumn.DataPropertyName = "Askerlik";
            this.askerlikDataGridViewCheckBoxColumn.HeaderText = "Askerlik";
            this.askerlikDataGridViewCheckBoxColumn.Name = "askerlikDataGridViewCheckBoxColumn";
            // 
            // mezuniyetDataGridViewTextBoxColumn
            // 
            this.mezuniyetDataGridViewTextBoxColumn.DataPropertyName = "Mezuniyet";
            this.mezuniyetDataGridViewTextBoxColumn.HeaderText = "Mezuniyet";
            this.mezuniyetDataGridViewTextBoxColumn.Name = "mezuniyetDataGridViewTextBoxColumn";
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // kanGrubuDataGridViewTextBoxColumn
            // 
            this.kanGrubuDataGridViewTextBoxColumn.DataPropertyName = "KanGrubu";
            this.kanGrubuDataGridViewTextBoxColumn.HeaderText = "KanGrubu";
            this.kanGrubuDataGridViewTextBoxColumn.Name = "kanGrubuDataGridViewTextBoxColumn";
            // 
            // button1
            // 
        
        
            // 
            // PersonelLiist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PersonelLiist";
            this.Text = "PersonelLiist";
            this.Load += new System.EventHandler(this.PersonelLiist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SmartDataSet4 smartDataSet4;
        private System.Windows.Forms.BindingSource calisanBindingSource;
        private SmartDataSet4TableAdapters.CalisanTableAdapter calisanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn askerlikDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mezuniyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanGrubuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}