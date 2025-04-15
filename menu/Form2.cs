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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int[] hotpotflavorPrice = { 300 , 300, 300, 300, 300, 400, 400, 400, 400, 400, 50 };
        int[] meatkindPrice = { 200, 200, 200, 250, 250, 250, 250, 300, 250, 250, 400, 400, 250, 250, 300, 350 ,300, 350, 300 };
        int[] mainfoodPrice = { 20, 30, 30, 30, 30, 45, 45, 45, 15, 50 };
        int[] dessertPrice = { 50, 50, 50, 50, 50, 50, 50, 40, 40, 40, 40, 45 };

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg += comboBox3.Text +"\r\t" + hotpotflavorPrice[comboBox3.SelectedIndex] + Environment.NewLine;
            Form1.msg += comboBox1.Text +"\r\t" + meatkindPrice[comboBox1.SelectedIndex] + Environment.NewLine;
            Form1.msg += comboBox2.Text +"\r\t" + mainfoodPrice[comboBox2.SelectedIndex] + Environment.NewLine;
            Form1.msg += comboBox4.Text +"\r\t" + dessertPrice[comboBox4.SelectedIndex] + Environment.NewLine;
            Form1.price = hotpotflavorPrice[comboBox1.SelectedIndex] + meatkindPrice[comboBox2.SelectedIndex] + mainfoodPrice[comboBox3.SelectedIndex] + dessertPrice[comboBox4.SelectedIndex];
            Form1.msg += "合計" + Form1.price + "元" + Environment.NewLine;

            this.Dispose();
            Form3 f1 = new Form3(); //建立FrmMenu的視窗，並命名為f1
            f1.ShowDialog();            //開啟f1

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
