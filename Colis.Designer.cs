namespace E4DataBinding
{
    partial class Colis
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
            this.gestionColis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numcolisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poidscolisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateenvoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceColis = new System.Windows.Forms.BindingSource(this.components);
            this.e4DataBindingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e4DataBindingDataSet = new E4DataBinding.E4DataBindingDataSet();
            this.colisTableAdapter = new E4DataBinding.E4DataBindingDataSetTableAdapters.ColisTableAdapter();
            this.colisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e4DataBindingDataSet1 = new E4DataBinding.E4DataBindingDataSet1();
            this.colisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colisTableAdapter1 = new E4DataBinding.E4DataBindingDataSet1TableAdapters.ColisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceColis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colisBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gestionColis
            // 
            this.gestionColis.Location = new System.Drawing.Point(166, 268);
            this.gestionColis.Name = "gestionColis";
            this.gestionColis.Size = new System.Drawing.Size(185, 32);
            this.gestionColis.TabIndex = 0;
            this.gestionColis.Text = "Gestion Colis";
            this.gestionColis.UseVisualStyleBackColor = true;
            this.gestionColis.Click += new System.EventHandler(this.gestionColis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numcolisDataGridViewTextBoxColumn,
            this.poidscolisDataGridViewTextBoxColumn,
            this.dateenvoiDataGridViewTextBoxColumn,
            this.idcommandeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.colisBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 249);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numcolisDataGridViewTextBoxColumn
            // 
            this.numcolisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numcolisDataGridViewTextBoxColumn.DataPropertyName = "num_colis";
            this.numcolisDataGridViewTextBoxColumn.HeaderText = "num_colis";
            this.numcolisDataGridViewTextBoxColumn.Name = "numcolisDataGridViewTextBoxColumn";
            this.numcolisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poidscolisDataGridViewTextBoxColumn
            // 
            this.poidscolisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.poidscolisDataGridViewTextBoxColumn.DataPropertyName = "poids_colis";
            this.poidscolisDataGridViewTextBoxColumn.HeaderText = "poids_colis";
            this.poidscolisDataGridViewTextBoxColumn.Name = "poidscolisDataGridViewTextBoxColumn";
            this.poidscolisDataGridViewTextBoxColumn.Width = 107;
            // 
            // dateenvoiDataGridViewTextBoxColumn
            // 
            this.dateenvoiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateenvoiDataGridViewTextBoxColumn.DataPropertyName = "date_envoi";
            this.dateenvoiDataGridViewTextBoxColumn.HeaderText = "date_envoi";
            this.dateenvoiDataGridViewTextBoxColumn.Name = "dateenvoiDataGridViewTextBoxColumn";
            this.dateenvoiDataGridViewTextBoxColumn.Width = 107;
            // 
            // idcommandeDataGridViewTextBoxColumn
            // 
            this.idcommandeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idcommandeDataGridViewTextBoxColumn.DataPropertyName = "id_commande";
            this.idcommandeDataGridViewTextBoxColumn.HeaderText = "id_commande";
            this.idcommandeDataGridViewTextBoxColumn.Name = "idcommandeDataGridViewTextBoxColumn";
            this.idcommandeDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceColis
            // 
            this.bindingSourceColis.DataMember = "Colis";
            this.bindingSourceColis.DataSource = this.e4DataBindingDataSetBindingSource;
            // 
            // e4DataBindingDataSetBindingSource
            // 
            this.e4DataBindingDataSetBindingSource.DataSource = this.e4DataBindingDataSet;
            this.e4DataBindingDataSetBindingSource.Position = 0;
            // 
            // e4DataBindingDataSet
            // 
            this.e4DataBindingDataSet.DataSetName = "E4DataBindingDataSet";
            this.e4DataBindingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colisTableAdapter
            // 
            this.colisTableAdapter.ClearBeforeFill = true;
            // 
            // colisBindingSource
            // 
            this.colisBindingSource.DataMember = "Colis";
            this.colisBindingSource.DataSource = this.e4DataBindingDataSetBindingSource;
            // 
            // e4DataBindingDataSet1
            // 
            this.e4DataBindingDataSet1.DataSetName = "E4DataBindingDataSet1";
            this.e4DataBindingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colisBindingSource1
            // 
            this.colisBindingSource1.DataMember = "Colis";
            this.colisBindingSource1.DataSource = this.e4DataBindingDataSet1;
            // 
            // colisTableAdapter1
            // 
            this.colisTableAdapter1.ClearBeforeFill = true;
            // 
            // Colis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 312);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gestionColis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Colis";
            this.Text = "Colis";
            this.Load += new System.EventHandler(this.Colis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceColis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colisBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gestionColis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource e4DataBindingDataSetBindingSource;
        private E4DataBindingDataSet e4DataBindingDataSet;
        private System.Windows.Forms.BindingSource bindingSourceColis;
        private E4DataBindingDataSetTableAdapters.ColisTableAdapter colisTableAdapter;
        private System.Windows.Forms.BindingSource colisBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcolisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poidscolisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateenvoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcommandeDataGridViewTextBoxColumn;
        private E4DataBindingDataSet1 e4DataBindingDataSet1;
        private System.Windows.Forms.BindingSource colisBindingSource1;
        private E4DataBindingDataSet1TableAdapters.ColisTableAdapter colisTableAdapter1;
    }
}