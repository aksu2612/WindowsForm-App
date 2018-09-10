namespace Smartiys_
{
    partial class BedenView
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartDataSet1 = new Smartiys_.SmartDataSet1();
            this.smartDataSet = new Smartiys_.SmartDataSet();
            this.smartDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bedenTableAdapter = new Smartiys_.SmartDataSet1TableAdapters.BedenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bedenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "Tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "Tur";
            this.turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            // 
            // bedenBindingSource
            // 
            this.bedenBindingSource.DataMember = "Beden";
            this.bedenBindingSource.DataSource = this.smartDataSet1;
            // 
            // smartDataSet1
            // 
            this.smartDataSet1.DataSetName = "SmartDataSet1";
            this.smartDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smartDataSet
            // 
            this.smartDataSet.DataSetName = "SmartDataSet";
            this.smartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smartDataSetBindingSource
            // 
            this.smartDataSetBindingSource.DataSource = this.smartDataSet;
            this.smartDataSetBindingSource.Position = 0;
            // 
            // bedenTableAdapter
            // 
            this.bedenTableAdapter.ClearBeforeFill = true;
            // 
            // BedenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 230);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "BedenView";
            this.Text = "BedenView";
            this.Load += new System.EventHandler(this.BedenView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SmartDataSet smartDataSet;
        private System.Windows.Forms.BindingSource smartDataSetBindingSource;
        private SmartDataSet1 smartDataSet1;
        private System.Windows.Forms.BindingSource bedenBindingSource;
        private SmartDataSet1TableAdapters.BedenTableAdapter bedenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
    }
}