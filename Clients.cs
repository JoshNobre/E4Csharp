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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet1.Clients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientsTableAdapter1.Fill(this.e4DataBindingDataSet1.Clients);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Clients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientsTableAdapter.Fill(this.e4DataBindingDataSet.Clients);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gestionClients_Click(object sender, EventArgs e)
        {
            BindingNavigatorClients form = new BindingNavigatorClients();
            form.ShowDialog();
            // Il faut rafraichir le DataGridView
            dataGridView1.DataSource = null;
            this.clientsTableAdapter1.Fill(this.e4DataBindingDataSet1.Clients);
            dataGridView1.DataSource = this.e4DataBindingDataSet1.Clients;
        }
    }
}
