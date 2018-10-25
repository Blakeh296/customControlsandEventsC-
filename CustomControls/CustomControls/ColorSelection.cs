using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DecimalConversionsDLL;

namespace CustomControls
{
    public partial class ColorSelection : UserControl
    {
        DecimalConvert convert = new DecimalConvert();
        private Color _controlColor; //Private property set in the trackBar_Scroll method
        private string _hexadecimal;

        public event EventHandler ColorChanged; // Public Event

        public Color ControlColor //Public property to be accessed by the Windows form
        {
            get { return _controlColor; }
            set { _controlColor = value; }
        }

        public string HexadecimalValue
        {
            get { return _hexadecimal; }
            set { _hexadecimal = value; }
        }

        //Delegate method that will invoke our public event
        protected virtual void OnColorChanged(EventArgs e)
        {
            ColorChanged?.Invoke(this, e);
        }

        public ColorSelection()
        {
            InitializeComponent();
        }

        public void UpdateHexaDecimal(string HexaDecimal)
        {
            tbHexaDec.Text = HexaDecimal;
        }

        public void UpdateCustomControl(int redVal, int greenVal, int blueVal)
        {
            ControlColor = Color.FromArgb(redVal, greenVal, blueVal);
            pnlColor.BackColor = ControlColor;
            tbRed.Value = redVal;
            tbGreen.Value = greenVal;
            tbBlue.Value = blueVal;

            string redHex = convert.HexCalculator(redVal);
            string greenHex = convert.HexCalculator(greenVal);
            string blueHex = convert.HexCalculator(blueVal);

            try
            {
                if (redHex == "F" || redHex == "E" || redHex == "D" || redHex == "C" || redHex == "B" || redHex == "A" || redHex == "9" || redHex == "8" || redHex == "7" || redHex == "6" || redHex == "5" || redHex == "4" || redHex == "3" || redHex == "2" || redHex == "1" || redHex == "0")
                { redHex = "0" + redHex; }
                if (greenHex == "F" || greenHex == "E" || greenHex == "D" || greenHex == "C" || greenHex == "B" || greenHex == "A" || greenHex == "9" || greenHex == "8" || greenHex == "7" || greenHex == "6" || greenHex == "5" || greenHex == "4" || greenHex == "3" || greenHex == "2" || greenHex == "1" || greenHex == "0")
                { greenHex = "0" + greenHex; }
                if (blueHex == "F" || blueHex == "E" || blueHex == "D" || blueHex == "C" || blueHex == "B" || blueHex == "A" || blueHex == "9" || blueHex == "8" || blueHex == "7" || blueHex == "6" || blueHex == "5" || blueHex == "4" || blueHex == "3" || blueHex == "2" || blueHex == "1" || blueHex == "0")
                { blueHex = "0" + blueHex; }

                _hexadecimal = "#" + redHex + greenHex + blueHex;
                tbHexaDec.Text = HexadecimalValue;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            int redValue = tbRed.Value;
            int greenValue = tbGreen.Value;
            int blueValue = tbBlue.Value;
            ControlColor = Color.FromArgb(redValue, greenValue, blueValue);
            string redHex = convert.HexCalculator(redValue);
            string greenHex = convert.HexCalculator(greenValue);
            string blueHex = convert.HexCalculator(blueValue);

            try
            {
                pnlColor.BackColor = ControlColor;

                    if (redHex == "F" || redHex == "E" || redHex == "D" || redHex == "C" || redHex == "B" || redHex == "A" || redHex == "9" || redHex == "8" || redHex == "7" || redHex == "6" || redHex == "5" || redHex == "4" || redHex == "3" || redHex == "2" || redHex == "1" || redHex == "0")
                       { redHex = "0" + redHex; }
                    if (greenHex == "F" || greenHex == "E" || greenHex == "D" || greenHex == "C" || greenHex == "B" || greenHex == "A" || greenHex == "9" || greenHex == "8" || greenHex == "7" || greenHex == "6" || greenHex == "5" || greenHex == "4" || greenHex == "3" || greenHex == "2" || greenHex == "1" || greenHex == "0")
                        { greenHex = "0" + greenHex; }
                    if (blueHex == "F" || blueHex == "E" || blueHex == "D" || blueHex == "C" || blueHex == "B" || blueHex == "A" || blueHex == "9" || blueHex == "8" || blueHex == "7" || blueHex == "6" || blueHex == "5" || blueHex == "4" || blueHex == "3" || blueHex == "2" || blueHex == "1" || blueHex == "0")
                       { blueHex = "0" + blueHex; }

                _hexadecimal = "#" + redHex + greenHex + blueHex;
                tbHexaDec.Text = HexadecimalValue;
                OnColorChanged(EventArgs.Empty); // Call to the method
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
