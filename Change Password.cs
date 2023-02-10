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
    public partial class frmChange_Password : Form
    {
        public frmChange_Password()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblexit_MouseEnter(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Red;
        }

        private void lblexit_MouseLeave(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.MintCream;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmChange_Password_Doc doc = new frmChange_Password_Doc();
            doc.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmChange_Password_Patient ch = new frmChange_Password_Patient();
            ch.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }
    }
}
