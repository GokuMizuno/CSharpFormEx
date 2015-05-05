using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double temp;
            //converts from F to C
            //Checks to see if F is empty.
            //TryParse checks to see if input is valid.
            bool parsesuccessF = false;
            bool parsesuccessC = false;
            parsesuccessF = Double.TryParse(tbTempF.Text, out temp);
            parsesuccessC = Double.TryParse(tbTempC.Text, out parsesuccessC);
            try
            {
                if (tbTempF.Text != String.Empty)
                {
                    temp = Convert.ToDouble(tbTempF.Text) - 32;
                    temp /= 9.0;
                    temp *= 5.0;
                    tbTempC.Text = Convert.ToString(temp);
                    tbTempC.Text = String.Format("{0:N2}", temp);
                }
                else if (tbTempC.Text != String.Empty)
                {
                    temp = Convert.ToDouble(tbTempC.Text) + 32;
                    temp *= 9.0;
                    temp /= 5.0;
                    tbTempF.Text = Convert.ToString(temp);
                    tbTempF.Text = String.Format("}0:N2}", temp);
                }
                else if (tbTempF.Text == String.Empty && tbTempC.Text == String.Empty)
                {
                    MessageBox.Show("Please fill out either the F or C scale with a valid number.\n");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
