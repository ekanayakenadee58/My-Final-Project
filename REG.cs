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
    public partial class frmREG : Form
    {
        public frmREG()
        {
            InitializeComponent();
        }

        private void lblexit_MouseEnter(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Red;
        }

        private void lblexit_MouseLeave(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.DarkCyan;
        }


        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            frmDocRegistration docreg = new frmDocRegistration();
            docreg.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            frmPatientReg patientreg = new frmPatientReg();
            patientreg.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmDocRegistration docreg = new frmDocRegistration();
            docreg.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmPatientReg patientreg = new frmPatientReg();
            patientreg.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmWelcomeForm well = new frmWelcomeForm();
            well.Show();
            this.Hide();
        }

        

        

        private void btnDocReg_Click_1(object sender, EventArgs e)
        {
            frmDocRegistration docreg = new frmDocRegistration();
            docreg.Show();
            this.Hide();
        }

        private void btnPatientReg_Click(object sender, EventArgs e)
        {
            frmPatientReg patreg = new frmPatientReg();
            patreg.Show();
            this.Hide();
        }

        
    }
}
