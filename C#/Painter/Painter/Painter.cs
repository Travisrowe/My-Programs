/*
 * Travis Rowe
 * 11/3/2016
 * 4143 Contemporary Programming Languages
 * An application that accepts mouse input to allow the user to
 * paint. 
 */
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Painter
{
    public partial class PainterForm : Form
    {
        bool shouldPaint = false; // determines whether to paint
        Brush brush = new SolidBrush(Color.Black);
        int size = 4;

        public PainterForm()
        {
            InitializeComponent();
        }

        // should paint when mouse button is pressed down
        private void PaintPanel_MouseDown(object sender, EventArgs e)
        {
            // indicate that user is dragging the mouse
            shouldPaint = true;
        } // end method Painter_MouseMove

        // stop painting when mouse button is released
        private void PaintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            // indicate that user released the mouse button
            shouldPaint = false;
        } // end method Painter_MouseUp

        // draw circle whenever mouse moves with its button held down
        private void PaintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint) // check if mouse button is being pressed
            {
                // draw a cricle where the mouse pointer is present
                using (Graphics graphics = PaintPanel.CreateGraphics())
                {
                    graphics.FillEllipse(brush, e.X, e.Y, size, size);
                } // end using; calls graphics.Dispose()
            } // end if
        }

        // Color box changes
        private void BlackButton_CheckedChanged(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Black);
        }

        private void RedButton_CheckedChanged(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Red);
        }

        private void OrangeButton_CheckedChanged(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Orange);
        }

        private void YellowButton_CheckedChanged(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Yellow);
        }

        private void GreenButton_CheckedChanged(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Green);
        }

        private void BlueButton_CheckedChanged(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Blue);
        }

        private void IndigoButton_CheckedChanged(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Indigo);
        }

        // Size Box changes
        private void VioletButton_CheckedChanged(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Violet);
        }

        private void SmallButton_CheckedChanged(object sender, EventArgs e)
        {
            size = 4;
        }

        private void MediumButton_CheckedChanged(object sender, EventArgs e)
        {
            size = 8;
        }

        private void LargeButton_CheckedChanged(object sender, EventArgs e)
        {
            size = 12;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PaintPanel.Invalidate();
        }
    } // end class Painter
}
