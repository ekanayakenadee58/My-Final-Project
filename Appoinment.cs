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
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace G_Pro_Try
{
    public partial class frmAppoinments : Form
    {

        DBConnect dBCon = new DBConnect();
        double val = 0;
        public static string to;
        
        public frmAppoinments()
        {
            InitializeComponent();
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
            string selectQuerry = "SELECT * FROM Appintments";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
        }
        
        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAppoinments_Load(object sender, EventArgs e)
        {
            AutoIDNUMBER();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblexit_MouseEnter(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Red;
        }

        private void lblexit_MouseLeave(object sender, EventArgs e)
        {
            lblexit.ForeColor = Color.Black;
        }


        private void clear()
        {

            txtName.Clear();
            txtTPNO.Clear();
            txtEmail.Clear();
            cmbboxConsultant.ResetText();
            AutoIDNUMBER();
        }
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            

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

            {
                string pattern1 = @"^[0-9]{10}$";
                if (Regex.IsMatch(txtTPNO.Text, pattern1))
                {
                    errorProvider7.Clear();
                }
                else
                {
                    errorProvider7.SetError(this.txtTPNO, "Please Enter Valid Mobile Number");
                    return;
                }
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

                if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                errorProvider3.SetError(txtEmail, "Patient Email is Required");
                return;
            }
            else
            {
                errorProvider3.SetError(txtEmail, String.Empty);
            }

            if (cmbboxConsultant.SelectedItem == null)
            {
                errorProvider4.SetError(cmbboxConsultant, "Consultant Name is Required");
                return;
            }
            else
            {
                errorProvider4.Clear();
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

                string insertQuery = "INSERT INTO Appintments VALUES (" + labelID.Text + ", '" + txtName.Text + "','" + txtTPNO.Text + "','" + txtEmail.Text + "','" + cmbboxConsultant.Text + "' ,'" + DateTimePickerAppoinment.Value.Date + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.Getcon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Appointment Added Sucssesfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                AutoIDNUMBER();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            }


            {
                string frommail = "wecarediagnosis@gmail.com";
                string frompassword = "pqhpfhrzfzmrvlsl";

                MailMessage message = new MailMessage();
                message.From = new MailAddress(frommail);
                message.Subject = "Appointment Details";
                message.To.Add(txtEmail.Text.ToString().Trim());
                message.Body = "<html><body><p>Dear Sir/Madam,</p><p>Your Appointment Added Successfully<br>Thank You for Choosing Us!</p><p>WECARE Diagnosis Pvt Ltd. Kandy.<br>Contact Us : 0812255875</p> </body></html>";
                message.IsBodyHtml = true;

                var SmtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(frommail, frompassword),
                    EnableSsl = true,
                };

                try
                {
                    SmtpClient.Send(message);
                    MessageBox.Show("Sent Email", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
            }

            clear();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtTPNO.Clear();
            txtEmail.Clear();
            cmbboxConsultant.ResetText();
            AutoIDNUMBER();
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

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
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

        private void lblMIN_MouseEnter(object sender, EventArgs e)
        {
            lblMIN.ForeColor = Color.Red;
        }

        private void lblMIN_MouseLeave(object sender, EventArgs e)
        {
            lblMIN.ForeColor = Color.Black;
        }

        private void lblMIN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
