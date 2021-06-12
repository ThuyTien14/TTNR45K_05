using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2
{
    public partial class frmCaculator : Form
    {
        public frmCaculator()
        {
            InitializeComponent();
        }

        private void bntCong_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 + dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void bntTru_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 - dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void bntNhan_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 * dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void bntChia_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo1.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 / dSo2;
            txtKQ.Text = dKQ.ToString();
        }
    }
}
