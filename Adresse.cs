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
    public partial class Adresse : Form
    {
        public Adresse()
        {
            InitializeComponent();
        }

        private void Adresse_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Adresse'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.adresseTableAdapter1.Fill(this.e4DataBindingDataSet1.Adresse);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Adresse'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.adresseTableAdapter.Fill(this.e4DataBindingDataSet.Adresse);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionAdresse_Click(object sender, EventArgs e)
        {
            BindingNavigatorAdresse form1 = new BindingNavigatorAdresse();
            form1.ShowDialog();
            // Il faut rafraichir le DataGridView
            dataGridView1.DataSource = null;
            this.adresseTableAdapter1.Fill(this.e4DataBindingDataSet1.Adresse);
            dataGridView1.DataSource = this.e4DataBindingDataSet1.Adresse;
        }
    }
}
