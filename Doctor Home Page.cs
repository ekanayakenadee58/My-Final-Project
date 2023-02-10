using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Pro_Try
{
    public partial class frmDoctor_Home_Page : Form
    {
        public frmDoctor_Home_Page()
        {
            InitializeComponent();
        }

        private void lblexit_MouseEnter(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Red;
        }

        private void lblexit_MouseLeave(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.DarkGray;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmDiseasesByDoc dis = new frmDiseasesByDoc();
            dis.Show();
            this.Hide();
;
        }

        private void btnmagediseases_Click(object sender, EventArgs e)
        {
            frmDiseasesByDoc dis = new frmDiseasesByDoc();
            dis.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmCategoryByDoc type = new frmCategoryByDoc();
            type.Show();
            this.Hide();
        }

        private void btndistypes_Click(object sender, EventArgs e)
        {
            frmCategoryByDoc type = new frmCategoryByDoc();
            type.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmSymptomsDoc sym = new frmSymptomsDoc();
            sym.Show();
            this.Hide();
        }

        private void brndissym_Click(object sender, EventArgs e)
        {
            frmSymptomsDoc sym = new frmSymptomsDoc();
            sym.Show();
            this.Hide();
        }
        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmDetails dit = new frmDetails();
            dit.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }

        private void btnDisInfo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDTS_Click(object sender, EventArgs e)
        {

        }

    }
}
