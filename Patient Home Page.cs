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
    public partial class frmPatient_Home_Page : Form
    {
        public frmPatient_Home_Page()
        {
            InitializeComponent();
        }

        private void lblexit_MouseEnter(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Red;
        }

        private void lblexit_MouseLeave(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Black;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }

        private void btnDisInfo_Click(object sender, EventArgs e)
        {
            frmDetails info = new frmDetails();
            info.Show();
            this.Hide();
        }

        private void btnMakeappoitmnet_Click(object sender, EventArgs e)
        {
            frmAppoinments app = new frmAppoinments();
            app.Show();
            this.Hide();
        }

        private void btndistypes_Click(object sender, EventArgs e)
        {
            frmView_Appoinments viewapp = new frmView_Appoinments();
            viewapp.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

    }
}
