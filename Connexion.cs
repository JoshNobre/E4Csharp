using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E4DataBinding
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet11.Employes'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.employesTableAdapter1.Fill(this.e4DataBindingDataSet11.Employes);
            // TODO: cette ligne de code charge les données dans la table 'e4DataBindingDataSet.Employes'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.employesTableAdapter.Fill(this.e4DataBindingDataSet.Employes);

        }

        private void button_connexion_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source = sqlserver.montpellier.epsi.fr, 4433; 
            Initial Catalog = E4DataBinding; Persist Security Info = True; User ID = joshua.nobre; Password = epsi587NRZ;");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from employes where login_emp = '" +
                IdentifiantSelect.Text + "' AND motDePasse_emp = HASHBYTES('SHA1', convert(nvarchar(4000), '" + MdpSelect.Text + "'))", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Votre identifiant ou votre mot de passe est incorrect");
            }
        }
    }
}
