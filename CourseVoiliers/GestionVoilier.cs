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

namespace CourseVoiliers
{
    public partial class GestionVoilier : Form
    {
        public GestionVoilier()
        {
            InitializeComponent();
        }

        private void GestionVoilier_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet11.listeSponsors'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listeSponsorsTableAdapter.Fill(this.bdd_voilierDataSet11.listeSponsors);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet2.COURSE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cOURSETableAdapter.Fill(this.bdd_voilierDataSet2.COURSE);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet2.VOILIER'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vOILIERTableAdapter.Fill(this.bdd_voilierDataSet2.VOILIER);
        }


        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            bindingSourceVoilier.EndEdit();
            vOILIERTableAdapter.Update(bdd_voilierDataSet2.VOILIER);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
