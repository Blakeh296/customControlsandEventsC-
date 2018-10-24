using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DecimalConversionsDLL;

namespace ControlandEventsDemo
{

    public partial class Form1 : Form
    {
        DecimalConvert decimalToHexi = new DecimalConvert();

        public Form1()
        {
            InitializeComponent();
        }

        private void colorSelection1_ColorChanged(object sender, EventArgs e)
        {
            tbRed.Text = colorSelection1.ControlColor.R.ToString();
            tbGreen.Text = colorSelection1.ControlColor.G.ToString();
            tbBlue.Text = colorSelection1.ControlColor.B.ToString();

            string redHex = decimalToHexi.HexCalculator(colorSelection1.ControlColor.R);
            string greenHex = decimalToHexi.HexCalculator(colorSelection1.ControlColor.G);
            string blueHex = decimalToHexi.HexCalculator(colorSelection1.ControlColor.B);

            if (redHex == "F" || redHex == "E" || redHex == "D" || redHex == "C" || redHex == "B" || redHex == "A" || redHex == "9" || redHex == "8" || redHex == "7" || redHex == "6" || redHex == "5" || redHex == "4" || redHex == "3" || redHex == "2" || redHex == "1" || redHex == "0")
            { redHex = "0" + redHex; }
            if (greenHex == "F" || greenHex == "E" || greenHex == "D" || greenHex == "C" || greenHex == "B" || greenHex == "A" || greenHex == "9" || greenHex == "8" || greenHex == "7" || greenHex == "6" || greenHex == "5" || greenHex == "4" || greenHex == "3" || greenHex == "2" || greenHex == "1" || greenHex == "0")
            { greenHex = "0" + greenHex; }
            if (blueHex == "F" || blueHex == "E" || blueHex == "D" || blueHex == "C" || blueHex == "B" || blueHex == "A" || blueHex == "9" || blueHex == "8" || blueHex == "7" || blueHex == "6" || blueHex == "5" || blueHex == "4" || blueHex == "3" || blueHex == "2" || blueHex == "1" || blueHex == "0")
            { blueHex = "0" + blueHex; }

            tbHexiDecimal.Text = "#" + redHex + greenHex + blueHex;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int redVal = int.Parse(tbRed.Text);
            int greenVal = int.Parse(tbGreen.Text);
            int blueVal = int.Parse(tbBlue.Text);

            colorSelection1.UpdateCustomControl(redVal,greenVal,blueVal);

            string redHex = decimalToHexi.HexCalculator(redVal);
            string greenHex = decimalToHexi.HexCalculator(greenVal);
            string blueHex = decimalToHexi.HexCalculator(blueVal);

            if (redHex == "F" || redHex == "E" || redHex == "D" || redHex == "C" || redHex == "B" || redHex == "A" || redHex == "9" || redHex == "8" || redHex == "7" || redHex == "6" || redHex == "5" || redHex == "4" || redHex == "3" || redHex == "2" || redHex == "1" || redHex == "0")
            { redHex = "0" + redHex; }
            if (greenHex == "F" || greenHex == "E" || greenHex == "D" || greenHex == "C" || greenHex == "B" || greenHex == "A" || greenHex == "9" || greenHex == "8" || greenHex == "7" || greenHex == "6" || greenHex == "5" || greenHex == "4" || greenHex == "3" || greenHex == "2" || greenHex == "1" || greenHex == "0")
            { greenHex = "0" + greenHex; }
            if (blueHex == "F" || blueHex == "E" || blueHex == "D" || blueHex == "C" || blueHex == "B" || blueHex == "A" || blueHex == "9" || blueHex == "8" || blueHex == "7" || blueHex == "6" || blueHex == "5" || blueHex == "4" || blueHex == "3" || blueHex == "2" || blueHex == "1" || blueHex == "0")
            { blueHex = "0" + blueHex; }

            tbHexiDecimal.Text = "#" + redHex + greenHex + blueHex;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
