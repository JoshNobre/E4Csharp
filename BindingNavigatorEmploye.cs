using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E4DataBinding
{
    public partial class BindingNavigatorEmploye : Form
    {
        public BindingNavigatorEmploye()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){}

        private void BindingNavigatorEmploye_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Adresse'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.adresseTableAdapter1.Fill(this.e4DataBindingDataSet1.Adresse);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Employes'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.employesTableAdapter1.Fill(this.e4DataBindingDataSet1.Employes);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Adresse'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.adresseTableAdapter.Fill(this.e4DataBindingDataSet.Adresse);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Employes'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.employesTableAdapter.Fill(this.e4DataBindingDataSet.Employes);

        }

        //private void Enregistrer_Click(object sender, EventArgs e)
        //{
            //employesBindingSource.EndEdit();
            //employesTableAdapter.Update(e4DataBindingDataSet.Employes);
        //}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            employesBindingSource1.EndEdit();
            employesTableAdapter1.Update(e4DataBindingDataSet1.Employes);
        }

        private void bindingNavigatorEmploye1_RefreshItems(object sender, EventArgs e){}

        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e){}

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e){}
    }
}
