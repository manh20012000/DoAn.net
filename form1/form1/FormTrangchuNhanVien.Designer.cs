
namespace form1
{
    partial class FormTrangchuNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnttcanhan = new System.Windows.Forms.Button();
            this.btnThme = new System.Windows.Forms.Button();
            this.btnDangky = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelUserControl = new System.Windows.Forms.Panel();
            this.homeU1 = new form1.HomeU();
            this.panel1.SuspendLayout();
            this.panelUserControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnttcanhan);
            this.panel1.Controls.Add(this.btnThme);
            this.panel1.Controls.Add(this.btnDangky);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(3, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 73);
            this.panel1.TabIndex = 0;
            // 
            // btnttcanhan
            // 
            this.btnttcanhan.Location = new System.Drawing.Point(897, 24);
            this.btnttcanhan.Name = "btnttcanhan";
            this.btnttcanhan.Size = new System.Drawing.Size(175, 32);
            this.btnttcanhan.TabIndex = 1;
            this.btnttcanhan.Text = "NhânCá ";
            this.btnttcanhan.UseVisualStyleBackColor = true;
            this.btnttcanhan.Click += new System.EventHandler(this.btnttcanhan_Click);
            // 
            // btnThme
            // 
            this.btnThme.Location = new System.Drawing.Point(672, 24);
            this.btnThme.Name = "btnThme";
            this.btnThme.Size = new System.Drawing.Size(170, 32);
            this.btnThme.TabIndex = 2;
            this.btnThme.Text = "ThemThongTin";
            this.btnThme.UseVisualStyleBackColor = true;
            this.btnThme.Click += new System.EventHandler(this.btnThme_Click);
            // 
            // btnDangky
            // 
            this.btnDangky.Location = new System.Drawing.Point(398, 24);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(175, 32);
            this.btnDangky.TabIndex = 1;
            this.btnDangky.Text = "ĐăngKyTour";
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(170, 24);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(169, 32);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelUserControl
            // 
            this.panelUserControl.AutoSize = true;
            this.panelUserControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelUserControl.Controls.Add(this.homeU1);
            this.panelUserControl.Location = new System.Drawing.Point(53, 88);
            this.panelUserControl.Name = "panelUserControl";
            this.panelUserControl.Size = new System.Drawing.Size(1055, 615);
            this.panelUserControl.TabIndex = 1;
            this.panelUserControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUserControl_Paint);
            // 
            // homeU1
            // 
            this.homeU1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.homeU1.Location = new System.Drawing.Point(0, 0);
            this.homeU1.Name = "homeU1";
            this.homeU1.Size = new System.Drawing.Size(1029, 592);
            this.homeU1.TabIndex = 0;
            this.homeU1.Load += new System.EventHandler(this.homeU1_Load);
            // 
            // FormTrangchuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 682);
            this.Controls.Add(this.panelUserControl);
            this.Controls.Add(this.panel1);
            this.Name = "FormTrangchuNhanVien";
            this.Text = "FormTrangchuNhanVien";
            this.Load += new System.EventHandler(this.FormTrangchuNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panelUserControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnttcanhan;
        private System.Windows.Forms.Button btnThme;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelUserControl;
        private HomeU homeU1;
    }
}