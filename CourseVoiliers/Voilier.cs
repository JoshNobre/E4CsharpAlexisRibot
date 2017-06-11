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
    public partial class Voilier : Form
    {
        public Voilier()
        {
            InitializeComponent();
        }

        private void Voilier_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet4.InscriptionCourse'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inscriptionCourseTableAdapter.Fill(this.bdd_voilierDataSet4.InscriptionCourse);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet2.VOILIER'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vOILIERTableAdapter1.Fill(this.bdd_voilierDataSet2.VOILIER);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionVoilier form = new GestionVoilier();
            form.ShowDialog();

            // Il faut rafraichir le DataGridView
            dataGridView1.DataSource = null;
            this.inscriptionCourseTableAdapter.Fill(this.bdd_voilierDataSet4.InscriptionCourse);
            dataGridView1.DataSource = this.bdd_voilierDataSet4.InscriptionCourse;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
