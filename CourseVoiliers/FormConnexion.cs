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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = sqlserver.montpellier.epsi.fr, 4433; 
            Initial Catalog = bdd_voilier; Persist Security Info = True; User ID = alexis.ribot; Password = epsi951FTT;");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from utilisateur where Login = '" +
                textBox1.Text + "' AND Password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows[0][0].ToString() == "1")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Mot de passe ou login incorrect");
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void InitialiseTextBox()
        {
            
        }
    }
}
