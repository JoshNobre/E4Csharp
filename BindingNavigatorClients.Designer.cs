namespace E4DataBinding
{
    partial class BindingNavigatorClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BindingNavigatorClients));
            this.bindingNavigator1Clients = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingSourceClients = new System.Windows.Forms.BindingSource(this.components);
            this.e4DataBindingDataSet = new E4DataBinding.E4DataBindingDataSet();
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
            this.nomClient = new System.Windows.Forms.Label();
            this.adresseClient = new System.Windows.Forms.Label();
            this.mailClient = new System.Windows.Forms.Label();
            this.prenomClient = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.adresseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new E4DataBinding.E4DataBindingDataSetTableAdapters.ClientsTableAdapter();
            this.passeTableAdapter = new E4DataBinding.E4DataBindingDataSetTableAdapters.passeTableAdapter();
            this.adresseTableAdapter = new E4DataBinding.E4DataBindingDataSetTableAdapters.AdresseTableAdapter();
            this.e4DataBindingDataSet1 = new E4DataBinding.E4DataBindingDataSet1();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter1 = new E4DataBinding.E4DataBindingDataSet1TableAdapters.ClientsTableAdapter();
            this.fKpasseidclientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passeTableAdapter1 = new E4DataBinding.E4DataBindingDataSet1TableAdapters.passeTableAdapter();
            this.adresseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adresseTableAdapter1 = new E4DataBinding.E4DataBindingDataSet1TableAdapters.AdresseTableAdapter();
            this.fKClientsidadresseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1Clients)).BeginInit();
            this.bindingNavigator1Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKpasseidclientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClientsidadresseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1Clients
            // 
            this.bindingNavigator1Clients.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1Clients.BindingSource = this.clientsBindingSource;
            this.bindingNavigator1Clients.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1Clients.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1Clients.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1Clients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigator1Clients.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1Clients.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1Clients.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1Clients.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1Clients.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1Clients.Name = "bindingNavigator1Clients";
            this.bindingNavigator1Clients.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1Clients.Size = new System.Drawing.Size(855, 27);
            this.bindingNavigator1Clients.TabIndex = 0;
            this.bindingNavigator1Clients.Text = "bindingNavigatorClients";
            this.bindingNavigator1Clients.RefreshItems += new System.EventHandler(this.bindingNavigator1Clients_RefreshItems);
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
            // bindingSourceClients
            // 
            this.bindingSourceClients.DataMember = "Clients";
            this.bindingSourceClients.DataSource = this.e4DataBindingDataSet;
            // 
            // e4DataBindingDataSet
            // 
            this.e4DataBindingDataSet.DataSetName = "E4DataBindingDataSet";
            this.e4DataBindingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // nomClient
            // 
            this.nomClient.AutoSize = true;
            this.nomClient.Location = new System.Drawing.Point(13, 57);
            this.nomClient.Name = "nomClient";
            this.nomClient.Size = new System.Drawing.Size(76, 17);
            this.nomClient.TabIndex = 1;
            this.nomClient.Text = "Nom Client";
            // 
            // adresseClient
            // 
            this.adresseClient.AutoSize = true;
            this.adresseClient.Location = new System.Drawing.Point(13, 143);
            this.adresseClient.Name = "adresseClient";
            this.adresseClient.Size = new System.Drawing.Size(99, 17);
            this.adresseClient.TabIndex = 2;
            this.adresseClient.Text = "Adresse Client";
            // 
            // mailClient
            // 
            this.mailClient.AutoSize = true;
            this.mailClient.Location = new System.Drawing.Point(13, 112);
            this.mailClient.Name = "mailClient";
            this.mailClient.Size = new System.Drawing.Size(72, 17);
            this.mailClient.TabIndex = 3;
            this.mailClient.Text = "Mail Client";
            // 
            // prenomClient
            // 
            this.prenomClient.AutoSize = true;
            this.prenomClient.Location = new System.Drawing.Point(13, 84);
            this.prenomClient.Name = "prenomClient";
            this.prenomClient.Size = new System.Drawing.Size(96, 17);
            this.prenomClient.TabIndex = 4;
            this.prenomClient.Text = "Prenom Client";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "nom_client", true));
            this.textBox1.Location = new System.Drawing.Point(149, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(694, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "mail_client", true));
            this.textBox2.Location = new System.Drawing.Point(149, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(694, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "prenom_client", true));
            this.textBox3.Location = new System.Drawing.Point(149, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(694, 22);
            this.textBox3.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientsBindingSource, "id_adresse", true));
            this.comboBox1.DataSource = this.adresseBindingSource1;
            this.comboBox1.DisplayMember = "adresse1";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(694, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "id_adresse";
            // 
            // adresseBindingSource
            // 
            this.adresseBindingSource.DataMember = "Adresse";
            this.adresseBindingSource.DataSource = this.e4DataBindingDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // passeTableAdapter
            // 
            this.passeTableAdapter.ClearBeforeFill = true;
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
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.e4DataBindingDataSet1;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // fKpasseidclientBindingSource
            // 
            this.fKpasseidclientBindingSource.DataMember = "FK_passe_id_client";
            this.fKpasseidclientBindingSource.DataSource = this.clientsBindingSource;
            // 
            // passeTableAdapter1
            // 
            this.passeTableAdapter1.ClearBeforeFill = true;
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
            // fKClientsidadresseBindingSource
            // 
            this.fKClientsidadresseBindingSource.DataMember = "FK_Clients_id_adresse";
            this.fKClientsidadresseBindingSource.DataSource = this.adresseBindingSource1;
            // 
            // BindingNavigatorClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 175);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.prenomClient);
            this.Controls.Add(this.mailClient);
            this.Controls.Add(this.adresseClient);
            this.Controls.Add(this.nomClient);
            this.Controls.Add(this.bindingNavigator1Clients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BindingNavigatorClients";
            this.Text = "BindingNavigatorClients";
            this.Load += new System.EventHandler(this.BindingNavigatorClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1Clients)).EndInit();
            this.bindingNavigator1Clients.ResumeLayout(false);
            this.bindingNavigator1Clients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e4DataBindingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKpasseidclientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKClientsidadresseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1Clients;
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label nomClient;
        private System.Windows.Forms.Label adresseClient;
        private System.Windows.Forms.Label mailClient;
        private System.Windows.Forms.Label prenomClient;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private E4DataBindingDataSet e4DataBindingDataSet;
        private E4DataBindingDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private E4DataBindingDataSetTableAdapters.passeTableAdapter passeTableAdapter;
        private System.Windows.Forms.BindingSource adresseBindingSource;
        private E4DataBindingDataSetTableAdapters.AdresseTableAdapter adresseTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceClients;
        private E4DataBindingDataSet1 e4DataBindingDataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private E4DataBindingDataSet1TableAdapters.ClientsTableAdapter clientsTableAdapter1;
        private System.Windows.Forms.BindingSource fKpasseidclientBindingSource;
        private E4DataBindingDataSet1TableAdapters.passeTableAdapter passeTableAdapter1;
        private System.Windows.Forms.BindingSource adresseBindingSource1;
        private E4DataBindingDataSet1TableAdapters.AdresseTableAdapter adresseTableAdapter1;
        private System.Windows.Forms.BindingSource fKClientsidadresseBindingSource;
    }
}