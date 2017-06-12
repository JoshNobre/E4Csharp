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
    public partial class Colis : Form
    {
        public Colis()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Colis_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Colis'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.colisTableAdapter1.Fill(this.e4DataBindingDataSet1.Colis);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Colis'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.colisTableAdapter.Fill(this.e4DataBindingDataSet.Colis);

        }

        private void gestionColis_Click(object sender, EventArgs e)
        {
            BindingNavigatorColis form = new BindingNavigatorColis();
            form.ShowDialog();
            // Il faut rafraichir le DataGridView
            dataGridView1.DataSource = null;
            this.colisTableAdapter1.Fill(this.e4DataBindingDataSet1.Colis);
            dataGridView1.DataSource = this.e4DataBindingDataSet1.Colis;
        }
    }
}
