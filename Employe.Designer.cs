namespace E4DataBinding
{
    partial class Employe
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
            this.idempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civiliteempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motDePasseempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeNaissanceempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmbaucheempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e4DataBindingDataSet = new E4DataBinding.E4DataBindingDataSet();
            this.employesTableAdapter = new E4DataBinding.E4DataBindingDataSetTableAdapters.EmployesTableAdapter();
            this.GestionEmploye = new System.Windows.Forms.Button();
            this.e4DataBindingDataSet1 = new E4DataBinding.E4DataBindingDataSet1();
            this.employesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter1 = new E4DataBinding.E4DataBindingDataSet1TableAdapters.EmployesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempDataGridViewTextBoxColumn,
            this.nomempDataGridViewTextBoxColumn,
            this.prenomempDataGridViewTextBoxColumn,
            this.civiliteempDataGridViewTextBoxColumn,
            this.loginempDataGridViewTextBoxColumn,
            this.motDePasseempDataGridViewTextBoxColumn,
            this.dateDeNaissanceempDataGridViewTextBoxColumn,
            this.dateEmbaucheempDataGridViewTextBoxColumn,
            this.idadresseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(31, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idempDataGridViewTextBoxColumn
            // 
            this.idempDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idempDataGridViewTextBoxColumn.DataPropertyName = "id_emp";
            this.idempDataGridViewTextBoxColumn.HeaderText = "id_emp";
            this.idempDataGridViewTextBoxColumn.Name = "idempDataGridViewTextBoxColumn";
            this.idempDataGridViewTextBoxColumn.ReadOnly = true;
            this.idempDataGridViewTextBoxColumn.Width = 83;
            // 
            // nomempDataGridViewTextBoxColumn
            // 
            this.nomempDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomempDataGridViewTextBoxColumn.DataPropertyName = "nom_emp";
            this.nomempDataGridViewTextBoxColumn.HeaderText = "nom_emp";
            this.nomempDataGridViewTextBoxColumn.Name = "nomempDataGridViewTextBoxColumn";
            this.nomempDataGridViewTextBoxColumn.Width = 99;
            // 
            // prenomempDataGridViewTextBoxColumn
            // 
            this.prenomempDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prenomempDataGridViewTextBoxColumn.DataPropertyName = "prenom_emp";
            this.prenomempDataGridViewTextBoxColumn.HeaderText = "prenom_emp";
            this.prenomempDataGridViewTextBoxColumn.Name = "prenomempDataGridViewTextBoxColumn";
            this.prenomempDataGridViewTextBoxColumn.Width = 120;
            // 
            // civiliteempDataGridViewTextBoxColumn
            // 
            this.civiliteempDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.civiliteempDataGridViewTextBoxColumn.DataPropertyName = "civilite_emp";
            this.civiliteempDataGridViewTextBoxColumn.HeaderText = "civilite_emp";
            this.civiliteempDataGridViewTextBoxColumn.Name = "civiliteempDataGridViewTextBoxColumn";
            this.civiliteempDataGridViewTextBoxColumn.Width = 110;
            // 
            // loginempDataGridViewTextBoxColumn
            // 
            this.loginempDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loginempDataGridViewTextBoxColumn.DataPropertyName = "login_emp";
            this.loginempDataGridViewTextBoxColumn.HeaderText = "login_emp";
            this.loginempDataGridViewTextBoxColumn.Name = "loginempDataGridViewTextBoxColumn";
            this.loginempDataGridViewTextBoxColumn.Width = 102;
            // 
            // motDePasseempDataGridViewTextBoxColumn
            // 
            this.motDePasseempDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.motDePasseempDataGridViewTextBoxColumn.DataPropertyName = "motDePasse_emp";
            this.motDePasseempDataGridViewTextBoxColumn.HeaderText = "motDePasse_emp";
            this.motDePasseempDataGridViewTextBoxColumn.Name = "motDePasseempDataGridViewTextBoxColumn";
            this.motDePasseempDataGridViewTextBoxColumn.Width = 152;
            // 
            // dateDeNaissanceempDataGridViewTextBoxColumn
            // 
            this.dateDeNaissanceempDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateDeNaissanceempDataGridViewTextBoxColumn.DataPropertyName = "dateDeNaissance_emp";
            this.dateDeNaissanceempDataGridViewTextBoxColumn.HeaderText = "dateDeNaissance_emp";
            this.dateDeNaissanceempDataGridViewTextBoxColumn.Name = "dateDeNaissanceempDataGridViewTextBoxColumn";
            this.dateDeNaissanceempDataGridViewTextBoxColumn.Width = 184;
            // 
            // dateEmbaucheempDataGridViewTextBoxColumn
            // 
            this.dateEmbaucheempDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateEmbaucheempDataGridViewTextBoxColumn.DataPropertyName = "dateEmbauche_emp";
            this.dateEmbaucheempDataGridViewTextBoxColumn.HeaderText = "dateEmbauche_emp";
            this.dateEmbaucheempDataGridViewTextBoxColumn.Name = "dateEmbaucheempDataGridViewTextBoxColumn";
            this.dateEmbaucheempDataGridViewTextBoxColumn.Width = 167;
            // 
            // idadresseDataGridViewTextBoxColumn
            // 
            this.idadresseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idadresseDataGridViewTextBoxColumn.DataPropertyName = "id_adresse";
            this.idadresseDataGridViewTextBoxColumn.HeaderText = "id_adresse";
            this.idadresseDataGridViewTextBoxColumn.Name = "idadresseDataGridViewTextBoxColumn";
            this.idadresseDataGridViewTextBoxColumn.Width = 107;
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataMember = "Employes";
            this.employesBindingSource.DataSource = this.e4DataBindingDataSet;
            // 
            // e4DataBindingDataSet
            // 
            this.e4DataBindingDataSet.DataSetName = "E4DataBindingDataSet";
            this.e4DataBindingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employesTableAdapter
            // 
            this.employesTableAdapter.ClearBeforeFill = true;
            // 
            // GestionEmploye
            // 
            this.GestionEmploye.Location = new System.Drawing.Point(587, 365);
            this.GestionEmploye.Name = "GestionEmploye";
            this.GestionEmploye.Size = new System.Drawing.Size(149, 34);
            this.GestionEmploye.TabIndex = 1;
            this.GestionEmploye.Text = "GestionEmploye";
            this.GestionEmploye.UseVisualStyleBackColor = true;
            this.GestionEmploye.Click += new System.EventHandler(this.GestionEmploye_Click);
            // 
            // e4DataBindingDataSet1
            // 
            this.e4DataBindingDataSet1.DataSetName = "E4DataBindingDataSet1";
            this.e4DataBindingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employesBindingSource1
            // 
            this.employesBindingSource1.DataMember = "Employes";
            this.employesBindingSource1.DataSource = this.e4DataBindingDataSet1;
            // 
            // employesTableAdapter1
            // 
            this.employesTableAdapter1.ClearBeforeFill = true;
            // 
            // Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 411);
            this.Controls.Add(this.GestionEmploye);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employe";
            this.Text = "Employe";
            this.Load += new System.EventHandler(this.Employe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private E4DataBindingDataSet e4DataBindingDataSet;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private E4DataBindingDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
        private System.Windows.Forms.Button GestionEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn civiliteempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motDePasseempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeNaissanceempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmbaucheempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadresseDataGridViewTextBoxColumn;
        private E4DataBindingDataSet1 e4DataBindingDataSet1;
        private System.Windows.Forms.BindingSource employesBindingSource1;
        private E4DataBindingDataSet1TableAdapters.EmployesTableAdapter employesTableAdapter1;
    }
}