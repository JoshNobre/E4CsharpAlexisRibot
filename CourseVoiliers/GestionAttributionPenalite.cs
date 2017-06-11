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
    public partial class GestionAttributionPenalite : Form
    {
        public GestionAttributionPenalite()
        {
            InitializeComponent();
        }

        private void GestionAttributionPenalite_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet.VOILIER'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vOILIERTableAdapter.Fill(this.bdd_voilierDataSet.VOILIER);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet.COURSE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cOURSETableAdapter.Fill(this.bdd_voilierDataSet.COURSE);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet.EPREUVE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ePREUVETableAdapter.Fill(this.bdd_voilierDataSet.EPREUVE);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet.PENALITE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.pENALITETableAdapter.Fill(this.bdd_voilierDataSet.PENALITE);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet.se_voire_attribuer'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.se_voire_attribuerTableAdapter.Fill(this.bdd_voilierDataSet.se_voire_attribuer);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bindingSourceSeVoireAttribuer.EndEdit();
            se_voire_attribuerTableAdapter.Update(bdd_voilierDataSet.se_voire_attribuer);
        }
    }
}
