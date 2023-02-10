namespace G_Pro_Try
{
    partial class frmDiseasesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiseasesForm));
            this.labelID = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.DataGridViewDiseases = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbboxSymptom = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSymptom = new System.Windows.Forms.Label();
            this.lblConsultant = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDTS = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSymptoms = new System.Windows.Forms.Button();
            this.btnAppoinments = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDiseasess = new System.Windows.Forms.Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnTypes = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPatient = new System.Windows.Forms.Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.comboBoxConsultant = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxtype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDiseases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.White;
            this.labelID.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.Black;
            this.labelID.Location = new System.Drawing.Point(352, 162);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(41, 26);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "ID  ";
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.BackColor = System.Drawing.Color.Transparent;
            this.lblClear.Font = new System.Drawing.Font("Minion Pro Med", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.MistyRose;
            this.lblClear.Location = new System.Drawing.Point(471, 475);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(61, 29);
            this.lblClear.TabIndex = 18;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // DataGridViewDiseases
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewDiseases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewDiseases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewDiseases.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewDiseases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewDiseases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewDiseases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDiseases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewDiseases.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewDiseases.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewDiseases.EnableHeadersVisualStyles = false;
            this.DataGridViewDiseases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewDiseases.Location = new System.Drawing.Point(586, 118);
            this.DataGridViewDiseases.Name = "DataGridViewDiseases";
            this.DataGridViewDiseases.RowHeadersVisible = false;
            this.DataGridViewDiseases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDiseases.Size = new System.Drawing.Size(751, 619);
            this.DataGridViewDiseases.TabIndex = 17;
            this.DataGridViewDiseases.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewDiseases.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewDiseases.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewDiseases.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewDiseases.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewDiseases.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewDiseases.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewDiseases.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewDiseases.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewDiseases.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewDiseases.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewDiseases.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewDiseases.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewDiseases.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridViewDiseases.ThemeStyle.ReadOnly = false;
            this.DataGridViewDiseases.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewDiseases.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewDiseases.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewDiseases.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewDiseases.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewDiseases.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewDiseases.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewDiseases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDiseases_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(363, 554);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 50);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(476, 554);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 50);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(249, 554);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 50);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbboxSymptom
            // 
            this.cmbboxSymptom.FormattingEnabled = true;
            this.cmbboxSymptom.Location = new System.Drawing.Point(345, 387);
            this.cmbboxSymptom.Name = "cmbboxSymptom";
            this.cmbboxSymptom.Size = new System.Drawing.Size(208, 30);
            this.cmbboxSymptom.TabIndex = 12;
            this.cmbboxSymptom.Text = "Select Symptom Type";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(345, 220);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 27);
            this.txtName.TabIndex = 11;
            // 
            // lblSymptom
            // 
            this.lblSymptom.AutoSize = true;
            this.lblSymptom.BackColor = System.Drawing.Color.Transparent;
            this.lblSymptom.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymptom.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblSymptom.Location = new System.Drawing.Point(219, 387);
            this.lblSymptom.Name = "lblSymptom";
            this.lblSymptom.Size = new System.Drawing.Size(112, 33);
            this.lblSymptom.TabIndex = 6;
            this.lblSymptom.Text = "Symptom";
            this.lblSymptom.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblConsultant
            // 
            this.lblConsultant.AutoSize = true;
            this.lblConsultant.BackColor = System.Drawing.Color.Transparent;
            this.lblConsultant.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultant.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblConsultant.Location = new System.Drawing.Point(213, 331);
            this.lblConsultant.Name = "lblConsultant";
            this.lblConsultant.Size = new System.Drawing.Size(128, 33);
            this.lblConsultant.TabIndex = 5;
            this.lblConsultant.Text = "Consultant";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblType.Location = new System.Drawing.Point(237, 272);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(62, 33);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblName.Location = new System.Drawing.Point(237, 215);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 33);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblID.Location = new System.Drawing.Point(239, 157);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 33);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 6;
            // 
            // lblDTS
            // 
            this.lblDTS.AutoSize = true;
            this.lblDTS.BackColor = System.Drawing.Color.Transparent;
            this.lblDTS.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTS.Location = new System.Drawing.Point(215, 9);
            this.lblDTS.Name = "lblDTS";
            this.lblDTS.Size = new System.Drawing.Size(605, 38);
            this.lblDTS.TabIndex = 5;
            this.lblDTS.Text = "\"WE CARE\" Diagnosis Tracking System";
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.BackColor = System.Drawing.Color.Transparent;
            this.lblexit.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.Black;
            this.lblexit.Location = new System.Drawing.Point(1315, -8);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(51, 59);
            this.lblexit.TabIndex = 16;
            this.lblexit.Text = "X";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            this.lblexit.MouseEnter += new System.EventHandler(this.lblexit_MouseEnter);
            this.lblexit.MouseLeave += new System.EventHandler(this.lblexit_MouseLeave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblexit);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 42);
            this.panel2.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 33);
            this.label2.TabIndex = 44;
            this.label2.Text = "Admin Dashboard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(271, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 32);
            this.label3.TabIndex = 100;
            this.label3.Text = "\"WE CARE\" Diagnosis Tracking System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnSymptoms);
            this.panel1.Controls.Add(this.btnAppoinments);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDiseasess);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnTypes);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnPatient);
            this.panel1.Controls.Add(this.guna2PictureBox2);
            this.panel1.Controls.Add(this.btnDoctor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 768);
            this.panel1.TabIndex = 49;
            // 
            // btnSymptoms
            // 
            this.btnSymptoms.BackColor = System.Drawing.Color.DimGray;
            this.btnSymptoms.FlatAppearance.BorderSize = 0;
            this.btnSymptoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSymptoms.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSymptoms.ForeColor = System.Drawing.Color.White;
            this.btnSymptoms.Location = new System.Drawing.Point(0, 506);
            this.btnSymptoms.Name = "btnSymptoms";
            this.btnSymptoms.Size = new System.Drawing.Size(213, 65);
            this.btnSymptoms.TabIndex = 134;
            this.btnSymptoms.Text = "Symptoms";
            this.btnSymptoms.UseVisualStyleBackColor = false;
            this.btnSymptoms.Click += new System.EventHandler(this.btnSymptoms_Click);
            // 
            // btnAppoinments
            // 
            this.btnAppoinments.BackColor = System.Drawing.Color.DimGray;
            this.btnAppoinments.FlatAppearance.BorderSize = 0;
            this.btnAppoinments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppoinments.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppoinments.ForeColor = System.Drawing.Color.White;
            this.btnAppoinments.Location = new System.Drawing.Point(-1, 571);
            this.btnAppoinments.Name = "btnAppoinments";
            this.btnAppoinments.Size = new System.Drawing.Size(214, 65);
            this.btnAppoinments.TabIndex = 133;
            this.btnAppoinments.Text = "Appoinments";
            this.btnAppoinments.UseVisualStyleBackColor = false;
            this.btnAppoinments.Click += new System.EventHandler(this.btnAppoinments_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(39, -19);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(122, 117);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 125;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(-11, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(759, 33);
            this.label5.TabIndex = 127;
            this.label5.Text = "______________________________________________________________";
            // 
            // btnDiseasess
            // 
            this.btnDiseasess.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDiseasess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiseasess.BackgroundImage")));
            this.btnDiseasess.FlatAppearance.BorderSize = 0;
            this.btnDiseasess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiseasess.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiseasess.ForeColor = System.Drawing.Color.White;
            this.btnDiseasess.Location = new System.Drawing.Point(-1, 246);
            this.btnDiseasess.Name = "btnDiseasess";
            this.btnDiseasess.Size = new System.Drawing.Size(214, 65);
            this.btnDiseasess.TabIndex = 130;
            this.btnDiseasess.Text = "Diseases";
            this.btnDiseasess.UseVisualStyleBackColor = false;
            this.btnDiseasess.Click += new System.EventHandler(this.btnDiseasess_Click);
            // 
            // btnHome
            // 
            this.btnHome.AutoRoundedCorners = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.BorderRadius = 19;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.Linen;
            this.btnHome.Font = new System.Drawing.Font("Minion Pro SmBd", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Location = new System.Drawing.Point(52, 707);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedColor = System.Drawing.Color.DarkGray;
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(109, 41);
            this.btnHome.TabIndex = 128;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnTypes
            // 
            this.btnTypes.BackColor = System.Drawing.Color.DimGray;
            this.btnTypes.FlatAppearance.BorderSize = 0;
            this.btnTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypes.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypes.ForeColor = System.Drawing.Color.White;
            this.btnTypes.Location = new System.Drawing.Point(0, 311);
            this.btnTypes.Name = "btnTypes";
            this.btnTypes.Size = new System.Drawing.Size(213, 65);
            this.btnTypes.TabIndex = 132;
            this.btnTypes.Text = "Types";
            this.btnTypes.UseVisualStyleBackColor = false;
            this.btnTypes.Click += new System.EventHandler(this.btnTypes_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Salmon;
            this.label9.Location = new System.Drawing.Point(8, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 33);
            this.label9.TabIndex = 124;
            this.label9.Text = "Admin Dashboard";
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.DimGray;
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.Location = new System.Drawing.Point(-1, 376);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(214, 65);
            this.btnPatient.TabIndex = 131;
            this.btnPatient.Text = "Patient";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(68, 118);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(62, 66);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 126;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackColor = System.Drawing.Color.DimGray;
            this.btnDoctor.FlatAppearance.BorderSize = 0;
            this.btnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctor.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.ForeColor = System.Drawing.Color.White;
            this.btnDoctor.Location = new System.Drawing.Point(1, 441);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(212, 65);
            this.btnDoctor.TabIndex = 129;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = false;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // comboBoxConsultant
            // 
            this.comboBoxConsultant.FormattingEnabled = true;
            this.comboBoxConsultant.Items.AddRange(new object[] {
            "Dr. Kamal Gunarathna",
            "Dr. Anil Alponsu",
            "Dr. Kumarasiri",
            "Dr. Amal Darshana",
            "Dr. Ruwan Disanayake",
            "Dr. Dinesh Arangala",
            "Dr.Dananjaya Sampath",
            "Dr. Palitha De Silva",
            "Dr. Nuwan Kumara",
            "Dr. Sumithra Kumari"});
            this.comboBoxConsultant.Location = new System.Drawing.Point(344, 333);
            this.comboBoxConsultant.Name = "comboBoxConsultant";
            this.comboBoxConsultant.Size = new System.Drawing.Size(208, 30);
            this.comboBoxConsultant.TabIndex = 51;
            this.comboBoxConsultant.Text = "Select Consultant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Minion Pro Cond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(214, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 66);
            this.label4.TabIndex = 101;
            this.label4.Text = "Manage Diseases";
            // 
            // cmbxtype
            // 
            this.cmbxtype.FormattingEnabled = true;
            this.cmbxtype.Location = new System.Drawing.Point(344, 277);
            this.cmbxtype.Name = "cmbxtype";
            this.cmbxtype.Size = new System.Drawing.Size(208, 30);
            this.cmbxtype.TabIndex = 102;
            this.cmbxtype.Text = "Select Disease Type";
            // 
            // frmDiseasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.cmbxtype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxConsultant);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DataGridViewDiseases);
            this.Controls.Add(this.cmbboxSymptom);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSymptom);
            this.Controls.Add(this.lblConsultant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDTS);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDiseasesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiseasesForm";
            this.Load += new System.EventHandler(this.DiseasesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDiseases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDTS;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSymptom;
        private System.Windows.Forms.Label lblConsultant;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbboxSymptom;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewDiseases;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxConsultant;
        private System.Windows.Forms.Button btnSymptoms;
        private System.Windows.Forms.Button btnAppoinments;
        private System.Windows.Forms.Button btnTypes;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDiseasess;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxtype;
    }
}