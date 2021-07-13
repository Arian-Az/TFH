namespace TFH.SettingsForm
{
    partial class SetingStartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetingStartUp));
            this.pnlStartup = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlStartup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStartup
            // 
            this.pnlStartup.BackColor = System.Drawing.Color.Transparent;
            this.pnlStartup.Controls.Add(this.button1);
            this.pnlStartup.Controls.Add(this.label3);
            this.pnlStartup.Controls.Add(this.label2);
            this.pnlStartup.Controls.Add(this.label1);
            this.pnlStartup.Controls.Add(this.lblAlarm);
            this.pnlStartup.Controls.Add(this.btnSetting);
            this.pnlStartup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnlStartup.Location = new System.Drawing.Point(-6, 0);
            this.pnlStartup.Name = "pnlStartup";
            this.pnlStartup.Size = new System.Drawing.Size(711, 506);
            this.pnlStartup.TabIndex = 2;
            this.pnlStartup.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "-- وضعیت استارت آپ :";
            // 
            // lblAlarm
            // 
            this.lblAlarm.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAlarm.Location = new System.Drawing.Point(3, 230);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(556, 46);
            this.lblAlarm.TabIndex = 1;
            this.lblAlarm.Text = "در حال حاضر استارت برای این نرم افزار بر روی کامپیوتر شما فعال است ، اگر نمیخواهی" +
    "د از این امکان استفاده کنید میتوانید آن را غیر فعال سازید.";
            // 
            // btnSetting
            // 
            this.btnSetting.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSetting.Location = new System.Drawing.Point(364, 353);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(328, 56);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Text = "غیر فعال سازی استارت آپ";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(701, 63);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "-- استارت آپ چیست و چه استفاده ای دارد؟";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "خروج از سربرگ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SetingStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(698, 506);
            this.Controls.Add(this.pnlStartup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetingStartUp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "فعال کردن استارت آپ";
            this.Load += new System.EventHandler(this.SetingStartUp_Load);
            this.pnlStartup.ResumeLayout(false);
            this.pnlStartup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStartup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}