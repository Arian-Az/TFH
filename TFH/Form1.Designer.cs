namespace TFH
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
            this.lbltimer3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltimer2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltime1 = new System.Windows.Forms.Label();
            this.lbltimetext = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnversion = new System.Windows.Forms.Button();
            this.btnwebsite = new System.Windows.Forms.Button();
            this.btnhowwork = new System.Windows.Forms.Button();
            this.btncredit = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btncontinue = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltimer3
            // 
            this.lbltimer3.AutoSize = true;
            this.lbltimer3.BackColor = System.Drawing.Color.Transparent;
            this.lbltimer3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbltimer3.Location = new System.Drawing.Point(163, 38);
            this.lbltimer3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbltimer3.Name = "lbltimer3";
            this.lbltimer3.Size = new System.Drawing.Size(16, 17);
            this.lbltimer3.TabIndex = 40;
            this.lbltimer3.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(182, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = ":";
            // 
            // lbltimer2
            // 
            this.lbltimer2.AutoSize = true;
            this.lbltimer2.BackColor = System.Drawing.Color.Transparent;
            this.lbltimer2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbltimer2.Location = new System.Drawing.Point(191, 38);
            this.lbltimer2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbltimer2.Name = "lbltimer2";
            this.lbltimer2.Size = new System.Drawing.Size(16, 17);
            this.lbltimer2.TabIndex = 38;
            this.lbltimer2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(209, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = ":";
            // 
            // lbltime1
            // 
            this.lbltime1.AutoSize = true;
            this.lbltime1.BackColor = System.Drawing.Color.Transparent;
            this.lbltime1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbltime1.Location = new System.Drawing.Point(219, 38);
            this.lbltime1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbltime1.Name = "lbltime1";
            this.lbltime1.Size = new System.Drawing.Size(16, 17);
            this.lbltime1.TabIndex = 36;
            this.lbltime1.Text = "0";
            // 
            // lbltimetext
            // 
            this.lbltimetext.AutoSize = true;
            this.lbltimetext.BackColor = System.Drawing.Color.Transparent;
            this.lbltimetext.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbltimetext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbltimetext.Location = new System.Drawing.Point(259, 38);
            this.lbltimetext.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbltimetext.Name = "lbltimetext";
            this.lbltimetext.Size = new System.Drawing.Size(182, 17);
            this.lbltimetext.TabIndex = 35;
            this.lbltimetext.Text = "مدت زمان حضور شما در برنامه";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnversion
            // 
            this.btnversion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnversion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnversion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnversion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnversion.Location = new System.Drawing.Point(293, 132);
            this.btnversion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnversion.Name = "btnversion";
            this.btnversion.Size = new System.Drawing.Size(145, 29);
            this.btnversion.TabIndex = 31;
            this.btnversion.Text = "نسخه و امکانات برنامه";
            this.btnversion.UseVisualStyleBackColor = false;
            this.btnversion.Click += new System.EventHandler(this.btnversion_Click);
            // 
            // btnwebsite
            // 
            this.btnwebsite.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnwebsite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnwebsite.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnwebsite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnwebsite.Location = new System.Drawing.Point(13, 132);
            this.btnwebsite.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnwebsite.Name = "btnwebsite";
            this.btnwebsite.Size = new System.Drawing.Size(142, 29);
            this.btnwebsite.TabIndex = 32;
            this.btnwebsite.Text = "nanenoghli.ir";
            this.btnwebsite.UseVisualStyleBackColor = false;
            this.btnwebsite.Click += new System.EventHandler(this.btnwebsite_Click);
            // 
            // btnhowwork
            // 
            this.btnhowwork.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnhowwork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhowwork.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnhowwork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnhowwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnhowwork.ForeColor = System.Drawing.Color.Blue;
            this.btnhowwork.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnhowwork.Location = new System.Drawing.Point(13, 95);
            this.btnhowwork.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnhowwork.Name = "btnhowwork";
            this.btnhowwork.Size = new System.Drawing.Size(142, 29);
            this.btnhowwork.TabIndex = 29;
            this.btnhowwork.Text = "چگونگی کار با برنامه";
            this.btnhowwork.UseVisualStyleBackColor = false;
            this.btnhowwork.Click += new System.EventHandler(this.btnhowwork_Click);
            // 
            // btncredit
            // 
            this.btncredit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncredit.ForeColor = System.Drawing.Color.Blue;
            this.btncredit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btncredit.Location = new System.Drawing.Point(293, 95);
            this.btncredit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btncredit.Name = "btncredit";
            this.btncredit.Size = new System.Drawing.Size(145, 29);
            this.btncredit.TabIndex = 30;
            this.btncredit.Text = "سازندگان";
            this.btncredit.UseVisualStyleBackColor = false;
            this.btncredit.Click += new System.EventHandler(this.btncredit_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnexit.Location = new System.Drawing.Point(164, 95);
            this.btnexit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(119, 29);
            this.btnexit.TabIndex = 34;
            this.btnexit.Text = "خروج";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnsettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsettings.Location = new System.Drawing.Point(164, 132);
            this.btnsettings.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(119, 29);
            this.btnsettings.TabIndex = 33;
            this.btnsettings.Text = "تنظیمات";
            this.btnsettings.UseVisualStyleBackColor = false;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(13, 3);
            this.btnstop.Margin = new System.Windows.Forms.Padding(2);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(86, 26);
            this.btnstop.TabIndex = 41;
            this.btnstop.Text = "توقف";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btncontinue
            // 
            this.btncontinue.Location = new System.Drawing.Point(13, 34);
            this.btncontinue.Margin = new System.Windows.Forms.Padding(2);
            this.btncontinue.Name = "btncontinue";
            this.btncontinue.Size = new System.Drawing.Size(86, 26);
            this.btncontinue.TabIndex = 42;
            this.btncontinue.Text = "ادامه";
            this.btncontinue.UseVisualStyleBackColor = true;
            this.btncontinue.Click += new System.EventHandler(this.btncontinue_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(13, 64);
            this.btnreset.Margin = new System.Windows.Forms.Padding(2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(86, 26);
            this.btnreset.TabIndex = 43;
            this.btnreset.Text = "شمارش از نو";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 170);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btncontinue);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.lbltimer3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltimer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltime1);
            this.Controls.Add(this.lbltimetext);
            this.Controls.Add(this.btnsettings);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncredit);
            this.Controls.Add(this.btnhowwork);
            this.Controls.Add(this.btnwebsite);
            this.Controls.Add(this.btnversion);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timre for health";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbltimer3;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lbltimer2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lbltime1;
        internal System.Windows.Forms.Label lbltimetext;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Button btnsettings;
        internal System.Windows.Forms.Button btnexit;
        internal System.Windows.Forms.Button btncredit;
        internal System.Windows.Forms.Button btnhowwork;
        internal System.Windows.Forms.Button btnwebsite;
        internal System.Windows.Forms.Button btnversion;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btncontinue;
        private System.Windows.Forms.Button btnreset;
    }
}

