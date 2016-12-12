namespace PressYourLuck
{
    partial class SetUp
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
            this.fileSelectGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filePathPreview = new System.Windows.Forms.Label();
            this.fileChooseButton = new System.Windows.Forms.Button();
            this.AudioGroup = new System.Windows.Forms.GroupBox();
            this.AudioCheckBox = new System.Windows.Forms.CheckBox();
            this.PlayerInfoGroup = new System.Windows.Forms.GroupBox();
            this.numOfPlayersComboBox = new System.Windows.Forms.ComboBox();
            this.okayButton = new System.Windows.Forms.Button();
            this.fileSelectGroup.SuspendLayout();
            this.AudioGroup.SuspendLayout();
            this.PlayerInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSelectGroup
            // 
            this.fileSelectGroup.Controls.Add(this.label1);
            this.fileSelectGroup.Controls.Add(this.filePathPreview);
            this.fileSelectGroup.Controls.Add(this.fileChooseButton);
            this.fileSelectGroup.Location = new System.Drawing.Point(12, 12);
            this.fileSelectGroup.Name = "fileSelectGroup";
            this.fileSelectGroup.Size = new System.Drawing.Size(217, 100);
            this.fileSelectGroup.TabIndex = 0;
            this.fileSelectGroup.TabStop = false;
            this.fileSelectGroup.Text = "Choose Question File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File path:";
            // 
            // filePathPreview
            // 
            this.filePathPreview.AllowDrop = true;
            this.filePathPreview.AutoEllipsis = true;
            this.filePathPreview.Location = new System.Drawing.Point(6, 74);
            this.filePathPreview.Name = "filePathPreview";
            this.filePathPreview.Size = new System.Drawing.Size(188, 23);
            this.filePathPreview.TabIndex = 1;
            // 
            // fileChooseButton
            // 
            this.fileChooseButton.Location = new System.Drawing.Point(47, 19);
            this.fileChooseButton.Name = "fileChooseButton";
            this.fileChooseButton.Size = new System.Drawing.Size(101, 23);
            this.fileChooseButton.TabIndex = 0;
            this.fileChooseButton.Text = "Choose File";
            this.fileChooseButton.UseVisualStyleBackColor = true;
            this.fileChooseButton.Click += new System.EventHandler(this.fileChooseButton_Click);
            // 
            // AudioGroup
            // 
            this.AudioGroup.Controls.Add(this.AudioCheckBox);
            this.AudioGroup.Location = new System.Drawing.Point(13, 119);
            this.AudioGroup.Name = "AudioGroup";
            this.AudioGroup.Size = new System.Drawing.Size(216, 100);
            this.AudioGroup.TabIndex = 1;
            this.AudioGroup.TabStop = false;
            this.AudioGroup.Text = "Audio";
            // 
            // AudioCheckBox
            // 
            this.AudioCheckBox.AutoSize = true;
            this.AudioCheckBox.Location = new System.Drawing.Point(46, 43);
            this.AudioCheckBox.Name = "AudioCheckBox";
            this.AudioCheckBox.Size = new System.Drawing.Size(95, 17);
            this.AudioCheckBox.TabIndex = 0;
            this.AudioCheckBox.Text = "Audio Enabled";
            this.AudioCheckBox.UseVisualStyleBackColor = true;
            // 
            // PlayerInfoGroup
            // 
            this.PlayerInfoGroup.Controls.Add(this.numOfPlayersComboBox);
            this.PlayerInfoGroup.Location = new System.Drawing.Point(12, 226);
            this.PlayerInfoGroup.Name = "PlayerInfoGroup";
            this.PlayerInfoGroup.Size = new System.Drawing.Size(217, 100);
            this.PlayerInfoGroup.TabIndex = 2;
            this.PlayerInfoGroup.TabStop = false;
            this.PlayerInfoGroup.Text = "Players";
            // 
            // numOfPlayersComboBox
            // 
            this.numOfPlayersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numOfPlayersComboBox.FormattingEnabled = true;
            this.numOfPlayersComboBox.Items.AddRange(new object[] {
            "2",
            "3"});
            this.numOfPlayersComboBox.Location = new System.Drawing.Point(47, 37);
            this.numOfPlayersComboBox.Name = "numOfPlayersComboBox";
            this.numOfPlayersComboBox.Size = new System.Drawing.Size(121, 21);
            this.numOfPlayersComboBox.TabIndex = 0;
            this.numOfPlayersComboBox.SelectedIndexChanged += new System.EventHandler(this.numOfPlayersComboBox_SelectedIndexChanged);
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(59, 339);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(121, 23);
            this.okayButton.TabIndex = 3;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // SetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(243, 374);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.PlayerInfoGroup);
            this.Controls.Add(this.AudioGroup);
            this.Controls.Add(this.fileSelectGroup);
            this.Name = "SetUp";
            this.Text = "Settings";
            this.fileSelectGroup.ResumeLayout(false);
            this.fileSelectGroup.PerformLayout();
            this.AudioGroup.ResumeLayout(false);
            this.AudioGroup.PerformLayout();
            this.PlayerInfoGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fileSelectGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label filePathPreview;
        private System.Windows.Forms.Button fileChooseButton;
        private System.Windows.Forms.GroupBox AudioGroup;
        private System.Windows.Forms.CheckBox AudioCheckBox;
        private System.Windows.Forms.GroupBox PlayerInfoGroup;
        private System.Windows.Forms.ComboBox numOfPlayersComboBox;
        private System.Windows.Forms.Button okayButton;
    }
}