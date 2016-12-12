namespace Painter
{
    partial class PainterForm
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
            this.BlackButton = new System.Windows.Forms.RadioButton();
            this.RedButton = new System.Windows.Forms.RadioButton();
            this.OrangeButton = new System.Windows.Forms.RadioButton();
            this.YellowButton = new System.Windows.Forms.RadioButton();
            this.BlueButton = new System.Windows.Forms.RadioButton();
            this.IndigoButton = new System.Windows.Forms.RadioButton();
            this.GreenButton = new System.Windows.Forms.RadioButton();
            this.VioletButton = new System.Windows.Forms.RadioButton();
            this.ColorBox = new System.Windows.Forms.GroupBox();
            this.SizeBox = new System.Windows.Forms.GroupBox();
            this.LargeButton = new System.Windows.Forms.RadioButton();
            this.MediumButton = new System.Windows.Forms.RadioButton();
            this.SmallButton = new System.Windows.Forms.RadioButton();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PaintPanel = new System.Windows.Forms.Panel();
            this.ColorBox.SuspendLayout();
            this.SizeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BlackButton
            // 
            this.BlackButton.AutoSize = true;
            this.BlackButton.Location = new System.Drawing.Point(6, 19);
            this.BlackButton.Name = "BlackButton";
            this.BlackButton.Size = new System.Drawing.Size(52, 17);
            this.BlackButton.TabIndex = 0;
            this.BlackButton.TabStop = true;
            this.BlackButton.Text = "Black";
            this.BlackButton.UseVisualStyleBackColor = true;
            this.BlackButton.CheckedChanged += new System.EventHandler(this.BlackButton_CheckedChanged);
            // 
            // RedButton
            // 
            this.RedButton.AutoSize = true;
            this.RedButton.Location = new System.Drawing.Point(6, 42);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(45, 17);
            this.RedButton.TabIndex = 1;
            this.RedButton.TabStop = true;
            this.RedButton.Text = "Red";
            this.RedButton.UseVisualStyleBackColor = true;
            this.RedButton.CheckedChanged += new System.EventHandler(this.RedButton_CheckedChanged);
            // 
            // OrangeButton
            // 
            this.OrangeButton.AutoSize = true;
            this.OrangeButton.Location = new System.Drawing.Point(6, 65);
            this.OrangeButton.Name = "OrangeButton";
            this.OrangeButton.Size = new System.Drawing.Size(60, 17);
            this.OrangeButton.TabIndex = 2;
            this.OrangeButton.TabStop = true;
            this.OrangeButton.Text = "Orange";
            this.OrangeButton.UseVisualStyleBackColor = true;
            this.OrangeButton.CheckedChanged += new System.EventHandler(this.OrangeButton_CheckedChanged);
            // 
            // YellowButton
            // 
            this.YellowButton.AutoSize = true;
            this.YellowButton.Location = new System.Drawing.Point(6, 88);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(56, 17);
            this.YellowButton.TabIndex = 3;
            this.YellowButton.TabStop = true;
            this.YellowButton.Text = "Yellow";
            this.YellowButton.UseVisualStyleBackColor = true;
            this.YellowButton.CheckedChanged += new System.EventHandler(this.YellowButton_CheckedChanged);
            // 
            // BlueButton
            // 
            this.BlueButton.AutoSize = true;
            this.BlueButton.Location = new System.Drawing.Point(6, 134);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(46, 17);
            this.BlueButton.TabIndex = 4;
            this.BlueButton.TabStop = true;
            this.BlueButton.Text = "Blue";
            this.BlueButton.UseVisualStyleBackColor = true;
            this.BlueButton.CheckedChanged += new System.EventHandler(this.BlueButton_CheckedChanged);
            // 
            // IndigoButton
            // 
            this.IndigoButton.AutoSize = true;
            this.IndigoButton.Location = new System.Drawing.Point(6, 157);
            this.IndigoButton.Name = "IndigoButton";
            this.IndigoButton.Size = new System.Drawing.Size(54, 17);
            this.IndigoButton.TabIndex = 5;
            this.IndigoButton.TabStop = true;
            this.IndigoButton.Text = "Indigo";
            this.IndigoButton.UseVisualStyleBackColor = true;
            this.IndigoButton.CheckedChanged += new System.EventHandler(this.IndigoButton_CheckedChanged);
            // 
            // GreenButton
            // 
            this.GreenButton.AutoSize = true;
            this.GreenButton.Location = new System.Drawing.Point(6, 111);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(54, 17);
            this.GreenButton.TabIndex = 6;
            this.GreenButton.TabStop = true;
            this.GreenButton.Text = "Green";
            this.GreenButton.UseVisualStyleBackColor = true;
            this.GreenButton.CheckedChanged += new System.EventHandler(this.GreenButton_CheckedChanged);
            // 
            // VioletButton
            // 
            this.VioletButton.AutoSize = true;
            this.VioletButton.Location = new System.Drawing.Point(6, 179);
            this.VioletButton.Name = "VioletButton";
            this.VioletButton.Size = new System.Drawing.Size(51, 17);
            this.VioletButton.TabIndex = 7;
            this.VioletButton.TabStop = true;
            this.VioletButton.Text = "Violet";
            this.VioletButton.UseVisualStyleBackColor = true;
            this.VioletButton.CheckedChanged += new System.EventHandler(this.VioletButton_CheckedChanged);
            // 
            // ColorBox
            // 
            this.ColorBox.BackColor = System.Drawing.Color.Silver;
            this.ColorBox.Controls.Add(this.VioletButton);
            this.ColorBox.Controls.Add(this.GreenButton);
            this.ColorBox.Controls.Add(this.IndigoButton);
            this.ColorBox.Controls.Add(this.BlueButton);
            this.ColorBox.Controls.Add(this.YellowButton);
            this.ColorBox.Controls.Add(this.OrangeButton);
            this.ColorBox.Controls.Add(this.RedButton);
            this.ColorBox.Controls.Add(this.BlackButton);
            this.ColorBox.Location = new System.Drawing.Point(1, 12);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(96, 199);
            this.ColorBox.TabIndex = 0;
            this.ColorBox.TabStop = false;
            this.ColorBox.Text = "Color";
            // 
            // SizeBox
            // 
            this.SizeBox.Controls.Add(this.LargeButton);
            this.SizeBox.Controls.Add(this.MediumButton);
            this.SizeBox.Controls.Add(this.SmallButton);
            this.SizeBox.Location = new System.Drawing.Point(5, 217);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(91, 90);
            this.SizeBox.TabIndex = 1;
            this.SizeBox.TabStop = false;
            this.SizeBox.Text = "Size";
            // 
            // LargeButton
            // 
            this.LargeButton.AutoSize = true;
            this.LargeButton.Location = new System.Drawing.Point(0, 65);
            this.LargeButton.Name = "LargeButton";
            this.LargeButton.Size = new System.Drawing.Size(52, 17);
            this.LargeButton.TabIndex = 2;
            this.LargeButton.TabStop = true;
            this.LargeButton.Text = "Large";
            this.LargeButton.UseVisualStyleBackColor = true;
            this.LargeButton.CheckedChanged += new System.EventHandler(this.LargeButton_CheckedChanged);
            // 
            // MediumButton
            // 
            this.MediumButton.AutoSize = true;
            this.MediumButton.Location = new System.Drawing.Point(2, 42);
            this.MediumButton.Name = "MediumButton";
            this.MediumButton.Size = new System.Drawing.Size(62, 17);
            this.MediumButton.TabIndex = 1;
            this.MediumButton.TabStop = true;
            this.MediumButton.Text = "Medium";
            this.MediumButton.UseVisualStyleBackColor = true;
            this.MediumButton.CheckedChanged += new System.EventHandler(this.MediumButton_CheckedChanged);
            // 
            // SmallButton
            // 
            this.SmallButton.AutoSize = true;
            this.SmallButton.Location = new System.Drawing.Point(2, 19);
            this.SmallButton.Name = "SmallButton";
            this.SmallButton.Size = new System.Drawing.Size(50, 17);
            this.SmallButton.TabIndex = 0;
            this.SmallButton.TabStop = true;
            this.SmallButton.Text = "Small";
            this.SmallButton.UseVisualStyleBackColor = true;
            this.SmallButton.CheckedChanged += new System.EventHandler(this.SmallButton_CheckedChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(7, 313);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(89, 58);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PaintPanel
            // 
            this.PaintPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaintPanel.AutoSize = true;
            this.PaintPanel.BackColor = System.Drawing.SystemColors.Window;
            this.PaintPanel.Location = new System.Drawing.Point(103, 12);
            this.PaintPanel.Name = "PaintPanel";
            this.PaintPanel.Size = new System.Drawing.Size(340, 359);
            this.PaintPanel.TabIndex = 3;
            this.PaintPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseDown);
            this.PaintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseMove);
            this.PaintPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseUp);
            // 
            // PainterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(455, 383);
            this.Controls.Add(this.PaintPanel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.ColorBox);
            this.Name = "PainterForm";
            this.Text = "Painter";
            this.ColorBox.ResumeLayout(false);
            this.ColorBox.PerformLayout();
            this.SizeBox.ResumeLayout(false);
            this.SizeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton BlackButton;
        private System.Windows.Forms.RadioButton RedButton;
        private System.Windows.Forms.RadioButton OrangeButton;
        private System.Windows.Forms.RadioButton YellowButton;
        private System.Windows.Forms.RadioButton BlueButton;
        private System.Windows.Forms.RadioButton IndigoButton;
        private System.Windows.Forms.RadioButton GreenButton;
        private System.Windows.Forms.RadioButton VioletButton;
        private System.Windows.Forms.GroupBox ColorBox;
        private System.Windows.Forms.GroupBox SizeBox;
        private System.Windows.Forms.RadioButton LargeButton;
        private System.Windows.Forms.RadioButton MediumButton;
        private System.Windows.Forms.RadioButton SmallButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel PaintPanel;

    }
}

