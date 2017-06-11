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
    public partial class Classement : Form
    {
        public Classement()
        {
            InitializeComponent();
            dataGridView1.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Classement_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet8.getTimes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.getTimesTableAdapter2.Fill(this.bdd_voilierDataSet8.getTimes);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet2.EPREUVE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ePREUVETableAdapter.Fill(this.bdd_voilierDataSet2.EPREUVE);
            // TODO: cette ligne de code charge les données dans la table 'bdd_voilierDataSet2.COURSE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cOURSETableAdapter.Fill(this.bdd_voilierDataSet2.COURSE);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = sqlserver.montpellier.epsi.fr, 4433; 
            Initial Catalog = bdd_voilier; Persist Security Info = True; User ID = alexis.ribot; Password = epsi951FTT;");
            SqlDataAdapter sda = new SqlDataAdapter("select * from getTimes where Id_Course = '" + comboBox1.SelectedValue+ "' and Id_Epreuve = '" + comboBox2.SelectedValue +  "' order by [Temps réel] asc", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.Show();
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = i + 1;
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
