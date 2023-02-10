using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace G_Pro_Try
{
    public partial class frmPatientReg : Form
    {
        DBConnect dBCon = new DBConnect();
        double val = 0;

        public frmPatientReg()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Patient";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
        }

        private void clear()
        {
            txtName.Clear();
            ComboxGender.ResetText();
            txtAddress.Clear();
            txtTPNO.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            AutoIDNUMBER();
        }

        private void lblexit_MouseEnter(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Red;
        }

        private void lblexit_MouseLeave(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.MintCream;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            if (String.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "Patient Name is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, String.Empty);
            }

            if (ComboxGender.SelectedItem == null)
            {
                errorProvider2.SetError(ComboxGender, "Patient Gender is Required");
                return;
            }
            else
            {
                errorProvider2.Clear();
            }

            if (String.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                errorProvider3.SetError(txtAddress, "Patient Address is Required");
                return;
            }
            else
            {
                errorProvider3.SetError(txtAddress, String.Empty);
            }

            if (String.IsNullOrEmpty(txtTPNO.Text.Trim()))
            {
                errorProvider4.SetError(txtTPNO, "Patient T.P Number is Required");
                return;
            }
            else
            {
                errorProvider4.SetError(txtTPNO, String.Empty);
            }

            {
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][*\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(txtEmail.Text, pattern))
                {
                    errorProvider6.Clear();
                }
                else
                {
                    errorProvider6.SetError(this.txtEmail, "Please Enter Valid Email Address");
                    return;
                }
            }

            if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                errorProvider5.SetError(txtEmail, "Patient Email is Required");
                return;
            }
            else
            {
                errorProvider5.SetError(txtEmail, String.Empty);
            }

            if (String.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorProvider6.SetError(txtPassword, "Password is Required");
                return;
            }
            else
            {
                errorProvider6.SetError(txtPassword, String.Empty);
            }

            if (txtPassword.Text.Length > 7)
            {




                Regex r = new Regex(@"^[0-9]{10}$");
                if (r.IsMatch(txtTPNO.Text))

                    try
                    {

                        string insertQuery = "INSERT INTO Patient VALUES (" + labelID.Text + ",'" + txtName.Text + "','" + ComboxGender.Text + "','" + txtAddress.Text + "','" + txtTPNO.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "')";
                        SqlCommand command = new SqlCommand(insertQuery, dBCon.Getcon());
                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Patient Added Sucssesfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dBCon.CloseCon();
                        getTable();
                        clear();
                        AutoIDNUMBER();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                else
                {
                    MessageBox.Show("Invalid Mobile Number", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTPNO.Clear();
                }
            }
            else
            {
                errorProvider4.SetError(txtPassword, "Set Minimum 8 Characters");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            ComboxGender.ResetText();
            txtAddress.Clear();
            txtTPNO.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            AutoIDNUMBER();
        }

        private void AutoIDNUMBER()
        {
            dBCon.OpenCon();
            SqlCommand cmd = new SqlCommand("Select count (PatientId) from [Patient]", dBCon.Getcon());
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            dBCon.CloseCon();
            i++;
            labelID.Text = val + i.ToString();
        }
        
        
        private void frmPatientReg_Load(object sender, EventArgs e)
        {
            AutoIDNUMBER();
        }

        private void lblNewDoctor_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmREG reg = new frmREG();
            reg.Show();
            this.Hide();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            {
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][*\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(txtEmail.Text, pattern))
                {
                    errorProvider6.Clear();
                }
                else
                {
                    errorProvider6.SetError(this.txtEmail, "Please Enter Valid Email Address");
                    return;
                }
            }
        }
    }
}
