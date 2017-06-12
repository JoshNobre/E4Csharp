namespace E4DataBinding
{
    partial class Adresse
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
            this.bindingSourceAdresse = new System.Windows.Forms.BindingSource(this.components);
            this.e4DataBindingDataSet = new E4DataBinding.E4DataBindingDataSet();
            this.adresseTableAdapter = new E4DataBinding.E4DataBindingDataSetTableAdapters.AdresseTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GestionAdresse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.e4DataBindingDataSet1 = new E4DataBinding.E4DataBindingDataSet1();
            this.e4DataBindingDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adresseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adresseTableAdapter1 = new E4DataBinding.E4DataBindingDataSet1TableAdapters.AdresseTableAdapter();
            this.idadresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpadresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeadresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysadresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAdresse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceAdresse
            // 
            this.bindingSourceAdresse.DataMember = "Adresse";
            this.bindingSourceAdresse.DataSource = this.e4DataBindingDataSet;
            // 
            // e4DataBindingDataSet
            // 
            this.e4DataBindingDataSet.DataSetName = "E4DataBindingDataSet";
            this.e4DataBindingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adresseTableAdapter
            // 
            this.adresseTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idadresseDataGridViewTextBoxColumn,
            this.adresse1DataGridViewTextBoxColumn,
            this.adresse2DataGridViewTextBoxColumn,
            this.cpadresseDataGridViewTextBoxColumn,
            this.villeadresseDataGridViewTextBoxColumn,
            this.paysadresseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adresseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 210);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GestionAdresse
            // 
            this.GestionAdresse.Location = new System.Drawing.Point(315, 228);
            this.GestionAdresse.Name = "GestionAdresse";
            this.GestionAdresse.Size = new System.Drawing.Size(121, 34);
            this.GestionAdresse.TabIndex = 1;
            this.GestionAdresse.Text = "GestionAdresse";
            this.GestionAdresse.UseVisualStyleBackColor = true;
            this.GestionAdresse.Click += new System.EventHandler(this.GestionAdresse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // e4DataBindingDataSet1
            // 
            this.e4DataBindingDataSet1.DataSetName = "E4DataBindingDataSet1";
            this.e4DataBindingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e4DataBindingDataSet1BindingSource
            // 
            this.e4DataBindingDataSet1BindingSource.DataSource = this.e4DataBindingDataSet1;
            this.e4DataBindingDataSet1BindingSource.Position = 0;
            // 
            // adresseBindingSource
            // 
            this.adresseBindingSource.DataMember = "Adresse";
            this.adresseBindingSource.DataSource = this.e4DataBindingDataSet1;
            // 
            // adresseTableAdapter1
            // 
            this.adresseTableAdapter1.ClearBeforeFill = true;
            // 
            // idadresseDataGridViewTextBoxColumn
            // 
            this.idadresseDataGridViewTextBoxColumn.DataPropertyName = "id_adresse";
            this.idadresseDataGridViewTextBoxColumn.HeaderText = "id_adresse";
            this.idadresseDataGridViewTextBoxColumn.Name = "idadresseDataGridViewTextBoxColumn";
            this.idadresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.idadresseDataGridViewTextBoxColumn.Width = 107;
            // 
            // adresse1DataGridViewTextBoxColumn
            // 
            this.adresse1DataGridViewTextBoxColumn.DataPropertyName = "adresse1";
            this.adresse1DataGridViewTextBoxColumn.HeaderText = "adresse1";
            this.adresse1DataGridViewTextBoxColumn.Name = "adresse1DataGridViewTextBoxColumn";
            this.adresse1DataGridViewTextBoxColumn.Width = 96;
            // 
            // adresse2DataGridViewTextBoxColumn
            // 
            this.adresse2DataGridViewTextBoxColumn.DataPropertyName = "adresse2";
            this.adresse2DataGridViewTextBoxColumn.HeaderText = "adresse2";
            this.adresse2DataGridViewTextBoxColumn.Name = "adresse2DataGridViewTextBoxColumn";
            this.adresse2DataGridViewTextBoxColumn.Width = 96;
            // 
            // cpadresseDataGridViewTextBoxColumn
            // 
            this.cpadresseDataGridViewTextBoxColumn.DataPropertyName = "cp_adresse";
            this.cpadresseDataGridViewTextBoxColumn.HeaderText = "cp_adresse";
            this.cpadresseDataGridViewTextBoxColumn.Name = "cpadresseDataGridViewTextBoxColumn";
            this.cpadresseDataGridViewTextBoxColumn.Width = 111;
            // 
            // villeadresseDataGridViewTextBoxColumn
            // 
            this.villeadresseDataGridViewTextBoxColumn.DataPropertyName = "ville_adresse";
            this.villeadresseDataGridViewTextBoxColumn.HeaderText = "ville_adresse";
            this.villeadresseDataGridViewTextBoxColumn.Name = "villeadresseDataGridViewTextBoxColumn";
            this.villeadresseDataGridViewTextBoxColumn.Width = 120;
            // 
            // paysadresseDataGridViewTextBoxColumn
            // 
            this.paysadresseDataGridViewTextBoxColumn.DataPropertyName = "pays_adresse";
            this.paysadresseDataGridViewTextBoxColumn.HeaderText = "pays_adresse";
            this.paysadresseDataGridViewTextBoxColumn.Name = "paysadresseDataGridViewTextBoxColumn";
            this.paysadresseDataGridViewTextBoxColumn.Width = 126;
            // 
            // Adresse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 268);
            this.Controls.Add(this.GestionAdresse);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Adresse";
            this.Text = "Adresse";
            this.Load += new System.EventHandler(this.Adresse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAdresse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceAdresse;
        private E4DataBindingDataSet e4DataBindingDataSet;
        private E4DataBindingDataSetTableAdapters.AdresseTableAdapter adresseTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GestionAdresse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource e4DataBindingDataSet1BindingSource;
        private E4DataBindingDataSet1 e4DataBindingDataSet1;
        private System.Windows.Forms.BindingSource adresseBindingSource;
        private E4DataBindingDataSet1TableAdapters.AdresseTableAdapter adresseTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpadresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeadresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysadresseDataGridViewTextBoxColumn;
    }
}