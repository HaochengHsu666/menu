using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg += "==================" + Environment.NewLine;
            if (checkBox1.Checked)
            {
                Form1.price = Form1.price * 0.95;
                Form1.msg += "會員打95折";

            }
            if (checkBox2.Checked)
            {
                Form1.price = Form1.price - 20;
                Form1.msg += "減20元";

            }
            if (checkBox3.Checked)
            {
                Form1.price = Form1.price -40;
                Form1.msg += "減40元";

            }
            if (checkBox4.Checked)
            {
                Form1.price = Form1.price -100;
                Form1.msg += "減100元";

            }
            if (checkBox5.Checked)
            {
                Form1.price = Form1.price * 0.85;
                Form1.msg += "會員打85折";

            }
            if (checkBox6.Checked)
            {
                Form1.price = Form1.price * 0.75;
                Form1.msg += "會員打75折";

            }
            if (checkBox7.Checked)
            {
                Form1.price = Form1.price +0;
                Form1.msg += "非會員會員沒轍:)";

            }
            Form1.msg += "實收" + Form1.price + Environment.NewLine;
            this.Dispose();
        }
    }
}