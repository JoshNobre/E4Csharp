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
    public partial class Employe : Form
    {
        public Employe()
        {
            InitializeComponent();
        }

        private void Employe_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Employes'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.employesTableAdapter1.Fill(this.e4DataBindingDataSet1.Employes);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Employes'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.employesTableAdapter.Fill(this.e4DataBindingDataSet.Employes);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionEmploye_Click(object sender, EventArgs e)
        {
            BindingNavigatorEmploye form = new BindingNavigatorEmploye();
            form.ShowDialog();
            // Il faut rafraichir le DataGridView
            dataGridView1.DataSource = null;
            this.employesTableAdapter1.Fill(this.e4DataBindingDataSet1.Employes);
            dataGridView1.DataSource = this.e4DataBindingDataSet1.Employes;

        }
    }
}
