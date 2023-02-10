namespace G_Pro_Try
{
    partial class frmPatient_Home_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatient_Home_Page));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDisInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btndistypes = new Guna.UI2.WinForms.Guna2Button();
            this.btnMakeappoitmnet = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.lblexit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDTS = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnDisInfo);
            this.panel1.Controls.Add(this.btndistypes);
            this.panel1.Controls.Add(this.btnMakeappoitmnet);
            this.panel1.Location = new System.Drawing.Point(174, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 421);
            this.panel1.TabIndex = 55;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(368, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(271, 214);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(673, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 214);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnDisInfo
            // 
            this.btnDisInfo.CheckedState.Parent = this.btnDisInfo;
            this.btnDisInfo.CustomImages.Parent = this.btnDisInfo;
            this.btnDisInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisInfo.ForeColor = System.Drawing.Color.White;
            this.btnDisInfo.HoverState.Parent = this.btnDisInfo;
            this.btnDisInfo.Location = new System.Drawing.Point(62, 300);
            this.btnDisInfo.Name = "btnDisInfo";
            this.btnDisInfo.ShadowDecoration.Parent = this.btnDisInfo;
            this.btnDisInfo.Size = new System.Drawing.Size(271, 45);
            this.btnDisInfo.TabIndex = 28;
            this.btnDisInfo.Text = "Disease Information";
            this.btnDisInfo.Click += new System.EventHandler(this.btnDisInfo_Click);
            // 
            // btndistypes
            // 
            this.btndistypes.CheckedState.Parent = this.btndistypes;
            this.btndistypes.CustomImages.Parent = this.btndistypes;
            this.btndistypes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndistypes.ForeColor = System.Drawing.Color.White;
            this.btndistypes.HoverState.Parent = this.btndistypes;
            this.btndistypes.Location = new System.Drawing.Point(673, 300);
            this.btndistypes.Name = "btndistypes";
            this.btndistypes.ShadowDecoration.Parent = this.btndistypes;
            this.btndistypes.Size = new System.Drawing.Size(271, 45);
            this.btndistypes.TabIndex = 26;
            this.btndistypes.Text = "View Appointments";
            this.btndistypes.Click += new System.EventHandler(this.btndistypes_Click);
            // 
            // btnMakeappoitmnet
            // 
            this.btnMakeappoitmnet.CheckedState.Parent = this.btnMakeappoitmnet;
            this.btnMakeappoitmnet.CustomImages.Parent = this.btnMakeappoitmnet;
            this.btnMakeappoitmnet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeappoitmnet.ForeColor = System.Drawing.Color.White;
            this.btnMakeappoitmnet.HoverState.Parent = this.btnMakeappoitmnet;
            this.btnMakeappoitmnet.Location = new System.Drawing.Point(368, 300);
            this.btnMakeappoitmnet.Name = "btnMakeappoitmnet";
            this.btnMakeappoitmnet.ShadowDecoration.Parent = this.btnMakeappoitmnet;
            this.btnMakeappoitmnet.Size = new System.Drawing.Size(271, 45);
            this.btnMakeappoitmnet.TabIndex = 25;
            this.btnMakeappoitmnet.Text = "Make Appointmnets";
            this.btnMakeappoitmnet.Click += new System.EventHandler(this.btnMakeappoitmnet_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.AutoRoundedCorners = true;
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.BorderColor = System.Drawing.Color.MistyRose;
            this.btnlogout.BorderRadius = 22;
            this.btnlogout.CheckedState.Parent = this.btnlogout;
            this.btnlogout.CustomImages.Parent = this.btnlogout;
            this.btnlogout.FillColor = System.Drawing.Color.MintCream;
            this.btnlogout.Font = new System.Drawing.Font("Minion Pro SmBd", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.Black;
            this.btnlogout.HoverState.Parent = this.btnlogout;
            this.btnlogout.Location = new System.Drawing.Point(1195, 692);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.PressedColor = System.Drawing.Color.DarkGray;
            this.btnlogout.ShadowDecoration.Parent = this.btnlogout;
            this.btnlogout.Size = new System.Drawing.Size(138, 47);
            this.btnlogout.TabIndex = 59;
            this.btnlogout.Text = "Logout";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.BackColor = System.Drawing.Color.Transparent;
            this.lblexit.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.Black;
            this.lblexit.Location = new System.Drawing.Point(1303, -12);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(68, 78);
            this.lblexit.TabIndex = 58;
            this.lblexit.Text = "X";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            this.lblexit.MouseEnter += new System.EventHandler(this.lblexit_MouseEnter);
            this.lblexit.MouseLeave += new System.EventHandler(this.lblexit_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(453, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 35);
            this.label1.TabIndex = 57;
            this.label1.Text = "Patient Home Page";
            // 
            // lblDTS
            // 
            this.lblDTS.AutoSize = true;
            this.lblDTS.BackColor = System.Drawing.Color.Transparent;
            this.lblDTS.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDTS.Location = new System.Drawing.Point(123, 9);
            this.lblDTS.Name = "lblDTS";
            this.lblDTS.Size = new System.Drawing.Size(1104, 71);
            this.lblDTS.TabIndex = 56;
            this.lblDTS.Text = "\"WE CARE\" Diagnosis Tracking System";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(8, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(75, 70);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 75;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmPatient_Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDTS);
            this.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPatient_Home_Page";
            this.Text = "Patient_Home_Page";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnDisInfo;
        private Guna.UI2.WinForms.Guna2Button btndistypes;
        private Guna.UI2.WinForms.Guna2Button btnMakeappoitmnet;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDTS;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}