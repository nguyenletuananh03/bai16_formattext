using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai16_formattext
{
    public partial class Formattext : Form
    {
        public Formattext()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Italic);
        }

        private void Formattext_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            txtnhapten.Focus();
            this.CancelButton = btnthoat;
        }

        private void txtnhapten_TextChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Text = txtnhapten.Text;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Red;
            txtnhapten.ForeColor = Color.Red;
        }

        private void radgreen_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Green;
            txtnhapten.ForeColor= Color.Green;
        }

        private void radblue_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor= Color.Blue;
            txtnhapten.ForeColor= Color.Blue;
        }

        private void radblack_CheckedChanged(object sender, EventArgs e)
        {
           lbllaptrinh.ForeColor=Color.Black;
            txtnhapten.ForeColor=Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
           lbllaptrinh.Font = new Font (lbllaptrinh. Font.Name, lbllaptrinh.Font.Size,lbllaptrinh.Font.Style ^ FontStyle.Bold);
        }
    }
}
