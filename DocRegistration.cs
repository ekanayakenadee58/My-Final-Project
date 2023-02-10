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
    public partial class frmDocRegistration : Form
    {
        DBConnect dBCon = new DBConnect();
        double val = 0;

        public frmDocRegistration()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Doctor";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
        }

        private void clear()
        {
            txtName.Clear();
            cmbDocReg.ResetText();
            comboBoxSpecify.ResetText();
            txtTPNO.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
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
                errorProvider1.SetError(txtName, "Doctor Name is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, String.Empty);
            }

            if (cmbDocReg.SelectedItem == null)
            {
                errorProvider2.SetError(cmbDocReg, "Doctor Gender is Required");
                return;
            }
            else
            {
                errorProvider2.Clear();
            }

            if (comboBoxSpecify.SelectedItem == null)
            {
                errorProvider3.SetError(comboBoxSpecify, "Doctor Specialization is Required");
                return;
            }
            else
            {
                errorProvider3.Clear();
            }

            if (String.IsNullOrEmpty(txtTPNO.Text.Trim()))
            {
                errorProvider4.SetError(txtTPNO, "Doctor T.P Number is Required");
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
                errorProvider5.SetError(txtEmail, "Doctor Email is Required");
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

                        string insertQuery = "INSERT INTO Doctor VALUES (" + labelID.Text + ",'" + txtName.Text + "','" + cmbDocReg.Text + "','" + comboBoxSpecify.Text + "','" + txtTPNO.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "')";
                        SqlCommand command = new SqlCommand(insertQuery, dBCon.Getcon());
                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Doctor Added Sucssesfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtName.Clear();
            cmbDocReg.ResetText();
            comboBoxSpecify.ResetText();
            txtTPNO.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void frmDocRegistration_Load(object sender, EventArgs e)
        {
            AutoIDNUMBER();
        }

        private void AutoIDNUMBER()
        {
            dBCon.OpenCon();
            SqlCommand cmd = new SqlCommand("Select count (DoctorId) from [Doctor]", dBCon.Getcon());
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            dBCon.CloseCon();
            i++;
            labelID.Text = val + i.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmREG reg = new frmREG();
            reg.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
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
