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
    public partial class BindingNavigatorCommande : Form
    {
        public BindingNavigatorCommande()
        {
            InitializeComponent();
        }

        private void BindingNavigatorCommande_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Employes'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.employesTableAdapter.Fill(this.e4DataBindingDataSet1.Employes);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Commande'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.commandeTableAdapter.Fill(this.e4DataBindingDataSet1.Commande);

        }

  

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            commandeBindingSource.EndEdit();
            commandeTableAdapter.Update(e4DataBindingDataSet1.Commande);
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

    }
}
