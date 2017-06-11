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
    public partial class GestionEpreuve : Form
    {
        public GestionEpreuve()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bindingSourceEpreuve.EndEdit();
            ePREUVETableAdapter.Update(bdd_voilierDataSet.EPREUVE);
        }

        private void GestionEpreuve_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet.EPREUVE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ePREUVETableAdapter.Fill(this.bdd_voilierDataSet.EPREUVE);

        }
    }
}
