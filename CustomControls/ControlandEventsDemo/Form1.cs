using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;

namespace ControlandEventsDemo
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //This is for when a user scrolls with the Trackbar
        private void colorSelection1_ColorChanged(object sender, EventArgs e)
        {
            tbRed.Text = colorSelection1.ControlColor.R.ToString();
            tbGreen.Text = colorSelection1.ControlColor.G.ToString();
            tbBlue.Text = colorSelection1.ControlColor.B.ToString();
            colorSelection1.UpdateHexaDecimal(colorSelection1.HexadecimalValue);
        }

        //This is for when the user changes a texbox value themselves
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int redVal = int.Parse(tbRed.Text);
            int greenVal = int.Parse(tbGreen.Text);
            int blueVal = int.Parse(tbBlue.Text);
            //Hexadicimal is also updated in the UpdateCustomControl method
            colorSelection1.UpdateCustomControl(redVal,greenVal,blueVal);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
