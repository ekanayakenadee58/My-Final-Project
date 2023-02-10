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
    public partial class frmCategoryByDoc : Form
    {
        DBConnect dBCon = new DBConnect();
        double val = 0;
        
        public frmCategoryByDoc()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewCategoriesByDoc.DataSource = table;
        }

        private void clear()
        {
            AutoIDNUMBER();
            txtName.Clear();
            
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
                SqlCommand command = new SqlCommand(insertQuery, dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added Sucssesfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errorProvider1.SetError(txtName, "Category Name is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, String.Empty);
            }
            
            try
            {
                string updateQuery = "UPDATE Category SET CategoryName='" + txtName.Text + "' WHERE CategoryId=" + labelID.Text + "";
                SqlCommand command = new SqlCommand(updateQuery, dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Updated Sucssesfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DataGridViewCategoriesByDoc_Click(object sender, EventArgs e)
        {
            labelID.Text = DataGridViewCategoriesByDoc.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = DataGridViewCategoriesByDoc.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            
            txtName.Clear();
            AutoIDNUMBER();
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
        
        private void frmCategoryByDoc_Load(object sender, EventArgs e)
        {
            getTable();
            AutoIDNUMBER();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmDoctor_Home_Page doc = new frmDoctor_Home_Page();
            doc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDiseasesByDoc dis = new frmDiseasesByDoc();
            dis.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSymptomsDoc sym = new frmSymptomsDoc();
            sym.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCategoryByDoc cat = new frmCategoryByDoc();
            cat.Show();
            this.Hide();
        }

    }
}
