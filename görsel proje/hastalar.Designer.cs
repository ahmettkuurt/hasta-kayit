namespace görsel_proje
{
    partial class hastalar
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
            this.mobilhastaDataSet = new görsel_proje.mobilhastaDataSet();
            this.hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaTableAdapter = new görsel_proje.mobilhastaDataSetTableAdapters.hastaTableAdapter();
            this.hastaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilhastaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hastaIDDataGridViewTextBoxColumn,
            this.hastaAdiDataGridViewTextBoxColumn,
            this.hastaSoyadiDataGridViewTextBoxColumn,
            this.hastaTcDataGridViewTextBoxColumn,
            this.hastaAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // mobilhastaDataSet
            // 
            this.mobilhastaDataSet.DataSetName = "mobilhastaDataSet";
            this.mobilhastaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaBindingSource
            // 
            this.hastaBindingSource.DataMember = "hasta";
            this.hastaBindingSource.DataSource = this.mobilhastaDataSet;
            // 
            // hastaTableAdapter
            // 
            this.hastaTableAdapter.ClearBeforeFill = true;
            // 
            // hastaIDDataGridViewTextBoxColumn
            // 
            this.hastaIDDataGridViewTextBoxColumn.DataPropertyName = "hastaID";
            this.hastaIDDataGridViewTextBoxColumn.HeaderText = "hastaID";
            this.hastaIDDataGridViewTextBoxColumn.Name = "hastaIDDataGridViewTextBoxColumn";
            this.hastaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaAdiDataGridViewTextBoxColumn
            // 
            this.hastaAdiDataGridViewTextBoxColumn.DataPropertyName = "hastaAdi";
            this.hastaAdiDataGridViewTextBoxColumn.HeaderText = "hastaAdi";
            this.hastaAdiDataGridViewTextBoxColumn.Name = "hastaAdiDataGridViewTextBoxColumn";
            this.hastaAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaSoyadiDataGridViewTextBoxColumn
            // 
            this.hastaSoyadiDataGridViewTextBoxColumn.DataPropertyName = "hastaSoyadi";
            this.hastaSoyadiDataGridViewTextBoxColumn.HeaderText = "hastaSoyadi";
            this.hastaSoyadiDataGridViewTextBoxColumn.Name = "hastaSoyadiDataGridViewTextBoxColumn";
            this.hastaSoyadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaTcDataGridViewTextBoxColumn
            // 
            this.hastaTcDataGridViewTextBoxColumn.DataPropertyName = "hastaTc";
            this.hastaTcDataGridViewTextBoxColumn.HeaderText = "hastaTc";
            this.hastaTcDataGridViewTextBoxColumn.Name = "hastaTcDataGridViewTextBoxColumn";
            this.hastaTcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaAdresDataGridViewTextBoxColumn
            // 
            this.hastaAdresDataGridViewTextBoxColumn.DataPropertyName = "hastaAdres";
            this.hastaAdresDataGridViewTextBoxColumn.HeaderText = "hastaAdres";
            this.hastaAdresDataGridViewTextBoxColumn.Name = "hastaAdresDataGridViewTextBoxColumn";
            this.hastaAdresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(190, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASTALAR";
            // 
            // hastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "hastalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hastalar";
            this.Load += new System.EventHandler(this.hastalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilhastaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private mobilhastaDataSet mobilhastaDataSet;
        private System.Windows.Forms.BindingSource hastaBindingSource;
        private mobilhastaDataSetTableAdapters.hastaTableAdapter hastaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}