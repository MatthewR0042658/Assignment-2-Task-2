namespace Assignment_2_Task_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SAClabel2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.VClabel1 = new System.Windows.Forms.Label();
            this.LCtextBox1 = new System.Windows.Forms.TextBox();
            this.HCtextBox1 = new System.Windows.Forms.TextBox();
            this.WCtextBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RStextBox1 = new System.Windows.Forms.TextBox();
            this.SphereVol = new System.Windows.Forms.Label();
            this.SphereSA = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ConeR = new System.Windows.Forms.TextBox();
            this.ConeH = new System.Windows.Forms.TextBox();
            this.VolumeCone = new System.Windows.Forms.Label();
            this.ConeSA = new System.Windows.Forms.Label();
            this.ConeEquals = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1370, 678);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SAClabel2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.VClabel1);
            this.tabPage1.Controls.Add(this.LCtextBox1);
            this.tabPage1.Controls.Add(this.HCtextBox1);
            this.tabPage1.Controls.Add(this.WCtextBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1362, 652);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cuboid";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(908, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(872, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Length";
            // 
            // SAClabel2
            // 
            this.SAClabel2.AutoSize = true;
            this.SAClabel2.Location = new System.Drawing.Point(17, 68);
            this.SAClabel2.Name = "SAClabel2";
            this.SAClabel2.Size = new System.Drawing.Size(69, 13);
            this.SAClabel2.TabIndex = 6;
            this.SAClabel2.Text = "Surface Area";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(1066, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 218);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate Volume";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // VClabel1
            // 
            this.VClabel1.AutoSize = true;
            this.VClabel1.Location = new System.Drawing.Point(44, 24);
            this.VClabel1.Name = "VClabel1";
            this.VClabel1.Size = new System.Drawing.Size(42, 13);
            this.VClabel1.TabIndex = 4;
            this.VClabel1.Text = "Volume";
            // 
            // LCtextBox1
            // 
            this.LCtextBox1.Location = new System.Drawing.Point(398, 471);
            this.LCtextBox1.Name = "LCtextBox1";
            this.LCtextBox1.Size = new System.Drawing.Size(99, 20);
            this.LCtextBox1.TabIndex = 3;
            // 
            // HCtextBox1
            // 
            this.HCtextBox1.Location = new System.Drawing.Point(901, 137);
            this.HCtextBox1.Name = "HCtextBox1";
            this.HCtextBox1.Size = new System.Drawing.Size(90, 20);
            this.HCtextBox1.TabIndex = 2;
            // 
            // WCtextBox1
            // 
            this.WCtextBox1.Location = new System.Drawing.Point(848, 467);
            this.WCtextBox1.Name = "WCtextBox1";
            this.WCtextBox1.Size = new System.Drawing.Size(98, 20);
            this.WCtextBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1022, 526);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SphereSA);
            this.tabPage2.Controls.Add(this.SphereVol);
            this.tabPage2.Controls.Add(this.RStextBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1362, 652);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sphere";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(778, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 222);
            this.button2.TabIndex = 1;
            this.button2.Text = "Calculate Surface Area and Volume";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(173, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(752, 528);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ConeEquals);
            this.tabPage3.Controls.Add(this.ConeSA);
            this.tabPage3.Controls.Add(this.VolumeCone);
            this.tabPage3.Controls.Add(this.ConeH);
            this.tabPage3.Controls.Add(this.ConeR);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1362, 652);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cone";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // RStextBox1
            // 
            this.RStextBox1.Location = new System.Drawing.Point(586, 203);
            this.RStextBox1.Name = "RStextBox1";
            this.RStextBox1.Size = new System.Drawing.Size(63, 20);
            this.RStextBox1.TabIndex = 2;
            this.RStextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // SphereVol
            // 
            this.SphereVol.AutoSize = true;
            this.SphereVol.Location = new System.Drawing.Point(179, 38);
            this.SphereVol.Name = "SphereVol";
            this.SphereVol.Size = new System.Drawing.Size(42, 13);
            this.SphereVol.TabIndex = 3;
            this.SphereVol.Text = "Volume";
            this.SphereVol.Click += new System.EventHandler(this.SphereVol_Click);
            // 
            // SphereSA
            // 
            this.SphereSA.AutoSize = true;
            this.SphereSA.Location = new System.Drawing.Point(177, 77);
            this.SphereSA.Name = "SphereSA";
            this.SphereSA.Size = new System.Drawing.Size(44, 13);
            this.SphereSA.TabIndex = 4;
            this.SphereSA.Text = "Surface";
            this.SphereSA.Click += new System.EventHandler(this.Label4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(339, -22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(629, 581);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // ConeR
            // 
            this.ConeR.Location = new System.Drawing.Point(768, 439);
            this.ConeR.Name = "ConeR";
            this.ConeR.Size = new System.Drawing.Size(84, 20);
            this.ConeR.TabIndex = 2;
            this.ConeR.TextChanged += new System.EventHandler(this.ConeR_TextChanged);
            // 
            // ConeH
            // 
            this.ConeH.Location = new System.Drawing.Point(649, 250);
            this.ConeH.Name = "ConeH";
            this.ConeH.Size = new System.Drawing.Size(71, 20);
            this.ConeH.TabIndex = 3;
            this.ConeH.TextChanged += new System.EventHandler(this.ConeH_TextChanged);
            // 
            // VolumeCone
            // 
            this.VolumeCone.AutoSize = true;
            this.VolumeCone.Location = new System.Drawing.Point(315, 37);
            this.VolumeCone.Name = "VolumeCone";
            this.VolumeCone.Size = new System.Drawing.Size(42, 13);
            this.VolumeCone.TabIndex = 4;
            this.VolumeCone.Text = "Volume";
            this.VolumeCone.Click += new System.EventHandler(this.VolumeCone_Click);
            // 
            // ConeSA
            // 
            this.ConeSA.AutoSize = true;
            this.ConeSA.Location = new System.Drawing.Point(288, 70);
            this.ConeSA.Name = "ConeSA";
            this.ConeSA.Size = new System.Drawing.Size(69, 13);
            this.ConeSA.TabIndex = 5;
            this.ConeSA.Text = "Surface Area";
            this.ConeSA.Click += new System.EventHandler(this.ConeSA_Click);
            // 
            // ConeEquals
            // 
            this.ConeEquals.Image = ((System.Drawing.Image)(resources.GetObject("ConeEquals.Image")));
            this.ConeEquals.Location = new System.Drawing.Point(974, 6);
            this.ConeEquals.Name = "ConeEquals";
            this.ConeEquals.Size = new System.Drawing.Size(228, 218);
            this.ConeEquals.TabIndex = 6;
            this.ConeEquals.Text = "Equals";
            this.ConeEquals.UseVisualStyleBackColor = true;
            this.ConeEquals.Click += new System.EventHandler(this.ConeEquals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 711);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox LCtextBox1;
        private System.Windows.Forms.TextBox HCtextBox1;
        private System.Windows.Forms.TextBox WCtextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label VClabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SAClabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox RStextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label SphereVol;
        private System.Windows.Forms.Label SphereSA;
        private System.Windows.Forms.TextBox ConeH;
        private System.Windows.Forms.TextBox ConeR;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label VolumeCone;
        private System.Windows.Forms.Label ConeSA;
        private System.Windows.Forms.Button ConeEquals;
    }
}

