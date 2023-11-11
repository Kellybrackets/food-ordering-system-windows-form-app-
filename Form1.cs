using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUT8_question2
{
    public partial class lbTotal : Form
    {
        public lbTotal()
        {
            InitializeComponent();
        }

        float total = 0;
        private void cbpep_CheckedChanged(object sender, EventArgs e)
        {
            if (cbpep.Checked)
                total += 7;
            else
                total -= 7;
            lbthetotal.Text = "Amount Due: " + total.ToString();
        }

        private void cbja_CheckedChanged(object sender, EventArgs e)
        {
            if (cbja.Checked)
                total += 7;
            else
                total -= 7;
            lbthetotal.Text = "Amount Due: " + total.ToString();
        }

        private void cbspi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbspi.Checked)
                total += 7;
            else
                total -= 7;
            lbthetotal.Text = "Amount Due: " + total.ToString();
        }

        private void cbEC_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEC.Checked)
                total += 7;
            else
                total -= 7;
            lbthetotal.Text = "Amount Due: " + total.ToString();
        }

        private void cbPine_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPine.Checked)
                total += 7;
            else
                total -= 7;
            lbthetotal.Text = "Amount Due: " + total.ToString();
        }

        private void cbSB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSB.Checked)
                total += 7;
            else
                total -= 7;
            lbthetotal.Text = "Amount Due: " + total.ToString();
        }

        private void cbMush_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMush.Checked)
                total += 7;
            else
                total -= 7;
            lbthetotal.Text = "Amount Due: " + total.ToString();
        }

        private void cbDS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDS.Checked)
                total += 7;
            else
                total -= 7;
            lbthetotal.Text = "Amount Due: " + total.ToString();
        }

        private void cbGB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGB.Checked)
                total += 7;
            else
                total -= 7;
            lbthetotal.Text = "Amount Due: " + total.ToString();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbsmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbsmall.Checked)
                total += 20;
            else
                total -= 20;
            lbthetotal.Text = "Amount Due: " + total.ToString();

        }

        private void rbmedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbmedium.Checked)
                total += 35;
            else
                total -= 35;
            lbthetotal.Text = "Amount Due: " + total.ToString();
        }

        private void rblarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rblarge.Checked)
                total += 55;
            else
                total -= 55;
            lbthetotal.Text = "Amount Due: " + total.ToString();
        }

        private void rbthick_CheckedChanged(object sender, EventArgs e)
        {
            if (rbthick.Checked)
                total += 2;
            else
                total -= 2;
            lbthetotal.Text = "Amount Due: " + total.ToString();
        }

        private void rbthin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbthin.Checked)
                total += 1;
            else
                total -= 1;
            lbthetotal.Text = "Amount Due: " + total.ToString();
        }

        private void lbthetotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(total.ToString());
        }
    }
}
