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
    public partial class GestionPenalite : Form
    {
        public GestionPenalite()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bindingSourcePenalite.EndEdit();
            pENALITETableAdapter.Update(bdd_voilierDataSet.PENALITE);
        }

        private void GestionPenalite_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet.PENALITE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.pENALITETableAdapter.Fill(this.bdd_voilierDataSet.PENALITE);

        }
    }
}
