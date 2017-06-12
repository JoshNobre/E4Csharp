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
    public partial class gestion : Form
    {
        public gestion()
        {
            InitializeComponent();
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employe form = new Employe();
            form.ShowDialog();
        }

        private void Adresse_Click(object sender, EventArgs e)
        {
            Adresse form1 = new Adresse();
            form1.ShowDialog();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            Clients form1 = new Clients();
            form1.ShowDialog();
        }

        private void Colis_Click(object sender, EventArgs e)
        {
            Colis form1 = new Colis();
            form1.ShowDialog();
        }

        private void Commande_Click(object sender, EventArgs e)
        {
            Commande form1 = new Commande();
            form1.ShowDialog();
        }

        private void gestion_Load(object sender, EventArgs e)
        {
            Connexion form1 = new Connexion();
            if(form1.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }

        }

        private void Produits_Click(object sender, EventArgs e)
        {
            Produit form1 = new Produit();
            form1.ShowDialog();
        }

        private void Catégorie_Click(object sender, EventArgs e)
        {
            Categorie form1 = new Categorie();
            form1.ShowDialog();
        }
    }
}
