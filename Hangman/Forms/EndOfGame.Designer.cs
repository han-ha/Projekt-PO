namespace HangmanUI.Forms
{
    partial class EndOfGame
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
            this.btnExitEndOfGame = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultPB = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExitEndOfGame);
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Controls.Add(this.resultPB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 574);
            this.panel1.TabIndex = 0;
            // 
            // btnExitEndOfGame
            // 
            this.btnExitEndOfGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExitEndOfGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExitEndOfGame.Location = new System.Drawing.Point(0, 509);
            this.btnExitEndOfGame.Name = "btnExitEndOfGame";
            this.btnExitEndOfGame.Size = new System.Drawing.Size(836, 65);
            this.btnExitEndOfGame.TabIndex = 2;
            this.btnExitEndOfGame.Text = "Wyjście";
            this.btnExitEndOfGame.UseVisualStyleBackColor = true;
            this.btnExitEndOfGame.Click += new System.EventHandler(this.btnExitEndOfGame_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(0, 351);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(836, 223);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "informacja o wyniku\r\n";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultPB
            // 
            this.resultPB.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultPB.Location = new System.Drawing.Point(0, 0);
            this.resultPB.Name = "resultPB";
            this.resultPB.Size = new System.Drawing.Size(836, 351);
            this.resultPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.resultPB.TabIndex = 0;
            this.resultPB.TabStop = false;
            // 
            // EndOfGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 574);
            this.Controls.Add(this.panel1);
            this.Name = "EndOfGame";
            this.Text = "EndOfGame";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox resultPB;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button btnExitEndOfGame;
    }
}