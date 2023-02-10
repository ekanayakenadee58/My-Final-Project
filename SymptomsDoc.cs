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
    public partial class frmSymptomsDoc : Form
    {
        DBConnect dBCon = new DBConnect();
        double val = 0;
        
        public frmSymptomsDoc()
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
            DataGridViewSymptomsdoc.DataSource = table;
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
        }
        
        private void lblexit_MouseEnter(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Red;
        }

        private void lblexit_MouseLeave(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Black;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void lblClear_Click(object sender, EventArgs e)
        {
           
            txtName.Clear();
            txtDisease.Clear();
            AutoIDNUMBER();
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

        private void DataGridViewSymptomsdoc_Click(object sender, EventArgs e)
        {
            labelID.Text = DataGridViewSymptomsdoc.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = DataGridViewSymptomsdoc.SelectedRows[0].Cells[1].Value.ToString();
            txtDisease.Text = DataGridViewSymptomsdoc.SelectedRows[0].Cells[2].Value.ToString();
        }

        
        private void frmSymptomsDoc_Load(object sender, EventArgs e)
        {
            getTable();
            AutoIDNUMBER();
        }

        private void btnSymptomss_Click(object sender, EventArgs e)
        {
            frmSymptomsDoc sym = new frmSymptomsDoc();
            sym.Show();
            this.Hide();

        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            frmCategoryByDoc cat = new frmCategoryByDoc();
            cat.Show();
            this.Hide();
        }

        private void btnDiseases_Click(object sender, EventArgs e)
        {
            frmDiseasesByDoc dis = new frmDiseasesByDoc();
            dis.Show();
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
