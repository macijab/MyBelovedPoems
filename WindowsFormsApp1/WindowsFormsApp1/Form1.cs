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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d, k, z, zysk, suma = 0;
            int min, max, ile, popyt;
            String a = "dostatwa" + (char)9 + "dzienny zysk " +(char)13 +(char)10;
            d = Convert.ToDouble(textBox1.Text);
            k = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            min = Convert.ToInt32(textBox4.Text);
            max = Convert.ToInt32(textBox5.Text);
            ile = Convert.ToInt32(textBox6.Text);
            for(int i = min + 1; i <= max; i++)
            {
                Random popyta = new Random();
                for (int j = 0; j<ile; j++)
                {
                    popyt = popyta.Next(min, max);
                    if (popyt >= i)
                    {
                        zysk = (double)i * (k - d);
                    }
                    else
                    {
                        zysk = (k - d) * popyt;
                        zysk -= z * ((double)i - (double)popyt);
                    }
                    suma += zysk;
                }
                zysk = suma / ile;
                a += Convert.ToString(i) + (char)9 + Convert.ToString(Math.Round(zysk,2)) + (char)13 + (char)10;
            }
            textBox7.Text = a;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text= "0,5";
            textBox2.Text = "1";
            textBox3.Text = "0,3";
            textBox4.Text = "10";
            textBox5.Text = "15";
            textBox6.Text = "365";
        }
    }
}
