using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E4DataBinding
{
    public partial class BindingNavigatorProduit : Form
    {
        public BindingNavigatorProduit()
        {
            InitializeComponent();
        }

        private void BindingNavigatorProduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.categorieTableAdapter.Fill(this.e4DataBindingDataSet.Categorie);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Produits'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.produitsTableAdapter.Fill(this.e4DataBindingDataSet.Produits);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            produitBindingSource.EndEdit();
            produitsTableAdapter.Update(e4DataBindingDataSet.Produits);
        }
    }
}
