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
using System.Text.RegularExpressions;

namespace G_Pro_Try
{
    public partial class frmAppoinments_by_Admin : Form
    {

        DBConnect dBCon = new DBConnect();
        double val = 0;
        
        public frmAppoinments_by_Admin()
        {
            InitializeComponent();
        }

        private void lbllgout_Click(object sender, EventArgs e)
        {
            frmAdmin_Home_Page docH = new frmAdmin_Home_Page();
            docH.Show();
            this.Hide();
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
            lblexit.ForeColor = Color.Black;
        }

        private void lbllgout_MouseEnter(object sender, EventArgs e)
        {
            lbllgout.ForeColor = Color.Red;
        }

        private void lbllgout_MouseLeave(object sender, EventArgs e)
        {
            lbllgout.ForeColor = Color.Black;
        }

        private void lblpatient_Click(object sender, EventArgs e)
        {
            frmPatientForm pat = new frmPatientForm();
            pat.Show();
            this.Hide();
        }

        private void AutoIDNUMBER()
        {
            dBCon.OpenCon();
            SqlCommand cmd = new SqlCommand("Select count (AppoinmentID) from [Appintments]", dBCon.Getcon());
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            dBCon.CloseCon();
            i++;
            labelID.Text = val + i.ToString();
        }

        private void getTable()
        {
            dBCon.OpenCon();
            string selectQuerry = "SELECT * FROM Appintments";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewAppoinment.DataSource = table;
            dBCon.CloseCon();
        }

        private void clear()
        {

            txtName.Clear();
            txtTPNO.Clear();
            txtEmail.Clear();
            cmbboxConsultant.ResetText();
            AutoIDNUMBER();
        }

        private void frmAppoinments_by_Admin_Load(object sender, EventArgs e)
        {
            getTable();
            AutoIDNUMBER();
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
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

            if (String.IsNullOrEmpty(txtTPNO.Text.Trim()))
            {
                errorProvider2.SetError(txtTPNO, "Patient TP No is Required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtTPNO, String.Empty);
            }

            if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                errorProvider3.SetError(txtEmail, "Patient Email is Required");
                return;
            }
            else
            {
                errorProvider3.SetError(txtEmail, String.Empty);
            }

            if (String.IsNullOrEmpty(cmbboxConsultant.Text.Trim()))
            {
                errorProvider4.SetError(cmbboxConsultant, "Consultant Name is Required");
                return;
            }
            else
            {
                errorProvider4.SetError(cmbboxConsultant, String.Empty);
            }

            if (String.IsNullOrEmpty(DateTimePickerAppoinment.Text.Trim()))
            {
                errorProvider5.SetError(DateTimePickerAppoinment, "Appointment Date is Required");
                return;
            }
            else
            {
                errorProvider5.SetError(DateTimePickerAppoinment, String.Empty);
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

            try
            {
                string updateQuary = "UPDATE Appintments SET AppoinName ='" + txtName.Text + "', AppoinTPNo ='" + txtTPNO.Text + "', AppointEmail ='" + txtEmail.Text + "', AppoinConsultant ='" + cmbboxConsultant.Text + "' , AppoinDate ='" + DateTimePickerAppoinment.Value.Date + "' WHERE AppoinmentID = " + labelID.Text + "";
                SqlCommand command = new SqlCommand(updateQuary, dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Appoinment Update Sucssesfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
                AutoIDNUMBER();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void lblExitt_MouseEnter(object sender, EventArgs e)
        {
            lblExitt.ForeColor = Color.Red;
        }

        private void lblExitt_MouseLeave(object sender, EventArgs e)
        {
            lblExitt.ForeColor = Color.Black;
        }

        private void lblExitt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void lblClear_Click(object sender, EventArgs e)
        {
            {

                txtName.Clear();
                txtTPNO.Clear();
                txtEmail.Clear();
                cmbboxConsultant.ResetText();
                AutoIDNUMBER();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

            if (String.IsNullOrEmpty(txtTPNO.Text.Trim()))
            {
                errorProvider2.SetError(txtTPNO, "Patient TP No is Required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtTPNO, String.Empty);
            }

            if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                errorProvider3.SetError(txtEmail, "Patient Email is Required");
                return;
            }
            else
            {
                errorProvider3.SetError(txtEmail, String.Empty);
            }

            if (String.IsNullOrEmpty(cmbboxConsultant.Text.Trim()))
            {
                errorProvider4.SetError(cmbboxConsultant, "Consultant Name is Required");
                return;
            }
            else
            {
                errorProvider4.SetError(cmbboxConsultant, String.Empty);
            }

            if (String.IsNullOrEmpty(DateTimePickerAppoinment.Text.Trim()))
            {
                errorProvider5.SetError(DateTimePickerAppoinment, "Appointment Date is Required");
                return;
            }
            else
            {
                errorProvider5.SetError(DateTimePickerAppoinment, String.Empty);
            }


            try
            {
                if ((MessageBox.Show("Are You sure you want to delete this?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    string deleteQuery = "DELETE FROM Appintments WHERE AppoinmentID= " + labelID.Text + " ";
                    SqlCommand command = new SqlCommand(deleteQuery, dBCon.Getcon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Appointment Deleted Sucssesfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                    AutoIDNUMBER();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridViewAppoinment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewAppoinment.CurrentRow.Selected = true;
            labelID.Text = DataGridViewAppoinment.Rows[e.RowIndex].Cells["AppoinmentID"].Value.ToString();
            txtName.Text = DataGridViewAppoinment.Rows[e.RowIndex].Cells["AppoinName"].Value.ToString();
            txtTPNO.Text = DataGridViewAppoinment.Rows[e.RowIndex].Cells["AppoinTPNo"].Value.ToString();
            txtEmail.Text = DataGridViewAppoinment.Rows[e.RowIndex].Cells["AppointEmail"].Value.ToString();
            cmbboxConsultant.Text = DataGridViewAppoinment.Rows[e.RowIndex].Cells["AppoinConsultant"].Value.ToString();
            DateTimePickerAppoinment.Text = DataGridViewAppoinment.Rows[e.RowIndex].Cells["AppoinDate"].Value.ToString();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdmin_Home_Page adh = new frmAdmin_Home_Page();
            adh.Show();
            this.Hide();
        }

        private void btnSymptomss_Click(object sender, EventArgs e)
        {
            frmAppoinments_by_Admin app = new frmAppoinments_by_Admin();
            app.Show();
            this.Hide();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            frmDoctorForm doc = new frmDoctorForm();
            doc.Show();
            this.Hide();

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            frmPatientForm patient = new frmPatientForm();
            patient.Show();
            this.Hide();
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            frmCategoryForm cat = new frmCategoryForm();
            cat.Show();
            this.Hide();
        }

        private void btnDiseases_Click(object sender, EventArgs e)
        {
            frmDiseasesForm dis = new frmDiseasesForm();
            dis.Show();
            this.Hide();
        }

        private void btnSymptoms_Click(object sender, EventArgs e)
        {
            frmSymptomsForm sym = new frmSymptomsForm();
            sym.Show();
            this.Hide();
        }

        private void DataGridViewAppoinment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewAppoinment.CurrentRow.Selected = true;
            labelID.Text = DataGridViewAppoinment.Rows[e.RowIndex].Cells["AppoinmentID"].Value.ToString();
            txtName.Text = DataGridViewAppoinment.Rows[e.RowIndex].Cells["AppoinName"].Value.ToString();
            txtTPNO.Text = DataGridViewAppoinment.Rows[e.RowIndex].Cells["AppoinTPNo"].Value.ToString();
            txtEmail.Text = DataGridViewAppoinment.Rows[e.RowIndex].Cells["AppointEmail"].Value.ToString();
            cmbboxConsultant.Text = DataGridViewAppoinment.Rows[e.RowIndex].Cells["AppoinConsultant"].Value.ToString();
            DateTimePickerAppoinment.Text = DataGridViewAppoinment.Rows[e.RowIndex].Cells["AppoinDate"].Value.ToString();
        }

        

    
    }

}
