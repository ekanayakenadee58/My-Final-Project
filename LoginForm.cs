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
    public partial class frmLogin : Form
    {
        DBConnect dBCon = new DBConnect();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblexit_MouseEnter(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Red;
        }

        private void lblexit_MouseLeave(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.MintCream;
        }

        private void lblClear_MouseEnter(object sender, EventArgs e)
        {
            lblClear.ForeColor = Color.Red;
        }

        private void lblClear_MouseLeave(object sender, EventArgs e)
        {
            lblClear.ForeColor = Color.Azure;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            comboxRole.ResetText();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                errorProvider1.SetError(txtUsername, "Username is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, String.Empty);
            }

            if (String.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtPassword, "Password is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPassword, String.Empty);
            }


            if (txtUsername.Text=="" || txtPassword.Text=="")
            {
                MessageBox.Show("Please Enter Username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 

            if (comboxRole.SelectedIndex > -1)
            {
                if (comboxRole.SelectedItem.ToString() == "Admin")
                {
                    if (txtUsername.Text == "Admin" && txtPassword.Text == "Admin98")
                    {
                        frmAdmin_Home_Page Admin  = new frmAdmin_Home_Page ();
                        Admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("If you are Admin, Please Enter the Correct Password", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        comboxRole.ResetText();
                    }
                }
                else if (comboxRole.SelectedItem.ToString() == "Doctor")
                {
                    string selectQuery = "SELECT * FROM Doctor WHERE DoctorName = '" + txtUsername.Text + "' AND DoctorPassword = '" + txtPassword.Text + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.Getcon());
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        frmDoctor_Home_Page DocHome = new frmDoctor_Home_Page();
                        DocHome.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        comboxRole.ResetText();
                    }
                }
                else 
                {
                    string selectQuery = "SELECT * FROM Patient WHERE PatientName = '" + txtUsername.Text + "' AND PatientPassword = '" + txtPassword.Text + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.Getcon());
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        frmPatient_Home_Page Home = new frmPatient_Home_Page();
                        Home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        comboxRole.ResetText();

                    }
                }

            }
            else
            {
                MessageBox.Show("Please Select Role", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Clear();
                txtPassword.Clear();
                comboxRole.ResetText();
            }

            }

        }

        private void btnwelcome_Click(object sender, EventArgs e)
        {
            frmWelcomeForm well = new frmWelcomeForm();
            well.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        private void lblreset_Click(object sender, EventArgs e)
        {
            frmChange_Password change = new frmChange_Password();
            change.Show();
            this.Hide();
        }

    }
}
