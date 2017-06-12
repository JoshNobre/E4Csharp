namespace E4DataBinding
{
    partial class BindingNavigatorColis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BindingNavigatorColis));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.colisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.e4DataBindingDataSet1 = new E4DataBinding.E4DataBindingDataSet1();
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.colisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.e4DataBindingDataSet = new E4DataBinding.E4DataBindingDataSet();
            this.bindingSourceColis = new System.Windows.Forms.BindingSource(this.components);
            this.commande = new System.Windows.Forms.Label();
            this.dateEnvoiCommande = new System.Windows.Forms.Label();
            this.poidsColis = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.commandeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.colisTableAdapter = new E4DataBinding.E4DataBindingDataSetTableAdapters.ColisTableAdapter();
            this.commandeTableAdapter = new E4DataBinding.E4DataBindingDataSetTableAdapters.CommandeTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.colisTableAdapter1 = new E4DataBinding.E4DataBindingDataSet1TableAdapters.ColisTableAdapter();
            this.commandeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.commandeTableAdapter1 = new E4DataBinding.E4DataBindingDataSet1TableAdapters.CommandeTableAdapter();
            this.composerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.composerTableAdapter = new E4DataBinding.E4DataBindingDataSet1TableAdapters.composerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceColis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.composerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.colisBindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(855, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigatorColis";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // colisBindingSource1
            // 
            this.colisBindingSource1.DataMember = "Colis";
            this.colisBindingSource1.DataSource = this.e4DataBindingDataSet1;
            // 
            // e4DataBindingDataSet1
            // 
            this.e4DataBindingDataSet1.DataSetName = "E4DataBindingDataSet1";
            this.e4DataBindingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // colisBindingSource
            // 
            this.colisBindingSource.DataMember = "Colis";
            this.colisBindingSource.DataSource = this.e4DataBindingDataSet;
            // 
            // e4DataBindingDataSet
            // 
            this.e4DataBindingDataSet.DataSetName = "E4DataBindingDataSet";
            this.e4DataBindingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commande
            // 
            this.commande.AutoSize = true;
            this.commande.Location = new System.Drawing.Point(12, 142);
            this.commande.Name = "commande";
            this.commande.Size = new System.Drawing.Size(79, 17);
            this.commande.TabIndex = 2;
            this.commande.Text = "Commande";
            // 
            // dateEnvoiCommande
            // 
            this.dateEnvoiCommande.AutoSize = true;
            this.dateEnvoiCommande.Location = new System.Drawing.Point(12, 108);
            this.dateEnvoiCommande.Name = "dateEnvoiCommande";
            this.dateEnvoiCommande.Size = new System.Drawing.Size(152, 17);
            this.dateEnvoiCommande.TabIndex = 3;
            this.dateEnvoiCommande.Text = "Date Envoi Commande";
            // 
            // poidsColis
            // 
            this.poidsColis.AutoSize = true;
            this.poidsColis.Location = new System.Drawing.Point(12, 77);
            this.poidsColis.Name = "poidsColis";
            this.poidsColis.Size = new System.Drawing.Size(77, 17);
            this.poidsColis.TabIndex = 4;
            this.poidsColis.Text = "Poids Colis";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.colisBindingSource1, "id_commande", true));
            this.comboBox1.DataSource = this.commandeBindingSource2;
            this.comboBox1.DisplayMember = "statut";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(636, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "id_commande";
            // 
            // commandeBindingSource2
            // 
            this.commandeBindingSource2.DataMember = "Commande";
            this.commandeBindingSource2.DataSource = this.e4DataBindingDataSet1;
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataMember = "Commande";
            this.commandeBindingSource.DataSource = this.e4DataBindingDataSet;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colisBindingSource1, "poids_colis", true));
            this.textBox2.Location = new System.Drawing.Point(207, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(636, 22);
            this.textBox2.TabIndex = 7;
            // 
            // colisTableAdapter
            // 
            this.colisTableAdapter.ClearBeforeFill = true;
            // 
            // commandeTableAdapter
            // 
            this.commandeTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.colisBindingSource1, "date_envoi", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(636, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // colisTableAdapter1
            // 
            this.colisTableAdapter1.ClearBeforeFill = true;
            // 
            // commandeBindingSource1
            // 
            this.commandeBindingSource1.DataMember = "Commande";
            this.commandeBindingSource1.DataSource = this.e4DataBindingDataSet1;
            // 
            // commandeTableAdapter1
            // 
            this.commandeTableAdapter1.ClearBeforeFill = true;
            // 
            // composerBindingSource
            // 
            this.composerBindingSource.DataMember = "composer";
            this.composerBindingSource.DataSource = this.e4DataBindingDataSet1;
            // 
            // composerTableAdapter
            // 
            this.composerTableAdapter.ClearBeforeFill = true;
            // 
            // BindingNavigatorColis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 177);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.poidsColis);
            this.Controls.Add(this.dateEnvoiCommande);
            this.Controls.Add(this.commande);
            this.Controls.Add(this.bindingNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BindingNavigatorColis";
            this.Text = "BindingNavigatorColis";
            this.Load += new System.EventHandler(this.BindingNavigatorColis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceColis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.composerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.BindingSource bindingSourceColis;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.Label commande;
        private System.Windows.Forms.Label dateEnvoiCommande;
        private System.Windows.Forms.Label poidsColis;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private E4DataBindingDataSet e4DataBindingDataSet;
        private System.Windows.Forms.BindingSource colisBindingSource;
        private E4DataBindingDataSetTableAdapters.ColisTableAdapter colisTableAdapter;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private E4DataBindingDataSetTableAdapters.CommandeTableAdapter commandeTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private E4DataBindingDataSet1 e4DataBindingDataSet1;
        private System.Windows.Forms.BindingSource colisBindingSource1;
        private E4DataBindingDataSet1TableAdapters.ColisTableAdapter colisTableAdapter1;
        private System.Windows.Forms.BindingSource commandeBindingSource1;
        private E4DataBindingDataSet1TableAdapters.CommandeTableAdapter commandeTableAdapter1;
        private System.Windows.Forms.BindingSource composerBindingSource;
        private E4DataBindingDataSet1TableAdapters.composerTableAdapter composerTableAdapter;
        private System.Windows.Forms.BindingSource commandeBindingSource2;
    }
}