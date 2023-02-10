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
    public partial class frmView_Appoinments : Form
    {

        DBConnect dBCon = new DBConnect();
        
        public frmView_Appoinments()
        {
            InitializeComponent();
        }

        private void fetchappoindata()
        {
            string selectQuerry = "SELECT * FROM Appintments WHERE AppoinmentID = ' " + txtAppID.Text+"' ";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach(DataRow row in table.Rows)
            {
                labelID.Text = row["AppoinmentID"].ToString();
                labelName.Text = row["AppoinName"].ToString();
                labelTPNO.Text = row["AppoinTPNo"].ToString();
                labelEmail.Text = row["AppointEmail"].ToString();
                labelConsulName.Text = row["AppoinConsultant"].ToString();
                labelDate.Text = row["AppoinDate"].ToString();
                labelID.Visible = true;
                labelName.Visible =true;
                labelTPNO.Visible =true; 
                labelEmail.Visible = true;
                labelConsulName.Visible = true;
                labelDate.Visible = true;
            }
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAppID.Text.Trim()))
            {
                errorProvider1.SetError(txtAppID, "Patient Name is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtAppID, String.Empty);
            }
            
            fetchappoindata();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labelID.ResetText();
            labelName.ResetText();
            labelTPNO.ResetText();
            labelEmail.ResetText();
            labelConsulName.ResetText();
            labelDate.ResetText();
            txtAppID.Clear();


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("APPOINTMENT DETAILS", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(190, 50));
            e.Graphics.DrawString("Appointment ID      :     " + labelID.Text, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(80, 180));
            e.Graphics.DrawString("Patient Name           :     " + labelName.Text, new Font("Century Gothic",15, FontStyle.Regular), Brushes.Black, new Point(80, 250));
            e.Graphics.DrawString("Mobile Number       :     " + labelTPNO.Text, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(80, 320));
            e.Graphics.DrawString("Email Address          :     " + labelEmail.Text, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(80, 390));
            e.Graphics.DrawString("Consultant Name   :     " + labelConsulName.Text, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(80, 460));
            e.Graphics.DrawString("Appointment Date :     " + labelDate.Text, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(80, 530));

            e.Graphics.DrawString("_____________________________WE CARE_____________________________", new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(00, 1000));
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
