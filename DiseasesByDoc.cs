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
    public partial class frmDiseasesByDoc : Form
    {
        DBConnect dBCon = new DBConnect();
        double val = 0;

        public frmDiseasesByDoc()
        {
            InitializeComponent();
        }


        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     
        private void getSymptom()
        {
            string selectQuerry = "SELECT * FROM Symptom";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbboxSymptom.DataSource = table;
            cmbboxSymptom.ValueMember = "SymptomName";

            
        }

        private void getType()
        {
            string selectQuerry = "SELECT * FROM category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbxtype.DataSource = table;
            cmbxtype.ValueMember = "CategoryName";


        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Diseases";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewDiseasesbyDoc.DataSource = table;
        }

        private void clear()
        {
            
            txtName.Clear();
            cmbxtype.ResetText();
            comboBoxConsultant.ResetText();
            cmbboxSymptom.ResetText();
            AutoIDNUMBER();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "Disease Name is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, String.Empty);
            }

            if (cmbxtype.SelectedItem == null)
            {
                errorProvider2.SetError(cmbxtype, "Disease Type is Required");
                return;
            }
            else
            {
                errorProvider2.Clear();
            }

            if (comboBoxConsultant.SelectedItem == null)
            {
                errorProvider3.SetError(comboBoxConsultant, "Consultant Name is Required");
                return;
            }
            else
            {
                errorProvider3.Clear();
            }

            if (cmbboxSymptom.SelectedItem == null)
            {
                errorProvider4.SetError(cmbboxSymptom, "Symptom is Required");
                return;
            }
            else
            {
                errorProvider4.Clear();
            }
            
            try
            {

            string insertQuery = "INSERT INTO Diseases VALUES (" + labelID.Text + ", '" + txtName.Text + "','" + cmbxtype.Text + "','" + comboBoxConsultant.Text + "','" + cmbboxSymptom.Text + "')";
            SqlCommand command = new SqlCommand(insertQuery, dBCon.Getcon());
            dBCon.OpenCon();
            command.ExecuteNonQuery();
            MessageBox.Show("Disease Added Sucssesfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dBCon.CloseCon();
            getTable();
            clear();
            AutoIDNUMBER();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "Disease Name is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, String.Empty);
            }

            if (cmbxtype.SelectedItem == null)
            {
                errorProvider2.SetError(cmbxtype, "Disease Type is Required");
                return;
            }
            else
            {
                errorProvider2.Clear();
            }

            if (comboBoxConsultant.SelectedItem == null)
            {
                errorProvider3.SetError(comboBoxConsultant, "Consultant Name is Required");
                return;
            }
            else
            {
                errorProvider3.Clear();
            }

            if (cmbboxSymptom.SelectedItem == null)
            {
                errorProvider4.SetError(cmbboxSymptom, "Symptom is Required");
                return;
            }
            else
            {
                errorProvider4.Clear();
            }
            
            
            try
            {
                string updateQuary = "UPDATE Diseases SET DiseaseName='" + txtName.Text + "', DiseaseType='" + cmbxtype.Text + "', DiseaseConsaltant='" + comboBoxConsultant.Text + "', DiseaseSymptom='" + cmbboxSymptom.Text + "' WHERE DiseaseId = " + labelID.Text + "";
                SqlCommand command = new SqlCommand(updateQuary, dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Disease Update Sucssesfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
                AutoIDNUMBER();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        

        private void lblClear_Click(object sender, EventArgs e)
        {
            
            txtName.Clear();
            cmbxtype.ResetText();
            comboBoxConsultant.ResetText();
            cmbboxSymptom.ResetText();
            AutoIDNUMBER();
        }

        
        private void AutoIDNUMBER()
        {
            dBCon.OpenCon();
            SqlCommand cmd = new SqlCommand("Select count (DiseaseId) from [Diseases]", dBCon.Getcon());
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            dBCon.CloseCon();
            i++;
            labelID.Text = val + i.ToString();
        }
        
        private void frmDiseasesByDoc_Load(object sender, EventArgs e)
        {
            getSymptom();
            getType();
            getTable();
            AutoIDNUMBER();
        }

        
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void DataGridViewDiseasesbyDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewDiseasesbyDoc.CurrentRow.Selected = true;
            labelID.Text = DataGridViewDiseasesbyDoc.Rows[e.RowIndex].Cells["DiseaseId"].Value.ToString();
            txtName.Text = DataGridViewDiseasesbyDoc.Rows[e.RowIndex].Cells["DiseaseName"].Value.ToString();
            cmbxtype.Text = DataGridViewDiseasesbyDoc.Rows[e.RowIndex].Cells["DiseaseType"].Value.ToString();
            comboBoxConsultant.Text = DataGridViewDiseasesbyDoc.Rows[e.RowIndex].Cells["DiseaseConsaltant"].Value.ToString();
            cmbboxSymptom.Text = DataGridViewDiseasesbyDoc.Rows[e.RowIndex].Cells["DiseaseSymptom"].Value.ToString();
        }

        private void btnDiseases_Click(object sender, EventArgs e)
        {
            frmDiseasesByDoc dis = new frmDiseasesByDoc();
            dis.Show();
            this.Hide();
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            frmCategoryByDoc cat = new frmCategoryByDoc();
            cat.Show();
            this.Hide();
        }

        private void btnSymptoms_Click(object sender, EventArgs e)
        {
            frmSymptomsDoc sym = new frmSymptomsDoc();
            sym.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmDoctor_Home_Page doc = new frmDoctor_Home_Page();
            doc.Show();
            this.Hide();
        }
    }
}
