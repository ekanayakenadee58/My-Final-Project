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
    public partial class frmCategoryForm : Form
    {
        DBConnect dBCon = new DBConnect();
        double val = 0;
        
        public frmCategoryForm()
        {
            InitializeComponent();
        }

        private void AutoIDNUMBER()
        {
            dBCon.OpenCon();
            SqlCommand cmd = new SqlCommand("Select count (CategoryId) from [Category]", dBCon.Getcon());
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            dBCon.CloseCon();
            i++;
            labelID.Text = val + i.ToString();
        }
        
        
        private void getTable()
        {
            string selectQuerry = "SELECT * FROM category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewCategories.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "Category Name is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, String.Empty);
            }
            
            try
            {
                string insertQuery = "INSERT INTO Category VALUES(" + labelID.Text + ",'" + txtName.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery,dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added Sucssesfully","Add Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getTable();
            AutoIDNUMBER();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "Category Name is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, String.Empty);
            }
            
            
            try
            {
                string updateQuery = "UPDATE Category SET CategoryName='" + txtName.Text + "' WHERE CategoryId = "+labelID.Text+"";
                SqlCommand command = new SqlCommand(updateQuery, dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Updated Sucssesfully","Update Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void dataGridViewCategories_Click(object sender, EventArgs e)
        {
           
        }

        private void DataGridViewCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridViewCategories_Click(object sender, EventArgs e)
        {
            
           
        }

        private void DataGridViewCategories_Click_1(object sender, EventArgs e)
        {
            labelID.Text = DataGridViewCategories.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = DataGridViewCategories.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void clear()
        {
            
            txtName.Clear();
            AutoIDNUMBER();
           
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            
            txtName.Clear();
            AutoIDNUMBER();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "Category Name is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, String.Empty);
            }
            
            try
            {
                if ((MessageBox.Show("Are You sure you want to delete this?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes))
                { 
                string deleteQuery = "DELETE FROM Category WHERE CategoryId=" + labelID.Text + "";
                SqlCommand command = new SqlCommand(deleteQuery, dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Deleted Sucssesfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
                AutoIDNUMBER();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblexit_MouseEnter(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Red;
        }

        private void lblexit_MouseLeave(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.DarkCyan;
        }

        

        private void lblexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDiseases_Click(object sender, EventArgs e)
        {
            frmDiseasesForm dis = new frmDiseasesForm();
            dis.Show();
            this.Hide();
        }

        private void btnTypess_Click(object sender, EventArgs e)
        {
            frmCategoryForm cat = new frmCategoryForm();
            cat.Show();
            this.Hide();
        }

        private void btnnPatient_Click(object sender, EventArgs e)
        {
            frmPatientForm patient = new frmPatientForm();
            patient.Show();
            this.Hide();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            frmDoctorForm doc = new frmDoctorForm();
            doc.Show();
            this.Hide();
        }

        private void btnSymptoms_Click(object sender, EventArgs e)
        {
            frmSymptomsForm sym = new frmSymptomsForm();
            sym.Show();
            this.Hide();
        }

        private void btnAppoinments_Click(object sender, EventArgs e)
        {
            frmAppoinments_by_Admin app = new frmAppoinments_by_Admin();
            app.Show();
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
