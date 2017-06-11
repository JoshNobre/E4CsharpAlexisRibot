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
    public partial class GestionPersonne : Form
    {
        public GestionPersonne()
        {
            InitializeComponent();
        }

        private void GestionPersonne_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet1.VOILIER'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vOILIERTableAdapter.Fill(this.bdd_voilierDataSet1.VOILIER);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet1.PERSONNE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.pERSONNETableAdapter.Fill(this.bdd_voilierDataSet1.PERSONNE);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bindingSourcePersonne.EndEdit();
            pERSONNETableAdapter.Update(bdd_voilierDataSet1.PERSONNE);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
