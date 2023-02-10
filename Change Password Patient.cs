using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace G_Pro_Try
{
    public partial class frmChange_Password_Patient : Form
    {
        DBConnect dBCon = new DBConnect();

        public frmChange_Password_Patient()
        {
            InitializeComponent();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChange_Password cha = new frmChange_Password();
            cha.Show();
            this.Hide();
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

        private SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nadeeshani\Documents\WECAREdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                errorProvider2.SetError(txtUserName, "UserName is Required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtUserName, String.Empty);
            }

            if (String.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                errorProvider3.SetError(txtCurrentPassword, "Please Enter Current Password");
                return;
            }
            else
            {
                errorProvider3.SetError(txtCurrentPassword, String.Empty);
            }

            if (String.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                errorProvider4.SetError(txtNewPassword, "Password is Required");
                return;
            }
            else
            {
                errorProvider4.SetError(txtNewPassword, String.Empty);
            }

            if (String.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                errorProvider5.SetError(txtConfirmPassword, "Password is Required");
                return;
            }
            else
            {
                errorProvider5.SetError(txtConfirmPassword, String.Empty);
            }
            
            
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT(*) FROM Patient WHERE PatientName = '" + txtUserName.Text + "' AND PatientPassword = '" + txtCurrentPassword.Text + "' ", Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            errorProvider1.Clear();

            if (table.Rows[0][0].ToString() == "1")
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    if (txtNewPassword.Text.Length > 7)
                    {
                        SqlDataAdapter cc = new SqlDataAdapter("UPDATE Patient SET PatientPassword = '" + txtNewPassword.Text + "' WHERE PatientName = '" + txtUserName.Text + "' AND PatientPassword = '" + txtCurrentPassword.Text + "'  ", Connection);
                        DataTable DataT = new DataTable();
                        cc.Fill(DataT);
                        MessageBox.Show("Password Change Sucssesfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        errorProvider4.SetError(txtNewPassword, "Set Minimum 8 Characters");
                    }
                    
                }
                else
                {
                    errorProvider1.SetError(txtNewPassword, "Unmatch Password");
                    errorProvider1.SetError(txtConfirmPassword, "Unmatch Password");
                }
            }
            else
            {
                errorProvider1.SetError(txtUserName, "Incorrect UserName");
                errorProvider1.SetError(txtCurrentPassword, "Incorrect Password");
            }

        }

        private void Clear()
        {
            txtUserName.Clear();
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }
    }
}
