
namespace form1
{
    partial class themphuongtien
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
            this.txtl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.bntthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btntkiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmapt = new System.Windows.Forms.TextBox();
            this.txtloaipt = new System.Windows.Forms.TextBox();
            this.txttiemkiem = new System.Windows.Forms.TextBox();
            this.btnclean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm phương tiện";
            // 
            // txtl
            // 
            this.txtl.AutoSize = true;
            this.txtl.Location = new System.Drawing.Point(112, 159);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(89, 13);
            this.txtl.TabIndex = 2;
            this.txtl.Text = "Loại phương tiện ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã phương tiện ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(315, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thêm phương tiện";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(234, 209);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(95, 23);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // bntthem
            // 
            this.bntthem.AutoSize = true;
            this.bntthem.Location = new System.Drawing.Point(69, 209);
            this.bntthem.Name = "bntthem";
            this.bntthem.Size = new System.Drawing.Size(99, 23);
            this.bntthem.TabIndex = 8;
            this.bntthem.Text = "Thêm";
            this.bntthem.UseVisualStyleBackColor = true;
            this.bntthem.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(407, 209);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(109, 23);
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 192);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btntkiem
            // 
            this.btntkiem.Location = new System.Drawing.Point(724, 209);
            this.btntkiem.Name = "btntkiem";
            this.btntkiem.Size = new System.Drawing.Size(75, 23);
            this.btntkiem.TabIndex = 11;
            this.btntkiem.Text = "tìm kiếm ";
            this.btntkiem.UseVisualStyleBackColor = true;
            this.btntkiem.Click += new System.EventHandler(this.btntkiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tìm kiếm ";
            // 
            // txtmapt
            // 
            this.txtmapt.Location = new System.Drawing.Point(234, 87);
            this.txtmapt.Name = "txtmapt";
            this.txtmapt.Size = new System.Drawing.Size(263, 20);
            this.txtmapt.TabIndex = 13;
            // 
            // txtloaipt
            // 
            this.txtloaipt.Location = new System.Drawing.Point(234, 152);
            this.txtloaipt.Name = "txtloaipt";
            this.txtloaipt.Size = new System.Drawing.Size(263, 20);
            this.txtloaipt.TabIndex = 14;
            // 
            // txttiemkiem
            // 
            this.txttiemkiem.Location = new System.Drawing.Point(601, 91);
            this.txttiemkiem.Name = "txttiemkiem";
            this.txttiemkiem.Size = new System.Drawing.Size(172, 20);
            this.txttiemkiem.TabIndex = 15;
            // 
            // btnclean
            // 
            this.btnclean.Location = new System.Drawing.Point(587, 209);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(75, 23);
            this.btnclean.TabIndex = 16;
            this.btnclean.Text = "Clean";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // themphuongtien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.txttiemkiem);
            this.Controls.Add(this.txtloaipt);
            this.Controls.Add(this.txtmapt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btntkiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.bntthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtl);
            this.Controls.Add(this.label1);
            this.Name = "themphuongtien";
            this.Size = new System.Drawing.Size(825, 544);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button bntthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmapt;
        private System.Windows.Forms.TextBox txtloaipt;
        private System.Windows.Forms.TextBox txttiemkiem;
        private System.Windows.Forms.Button btnclean;
    }
}
