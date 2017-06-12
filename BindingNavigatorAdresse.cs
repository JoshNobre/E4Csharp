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
    public partial class BindingNavigatorAdresse : Form
    {
        public BindingNavigatorAdresse()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            adresseBindingSource.EndEdit();
            adresseTableAdapter.Update(e4DataBindingDataSet.Adresse);
        }

        private void BindingNavigatorAdresse_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Adresse'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.adresseTableAdapter1.Fill(this.e4DataBindingDataSet1.Adresse);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Adresse'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.adresseTableAdapter.Fill(this.e4DataBindingDataSet.Adresse);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            adresseBindingSource1.EndEdit();
            adresseTableAdapter1.Update(e4DataBindingDataSet1.Adresse);
        }
    }
}
