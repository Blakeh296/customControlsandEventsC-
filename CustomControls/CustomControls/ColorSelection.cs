using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class ColorSelection : UserControl
    {
        private Color _controlColor; //Private property set in the trackBar_Scroll method

        public event EventHandler ColorChanged; // Public Event

        public Color ControlColor //Public property to be accessed by the Windows form
        {
            get { return _controlColor; }
            set { _controlColor = value; }
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

        public void UpdateCustomControl(int redVal, int greenVal, int blueVal)
        {
            Color controlColor = Color.FromArgb(redVal, greenVal, blueVal);
            pnlColor.BackColor = controlColor;
            tbRed.Value = redVal;
            tbGreen.Value = greenVal;
            tbBlue.Value = blueVal;
            Application.DoEvents();
            
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            int redValue = tbRed.Value;
            int greenValue = tbGreen.Value;
            int blueValue = tbBlue.Value;
            Color controlColor = Color.FromArgb(redValue, greenValue, blueValue);

            try
            {
                pnlColor.BackColor = controlColor;
                _controlColor = controlColor;
                OnColorChanged(EventArgs.Empty); // Call to the method
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
