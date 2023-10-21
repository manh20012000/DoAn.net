
namespace form1
{
    partial class ThemDiadiem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bntthem = new System.Windows.Forms.Button();
            this.bntxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.dvgdiadiem = new System.Windows.Forms.DataGridView();
            this.txtdiadiem = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdiadiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa điểm ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên địa điểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = " Địa điểm ";
            // 
            // bntthem
            // 
            this.bntthem.Location = new System.Drawing.Point(81, 226);
            this.bntthem.Name = "bntthem";
            this.bntthem.Size = new System.Drawing.Size(75, 23);
            this.bntthem.TabIndex = 6;
            this.bntthem.Text = "Thêm ";
            this.bntthem.UseVisualStyleBackColor = true;
            this.bntthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntxoa
            // 
            this.bntxoa.Location = new System.Drawing.Point(302, 226);
            this.bntxoa.Name = "bntxoa";
            this.bntxoa.Size = new System.Drawing.Size(75, 23);
            this.bntxoa.TabIndex = 7;
            this.bntxoa.Text = "Xóa ";
            this.bntxoa.UseVisualStyleBackColor = true;
            this.bntxoa.Click += new System.EventHandler(this.bntxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(490, 226);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // dvgdiadiem
            // 
            this.dvgdiadiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgdiadiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dvgdiadiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgdiadiem.Location = new System.Drawing.Point(18, 334);
            this.dvgdiadiem.Name = "dvgdiadiem";
            this.dvgdiadiem.Size = new System.Drawing.Size(753, 156);
            this.dvgdiadiem.TabIndex = 9;
            this.dvgdiadiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgdiadiem_CellClick);
            // 
            // txtdiadiem
            // 
            this.txtdiadiem.Location = new System.Drawing.Point(347, 79);
            this.txtdiadiem.Name = "txtdiadiem";
            this.txtdiadiem.Size = new System.Drawing.Size(350, 20);
            this.txtdiadiem.TabIndex = 11;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(340, 137);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(356, 20);
            this.txtdiachi.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tìm địa điêm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(445, 14);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(208, 20);
            this.txttimkiem.TabIndex = 14;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(681, 11);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 15;
            this.btnTimkiem.Text = "Tim kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnclean
            // 
            this.btnclean.Location = new System.Drawing.Point(708, 226);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(75, 23);
            this.btnclean.TabIndex = 16;
            this.btnclean.Text = "clean";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // ThemDiadiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtdiadiem);
            this.Controls.Add(this.dvgdiadiem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.bntxoa);
            this.Controls.Add(this.bntthem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemDiadiem";
            this.Size = new System.Drawing.Size(822, 493);
            this.Load += new System.EventHandler(this.ThemDiadiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgdiadiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bntthem;
        private System.Windows.Forms.Button bntxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.DataGridView dvgdiadiem;
        private System.Windows.Forms.TextBox txtdiadiem;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnclean;
    }
}
