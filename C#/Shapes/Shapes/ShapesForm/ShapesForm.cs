//ShapeForm (Form file)
//Travis Rowe
//4143 Contemporary Programming Languages
//Polymorphism assignment - Shapes
//Creates a dll of shapes which can calculate perimeter, area, and/or volume
//based on the selected shape

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Shapes;

namespace ShapesForm
{
    public partial class ShapesForm : Form
    {
        public ShapesForm()
        {
            InitializeComponent();
        }

        private void ShapeType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Enables appropriate boxes for selected shape
            switch (ShapeType.SelectedIndex)
            {
                case 0: // circle
                    XBox.Enabled = true;
                    YBox.Enabled = true;
                    ZBox.Enabled = false;
                    RadiusBox.Enabled = true;
                    WidthBox.Enabled = false;
                    HeightBox.Enabled = false;
                    XBox.Text = "0";
                    break;
                case 1: // square
                    XBox.Enabled = true;
                    YBox.Enabled = true;
                    ZBox.Enabled = false;
                    WidthBox.Enabled = true;
                    RadiusBox.Enabled = false;
                    HeightBox.Enabled = false;
                    break;
                case 2: // rectangle
                    XBox.Enabled = true;
                    YBox.Enabled = true;
                    ZBox.Enabled = false;
                    RadiusBox.Enabled = false;
                    WidthBox.Enabled = true;
                    HeightBox.Enabled = true;
                    break;
                case 3: // cylinder
                    XBox.Enabled = true;
                    YBox.Enabled = true;
                    ZBox.Enabled = true;
                    RadiusBox.Enabled = true;
                    WidthBox.Enabled = false;
                    HeightBox.Enabled = true;
                    break;
                case 4: // sphere
                    XBox.Enabled = true;
                    YBox.Enabled = true;
                    ZBox.Enabled = true;
                    RadiusBox.Enabled = true;
                    WidthBox.Enabled = false;
                    HeightBox.Enabled = false;
                    break;
                case 5: // cube
                    XBox.Enabled = true;
                    YBox.Enabled = true;
                    ZBox.Enabled = true;
                    RadiusBox.Enabled = false;
                    WidthBox.Enabled = true;
                    HeightBox.Enabled = false;
                    break;
            }
        }

        private void CalculateButton_Click_1(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(XBox.Text);
            int y = Convert.ToInt32(YBox.Text);
            int z;
            int w;
            double h;
            double r;

            // common directory in which images will be stored
            string imageDir = Environment.CurrentDirectory;
            // To delete \bin\Debug from directory
            imageDir = imageDir.Replace("\\bin\\Debug", "\\Resources\\");

            //check for negative values in width, height, and radius boxes
            try
            {
                bool wBool = Convert.ToInt32(WidthBox.Text) >= 0;
                bool hBool = Convert.ToInt32(HeightBox.Text) >= 0;
                bool rBool = Convert.ToInt32(RadiusBox.Text) >= 0;
                if (!(wBool && hBool && rBool))
                    throw new FormatException();
            }
            catch (FormatException)
            {
                InfoLabel.Text = "Please input non-negative numbers \nfor width, height, and/or radius";
                //resets Textboxes to 0
                Utilities.ResetTextboxes(this);
                PerimNumLabel.Text = "";
                VolNumLabel.Text = "";
                AreaNumLabel.Text = "";
                return;
            }
            //Calculate given shape
            switch (ShapeType.SelectedIndex)
            {
                case 0: // circle
                    r = Convert.ToDouble(RadiusBox.Text);
                    Shapes.Circle circ = new Circle(x, y, r);
                    InfoLabel.Text = "You selected a " + circ.Name + '\n' + circ.ToString();
                    ShapePictureBox.Image = Image.FromFile(Path.Combine(imageDir, "circle.png"));
                    PerimNumLabel.Text = Convert.ToString(circ.Perimeter());
                    AreaNumLabel.Text = Convert.ToString(circ.Area());
                    VolNumLabel.Text = "Not calculated";
                    break;
                case 1: // square
                    w = Convert.ToInt32(WidthBox.Text);
                    Shapes.Square squar = new Square(x, y, w);
                    InfoLabel.Text = "You selected a " + squar.Name + '\n' + squar.ToString();
                    ShapePictureBox.Image = Image.FromFile(Path.Combine(imageDir, "square.png"));
                    PerimNumLabel.Text = Convert.ToString(squar.Perimeter());
                    AreaNumLabel.Text = Convert.ToString(squar.Area());
                    VolNumLabel.Text = "Not calculated";
                    break;
                case 2: // rectangle
                    w = Convert.ToInt32(WidthBox.Text);
                    h = Convert.ToDouble(HeightBox.Text);
                    Shapes.Rectangle rect = new Shapes.Rectangle(x, y, w, (int) h);
                    ShapePictureBox.Image = Image.FromFile(Path.Combine(imageDir, "rectangle.jpg"));
                    InfoLabel.Text = "You selected a " + rect.Name + '\n' + rect.ToString();
                    PerimNumLabel.Text = Convert.ToString(rect.Perimeter());
                    AreaNumLabel.Text = Convert.ToString(rect.Area());
                    VolNumLabel.Text = "Not calculated";
                    break;
                case 3: // cylinder
                    r = Convert.ToDouble(RadiusBox.Text);
                    z = Convert.ToInt32(ZBox.Text);
                    h = Convert.ToDouble(HeightBox.Text);
                    Shapes.Cylinder cyl = new Cylinder(x, y, z, r, h);
                    InfoLabel.Text = "You selected a " + cyl.Name + '\n' + cyl.ToString();
                    ShapePictureBox.Image = Image.FromFile(Path.Combine(imageDir, "cylinder.png"));
                    VolNumLabel.Text = Convert.ToString(cyl.Volume());
                    PerimNumLabel.Text = "Not calculated";
                    AreaNumLabel.Text = "Not calculated";
                    break;
                case 4: // sphere
                    r = Convert.ToDouble(RadiusBox.Text);
                    z = Convert.ToInt32(ZBox.Text);
                    Shapes.Sphere spher = new Sphere(x, y, z, r);
                    InfoLabel.Text = "You selected a " + spher.Name + '\n' + spher.ToString();
                    ShapePictureBox.Image = Image.FromFile(Path.Combine(imageDir, "sphere.png"));
                    VolNumLabel.Text = Convert.ToString(spher.Volume());
                    PerimNumLabel.Text = "Not calculated";
                    AreaNumLabel.Text = "Not calculated";
                    break;
                case 5: // cube
                    w = Convert.ToInt32(WidthBox.Text);
                    z = Convert.ToInt32(ZBox.Text);
                    Shapes.Cube cub = new Cube(x, y, z, w);
                    InfoLabel.Text = "You selected a " + cub.Name + '\n' + cub.ToString();
                    ShapePictureBox.Image = Image.FromFile(Path.Combine(imageDir, "cube.png"));
                    VolNumLabel.Text = Convert.ToString(cub.Volume());
                    PerimNumLabel.Text = "Not calculated";
                    AreaNumLabel.Text = "Not calculated";
                    break;
            }
        }
    }
}
