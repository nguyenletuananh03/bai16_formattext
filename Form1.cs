using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai16_formattext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ten = "nguyễn lê tuấn anh ";
            lblinfo.Text = "họ và tên thí sinh " + ten + Environment.NewLine;
            lblinfo.Text += "ngày viết chương trình:" + System.DateTime.Now;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formattextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formattext formatText = new Formattext();
            formatText.MdiParent = this;
            formatText.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
