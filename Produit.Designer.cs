namespace E4DataBinding
{
    partial class Produit
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
            this.idproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qrestestockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceProduits = new System.Windows.Forms.BindingSource(this.components);
            this.e4DataBindingDataSet = new E4DataBinding.E4DataBindingDataSet();
            this.produitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitsTableAdapter = new E4DataBinding.E4DataBindingDataSetTableAdapters.ProduitsTableAdapter();
            this.gestionProduits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduitDataGridViewTextBoxColumn,
            this.nomproduitDataGridViewTextBoxColumn,
            this.prixproduitDataGridViewTextBoxColumn,
            this.qrestestockDataGridViewTextBoxColumn,
            this.idcategorieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceProduits;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idproduitDataGridViewTextBoxColumn
            // 
            this.idproduitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idproduitDataGridViewTextBoxColumn.DataPropertyName = "id_produit";
            this.idproduitDataGridViewTextBoxColumn.HeaderText = "id_produit";
            this.idproduitDataGridViewTextBoxColumn.Name = "idproduitDataGridViewTextBoxColumn";
            this.idproduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomproduitDataGridViewTextBoxColumn
            // 
            this.nomproduitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomproduitDataGridViewTextBoxColumn.DataPropertyName = "nom_produit";
            this.nomproduitDataGridViewTextBoxColumn.HeaderText = "nom_produit";
            this.nomproduitDataGridViewTextBoxColumn.Name = "nomproduitDataGridViewTextBoxColumn";
            this.nomproduitDataGridViewTextBoxColumn.Width = 116;
            // 
            // prixproduitDataGridViewTextBoxColumn
            // 
            this.prixproduitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prixproduitDataGridViewTextBoxColumn.DataPropertyName = "prix_produit";
            this.prixproduitDataGridViewTextBoxColumn.HeaderText = "prix_produit";
            this.prixproduitDataGridViewTextBoxColumn.Name = "prixproduitDataGridViewTextBoxColumn";
            this.prixproduitDataGridViewTextBoxColumn.Width = 111;
            // 
            // qrestestockDataGridViewTextBoxColumn
            // 
            this.qrestestockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qrestestockDataGridViewTextBoxColumn.DataPropertyName = "qrestestock";
            this.qrestestockDataGridViewTextBoxColumn.HeaderText = "qrestestock";
            this.qrestestockDataGridViewTextBoxColumn.Name = "qrestestockDataGridViewTextBoxColumn";
            this.qrestestockDataGridViewTextBoxColumn.Width = 110;
            // 
            // idcategorieDataGridViewTextBoxColumn
            // 
            this.idcategorieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idcategorieDataGridViewTextBoxColumn.DataPropertyName = "id_categorie";
            this.idcategorieDataGridViewTextBoxColumn.HeaderText = "id_categorie";
            this.idcategorieDataGridViewTextBoxColumn.Name = "idcategorieDataGridViewTextBoxColumn";
            this.idcategorieDataGridViewTextBoxColumn.Width = 115;
            // 
            // bindingSourceProduits
            // 
            this.bindingSourceProduits.DataMember = "Produits";
            this.bindingSourceProduits.DataSource = this.e4DataBindingDataSet;
            // 
            // e4DataBindingDataSet
            // 
            this.e4DataBindingDataSet.DataSetName = "E4DataBindingDataSet";
            this.e4DataBindingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitsBindingSource
            // 
            this.produitsBindingSource.DataMember = "Produits";
            this.produitsBindingSource.DataSource = this.e4DataBindingDataSet;
            // 
            // produitsTableAdapter
            // 
            this.produitsTableAdapter.ClearBeforeFill = true;
            // 
            // gestionProduits
            // 
            this.gestionProduits.Location = new System.Drawing.Point(214, 281);
            this.gestionProduits.Name = "gestionProduits";
            this.gestionProduits.Size = new System.Drawing.Size(188, 33);
            this.gestionProduits.TabIndex = 1;
            this.gestionProduits.Text = "Gestion Produits";
            this.gestionProduits.UseVisualStyleBackColor = true;
            this.gestionProduits.Click += new System.EventHandler(this.gestionProduits_Click);
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 316);
            this.Controls.Add(this.gestionProduits);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Produit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private E4DataBindingDataSet e4DataBindingDataSet;
        private System.Windows.Forms.BindingSource produitsBindingSource;
        private E4DataBindingDataSetTableAdapters.ProduitsTableAdapter produitsTableAdapter;
        private System.Windows.Forms.Button gestionProduits;
        private System.Windows.Forms.BindingSource bindingSourceProduits;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qrestestockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategorieDataGridViewTextBoxColumn;
    }
}