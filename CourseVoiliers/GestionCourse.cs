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
    public partial class GestionCourse : Form
    {
        public GestionCourse()
        {
            InitializeComponent();
        }

        private void GestionCourse_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet.COURSE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cOURSETableAdapter.Fill(this.bdd_voilierDataSet.COURSE);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bindingSourceCourse.EndEdit();
            cOURSETableAdapter.Update(bdd_voilierDataSet.COURSE);
        }
    }
}
