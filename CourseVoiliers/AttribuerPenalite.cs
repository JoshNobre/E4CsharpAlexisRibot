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
    public partial class AttribuerPenalite : Form
    {
        public AttribuerPenalite()
        {
            InitializeComponent();
        }

        private void AttribuerPenalite_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet.se_voire_attribuer'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.se_voire_attribuerTableAdapter.Fill(this.bdd_voilierDataSet.se_voire_attribuer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionAttributionPenalite form = new GestionAttributionPenalite();
            form.ShowDialog();

            // Il faut rafraichir le DataGridView
            dataGridView1.DataSource = null;
            this.se_voire_attribuerTableAdapter.Fill(this.bdd_voilierDataSet.se_voire_attribuer);
            dataGridView1.DataSource = this.bdd_voilierDataSet.se_voire_attribuer;
        }
    }
}
