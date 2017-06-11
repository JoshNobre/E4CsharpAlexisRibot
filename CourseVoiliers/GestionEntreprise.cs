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
    public partial class GestionEntreprise : Form
    {
        public GestionEntreprise()
        {
            InitializeComponent();
        }

        private void GestionEntreprise_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet.ENTREPRISE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.eNTREPRISETableAdapter.Fill(this.bdd_voilierDataSet.ENTREPRISE);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bindingSourceEntreprise.EndEdit();
            eNTREPRISETableAdapter.Update(bdd_voilierDataSet.ENTREPRISE);
        }
    }
}
