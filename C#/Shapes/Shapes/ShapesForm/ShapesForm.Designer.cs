namespace ShapesForm
{
    partial class ShapesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShapeType = new System.Windows.Forms.ComboBox();
            this.XBox = new System.Windows.Forms.TextBox();
            this.YBox = new System.Windows.Forms.TextBox();
            this.ShapePictureBox = new System.Windows.Forms.PictureBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.ZLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.RadiusBox = new System.Windows.Forms.TextBox();
            this.ZBox = new System.Windows.Forms.TextBox();
            this.VolNumLabel = new System.Windows.Forms.Label();
            this.AreaNumLabel = new System.Windows.Forms.Label();
            this.PerimNumLabel = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.PerimeterLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShapePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShapeType
            // 
            this.ShapeType.FormattingEnabled = true;
            this.ShapeType.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Rectangle",
            "Cylinder",
            "Sphere",
            "Cube"});
            this.ShapeType.Location = new System.Drawing.Point(56, 12);
            this.ShapeType.MaxDropDownItems = 7;
            this.ShapeType.Name = "ShapeType";
            this.ShapeType.Size = new System.Drawing.Size(168, 21);
            this.ShapeType.TabIndex = 1;
            this.ShapeType.SelectedIndexChanged += new System.EventHandler(this.ShapeType_SelectedIndexChanged_1);
            // 
            // XBox
            // 
            this.XBox.Enabled = false;
            this.XBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XBox.Location = new System.Drawing.Point(56, 39);
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(47, 21);
            this.XBox.TabIndex = 2;
            this.XBox.Text = "0";
            // 
            // YBox
            // 
            this.YBox.Enabled = false;
            this.YBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YBox.Location = new System.Drawing.Point(56, 66);
            this.YBox.Name = "YBox";
            this.YBox.Size = new System.Drawing.Size(47, 21);
            this.YBox.TabIndex = 3;
            this.YBox.Text = "0";
            // 
            // ShapePictureBox
            // 
            this.ShapePictureBox.Location = new System.Drawing.Point(109, 39);
            this.ShapePictureBox.Name = "ShapePictureBox";
            this.ShapePictureBox.Size = new System.Drawing.Size(160, 155);
            this.ShapePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShapePictureBox.TabIndex = 24;
            this.ShapePictureBox.TabStop = false;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(7, 174);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HeightLabel.Size = new System.Drawing.Size(43, 15);
            this.HeightLabel.TabIndex = 23;
            this.HeightLabel.Text = "Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(11, 147);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WidthLabel.Size = new System.Drawing.Size(38, 15);
            this.WidthLabel.TabIndex = 22;
            this.WidthLabel.Text = "Width";
            this.WidthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadiusLabel.Location = new System.Drawing.Point(4, 120);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RadiusLabel.Size = new System.Drawing.Size(46, 15);
            this.RadiusLabel.TabIndex = 21;
            this.RadiusLabel.Text = "Radius";
            this.RadiusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ZLabel
            // 
            this.ZLabel.AutoSize = true;
            this.ZLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZLabel.Location = new System.Drawing.Point(37, 93);
            this.ZLabel.Name = "ZLabel";
            this.ZLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ZLabel.Size = new System.Drawing.Size(13, 15);
            this.ZLabel.TabIndex = 20;
            this.ZLabel.Text = "z";
            this.ZLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YLabel.Location = new System.Drawing.Point(37, 66);
            this.YLabel.Name = "YLabel";
            this.YLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.YLabel.Size = new System.Drawing.Size(12, 15);
            this.YLabel.TabIndex = 19;
            this.YLabel.Text = "y";
            this.YLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLabel.Location = new System.Drawing.Point(37, 39);
            this.XLabel.Name = "XLabel";
            this.XLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.XLabel.Size = new System.Drawing.Size(13, 15);
            this.XLabel.TabIndex = 18;
            this.XLabel.Text = "x";
            this.XLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HeightBox
            // 
            this.HeightBox.Enabled = false;
            this.HeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightBox.Location = new System.Drawing.Point(56, 174);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(47, 21);
            this.HeightBox.TabIndex = 17;
            this.HeightBox.Text = "0";
            // 
            // WidthBox
            // 
            this.WidthBox.Enabled = false;
            this.WidthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthBox.Location = new System.Drawing.Point(56, 147);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(47, 21);
            this.WidthBox.TabIndex = 16;
            this.WidthBox.Text = "0";
            // 
            // RadiusBox
            // 
            this.RadiusBox.Enabled = false;
            this.RadiusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadiusBox.Location = new System.Drawing.Point(56, 120);
            this.RadiusBox.Name = "RadiusBox";
            this.RadiusBox.Size = new System.Drawing.Size(47, 21);
            this.RadiusBox.TabIndex = 15;
            this.RadiusBox.Text = "0";
            // 
            // ZBox
            // 
            this.ZBox.Enabled = false;
            this.ZBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZBox.Location = new System.Drawing.Point(56, 93);
            this.ZBox.Name = "ZBox";
            this.ZBox.Size = new System.Drawing.Size(47, 21);
            this.ZBox.TabIndex = 14;
            this.ZBox.Text = "0";
            // 
            // VolNumLabel
            // 
            this.VolNumLabel.AutoSize = true;
            this.VolNumLabel.Location = new System.Drawing.Point(120, 282);
            this.VolNumLabel.Name = "VolNumLabel";
            this.VolNumLabel.Size = new System.Drawing.Size(0, 13);
            this.VolNumLabel.TabIndex = 31;
            // 
            // AreaNumLabel
            // 
            this.AreaNumLabel.AutoSize = true;
            this.AreaNumLabel.Location = new System.Drawing.Point(120, 259);
            this.AreaNumLabel.Name = "AreaNumLabel";
            this.AreaNumLabel.Size = new System.Drawing.Size(0, 13);
            this.AreaNumLabel.TabIndex = 30;
            // 
            // PerimNumLabel
            // 
            this.PerimNumLabel.AutoSize = true;
            this.PerimNumLabel.Location = new System.Drawing.Point(120, 237);
            this.PerimNumLabel.Name = "PerimNumLabel";
            this.PerimNumLabel.Size = new System.Drawing.Size(0, 13);
            this.PerimNumLabel.TabIndex = 29;
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(57, 282);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(48, 13);
            this.VolumeLabel.TabIndex = 28;
            this.VolumeLabel.Text = "Volume: ";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(57, 259);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(35, 13);
            this.AreaLabel.TabIndex = 27;
            this.AreaLabel.Text = "Area: ";
            // 
            // PerimeterLabel
            // 
            this.PerimeterLabel.AutoSize = true;
            this.PerimeterLabel.Location = new System.Drawing.Point(57, 237);
            this.PerimeterLabel.Name = "PerimeterLabel";
            this.PerimeterLabel.Size = new System.Drawing.Size(57, 13);
            this.PerimeterLabel.TabIndex = 26;
            this.PerimeterLabel.Text = "Perimeter: ";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(55, 302);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(183, 45);
            this.CalculateButton.TabIndex = 25;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click_1);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(103, 210);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 13);
            this.InfoLabel.TabIndex = 32;
            // 
            // ShapesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 350);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.VolNumLabel);
            this.Controls.Add(this.AreaNumLabel);
            this.Controls.Add(this.PerimNumLabel);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.PerimeterLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ShapePictureBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.ZLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.RadiusBox);
            this.Controls.Add(this.ZBox);
            this.Controls.Add(this.YBox);
            this.Controls.Add(this.XBox);
            this.Controls.Add(this.ShapeType);
            this.Name = "ShapesForm";
            this.Text = "ShapesForm";
            ((System.ComponentModel.ISupportInitialize)(this.ShapePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ShapeType;
        private System.Windows.Forms.TextBox XBox;
        private System.Windows.Forms.TextBox YBox;
        private System.Windows.Forms.PictureBox ShapePictureBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.Label ZLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.TextBox RadiusBox;
        private System.Windows.Forms.TextBox ZBox;
        private System.Windows.Forms.Label VolNumLabel;
        private System.Windows.Forms.Label AreaNumLabel;
        private System.Windows.Forms.Label PerimNumLabel;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.Label PerimeterLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label InfoLabel;
    }
}