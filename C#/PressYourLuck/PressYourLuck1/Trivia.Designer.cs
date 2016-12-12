namespace PressYourLuck
{
    partial class Trivia
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
            this.question = new System.Windows.Forms.Label();
            this.player1Spin = new System.Windows.Forms.Label();
            this.player2Spin = new System.Windows.Forms.Label();
            this.player3Spin = new System.Windows.Forms.Label();
            this.readyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.answerText = new System.Windows.Forms.TextBox();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.BuzzinTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(12, 9);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(335, 139);
            this.question.TabIndex = 0;
            this.question.Text = "Player1 press Q to buzz in\r\nPlayer2 press P to buzz in\r\nPlayer3 press the spaceba" +
    "r to buzz in\r\n";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1Spin
            // 
            this.player1Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Spin.Location = new System.Drawing.Point(272, 277);
            this.player1Spin.Name = "player1Spin";
            this.player1Spin.Size = new System.Drawing.Size(75, 37);
            this.player1Spin.TabIndex = 1;
            // 
            // player2Spin
            // 
            this.player2Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Spin.Location = new System.Drawing.Point(135, 277);
            this.player2Spin.Name = "player2Spin";
            this.player2Spin.Size = new System.Drawing.Size(75, 37);
            this.player2Spin.TabIndex = 2;
            this.player2Spin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player3Spin
            // 
            this.player3Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3Spin.Location = new System.Drawing.Point(12, 277);
            this.player3Spin.Name = "player3Spin";
            this.player3Spin.Size = new System.Drawing.Size(75, 37);
            this.player3Spin.TabIndex = 3;
            this.player3Spin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // readyButton
            // 
            this.readyButton.Location = new System.Drawing.Point(37, 194);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(134, 43);
            this.readyButton.TabIndex = 4;
            this.readyButton.Text = "Ready?";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 10;
            // 
            // answerText
            // 
            this.answerText.Location = new System.Drawing.Point(37, 151);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(284, 20);
            this.answerText.TabIndex = 9;
            // 
            // AnswerButton
            // 
            this.AnswerButton.Enabled = false;
            this.AnswerButton.Location = new System.Drawing.Point(190, 194);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(131, 43);
            this.AnswerButton.TabIndex = 11;
            this.AnswerButton.Text = "Final Answer?";
            this.AnswerButton.UseVisualStyleBackColor = true;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // BuzzinTextbox
            // 
            this.BuzzinTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.BuzzinTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.BuzzinTextbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuzzinTextbox.Location = new System.Drawing.Point(150, 243);
            this.BuzzinTextbox.Name = "BuzzinTextbox";
            this.BuzzinTextbox.Size = new System.Drawing.Size(60, 20);
            this.BuzzinTextbox.TabIndex = 12;
            // 
            // Trivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 323);
            this.Controls.Add(this.BuzzinTextbox);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.player3Spin);
            this.Controls.Add(this.player2Spin);
            this.Controls.Add(this.player1Spin);
            this.Controls.Add(this.question);
            this.KeyPreview = true;
            this.Name = "Trivia";
            this.Text = "Trivia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label player1Spin;
        private System.Windows.Forms.Label player2Spin;
        private System.Windows.Forms.Label player3Spin;
        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.TextBox BuzzinTextbox;
    }
}