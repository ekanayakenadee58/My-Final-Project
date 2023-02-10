namespace G_Pro_Try
{
    partial class frmView_Appoinments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmView_Appoinments));
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTPNO = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelConsulName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAppdate = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblappID = new System.Windows.Forms.Label();
            this.lblSymptom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewAppointments = new System.Windows.Forms.Button();
            this.btnMakeAppoinments = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInformation = new System.Windows.Forms.Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblexit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblMangeDiseases = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.labelName);
            this.panel3.Controls.Add(this.labelTPNO);
            this.panel3.Controls.Add(this.labelDate);
            this.panel3.Controls.Add(this.labelEmail);
            this.panel3.Controls.Add(this.labelID);
            this.panel3.Controls.Add(this.labelConsulName);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.lblType);
            this.panel3.Controls.Add(this.lblAppdate);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.lblappID);
            this.panel3.Controls.Add(this.lblSymptom);
            this.panel3.Location = new System.Drawing.Point(402, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 483);
            this.panel3.TabIndex = 81;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelName.Location = new System.Drawing.Point(351, 103);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(145, 29);
            this.labelName.TabIndex = 75;
            this.labelName.Text = "Patient Name :";
            this.labelName.Visible = false;
            // 
            // labelTPNO
            // 
            this.labelTPNO.AutoSize = true;
            this.labelTPNO.BackColor = System.Drawing.Color.Transparent;
            this.labelTPNO.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTPNO.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTPNO.Location = new System.Drawing.Point(350, 159);
            this.labelTPNO.Name = "labelTPNO";
            this.labelTPNO.Size = new System.Drawing.Size(163, 29);
            this.labelTPNO.TabIndex = 76;
            this.labelTPNO.Text = "Mobile Number :";
            this.labelTPNO.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDate.Location = new System.Drawing.Point(351, 336);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(181, 29);
            this.labelDate.TabIndex = 80;
            this.labelDate.Text = "Appoinment Date :";
            this.labelDate.Visible = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelEmail.Location = new System.Drawing.Point(351, 220);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(138, 29);
            this.labelEmail.TabIndex = 77;
            this.labelEmail.Text = "Email Adress :";
            this.labelEmail.Visible = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelID.Location = new System.Drawing.Point(350, 47);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(163, 29);
            this.labelID.TabIndex = 79;
            this.labelID.Text = "Appoinment ID :";
            this.labelID.Visible = false;
            // 
            // labelConsulName
            // 
            this.labelConsulName.AutoSize = true;
            this.labelConsulName.BackColor = System.Drawing.Color.Transparent;
            this.labelConsulName.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsulName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelConsulName.Location = new System.Drawing.Point(350, 278);
            this.labelConsulName.Name = "labelConsulName";
            this.labelConsulName.Size = new System.Drawing.Size(180, 29);
            this.labelConsulName.TabIndex = 78;
            this.labelConsulName.Text = "Consultant Name :";
            this.labelConsulName.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClear.Location = new System.Drawing.Point(492, 407);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 56);
            this.btnClear.TabIndex = 74;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.LightPink;
            this.lblName.Location = new System.Drawing.Point(102, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 29);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "Patient Name :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.LightPink;
            this.lblType.Location = new System.Drawing.Point(101, 159);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(163, 29);
            this.lblType.TabIndex = 53;
            this.lblType.Text = "Mobile Number :";
            // 
            // lblAppdate
            // 
            this.lblAppdate.AutoSize = true;
            this.lblAppdate.BackColor = System.Drawing.Color.Transparent;
            this.lblAppdate.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppdate.ForeColor = System.Drawing.Color.LightPink;
            this.lblAppdate.Location = new System.Drawing.Point(102, 336);
            this.lblAppdate.Name = "lblAppdate";
            this.lblAppdate.Size = new System.Drawing.Size(181, 29);
            this.lblAppdate.TabIndex = 73;
            this.lblAppdate.Text = "Appoinment Date :";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPrint.Location = new System.Drawing.Point(237, 407);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 56);
            this.btnPrint.TabIndex = 62;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.LightPink;
            this.lblEmail.Location = new System.Drawing.Point(102, 220);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(138, 29);
            this.lblEmail.TabIndex = 55;
            this.lblEmail.Text = "Email Adress :";
            // 
            // lblappID
            // 
            this.lblappID.AutoSize = true;
            this.lblappID.BackColor = System.Drawing.Color.Transparent;
            this.lblappID.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblappID.ForeColor = System.Drawing.Color.LightPink;
            this.lblappID.Location = new System.Drawing.Point(101, 47);
            this.lblappID.Name = "lblappID";
            this.lblappID.Size = new System.Drawing.Size(163, 29);
            this.lblappID.TabIndex = 72;
            this.lblappID.Text = "Appoinment ID :";
            // 
            // lblSymptom
            // 
            this.lblSymptom.AutoSize = true;
            this.lblSymptom.BackColor = System.Drawing.Color.Transparent;
            this.lblSymptom.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymptom.ForeColor = System.Drawing.Color.LightPink;
            this.lblSymptom.Location = new System.Drawing.Point(101, 278);
            this.lblSymptom.Name = "lblSymptom";
            this.lblSymptom.Size = new System.Drawing.Size(180, 29);
            this.lblSymptom.TabIndex = 57;
            this.lblSymptom.Text = "Consultant Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 77;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.btnViewAppointments);
            this.panel1.Controls.Add(this.btnMakeAppoinments);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnInformation);
            this.panel1.Controls.Add(this.guna2PictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 768);
            this.panel1.TabIndex = 79;
            // 
            // btnViewAppointments
            // 
            this.btnViewAppointments.BackColor = System.Drawing.Color.Sienna;
            this.btnViewAppointments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewAppointments.BackgroundImage")));
            this.btnViewAppointments.FlatAppearance.BorderSize = 0;
            this.btnViewAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAppointments.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAppointments.ForeColor = System.Drawing.Color.MintCream;
            this.btnViewAppointments.Location = new System.Drawing.Point(-4, 457);
            this.btnViewAppointments.Name = "btnViewAppointments";
            this.btnViewAppointments.Size = new System.Drawing.Size(238, 65);
            this.btnViewAppointments.TabIndex = 97;
            this.btnViewAppointments.Text = "View Appointments";
            this.btnViewAppointments.UseVisualStyleBackColor = false;
            this.btnViewAppointments.Click += new System.EventHandler(this.btnViewAppointments_Click);
            // 
            // btnMakeAppoinments
            // 
            this.btnMakeAppoinments.BackColor = System.Drawing.Color.Sienna;
            this.btnMakeAppoinments.FlatAppearance.BorderSize = 0;
            this.btnMakeAppoinments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeAppoinments.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeAppoinments.ForeColor = System.Drawing.Color.MintCream;
            this.btnMakeAppoinments.Location = new System.Drawing.Point(-4, 391);
            this.btnMakeAppoinments.Name = "btnMakeAppoinments";
            this.btnMakeAppoinments.Size = new System.Drawing.Size(238, 65);
            this.btnMakeAppoinments.TabIndex = 96;
            this.btnMakeAppoinments.Text = "Make Appointments";
            this.btnMakeAppoinments.UseVisualStyleBackColor = false;
            this.btnMakeAppoinments.Click += new System.EventHandler(this.btnMakeAppoinments_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(49, -13);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(122, 117);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 92;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 33);
            this.label2.TabIndex = 90;
            this.label2.Text = "Patient Dashboard";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.BorderRadius = 19;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.Linen;
            this.btnLogin.Font = new System.Drawing.Font("Minion Pro SmBd", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(47, 716);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedColor = System.Drawing.Color.DarkGray;
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(109, 41);
            this.btnLogin.TabIndex = 95;
            this.btnLogin.Text = "Home";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(-9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(759, 33);
            this.label3.TabIndex = 94;
            this.label3.Text = "______________________________________________________________";
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.Sienna;
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformation.ForeColor = System.Drawing.Color.MintCream;
            this.btnInformation.Location = new System.Drawing.Point(-4, 325);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(240, 65);
            this.btnInformation.TabIndex = 91;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseVisualStyleBackColor = false;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(81, 150);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(62, 66);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 93;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblexit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 42);
            this.panel2.TabIndex = 78;
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.BackColor = System.Drawing.Color.Transparent;
            this.lblexit.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.Black;
            this.lblexit.Location = new System.Drawing.Point(1315, -13);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(51, 59);
            this.lblexit.TabIndex = 16;
            this.lblexit.Text = "X";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            this.lblexit.MouseEnter += new System.EventHandler(this.lblexit_MouseEnter);
            this.lblexit.MouseLeave += new System.EventHandler(this.lblexit_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(283, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 32);
            this.label4.TabIndex = 84;
            this.label4.Text = "\"WE CARE\" Diagnosis Tracking System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(234, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Sienna;
            this.label5.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(520, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 29);
            this.label5.TabIndex = 75;
            this.label5.Text = "Appoinment ID :";
            // 
            // txtAppID
            // 
            this.txtAppID.Location = new System.Drawing.Point(703, 173);
            this.txtAppID.Multiline = true;
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(212, 29);
            this.txtAppID.TabIndex = 82;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.BorderRadius = 17;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.PeachPuff;
            this.btnSearch.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(944, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedColor = System.Drawing.Color.DarkGray;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(109, 37);
            this.btnSearch.TabIndex = 83;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // lblMangeDiseases
            // 
            this.lblMangeDiseases.AutoSize = true;
            this.lblMangeDiseases.BackColor = System.Drawing.Color.Transparent;
            this.lblMangeDiseases.Font = new System.Drawing.Font("Minion Pro Cond", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangeDiseases.ForeColor = System.Drawing.Color.Black;
            this.lblMangeDiseases.Location = new System.Drawing.Point(231, 44);
            this.lblMangeDiseases.Name = "lblMangeDiseases";
            this.lblMangeDiseases.Size = new System.Drawing.Size(513, 88);
            this.lblMangeDiseases.TabIndex = 86;
            this.lblMangeDiseases.Text = "View Appoinments";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmView_Appoinments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lblMangeDiseases);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAppID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmView_Appoinments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Appoinments";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAppdate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblappID;
        private System.Windows.Forms.Label lblSymptom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTPNO;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelConsulName;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnViewAppointments;
        private System.Windows.Forms.Button btnMakeAppoinments;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInformation;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMangeDiseases;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}