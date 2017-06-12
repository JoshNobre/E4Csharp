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
    public partial class BindingNavigatorColis : Form
    {
        public BindingNavigatorColis()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            colisBindingSource1.EndEdit();
            colisTableAdapter1.Update(e4DataBindingDataSet1.Colis);
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void BindingNavigatorColis_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.composer'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.composerTableAdapter.Fill(this.e4DataBindingDataSet1.composer);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Commande'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.commandeTableAdapter1.Fill(this.e4DataBindingDataSet1.Commande);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Colis'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.colisTableAdapter1.Fill(this.e4DataBindingDataSet1.Colis);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Commande'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.commandeTableAdapter.Fill(this.e4DataBindingDataSet.Commande);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Colis'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.colisTableAdapter.Fill(this.e4DataBindingDataSet.Colis);

        }
    }
}
