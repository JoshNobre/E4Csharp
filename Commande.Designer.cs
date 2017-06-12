namespace E4DataBinding
{
    partial class Commande
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
            this.gestionCommande = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.e4DataBindingDataSet1 = new E4DataBinding.E4DataBindingDataSet1();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandeTableAdapter = new E4DataBinding.E4DataBindingDataSet1TableAdapters.CommandeTableAdapter();
            this.idcommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gestionCommande
            // 
            this.gestionCommande.Location = new System.Drawing.Point(140, 265);
            this.gestionCommande.Name = "gestionCommande";
            this.gestionCommande.Size = new System.Drawing.Size(210, 33);
            this.gestionCommande.TabIndex = 1;
            this.gestionCommande.Text = "Gestion Commande";
            this.gestionCommande.UseVisualStyleBackColor = true;
            this.gestionCommande.Click += new System.EventHandler(this.gestionCommande_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcommandeDataGridViewTextBoxColumn,
            this.datecommandeDataGridViewTextBoxColumn,
            this.statutDataGridViewTextBoxColumn,
            this.idempDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.commandeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(494, 247);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // e4DataBindingDataSet1
            // 
            this.e4DataBindingDataSet1.DataSetName = "E4DataBindingDataSet1";
            this.e4DataBindingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataMember = "Commande";
            this.commandeBindingSource.DataSource = this.e4DataBindingDataSet1;
            // 
            // commandeTableAdapter
            // 
            this.commandeTableAdapter.ClearBeforeFill = true;
            // 
            // idcommandeDataGridViewTextBoxColumn
            // 
            this.idcommandeDataGridViewTextBoxColumn.DataPropertyName = "id_commande";
            this.idcommandeDataGridViewTextBoxColumn.HeaderText = "id_commande";
            this.idcommandeDataGridViewTextBoxColumn.Name = "idcommandeDataGridViewTextBoxColumn";
            this.idcommandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datecommandeDataGridViewTextBoxColumn
            // 
            this.datecommandeDataGridViewTextBoxColumn.DataPropertyName = "date_commande";
            this.datecommandeDataGridViewTextBoxColumn.HeaderText = "date_commande";
            this.datecommandeDataGridViewTextBoxColumn.Name = "datecommandeDataGridViewTextBoxColumn";
            // 
            // statutDataGridViewTextBoxColumn
            // 
            this.statutDataGridViewTextBoxColumn.DataPropertyName = "statut";
            this.statutDataGridViewTextBoxColumn.HeaderText = "statut";
            this.statutDataGridViewTextBoxColumn.Name = "statutDataGridViewTextBoxColumn";
            // 
            // idempDataGridViewTextBoxColumn
            // 
            this.idempDataGridViewTextBoxColumn.DataPropertyName = "id_emp";
            this.idempDataGridViewTextBoxColumn.HeaderText = "id_emp";
            this.idempDataGridViewTextBoxColumn.Name = "idempDataGridViewTextBoxColumn";
            // 
            // Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 300);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gestionCommande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Commande";
            this.Text = "Commande";
            this.Load += new System.EventHandler(this.Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button gestionCommande;
        private System.Windows.Forms.DataGridView dataGridView1;
        private E4DataBindingDataSet1 e4DataBindingDataSet1;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private E4DataBindingDataSet1TableAdapters.CommandeTableAdapter commandeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempDataGridViewTextBoxColumn;
    }
}