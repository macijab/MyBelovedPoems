using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericMethod
{
    public partial class Form2 : Form
    {
        Form1 form1;
       // public Punkt p11 = null;
        public Form2()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
         //   p11.setXY(Convert.ToDouble(nudX.Value), Convert.ToDouble(nudY.Value));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            nudX.Value = Convert.ToDecimal(form1.getSX());
            nudY.Value = Convert.ToDecimal(form1.getSY());
        }
    }
}
