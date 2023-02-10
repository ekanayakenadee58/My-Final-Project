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
    public partial class frmDetails : Form
    {
        DBConnect dBCon = new DBConnect();
        public frmDetails()
        {
            InitializeComponent();
        }

        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM Symptom";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbboxSymptom.DataSource = table;
            cmbboxSymptom.ValueMember = "SymptomName";


        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Diseases";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewInfo.DataSource = table;
        }
        private void frmInformation_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            getTable();
            cmbboxSymptom.ResetText();
        }

        private void cmbboxSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT * FROM Diseases WHERE DiseaseSymptom = '" + cmbboxSymptom.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewInfo.DataSource = table;
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

        private void lbllgout_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            frmAppoinments app = new frmAppoinments();
            app.Show();
            this.Hide();
        }


        private void btnApp_Click(object sender, EventArgs e)
        {
            frmAppoinments app = new frmAppoinments();
            app.Show();
            this.Hide();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            frmDetails info = new frmDetails();
            info.Show();
            this.Hide();
        }

        private void btnMakeAppoinments_Click(object sender, EventArgs e)
        {
            frmAppoinments app = new frmAppoinments();
            app.Show();
            this.Hide();
        }

        private void btnViewAppointments_Click(object sender, EventArgs e)
        {
            frmView_Appoinments view = new frmView_Appoinments();
            view.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmPatient_Home_Page home = new frmPatient_Home_Page();
            home.Show();
            this.Hide();
        }
    }
}
