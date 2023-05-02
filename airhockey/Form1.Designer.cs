namespace airhockey
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.winLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.p1Score = new System.Windows.Forms.Label();
            this.p2Sxore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.Black;
            this.winLabel.Location = new System.Drawing.Point(235, 175);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(0, 29);
            this.winLabel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(140, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(403, 29);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Kristen\'s super awesome Air Hockey";
            // 
            // p1Score
            // 
            this.p1Score.AutoSize = true;
            this.p1Score.BackColor = System.Drawing.Color.Transparent;
            this.p1Score.ForeColor = System.Drawing.Color.Black;
            this.p1Score.Location = new System.Drawing.Point(60, 18);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(59, 16);
            this.p1Score.TabIndex = 2;
            this.p1Score.Text = "Player 1:";
            // 
            // p2Sxore
            // 
            this.p2Sxore.AutoSize = true;
            this.p2Sxore.BackColor = System.Drawing.Color.Transparent;
            this.p2Sxore.ForeColor = System.Drawing.Color.Black;
            this.p2Sxore.Location = new System.Drawing.Point(559, 19);
            this.p2Sxore.Name = "p2Sxore";
            this.p2Sxore.Size = new System.Drawing.Size(59, 16);
            this.p2Sxore.TabIndex = 3;
            this.p2Sxore.Text = "Player 2:";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.p2Sxore);
            this.Controls.Add(this.p1Score);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.winLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "6";
           // this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label p1Score;
        private System.Windows.Forms.Label p2Sxore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

