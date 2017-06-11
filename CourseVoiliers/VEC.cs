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
    public partial class VEC : Form
    {
        public VEC()
        {
            InitializeComponent();
        }

        private void VEC_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet_ALL.VEC'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vECTableAdapter.Fill(this.bdd_voilierDataSet_ALL.VEC);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionVEC form = new GestionVEC();
            form.ShowDialog();

            // Il faut rafraichir le DataGridView
            dataGridView1.DataSource = null;
            this.vECTableAdapter.Fill(this.bdd_voilierDataSet_ALL.VEC);
            dataGridView1.DataSource = this.bdd_voilierDataSet_ALL.VEC;
        }
    }
}
