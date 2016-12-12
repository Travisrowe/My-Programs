//Utilities.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Code from http://stackoverflow.com/questions/15569641/reset-all-the-items-in-a-form
namespace ShapesForm
{
    class Utilities
    {
        public static void ResetTextboxes(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "0";
                }
            }
        }
    }
}
