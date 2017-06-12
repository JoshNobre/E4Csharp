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
    public partial class BindingNavigatorClients : Form
    {
        public BindingNavigatorClients()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clientsBindingSource.EndEdit();
            clientsTableAdapter1.Update(e4DataBindingDataSet1.Clients);
        }

        private void BindingNavigatorClients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Adresse'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.adresseTableAdapter1.Fill(this.e4DataBindingDataSet1.Adresse);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.passe'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.passeTableAdapter1.Fill(this.e4DataBindingDataSet1.passe);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Clients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientsTableAdapter1.Fill(this.e4DataBindingDataSet1.Clients);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Adresse'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.adresseTableAdapter.Fill(this.e4DataBindingDataSet.Adresse);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.passe'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.passeTableAdapter.Fill(this.e4DataBindingDataSet.passe);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Clients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientsTableAdapter.Fill(this.e4DataBindingDataSet.Clients);

        }

        private void bindingNavigator1Clients_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
