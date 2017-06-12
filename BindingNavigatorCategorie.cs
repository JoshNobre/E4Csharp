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
    public partial class BindingNavigatorCategorie : Form
    {
        public BindingNavigatorCategorie()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            categorieBindingSource1.EndEdit();
            categorieTableAdapter1.Update(e4DataBindingDataSet1.Categorie);
        }

        private void BindingNavigatorCategorie_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Categorie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.categorieTableAdapter1.Fill(this.e4DataBindingDataSet1.Categorie);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.categorieTableAdapter.Fill(this.e4DataBindingDataSet.Categorie);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
