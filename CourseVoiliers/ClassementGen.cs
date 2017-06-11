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
    public partial class ClassementGen : Form
    {
        public ClassementGen()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ClassementGen_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet9.ClassementGeneral'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.classementGeneralTableAdapter.Fill(this.bdd_voilierDataSet9.ClassementGeneral);
            dataGridView1.Hide();

            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet2.COURSE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cOURSETableAdapter.Fill(this.bdd_voilierDataSet2.COURSE);

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = sqlserver.montpellier.epsi.fr, 4433; 
            Initial Catalog = bdd_voilier; Persist Security Info = True; User ID = alexis.ribot; Password = epsi951FTT;");
            SqlDataAdapter sda = new SqlDataAdapter("select * from ClassementGeneral where Id_Course = '" + comboBox1.SelectedValue + "' order by [Temps réel] asc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = i + 1;
            }
            dataGridView1.Show();
            con.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
