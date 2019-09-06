using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float weight, height,res;
        private void bmi_chishuv(object sender, EventArgs e)
        {
           
            if(float.TryParse(textBox_height.Text,out height)==false)
            {
                textBox_height.BackColor=Color.Red;
                label_bmi.Text=string.Empty;
                return;
            }
            textBox_height.BackColor=Color.White;

             if(float.TryParse(textBox_weight.Text,out weight)==false)
            {
                textBox_weight.BackColor=Color.Red;
                label_bmi.Text=string.Empty;
                return;
            }
            textBox_weight.BackColor=Color.White;

            res = weight / (height * height);

            if (res < 18.5)
                label_bmi.Text = "You're underweight(" + res.ToString("0.0") + ")";
            else
                if (res >= 18.5 && res < 25)
                    label_bmi.Text = "Properly configured(" + res.ToString("0.0") + ")";
                else
                    if (res >= 25 && res < 29.9)
                        label_bmi.Text = "Defined as overweight(" + res.ToString("0.0") + ")";
                    else
                        if (res > 30)
                            label_bmi.Text = "Defined as obese(" + res.ToString("0.0") + ")";
                        else
                                label_bmi.Text = "Defined as acute obese(" + res.ToString("0.0") + ")";

        }

    }
}
