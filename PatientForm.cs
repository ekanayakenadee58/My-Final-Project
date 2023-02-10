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
    public partial class frmPatientForm : Form
    {
        DBConnect dBCon = new DBConnect();
        double val = 0;

        public frmPatientForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT  * FROM [Patient] ";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewPatient.AutoGenerateColumns = false;
            DataGridViewPatient.ColumnCount = 6;
            DataGridViewPatient.Columns[0].HeaderText = "PatientId";
            DataGridViewPatient.Columns[0].DataPropertyName = "PatientId";
            DataGridViewPatient.Columns[1].HeaderText = "PatientName";
            DataGridViewPatient.Columns[1].DataPropertyName = "PatientName";
            DataGridViewPatient.Columns[2].HeaderText = "PatientGender";
            DataGridViewPatient.Columns[2].DataPropertyName = "PatientGender";
            DataGridViewPatient.Columns[3].HeaderText = "PatientAddress";
            DataGridViewPatient.Columns[3].DataPropertyName = "PatientAddress";
            DataGridViewPatient.Columns[4].HeaderText = "PatientTPNo";
            DataGridViewPatient.Columns[4].DataPropertyName = "PatientTPNo";
            DataGridViewPatient.Columns[5].HeaderText = "PatientEmail";
            DataGridViewPatient.Columns[5].DataPropertyName = "PatientEmail";
            DataGridViewPatient.DataSource = table;
        }

        private void clear()
        {
            txtName.Clear();
            ComboxGender.ResetText();
            txtAddress.Clear();
            txtTPNO.Clear();
            txtNIC.Clear();
            AutoIDNUMBER();
        }
        
        
        private void lblexit_MouseEnter(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Red;
        }

        private void lblexit_MouseLeave(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Black;
        }

        

        

        

        private void DataGridViewPatient_Click(object sender, EventArgs e)
        {
            labelID.Text = DataGridViewPatient.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = DataGridViewPatient.SelectedRows[0].Cells[1].Value.ToString();
            ComboxGender.Text = DataGridViewPatient.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = DataGridViewPatient.SelectedRows[0].Cells[3].Value.ToString();
            txtTPNO.Text = DataGridViewPatient.SelectedRows[0].Cells[4].Value.ToString();
            txtNIC.Text = DataGridViewPatient.SelectedRows[0].Cells[5].Value.ToString();
        }

        

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            ComboxGender.ResetText();
            txtAddress.Clear();
            txtTPNO.Clear();
            txtNIC.Clear();
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
        
        
        private void frmPatientForm_Load(object sender, EventArgs e)
        {
            getTable();
            AutoIDNUMBER();
        }

        

        private void btnPatient_Click(object sender, EventArgs e)
        {
            frmPatientForm patient = new frmPatientForm();
            patient.Show();
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

        private void btnSymptoms_Click(object sender, EventArgs e)
        {
            frmSymptomsForm sym = new frmSymptomsForm();
            sym.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdmin_Home_Page adh = new frmAdmin_Home_Page();
            adh.Show();
            this.Hide();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
