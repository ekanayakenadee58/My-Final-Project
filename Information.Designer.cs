namespace G_Pro_Try
{
    partial class frmDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetails));
            this.labelselectsym = new System.Windows.Forms.Label();
            this.cmbboxSymptom = new System.Windows.Forms.ComboBox();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.DataGridViewInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblexit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewAppointments = new System.Windows.Forms.Button();
            this.btnMakeAppoinments = new System.Windows.Forms.Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnInformation = new System.Windows.Forms.Button();
            this.lblMangeDiseases = new System.Windows.Forms.Label();
            this.btnApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInfo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelselectsym
            // 
            this.labelselectsym.AutoSize = true;
            this.labelselectsym.BackColor = System.Drawing.Color.Bisque;
            this.labelselectsym.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelselectsym.ForeColor = System.Drawing.Color.Black;
            this.labelselectsym.Location = new System.Drawing.Point(250, 152);
            this.labelselectsym.Name = "labelselectsym";
            this.labelselectsym.Size = new System.Drawing.Size(136, 26);
            this.labelselectsym.TabIndex = 21;
            this.labelselectsym.Text = "Select Symptom";
            // 
            // cmbboxSymptom
            // 
            this.cmbboxSymptom.FormattingEnabled = true;
            this.cmbboxSymptom.Location = new System.Drawing.Point(402, 148);
            this.cmbboxSymptom.Name = "cmbboxSymptom";
            this.cmbboxSymptom.Size = new System.Drawing.Size(330, 30);
            this.cmbboxSymptom.TabIndex = 20;
            this.cmbboxSymptom.Text = "Select Symptom";
            this.cmbboxSymptom.SelectionChangeCommitted += new System.EventHandler(this.cmbboxSearch_SelectionChangeCommitted);
            // 
            // lblRefresh
            // 
            this.lblRefresh.AutoSize = true;
            this.lblRefresh.BackColor = System.Drawing.Color.Transparent;
            this.lblRefresh.Font = new System.Drawing.Font("Minion Pro SmBd", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRefresh.Location = new System.Drawing.Point(737, 153);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(70, 26);
            this.lblRefresh.TabIndex = 19;
            this.lblRefresh.Text = "Refresh";
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // DataGridViewInfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewInfo.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewInfo.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewInfo.EnableHeadersVisualStyles = false;
            this.DataGridViewInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewInfo.Location = new System.Drawing.Point(254, 200);
            this.DataGridViewInfo.Name = "DataGridViewInfo";
            this.DataGridViewInfo.RowHeadersVisible = false;
            this.DataGridViewInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewInfo.Size = new System.Drawing.Size(958, 546);
            this.DataGridViewInfo.TabIndex = 17;
            this.DataGridViewInfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewInfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewInfo.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridViewInfo.ThemeStyle.ReadOnly = false;
            this.DataGridViewInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewInfo.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.BackColor = System.Drawing.Color.Transparent;
            this.lblexit.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblexit.Location = new System.Drawing.Point(1089, -12);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(51, 59);
            this.lblexit.TabIndex = 29;
            this.lblexit.Text = "X";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            this.lblexit.MouseEnter += new System.EventHandler(this.lblexit_MouseEnter);
            this.lblexit.MouseLeave += new System.EventHandler(this.lblexit_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblexit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(230, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 42);
            this.panel2.TabIndex = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(61, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 32);
            this.label1.TabIndex = 72;
            this.label1.Text = "\"WE CARE\" Diagnosis Tracking System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.btnViewAppointments);
            this.panel1.Controls.Add(this.btnMakeAppoinments);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.guna2PictureBox2);
            this.panel1.Controls.Add(this.btnInformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 768);
            this.panel1.TabIndex = 71;
            // 
            // btnViewAppointments
            // 
            this.btnViewAppointments.BackColor = System.Drawing.Color.Sienna;
            this.btnViewAppointments.FlatAppearance.BorderSize = 0;
            this.btnViewAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAppointments.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAppointments.ForeColor = System.Drawing.Color.MintCream;
            this.btnViewAppointments.Location = new System.Drawing.Point(-2, 452);
            this.btnViewAppointments.Name = "btnViewAppointments";
            this.btnViewAppointments.Size = new System.Drawing.Size(233, 65);
            this.btnViewAppointments.TabIndex = 81;
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
            this.btnMakeAppoinments.Location = new System.Drawing.Point(0, 386);
            this.btnMakeAppoinments.Name = "btnMakeAppoinments";
            this.btnMakeAppoinments.Size = new System.Drawing.Size(233, 65);
            this.btnMakeAppoinments.TabIndex = 80;
            this.btnMakeAppoinments.Text = "Make Appointments";
            this.btnMakeAppoinments.UseVisualStyleBackColor = false;
            this.btnMakeAppoinments.Click += new System.EventHandler(this.btnMakeAppoinments_Click);
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
            this.btnLogin.Location = new System.Drawing.Point(47, 708);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedColor = System.Drawing.Color.DarkGray;
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(109, 41);
            this.btnLogin.TabIndex = 79;
            this.btnLogin.Text = "Home";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(47, -15);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(122, 117);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 76;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(-8, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(759, 33);
            this.label3.TabIndex = 78;
            this.label3.Text = "______________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Minion Pro Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 33);
            this.label2.TabIndex = 74;
            this.label2.Text = "Patient Dashboard";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(81, 148);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(62, 66);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 77;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.LightSalmon;
            this.btnInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInformation.BackgroundImage")));
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.Font = new System.Drawing.Font("Minion Pro SmBd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformation.ForeColor = System.Drawing.Color.MintCream;
            this.btnInformation.Location = new System.Drawing.Point(-2, 320);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(235, 65);
            this.btnInformation.TabIndex = 75;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseVisualStyleBackColor = false;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // lblMangeDiseases
            // 
            this.lblMangeDiseases.AutoSize = true;
            this.lblMangeDiseases.BackColor = System.Drawing.Color.Transparent;
            this.lblMangeDiseases.Font = new System.Drawing.Font("Minion Pro Cond", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangeDiseases.ForeColor = System.Drawing.Color.Black;
            this.lblMangeDiseases.Location = new System.Drawing.Point(233, 42);
            this.lblMangeDiseases.Name = "lblMangeDiseases";
            this.lblMangeDiseases.Size = new System.Drawing.Size(570, 88);
            this.lblMangeDiseases.TabIndex = 74;
            this.lblMangeDiseases.Text = "Diseases Information";
            // 
            // btnApp
            // 
            this.btnApp.BackColor = System.Drawing.Color.Sienna;
            this.btnApp.FlatAppearance.BorderSize = 0;
            this.btnApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApp.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApp.ForeColor = System.Drawing.Color.MintCream;
            this.btnApp.Location = new System.Drawing.Point(1222, 200);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(136, 70);
            this.btnApp.TabIndex = 81;
            this.btnApp.Text = "Make Appointments";
            this.btnApp.UseVisualStyleBackColor = false;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnApp);
            this.Controls.Add(this.lblMangeDiseases);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelselectsym);
            this.Controls.Add(this.cmbboxSymptom);
            this.Controls.Add(this.lblRefresh);
            this.Controls.Add(this.DataGridViewInfo);
            this.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.Load += new System.EventHandler(this.frmInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInfo)).EndInit();
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

        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewInfo;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.ComboBox cmbboxSymptom;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.Label labelselectsym;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnViewAppointments;
        private System.Windows.Forms.Button btnMakeAppoinments;
        private System.Windows.Forms.Label lblMangeDiseases;
        private System.Windows.Forms.Button btnApp;
    }
}