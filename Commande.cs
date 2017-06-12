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
    public partial class Commande : Form
    {
        public Commande()
        {
            InitializeComponent();
        }

        private void Commande_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Commande'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.commandeTableAdapter.Fill(this.e4DataBindingDataSet1.Commande);

        }

        private void gestionCommande_Click(object sender, EventArgs e)
        {
            BindingNavigatorCommande form = new BindingNavigatorCommande();
            form.ShowDialog();
            // Il faut rafraichir le DataGridView
            dataGridView1.DataSource = null;
            this.commandeTableAdapter.Fill(this.e4DataBindingDataSet1.Commande);
            dataGridView1.DataSource = this.e4DataBindingDataSet1.Commande;
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
