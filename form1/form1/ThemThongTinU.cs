using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class ThemThongTinU : UserControl
    {
        Panel parentPanel;
        public ThemThongTinU()
        {
            InitializeComponent();
            parentPanel = new Panel();
            parentPanel.Location = new Point(175, 49);
            parentPanel.Size = new Size(825, 544);
            parentPanel.BackColor = Color.Gray;
            parentPanel.Controls.Add(panel2);
            this.Controls.Add(parentPanel);
        }

        private void ThemThongTinU_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(selectedFile);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*panel2.Visible = true;*/
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            parentPanel.Controls.Add(panel2);
        }

        private void button2_Click(object sender, EventArgs e)
        {


           panel5.Visible = false;
            panel2.Visible = false;
           panel4.Visible = false;
           /*  panel3.Visible = true; */
           
            parentPanel.Controls.Add(panel3);
        }

        private void button3_Click(object sender, EventArgs e)
        {   ;

            /* panel2.Visible = false;
              panel3.Visible = false;
              panel4.Visible = true;
              panel5.Visible = false;*/
            parentPanel.Controls.Add(panel4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*panel5.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;*/
            parentPanel.Controls.Add(panel5);
        }
    }
}
