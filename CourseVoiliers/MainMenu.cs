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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Voilier form = new Voilier();
            form.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Course form = new Course();
            form.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            VEC form = new VEC();
            form.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Penalite form = new Penalite();
            form.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Epreuve form = new Epreuve();
            form.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Personne form = new Personne();
            form.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Classement form = new Classement();
            form.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            GestionAttributionPenalite form = new GestionAttributionPenalite();
            form.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            ClassementGen form = new ClassementGen();
            form.ShowDialog();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            FormConnexion form = new FormConnexion();
            if(form.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Entreprise form = new Entreprise();
            form.Show();
        }
    }
}
