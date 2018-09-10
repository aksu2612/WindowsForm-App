namespace Smartiys_
{
    partial class ModelPage
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
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxkapasiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tanimiDataGridViewTextBoxColumn,
            this.maxkapasiteDataGridViewTextBoxColumn,
            this.standartDataGridViewTextBoxColumn,
            this.koduDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // smartDataSet
            // 
        
            // modelBindingSource
            //  
      
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanimiDataGridViewTextBoxColumn
            // 
            this.tanimiDataGridViewTextBoxColumn.DataPropertyName = "Tanimi";
            this.tanimiDataGridViewTextBoxColumn.HeaderText = "Tanimi";
            this.tanimiDataGridViewTextBoxColumn.Name = "tanimiDataGridViewTextBoxColumn";
            // 
            // maxkapasiteDataGridViewTextBoxColumn
            // 
            this.maxkapasiteDataGridViewTextBoxColumn.DataPropertyName = "maxkapasite";
            this.maxkapasiteDataGridViewTextBoxColumn.HeaderText = "maxkapasite";
            this.maxkapasiteDataGridViewTextBoxColumn.Name = "maxkapasiteDataGridViewTextBoxColumn";
            // 
            // standartDataGridViewTextBoxColumn
            // 
            this.standartDataGridViewTextBoxColumn.DataPropertyName = "Standart";
            this.standartDataGridViewTextBoxColumn.HeaderText = "Standart";
            this.standartDataGridViewTextBoxColumn.Name = "standartDataGridViewTextBoxColumn";
            // 
            // koduDataGridViewTextBoxColumn
            // 
            this.koduDataGridViewTextBoxColumn.DataPropertyName = "Kodu";
            this.koduDataGridViewTextBoxColumn.HeaderText = "Kodu";
            this.koduDataGridViewTextBoxColumn.Name = "koduDataGridViewTextBoxColumn";
            // 
            // ModelPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 414);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModelPage";
            this.Text = "ModelPage";
            this.Load += new System.EventHandler(this.ModelPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxkapasiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koduDataGridViewTextBoxColumn;
    }
}