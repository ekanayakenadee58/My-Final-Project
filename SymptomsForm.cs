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
    public partial class frmSymptomsForm : Form
    {
        DBConnect dBCon = new DBConnect();
        double val = 0;

        public frmSymptomsForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Symptom";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewSymptoms.DataSource = table;
        }


        private void AutoIDNUMBER()
        {
            dBCon.OpenCon();
            SqlCommand cmd = new SqlCommand("Select count (SymptomId) from [Symptom]", dBCon.Getcon());
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            dBCon.CloseCon();
            i++;
            labelID.Text = val + i.ToString();
        }
        
        private void clear()
        {
            
            txtName.Clear();
            txtDisease.Clear();
            AutoIDNUMBER();
        }
        
        private void lblClear_Click(object sender, EventArgs e)
        {
            
            txtName.Clear();
            txtDisease.Clear();
            AutoIDNUMBER();
        }

        private void frmSymptomsForm_Load(object sender, EventArgs e)
        {
            getTable();
            AutoIDNUMBER();
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

        private void lbllgout_Click(object sender, EventArgs e)
        {
            frmAdmin_Home_Page Admin = new frmAdmin_Home_Page();
            Admin.Show();
            this.Hide();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "Symptom Name is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, String.Empty);
            }

            if (String.IsNullOrEmpty(txtDisease.Text.Trim()))
            {
                errorProvider2.SetError(txtDisease, "Diseases are Required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtDisease, String.Empty);
            }
            
            try
            {
                string insertQuery = "INSERT INTO Symptom VALUES(" + labelID.Text + ",'" + txtName.Text + "','" + txtDisease.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Symptom Added Sucssesfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "Symptom Name is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, String.Empty);
            }

            if (String.IsNullOrEmpty(txtDisease.Text.Trim()))
            {
                errorProvider2.SetError(txtDisease, "Diseases are Required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtDisease, String.Empty);
            }
            
            try
            {
                string updateQuery = "UPDATE Symptom SET SymptomName='" + txtName.Text + "', SymptomDisease='" + txtDisease.Text + "' WHERE SymptomId=" + labelID.Text + "";
                SqlCommand command = new SqlCommand(updateQuery, dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Symptom Updated Sucssesfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DataGridViewSymptoms_Click(object sender, EventArgs e)
        {
            labelID.Text = DataGridViewSymptoms.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = DataGridViewSymptoms.SelectedRows[0].Cells[1].Value.ToString();
            txtDisease.Text = DataGridViewSymptoms.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "Symptom Name is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, String.Empty);
            }

            if (String.IsNullOrEmpty(txtDisease.Text.Trim()))
            {
                errorProvider2.SetError(txtDisease, "Diseases are Required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtDisease, String.Empty);
            }
            
            try
            {
                if ((MessageBox.Show("Are You sure you want to delete this?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    string deleteQuery = "DELETE FROM Symptom WHERE SymptomId=" + labelID.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, dBCon.Getcon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Symptom Deleted Sucssesfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        

        private void btnSymptomss_Click(object sender, EventArgs e)
        {
            frmSymptomsForm sym = new frmSymptomsForm();
            sym.Show();
            this.Hide();
        }

        private void btnDiseases_Click(object sender, EventArgs e)
        {
            frmDiseasesForm dis = new frmDiseasesForm();
            dis.Show();
            this.Hide();
        }

        private void btnnDoctor_Click(object sender, EventArgs e)
        {
            frmDoctorForm doc = new frmDoctorForm();
            doc.Show();
            this.Hide();
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            frmCategoryForm cat = new frmCategoryForm();
            cat.Show();
            this.Hide();
        }

        private void btnAppoinments_Click(object sender, EventArgs e)
        {
            frmAppoinments_by_Admin app = new frmAppoinments_by_Admin();
            app.Show();
            this.Hide();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            frmPatientForm patient = new frmPatientForm();
            patient.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdmin_Home_Page adh = new frmAdmin_Home_Page();
            adh.Show();
            this.Hide();
        }
    }
}
