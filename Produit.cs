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
    public partial class Produit : Form
    {
        public Produit()
        {
            InitializeComponent();
        }

        private void Produit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Produits'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.produitsTableAdapter.Fill(this.e4DataBindingDataSet.Produits);

        }

        private void gestionProduits_Click(object sender, EventArgs e)
        {
            BindingNavigatorProduit form = new BindingNavigatorProduit();
            form.ShowDialog();
            // Il faut rafraichir le DataGridView
            dataGridView1.DataSource = null;
            this.produitsTableAdapter.Fill(this.e4DataBindingDataSet.Produits);
            dataGridView1.DataSource = this.e4DataBindingDataSet.Produits;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
