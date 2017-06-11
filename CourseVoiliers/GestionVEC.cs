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
    public partial class GestionVEC : Form
    {
        public GestionVEC()
        {
            InitializeComponent();
        }

        private void GestionVEC_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet_ALL.VOILIER'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vOILIERTableAdapter.Fill(this.bdd_voilierDataSet_ALL.VOILIER);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet_ALL.COURSE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cOURSETableAdapter.Fill(this.bdd_voilierDataSet_ALL.COURSE);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet_ALL.EPREUVE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ePREUVETableAdapter.Fill(this.bdd_voilierDataSet_ALL.EPREUVE);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet_ALL.VEC'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vECTableAdapter.Fill(this.bdd_voilierDataSet_ALL.VEC);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            vECTableAdapter.Update(bdd_voilierDataSet_ALL.VEC);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            vECTableAdapter.Update(bdd_voilierDataSet_ALL.VEC);
        }
    }
}
