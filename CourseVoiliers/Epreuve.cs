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
    public partial class Epreuve : Form
    {
        public Epreuve()
        {
            InitializeComponent();
        }

        private void Epreuve_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet.EPREUVE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ePREUVETableAdapter.Fill(this.bdd_voilierDataSet.EPREUVE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionEpreuve form = new GestionEpreuve();
            form.ShowDialog();

            // Il faut rafraichir le DataGridView
            dataGridView1.DataSource = null;
            this.ePREUVETableAdapter.Fill(this.bdd_voilierDataSet.EPREUVE);
            dataGridView1.DataSource = this.bdd_voilierDataSet.EPREUVE;
        }
    }
}
