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
    public partial class Personne : Form
    {
        public Personne()
        {
            InitializeComponent();
        }

        private void Personne_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet1.PERSONNE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.pERSONNETableAdapter.Fill(this.bdd_voilierDataSet1.PERSONNE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionPersonne form = new GestionPersonne();
            form.ShowDialog();

            // Il faut rafraichir le DataGridView
            dataGridView1.DataSource = null;
            this.pERSONNETableAdapter.Fill(this.bdd_voilierDataSet1.PERSONNE);
            dataGridView1.DataSource = this.bdd_voilierDataSet1.PERSONNE;
        }
    }
}
