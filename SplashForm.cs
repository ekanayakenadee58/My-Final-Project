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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProBar1.Value != 100)
            {
                ProBar1.Value++;
            }
            else
            {
                frmWelcomeForm welcome = new frmWelcomeForm();
                welcome.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }

        private void ProBar1_Click(object sender, EventArgs e)
        {

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
