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
    public partial class Penalite : Form
    {
        public Penalite()
        {
            InitializeComponent();
        }

        private void Penalite_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet.PENALITE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.pENALITETableAdapter.Fill(this.bdd_voilierDataSet.PENALITE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionPenalite form = new GestionPenalite();
            form.ShowDialog();

            // Il faut rafraichir le DataGridView
            dataGridView1.DataSource = null;
            this.pENALITETableAdapter.Fill(this.bdd_voilierDataSet.PENALITE);
            dataGridView1.DataSource = this.bdd_voilierDataSet.PENALITE;
        }
    }
}
