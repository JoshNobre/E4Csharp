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
    public partial class Categorie : Form
    {
        public Categorie()
        {
            InitializeComponent();
        }

        private void Categorie_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Categorie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.categorieTableAdapter1.Fill(this.e4DataBindingDataSet1.Categorie);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.categorieTableAdapter.Fill(this.e4DataBindingDataSet.Categorie);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.categorieTableAdapter.Fill(this.e4DataBindingDataSet.Categorie);

        }

        private void gestionCategorie_Click(object sender, EventArgs e)
        {
            BindingNavigatorCategorie form = new BindingNavigatorCategorie();
            form.ShowDialog();
            // Il faut rafraichir le DataGridView
            dataGridView1.DataSource = null;
            this.categorieTableAdapter1.Fill(this.e4DataBindingDataSet1.Categorie);
            dataGridView1.DataSource = this.e4DataBindingDataSet1.Categorie;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
