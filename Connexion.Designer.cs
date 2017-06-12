namespace E4DataBinding
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.Identifiant = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.IdentifiantSelect = new System.Windows.Forms.TextBox();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e4DataBindingDataSet = new E4DataBinding.E4DataBindingDataSet();
            this.MdpSelect = new System.Windows.Forms.TextBox();
            this.button_connexion = new System.Windows.Forms.Button();
            this.employesTableAdapter = new E4DataBinding.E4DataBindingDataSetTableAdapters.EmployesTableAdapter();
            this.e4DataBindingDataSet1 = new E4DataBinding.E4DataBindingDataSet();
            this.e4DataBindingDataSet11 = new E4DataBinding.E4DataBindingDataSet1();
            this.employesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter1 = new E4DataBinding.E4DataBindingDataSet1TableAdapters.EmployesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Identifiant
            // 
            this.Identifiant.AutoSize = true;
            this.Identifiant.Location = new System.Drawing.Point(12, 46);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(77, 17);
            this.Identifiant.TabIndex = 0;
            this.Identifiant.Text = "Identifiant :";
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(12, 112);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(101, 17);
            this.mdp.TabIndex = 1;
            this.mdp.Text = "Mot de passe :";
            // 
            // IdentifiantSelect
            // 
            this.IdentifiantSelect.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.employesBindingSource1, "login_emp", true));
            this.IdentifiantSelect.Location = new System.Drawing.Point(119, 46);
            this.IdentifiantSelect.Name = "IdentifiantSelect";
            this.IdentifiantSelect.Size = new System.Drawing.Size(100, 22);
            this.IdentifiantSelect.TabIndex = 2;
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
            // MdpSelect
            // 
            this.MdpSelect.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.employesBindingSource1, "motDePasse_emp", true));
            this.MdpSelect.Location = new System.Drawing.Point(119, 112);
            this.MdpSelect.Name = "MdpSelect";
            this.MdpSelect.Size = new System.Drawing.Size(100, 22);
            this.MdpSelect.TabIndex = 3;
            this.MdpSelect.UseSystemPasswordChar = true;
            // 
            // button_connexion
            // 
            this.button_connexion.Location = new System.Drawing.Point(119, 181);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Size = new System.Drawing.Size(100, 28);
            this.button_connexion.TabIndex = 4;
            this.button_connexion.Text = "Connexion";
            this.button_connexion.UseVisualStyleBackColor = true;
            this.button_connexion.Click += new System.EventHandler(this.button_connexion_Click);
            // 
            // employesTableAdapter
            // 
            this.employesTableAdapter.ClearBeforeFill = true;
            // 
            // e4DataBindingDataSet1
            // 
            this.e4DataBindingDataSet1.DataSetName = "E4DataBindingDataSet";
            this.e4DataBindingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e4DataBindingDataSet11
            // 
            this.e4DataBindingDataSet11.DataSetName = "E4DataBindingDataSet1";
            this.e4DataBindingDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employesBindingSource1
            // 
            this.employesBindingSource1.DataMember = "Employes";
            this.employesBindingSource1.DataSource = this.e4DataBindingDataSet11;
            // 
            // employesTableAdapter1
            // 
            this.employesTableAdapter1.ClearBeforeFill = true;
            // 
            // Connexion
            // 
            this.AcceptButton = this.button_connexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(288, 234);
            this.Controls.Add(this.button_connexion);
            this.Controls.Add(this.MdpSelect);
            this.Controls.Add(this.IdentifiantSelect);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.Identifiant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Identifiant;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.TextBox IdentifiantSelect;
        private E4DataBindingDataSet e4DataBindingDataSet;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private E4DataBindingDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
        private System.Windows.Forms.TextBox MdpSelect;
        private System.Windows.Forms.Button button_connexion;
        private E4DataBindingDataSet e4DataBindingDataSet1;
        private E4DataBindingDataSet1 e4DataBindingDataSet11;
        private System.Windows.Forms.BindingSource employesBindingSource1;
        private E4DataBindingDataSet1TableAdapters.EmployesTableAdapter employesTableAdapter1;
    }
}