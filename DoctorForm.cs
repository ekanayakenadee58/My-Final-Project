using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class frmDoctorForm : Form
    {
        DBConnect dBCon = new DBConnect();
        double val = 0;

        public frmDoctorForm()
        {
            InitializeComponent();

        }

        private void getTable()
        {
            string selectQuerry = "SELECT  * FROM [Doctor] ";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewDoctor.AutoGenerateColumns = false;
            DataGridViewDoctor.ColumnCount = 6;
            DataGridViewDoctor.Columns[0].HeaderText = "DoctorId";
            DataGridViewDoctor.Columns[0].DataPropertyName = "DoctorId";
            DataGridViewDoctor.Columns[1].HeaderText = "DoctorName";
            DataGridViewDoctor.Columns[1].DataPropertyName = "DoctorName";
            DataGridViewDoctor.Columns[2].HeaderText = "DoctorGender";
            DataGridViewDoctor.Columns[2].DataPropertyName = "DoctorGender";
            DataGridViewDoctor.Columns[3].HeaderText = "DoctorSpecify";
            DataGridViewDoctor.Columns[3].DataPropertyName = "DoctorSpecify";
            DataGridViewDoctor.Columns[4].HeaderText = "DoctorTPNo";
            DataGridViewDoctor.Columns[4].DataPropertyName = "DoctorTPNo";
            DataGridViewDoctor.Columns[5].HeaderText = "DoctorEmail";
            DataGridViewDoctor.Columns[5].DataPropertyName = "DoctorEmail";
            DataGridViewDoctor.DataSource = table;

        }

        private void clear()
        {
            txtName.Clear();
            comboxGender.ResetText();
            comboBoxSpecify.ResetText();
            txtTPNO.Clear();
            txtEmail.Clear();
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

        private void lblDiseases_Click(object sender, EventArgs e)
        {
            frmDiseasesForm Diseases = new frmDiseasesForm();
            Diseases.Show();
            this.Hide();
        }

        private void lblTypesCategory_Click(object sender, EventArgs e)
        {
            frmCategoryForm Category = new frmCategoryForm();
            Category.Show();
            this.Hide();
        }

        private void lbllgout_Click(object sender, EventArgs e)
        {
            frmAdmin_Home_Page Admin = new frmAdmin_Home_Page();
            Admin.Show();
            this.Hide();
        }

        private void frmDoctorForm_Load(object sender, EventArgs e)
        {
            AutoIDNUMBER();
            getTable();
            clear();

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


        private void lblClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            comboxGender.ResetText();
            comboBoxSpecify.ResetText();
            txtTPNO.Clear();
            txtEmail.Clear();
            AutoIDNUMBER();
        }

        
        
        private void btnDiseasess_Click(object sender, EventArgs e)
        {
            frmDoctorForm doc = new frmDoctorForm();
            doc.Show();
            this.Hide();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            frmDiseasesForm dis = new frmDiseasesForm();
            dis.Show();
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

        

        private void DataGridViewDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelID.Text = DataGridViewDoctor.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = DataGridViewDoctor.SelectedRows[0].Cells[1].Value.ToString();
            comboxGender.Text = DataGridViewDoctor.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxSpecify.Text = DataGridViewDoctor.SelectedRows[0].Cells[3].Value.ToString();
            txtTPNO.Text = DataGridViewDoctor.SelectedRows[0].Cells[4].Value.ToString();
            txtEmail.Text = DataGridViewDoctor.SelectedRows[0].Cells[5].Value.ToString();
        }

    }
}
