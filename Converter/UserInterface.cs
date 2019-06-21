using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        public double ConvertOZ(string Measurement, double Value)
        {
            if (Measurement == "oz")

                return Value;

            else if (Measurement == "lbs")

                return Value * .0625;

            else if (Measurement == "mg")

                return Value * 28349.5;

            else if (Measurement == "g")

                return Value * 28.3495;

            else if (Measurement == "kg")

                return Value * .0283495;

            else

                throw new ArgumentNullException();

        }

        public double ConvertLBS(string Measurement, double Value)
        {
            if (Measurement == "oz")

                return Value * 16;

            else if (Measurement == "lbs")

                return Value;

            else if (Measurement == "mg")

                return Value * 453592;

            else if (Measurement == "g")

                return Value * 453.592;

            else if (Measurement == "kg")

                return Value * .0453592;

            else

                throw new ArgumentNullException();
        }

        public double ConvertMG(string Measurement, double Value)
        {
            if (Measurement == "oz")

                return Value * .000035274;

            else if (Measurement == "lbs")

                return Value * .0000022046;

            else if (Measurement == "mg")

                return Value;

            else if (Measurement == "g")

                return Value * .001;

            else if (Measurement == "kg")

                return Value * .000001;

            else

                throw new ArgumentNullException();
        }

        public double ConvertG(string Measurement, double Value)
        {
            if (Measurement == "oz")

                return Value * .035274;

            else if (Measurement == "lbs")

                return Value * .00220462;

            else if (Measurement == "mg")

                return Value * 1000;

            else if (Measurement == "g")

                return Value;

            else if (Measurement == "kg")

                return Value * .001;

            else

                throw new ArgumentNullException();
        }

        public double ConvertKG(string Measurement, double Value)
        {
            if (Measurement == "oz")

                return Value * 35.274;

            else if (Measurement == "lbs")

                return Value * 2.20462;

            else if (Measurement == "mg")

                return Value * 1000000;

            else if (Measurement == "g")

                return Value * 1000;

            else if (Measurement == "kg")

                return Value;

            else

                throw new ArgumentNullException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UxConvert_Click(object sender, EventArgs e)
        {
            try
            {
                string Measurement1 = uxMeasurement1.Text;
                string Measurement2 = uxMeasurement2.Text;
                double Value = Convert.ToDouble(uxText1.Text);
                if (Measurement1 == "oz")
                {
                    uxAnswer.Text = Convert.ToString(ConvertOZ(Measurement2, Value));
                }
                else if (Measurement1 == "lbs")
                {
                    uxAnswer.Text = Convert.ToString(ConvertLBS(Measurement2, Value));
                }
                else if(Measurement1 == "mg")
                {
                    uxAnswer.Text = Convert.ToString(ConvertMG(Measurement2, Value));
                }
                else if(Measurement1 == "g")
                {
                    uxAnswer.Text = Convert.ToString(ConvertG(Measurement2, Value));
                }
                else if(Measurement1 == "kg")
                {
                    uxAnswer.Text = Convert.ToString(ConvertKG(Measurement2, Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Entry. We encountered this error: " + ex);
            }
        }

        private void UxMeasurement1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
