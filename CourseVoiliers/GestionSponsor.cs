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
    public partial class GestionSponsor : Form
    {
        public GestionSponsor()
        {
            InitializeComponent();
        }

        private void GestionSponsor_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet10.ENTREPRISE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.eNTREPRISETableAdapter.Fill(this.bdd_voilierDataSet10.ENTREPRISE);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet10.VOILIER'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vOILIERTableAdapter.Fill(this.bdd_voilierDataSet10.VOILIER);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet10.SPONSORISER'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sPONSORISERTableAdapter.Fill(this.bdd_voilierDataSet10.SPONSORISER);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            sPONSORISERTableAdapter.Update(bdd_voilierDataSet10.SPONSORISER);
        }
    }
}
