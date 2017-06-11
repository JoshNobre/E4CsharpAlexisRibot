using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseVoiliers
{
    public partial class Entreprise : Form
    {
        public Entreprise()
        {
            InitializeComponent();
        }

        private void Entreprise_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet.ENTREPRISE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.eNTREPRISETableAdapter.Fill(this.bdd_voilierDataSet.ENTREPRISE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionEntreprise form = new GestionEntreprise();
            form.ShowDialog();

            // Il faut rafraichir le DataGridView
            dataGridView1.DataSource = null;
            this.eNTREPRISETableAdapter.Fill(this.bdd_voilierDataSet.ENTREPRISE);
            dataGridView1.DataSource = this.bdd_voilierDataSet.ENTREPRISE;
        }
    }
}
