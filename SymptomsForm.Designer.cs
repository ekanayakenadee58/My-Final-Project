namespace G_Pro_Try
{
    partial class frmSymptomsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSymptomsForm));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDisease = new System.Windows.Forms.TextBox();
            this.lblexit = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.DataGridViewSymptoms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblDisease = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPatient = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAppoinments = new System.Windows.Forms.Button();
            this.btnSymptomss = new System.Windows.Forms.Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTypes = new System.Windows.Forms.Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnnDoctor = new System.Windows.Forms.Button();
            this.btnDiseases = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSymptoms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Wheat;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Location = new System.Drawing.Point(362, 617);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 51);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Wheat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(477, 617);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 52);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Wheat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(249, 617);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 51);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(342, 195);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 39);
            this.txtName.TabIndex = 11;
            // 
            // txtDisease
            // 
            this.txtDisease.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisease.Location = new System.Drawing.Point(342, 279);
            this.txtDisease.Multiline = true;
            this.txtDisease.Name = "txtDisease";
            this.txtDisease.Size = new System.Drawing.Size(218, 200);
            this.txtDisease.TabIndex = 10;
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.BackColor = System.Drawing.Color.Transparent;
            this.lblexit.Font = new System.Drawing.Font("Calibri", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.Black;
            this.lblexit.Location = new System.Drawing.Point(1315, -10);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(51, 58);
            this.lblexit.TabIndex = 39;
            this.lblexit.Text = "X";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            this.lblexit.MouseEnter += new System.EventHandler(this.lblexit_MouseEnter);
            this.lblexit.MouseLeave += new System.EventHandler(this.lblexit_MouseLeave);
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.BackColor = System.Drawing.Color.Transparent;
            this.lblClear.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClear.Location = new System.Drawing.Point(487, 545);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(61, 29);
            this.lblClear.TabIndex = 18;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // DataGridViewSymptoms
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewSymptoms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewSymptoms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewSymptoms.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewSymptoms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewSymptoms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewSymptoms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSymptoms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewSymptoms.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewSymptoms.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewSymptoms.EnableHeadersVisualStyles = false;
            this.DataGridViewSymptoms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewSymptoms.Location = new System.Drawing.Point(592, 136);
            this.DataGridViewSymptoms.Name = "DataGridViewSymptoms";
            this.DataGridViewSymptoms.RowHeadersVisible = false;
            this.DataGridViewSymptoms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewSymptoms.Size = new System.Drawing.Size(748, 610);
            this.DataGridViewSymptoms.TabIndex = 17;
            this.DataGridViewSymptoms.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewSymptoms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewSymptoms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewSymptoms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewSymptoms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewSymptoms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewSymptoms.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewSymptoms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewSymptoms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewSymptoms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewSymptoms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewSymptoms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewSymptoms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewSymptoms.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridViewSymptoms.ThemeStyle.ReadOnly = false;
            this.DataGridViewSymptoms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewSymptoms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewSymptoms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewSymptoms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewSymptoms.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewSymptoms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewSymptoms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewSymptoms.Click += new System.EventHandler(this.DataGridViewSymptoms_Click);
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.BackColor = System.Drawing.Color.Transparent;
            this.lblDisease.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisease.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblDisease.Location = new System.Drawing.Point(231, 270);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(98, 33);
            this.lblDisease.TabIndex = 3;
            this.lblDisease.Text = "Diseases";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.White;
            this.labelID.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.Black;
            this.labelID.Location = new System.Drawing.Point(345, 141);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(42, 33);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblName.Location = new System.Drawing.Point(241, 198);
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
            this.lblID.Location = new System.Drawing.Point(246, 141);
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
            this.label1.Location = new System.Drawing.Point(90, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 34;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblexit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 42);
            this.panel2.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnSymptomss);
            this.panel1.Controls.Add(this.btnPatient);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.btnAppoinments);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.guna2PictureBox2);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnDiseases);
            this.panel1.Controls.Add(this.btnnDoctor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnTypes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 768);
            this.panel1.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Minion Pro Cond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(220, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(595, 66);
            this.label2.TabIndex = 105;
            this.label2.Text = "Manage Symptoms of Diseases";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(271, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 32);
            this.label3.TabIndex = 106;
            this.label3.Text = "\"WE CARE\" Diagnosis Tracking System";
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.DimGray;
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.Location = new System.Drawing.Point(0, 387);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(213, 65);
            this.btnPatient.TabIndex = 167;
            this.btnPatient.Text = "Patient";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(41, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(122, 117);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 158;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnAppoinments
            // 
            this.btnAppoinments.BackColor = System.Drawing.Color.DimGray;
            this.btnAppoinments.FlatAppearance.BorderSize = 0;
            this.btnAppoinments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppoinments.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppoinments.ForeColor = System.Drawing.Color.White;
            this.btnAppoinments.Location = new System.Drawing.Point(0, 583);
            this.btnAppoinments.Name = "btnAppoinments";
            this.btnAppoinments.Size = new System.Drawing.Size(213, 65);
            this.btnAppoinments.TabIndex = 166;
            this.btnAppoinments.Text = "Appoitnments";
            this.btnAppoinments.UseVisualStyleBackColor = false;
            this.btnAppoinments.Click += new System.EventHandler(this.btnAppoinments_Click);
            // 
            // btnSymptomss
            // 
            this.btnSymptomss.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSymptomss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSymptomss.BackgroundImage")));
            this.btnSymptomss.FlatAppearance.BorderSize = 0;
            this.btnSymptomss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSymptomss.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSymptomss.ForeColor = System.Drawing.Color.White;
            this.btnSymptomss.Location = new System.Drawing.Point(-1, 517);
            this.btnSymptomss.Name = "btnSymptomss";
            this.btnSymptomss.Size = new System.Drawing.Size(214, 65);
            this.btnSymptomss.TabIndex = 163;
            this.btnSymptomss.Text = "Symptoms";
            this.btnSymptomss.UseVisualStyleBackColor = false;
            this.btnSymptomss.Click += new System.EventHandler(this.btnSymptomss_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(70, 140);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(62, 66);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 159;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(-9, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(759, 33);
            this.label5.TabIndex = 160;
            this.label5.Text = "______________________________________________________________";
            // 
            // btnTypes
            // 
            this.btnTypes.BackColor = System.Drawing.Color.DimGray;
            this.btnTypes.FlatAppearance.BorderSize = 0;
            this.btnTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypes.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypes.ForeColor = System.Drawing.Color.White;
            this.btnTypes.Location = new System.Drawing.Point(0, 322);
            this.btnTypes.Name = "btnTypes";
            this.btnTypes.Size = new System.Drawing.Size(213, 65);
            this.btnTypes.TabIndex = 165;
            this.btnTypes.Text = "Types";
            this.btnTypes.UseVisualStyleBackColor = false;
            this.btnTypes.Click += new System.EventHandler(this.btnTypes_Click);
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
            this.btnHome.Location = new System.Drawing.Point(54, 715);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedColor = System.Drawing.Color.DarkGray;
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(109, 41);
            this.btnHome.TabIndex = 161;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Salmon;
            this.label9.Location = new System.Drawing.Point(10, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 33);
            this.label9.TabIndex = 157;
            this.label9.Text = "Admin Dashboard";
            // 
            // btnnDoctor
            // 
            this.btnnDoctor.BackColor = System.Drawing.Color.DimGray;
            this.btnnDoctor.FlatAppearance.BorderSize = 0;
            this.btnnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnDoctor.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnDoctor.ForeColor = System.Drawing.Color.White;
            this.btnnDoctor.Location = new System.Drawing.Point(-3, 452);
            this.btnnDoctor.Name = "btnnDoctor";
            this.btnnDoctor.Size = new System.Drawing.Size(216, 65);
            this.btnnDoctor.TabIndex = 164;
            this.btnnDoctor.Text = "Doctor";
            this.btnnDoctor.UseVisualStyleBackColor = false;
            this.btnnDoctor.Click += new System.EventHandler(this.btnnDoctor_Click);
            // 
            // btnDiseases
            // 
            this.btnDiseases.BackColor = System.Drawing.Color.DimGray;
            this.btnDiseases.FlatAppearance.BorderSize = 0;
            this.btnDiseases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiseases.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiseases.ForeColor = System.Drawing.Color.White;
            this.btnDiseases.Location = new System.Drawing.Point(0, 257);
            this.btnDiseases.Name = "btnDiseases";
            this.btnDiseases.Size = new System.Drawing.Size(213, 65);
            this.btnDiseases.TabIndex = 162;
            this.btnDiseases.Text = "Diseases";
            this.btnDiseases.UseVisualStyleBackColor = false;
            this.btnDiseases.Click += new System.EventHandler(this.btnDiseases_Click);
            // 
            // frmSymptomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DataGridViewSymptoms);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDisease);
            this.Controls.Add(this.lblDisease);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSymptomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SymptomsForm";
            this.Load += new System.EventHandler(this.frmSymptomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSymptoms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDisease;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Label lblClear;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewSymptoms;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPatient;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Button btnDiseases;
        private System.Windows.Forms.Button btnAppoinments;
        private System.Windows.Forms.Button btnnDoctor;
        private System.Windows.Forms.Button btnSymptomss;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTypes;
    }
}