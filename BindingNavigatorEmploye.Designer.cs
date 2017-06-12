namespace E4DataBinding
{
    partial class BindingNavigatorEmploye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BindingNavigatorEmploye));
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e4DataBindingDataSet = new E4DataBinding.E4DataBindingDataSet();
            this.employesTableAdapter = new E4DataBinding.E4DataBindingDataSetTableAdapters.EmployesTableAdapter();
            this.mdp_emp = new System.Windows.Forms.Label();
            this.login_emp = new System.Windows.Forms.Label();
            this.civilite_emp = new System.Windows.Forms.Label();
            this.prenom_emp = new System.Windows.Forms.Label();
            this.nom_emp = new System.Windows.Forms.Label();
            this.dateEmbauche_emp = new System.Windows.Forms.Label();
            this.dateDeNaissance_emp = new System.Windows.Forms.Label();
            this.adresse_emp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.adresse1_emp = new System.Windows.Forms.ComboBox();
            this.adresseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDeNaissance1_emp = new System.Windows.Forms.DateTimePicker();
            this.dateEmbauche1_emp = new System.Windows.Forms.DateTimePicker();
            this.bindingNavigatorEmploye1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Enregistrer = new System.Windows.Forms.ToolStripButton();
            this.adresseTableAdapter = new E4DataBinding.E4DataBindingDataSetTableAdapters.AdresseTableAdapter();
            this.e4DataBindingDataSet1 = new E4DataBinding.E4DataBindingDataSet1();
            this.employesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter1 = new E4DataBinding.E4DataBindingDataSet1TableAdapters.EmployesTableAdapter();
            this.adresseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adresseTableAdapter1 = new E4DataBinding.E4DataBindingDataSet1TableAdapters.AdresseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEmploye1)).BeginInit();
            this.bindingNavigatorEmploye1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresseBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // mdp_emp
            // 
            this.mdp_emp.AutoSize = true;
            this.mdp_emp.Location = new System.Drawing.Point(13, 188);
            this.mdp_emp.Name = "mdp_emp";
            this.mdp_emp.Size = new System.Drawing.Size(158, 17);
            this.mdp_emp.TabIndex = 3;
            this.mdp_emp.Text = "Mot de passe employe :";
            // 
            // login_emp
            // 
            this.login_emp.AutoSize = true;
            this.login_emp.Location = new System.Drawing.Point(13, 156);
            this.login_emp.Name = "login_emp";
            this.login_emp.Size = new System.Drawing.Size(108, 17);
            this.login_emp.TabIndex = 4;
            this.login_emp.Text = "Login employe :";
            // 
            // civilite_emp
            // 
            this.civilite_emp.AutoSize = true;
            this.civilite_emp.Location = new System.Drawing.Point(13, 123);
            this.civilite_emp.Name = "civilite_emp";
            this.civilite_emp.Size = new System.Drawing.Size(113, 17);
            this.civilite_emp.TabIndex = 5;
            this.civilite_emp.Text = "Civilite employe :";
            // 
            // prenom_emp
            // 
            this.prenom_emp.AutoSize = true;
            this.prenom_emp.Location = new System.Drawing.Point(13, 89);
            this.prenom_emp.Name = "prenom_emp";
            this.prenom_emp.Size = new System.Drawing.Size(122, 17);
            this.prenom_emp.TabIndex = 6;
            this.prenom_emp.Text = "Prenom employe :";
            // 
            // nom_emp
            // 
            this.nom_emp.AutoSize = true;
            this.nom_emp.Location = new System.Drawing.Point(13, 59);
            this.nom_emp.Name = "nom_emp";
            this.nom_emp.Size = new System.Drawing.Size(102, 17);
            this.nom_emp.TabIndex = 7;
            this.nom_emp.Text = "Nom employe :";
            // 
            // dateEmbauche_emp
            // 
            this.dateEmbauche_emp.AutoSize = true;
            this.dateEmbauche_emp.Location = new System.Drawing.Point(13, 263);
            this.dateEmbauche_emp.Name = "dateEmbauche_emp";
            this.dateEmbauche_emp.Size = new System.Drawing.Size(184, 17);
            this.dateEmbauche_emp.TabIndex = 8;
            this.dateEmbauche_emp.Text = "Date d\'embauche employe :";
            // 
            // dateDeNaissance_emp
            // 
            this.dateDeNaissance_emp.AutoSize = true;
            this.dateDeNaissance_emp.Location = new System.Drawing.Point(13, 226);
            this.dateDeNaissance_emp.Name = "dateDeNaissance_emp";
            this.dateDeNaissance_emp.Size = new System.Drawing.Size(191, 17);
            this.dateDeNaissance_emp.TabIndex = 9;
            this.dateDeNaissance_emp.Text = "Date de naissance employe :";
            // 
            // adresse_emp
            // 
            this.adresse_emp.AutoSize = true;
            this.adresse_emp.Location = new System.Drawing.Point(13, 299);
            this.adresse_emp.Name = "adresse_emp";
            this.adresse_emp.Size = new System.Drawing.Size(125, 17);
            this.adresse_emp.TabIndex = 10;
            this.adresse_emp.Text = "Adresse employe :";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource1, "motDePasse_emp", true));
            this.textBox1.Location = new System.Drawing.Point(221, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource1, "login_emp", true));
            this.textBox5.Location = new System.Drawing.Point(221, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(316, 22);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource1, "civilite_emp", true));
            this.textBox6.Location = new System.Drawing.Point(221, 123);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(316, 22);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource1, "prenom_emp", true));
            this.textBox7.Location = new System.Drawing.Point(221, 89);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(316, 22);
            this.textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource1, "nom_emp", true));
            this.textBox8.Location = new System.Drawing.Point(221, 59);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(316, 22);
            this.textBox8.TabIndex = 18;
            // 
            // adresse1_emp
            // 
            this.adresse1_emp.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employesBindingSource1, "id_adresse", true));
            this.adresse1_emp.DataSource = this.adresseBindingSource1;
            this.adresse1_emp.DisplayMember = "adresse1";
            this.adresse1_emp.FormattingEnabled = true;
            this.adresse1_emp.Location = new System.Drawing.Point(221, 299);
            this.adresse1_emp.Name = "adresse1_emp";
            this.adresse1_emp.Size = new System.Drawing.Size(316, 24);
            this.adresse1_emp.TabIndex = 19;
            this.adresse1_emp.ValueMember = "id_adresse";
            // 
            // adresseBindingSource
            // 
            this.adresseBindingSource.DataMember = "Adresse";
            this.adresseBindingSource.DataSource = this.e4DataBindingDataSet;
            // 
            // dateDeNaissance1_emp
            // 
            this.dateDeNaissance1_emp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employesBindingSource1, "dateDeNaissance_emp", true));
            this.dateDeNaissance1_emp.Location = new System.Drawing.Point(221, 220);
            this.dateDeNaissance1_emp.Name = "dateDeNaissance1_emp";
            this.dateDeNaissance1_emp.Size = new System.Drawing.Size(316, 22);
            this.dateDeNaissance1_emp.TabIndex = 20;
            // 
            // dateEmbauche1_emp
            // 
            this.dateEmbauche1_emp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employesBindingSource1, "dateEmbauche_emp", true));
            this.dateEmbauche1_emp.Location = new System.Drawing.Point(221, 263);
            this.dateEmbauche1_emp.Name = "dateEmbauche1_emp";
            this.dateEmbauche1_emp.Size = new System.Drawing.Size(316, 22);
            this.dateEmbauche1_emp.TabIndex = 21;
            // 
            // bindingNavigatorEmploye1
            // 
            this.bindingNavigatorEmploye1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorEmploye1.BindingSource = this.employesBindingSource1;
            this.bindingNavigatorEmploye1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorEmploye1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorEmploye1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorEmploye1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.Enregistrer});
            this.bindingNavigatorEmploye1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorEmploye1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorEmploye1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorEmploye1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorEmploye1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorEmploye1.Name = "bindingNavigatorEmploye1";
            this.bindingNavigatorEmploye1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorEmploye1.Size = new System.Drawing.Size(549, 27);
            this.bindingNavigatorEmploye1.TabIndex = 22;
            this.bindingNavigatorEmploye1.Text = "bindingNavigatorEmploye1";
            this.bindingNavigatorEmploye1.RefreshItems += new System.EventHandler(this.bindingNavigatorEmploye1_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // Enregistrer
            // 
            this.Enregistrer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Enregistrer.Image = ((System.Drawing.Image)(resources.GetObject("Enregistrer.Image")));
            this.Enregistrer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(24, 24);
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // adresseTableAdapter
            // 
            this.adresseTableAdapter.ClearBeforeFill = true;
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
            // adresseBindingSource1
            // 
            this.adresseBindingSource1.DataMember = "Adresse";
            this.adresseBindingSource1.DataSource = this.e4DataBindingDataSet1;
            // 
            // adresseTableAdapter1
            // 
            this.adresseTableAdapter1.ClearBeforeFill = true;
            // 
            // BindingNavigatorEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 334);
            this.Controls.Add(this.bindingNavigatorEmploye1);
            this.Controls.Add(this.dateEmbauche1_emp);
            this.Controls.Add(this.dateDeNaissance1_emp);
            this.Controls.Add(this.adresse1_emp);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.adresse_emp);
            this.Controls.Add(this.dateDeNaissance_emp);
            this.Controls.Add(this.dateEmbauche_emp);
            this.Controls.Add(this.nom_emp);
            this.Controls.Add(this.prenom_emp);
            this.Controls.Add(this.civilite_emp);
            this.Controls.Add(this.login_emp);
            this.Controls.Add(this.mdp_emp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BindingNavigatorEmploye";
            this.Text = "BindingNavigatorEmploye";
            this.Load += new System.EventHandler(this.BindingNavigatorEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEmploye1)).EndInit();
            this.bindingNavigatorEmploye1.ResumeLayout(false);
            this.bindingNavigatorEmploye1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private E4DataBindingDataSet e4DataBindingDataSet;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private E4DataBindingDataSetTableAdapters.EmployesTableAdapter employesTableAdapter;
        private System.Windows.Forms.Label mdp_emp;
        private System.Windows.Forms.Label login_emp;
        private System.Windows.Forms.Label civilite_emp;
        private System.Windows.Forms.Label prenom_emp;
        private System.Windows.Forms.Label nom_emp;
        private System.Windows.Forms.Label dateEmbauche_emp;
        private System.Windows.Forms.Label dateDeNaissance_emp;
        private System.Windows.Forms.Label adresse_emp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox adresse1_emp;
        private System.Windows.Forms.DateTimePicker dateDeNaissance1_emp;
        private System.Windows.Forms.DateTimePicker dateEmbauche1_emp;
        private System.Windows.Forms.BindingNavigator bindingNavigatorEmploye1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton Enregistrer;
        private System.Windows.Forms.BindingSource adresseBindingSource;
        private E4DataBindingDataSetTableAdapters.AdresseTableAdapter adresseTableAdapter;
        private E4DataBindingDataSet1 e4DataBindingDataSet1;
        private System.Windows.Forms.BindingSource employesBindingSource1;
        private E4DataBindingDataSet1TableAdapters.EmployesTableAdapter employesTableAdapter1;
        private System.Windows.Forms.BindingSource adresseBindingSource1;
        private E4DataBindingDataSet1TableAdapters.AdresseTableAdapter adresseTableAdapter1;
    }
}