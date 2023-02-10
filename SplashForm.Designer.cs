namespace G_Pro_Try
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDTS = new System.Windows.Forms.Label();
            this.lblWCPL = new System.Windows.Forms.Label();
            this.lblKnady = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProBar1 = new System.Windows.Forms.ProgressBar();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblexit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDTS
            // 
            this.lblDTS.AutoSize = true;
            this.lblDTS.BackColor = System.Drawing.Color.Transparent;
            this.lblDTS.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTS.Location = new System.Drawing.Point(460, 74);
            this.lblDTS.Name = "lblDTS";
            this.lblDTS.Size = new System.Drawing.Size(795, 71);
            this.lblDTS.TabIndex = 1;
            this.lblDTS.Text = "Diagnosis Tracking System";
            // 
            // lblWCPL
            // 
            this.lblWCPL.AutoSize = true;
            this.lblWCPL.BackColor = System.Drawing.Color.Transparent;
            this.lblWCPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWCPL.Location = new System.Drawing.Point(629, 689);
            this.lblWCPL.Name = "lblWCPL";
            this.lblWCPL.Size = new System.Drawing.Size(184, 25);
            this.lblWCPL.TabIndex = 2;
            this.lblWCPL.Text = "We Care Pvt Ltd";
            // 
            // lblKnady
            // 
            this.lblKnady.AutoSize = true;
            this.lblKnady.BackColor = System.Drawing.Color.Transparent;
            this.lblKnady.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKnady.Location = new System.Drawing.Point(678, 714);
            this.lblKnady.Name = "lblKnady";
            this.lblKnady.Size = new System.Drawing.Size(78, 25);
            this.lblKnady.TabIndex = 3;
            this.lblKnady.Text = "Kandy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "\"WE CARE\"";
            // 
            // ProBar1
            // 
            this.ProBar1.Location = new System.Drawing.Point(66, 427);
            this.ProBar1.Name = "ProBar1";
            this.ProBar1.Size = new System.Drawing.Size(1239, 44);
            this.ProBar1.TabIndex = 0;
            this.ProBar1.Click += new System.EventHandler(this.ProBar1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(675, 562);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(85, 87);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 72;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.BackColor = System.Drawing.Color.Transparent;
            this.lblexit.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.MintCream;
            this.lblexit.Location = new System.Drawing.Point(1308, -10);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(68, 78);
            this.lblexit.TabIndex = 73;
            this.lblexit.Text = "X";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.ProBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKnady);
            this.Controls.Add(this.lblWCPL);
            this.Controls.Add(this.lblDTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spalsh";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDTS;
        private System.Windows.Forms.Label lblWCPL;
        private System.Windows.Forms.Label lblKnady;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ProBar1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblexit;
    }
}

