using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator00
{
    public partial class Form1 : Form
    {
        IMycalculator calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if(validateinpot())
            {
                int plus = calculator.plus((int)txtnumber1.Value ,(int) txtnumber2.Value);
                MessageBox.Show("int sum :"+plus);
            }
        }

        private void txtnumber2_ValueChanged(object sender, EventArgs e)
        {

        }

        bool validateinpot()

        {
            bool itvalidate = true;
            if (txtnumber1.Value == 0)
            {
                MessageBox.Show("عدد صفر وارد نکن");
                itvalidate = false;

            }
            else
            {


                if (txtnumber2.Value == 0)
                {
                    MessageBox.Show("گمج دومی رو هم صفر وارد نکن ");
                    itvalidate = false;
                }
            }

           return itvalidate;
        }

        private void btnmultiple_Click(object sender, EventArgs e)
        {
            if(validateinpot())
            {
                int multiple = calculator.multiple((int)txtnumber1.Value, (int)txtnumber2.Value);
                MessageBox.Show("int multiple:" + multiple);
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if(validateinpot())
            {
                int minus = calculator.minus((int)txtnumber1.Value, (int)txtnumber2.Value);
                MessageBox.Show("int minus:" + minus);
            }

        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            int divide = calculator.divide((int)txtnumber1.Value, (int)txtnumber2.Value);

            MessageBox.Show("int divide:" + divide);
        }
    }
}
