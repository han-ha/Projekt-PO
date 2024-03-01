namespace HangmanUI.Forms
{
    partial class Game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtUsedLetters = new System.Windows.Forms.TextBox();
            this.lblUsedLetters = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.inputConfirmButton = new System.Windows.Forms.Button();
            this.lblGiveLetter = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbImages = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1045, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wisielec";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 554);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(532, 554);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(532, 492);
            this.panel5.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnGiveUp);
            this.panel8.Controls.Add(this.lblWord);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(532, 343);
            this.panel8.TabIndex = 0;
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGiveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGiveUp.Location = new System.Drawing.Point(0, 265);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(532, 78);
            this.btnGiveUp.TabIndex = 6;
            this.btnGiveUp.Text = "Poddaję się (wyjście z programu)";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // lblWord
            // 
            this.lblWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWord.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWord.Location = new System.Drawing.Point(0, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(532, 343);
            this.lblWord.TabIndex = 5;
            this.lblWord.Text = "słowo";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 343);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(532, 149);
            this.panel7.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtUsedLetters);
            this.panel10.Controls.Add(this.lblUsedLetters);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(332, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 149);
            this.panel10.TabIndex = 0;
            // 
            // txtUsedLetters
            // 
            this.txtUsedLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsedLetters.Location = new System.Drawing.Point(0, 39);
            this.txtUsedLetters.Multiline = true;
            this.txtUsedLetters.Name = "txtUsedLetters";
            this.txtUsedLetters.ReadOnly = true;
            this.txtUsedLetters.Size = new System.Drawing.Size(200, 110);
            this.txtUsedLetters.TabIndex = 1;
            // 
            // lblUsedLetters
            // 
            this.lblUsedLetters.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsedLetters.Location = new System.Drawing.Point(0, 0);
            this.lblUsedLetters.Name = "lblUsedLetters";
            this.lblUsedLetters.Size = new System.Drawing.Size(200, 39);
            this.lblUsedLetters.TabIndex = 0;
            this.lblUsedLetters.Text = "Użyte litery:";
            this.lblUsedLetters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtLogs);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(332, 149);
            this.panel9.TabIndex = 0;
            // 
            // txtLogs
            // 
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogs.Location = new System.Drawing.Point(0, 0);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(332, 149);
            this.txtLogs.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtInput);
            this.panel6.Controls.Add(this.inputConfirmButton);
            this.panel6.Controls.Add(this.lblGiveLetter);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(532, 62);
            this.panel6.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtInput.Location = new System.Drawing.Point(136, 0);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(259, 62);
            this.txtInput.TabIndex = 3;
            // 
            // inputConfirmButton
            // 
            this.inputConfirmButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.inputConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputConfirmButton.Location = new System.Drawing.Point(395, 0);
            this.inputConfirmButton.Name = "inputConfirmButton";
            this.inputConfirmButton.Size = new System.Drawing.Size(137, 62);
            this.inputConfirmButton.TabIndex = 2;
            this.inputConfirmButton.Text = "Zatwierdź";
            this.inputConfirmButton.UseVisualStyleBackColor = true;
            this.inputConfirmButton.Click += new System.EventHandler(this.inputConfirmButton_Click);
            // 
            // lblGiveLetter
            // 
            this.lblGiveLetter.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGiveLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGiveLetter.Location = new System.Drawing.Point(0, 0);
            this.lblGiveLetter.Name = "lblGiveLetter";
            this.lblGiveLetter.Size = new System.Drawing.Size(136, 62);
            this.lblGiveLetter.TabIndex = 1;
            this.lblGiveLetter.Text = "Podaj literę:";
            this.lblGiveLetter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pbImages);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(532, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 554);
            this.panel3.TabIndex = 0;
            // 
            // pbImages
            // 
            this.pbImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImages.Location = new System.Drawing.Point(0, 0);
            this.pbImages.Name = "pbImages";
            this.pbImages.Size = new System.Drawing.Size(513, 554);
            this.pbImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImages.TabIndex = 3;
            this.pbImages.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 621);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Game";
            this.Text = "Gra";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblGiveLetter;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button inputConfirmButton;
        private System.Windows.Forms.PictureBox pbImages;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblUsedLetters;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.TextBox txtUsedLetters;
    }
}