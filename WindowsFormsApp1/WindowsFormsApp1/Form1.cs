using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void print_res(double res)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show(res.ToString());
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Color labelbackupclr = label1.ForeColor;
            Color textboxbackupclr = textBox1.BackColor;
            Color optextboxbackupclr = textBox1.BackColor;
            string op = textBox3.Text;
            double res;
            bool check = double.TryParse(textBox1.Text,out res) && double.TryParse(textBox2.Text, out res);
            if (check)
            {
                switch (op)
                {
                    case "+":
                        res = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                        print_res(res);
                        break;
                    case "-":
                        res = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
                        print_res(res);
                        break;
                    case "*":
                        res = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
                        print_res(res);
                        break;
                    case "/":
                        res = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                        print_res(res);
                        break;
                    default:
                        textBox3.Clear();
                        textBox3.BackColor = Color.LightCoral;
                        MessageBox.Show("incorrect operator");
                        textBox3.BackColor = optextboxbackupclr;
                        break;
                }

            }
            else {
                textBox1.Clear();
                textBox2.Clear();
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                textBox1.BackColor = Color.LightCoral;
                textBox2.BackColor = Color.LightCoral;
                MessageBox.Show("input sting isnt digit");
                label1.ForeColor = labelbackupclr;
                label2.ForeColor = labelbackupclr;
                textBox1.BackColor = textboxbackupclr;
                textBox2.BackColor = textboxbackupclr;
            }
            
        }
    }
}
