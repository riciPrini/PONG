namespace FerriPong
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.plain = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.plain2 = new System.Windows.Forms.PictureBox();
            this.plain3 = new System.Windows.Forms.PictureBox();
            this.ballTimer = new System.Windows.Forms.Timer(this.components);
            this.flower = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.plain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plain2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plain3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower)).BeginInit();
            this.SuspendLayout();
            // 
            // plain
            // 
            this.plain.BackColor = System.Drawing.Color.Black;
            this.plain.Location = new System.Drawing.Point(155, 452);
            this.plain.Name = "plain";
            this.plain.Size = new System.Drawing.Size(120, 13);
            this.plain.TabIndex = 0;
            this.plain.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(125, 192);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 33);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.flower);
            this.panel.Controls.Add(this.bomb);
            this.panel.Controls.Add(this.score);
            this.panel.Controls.Add(this.plain2);
            this.panel.Controls.Add(this.plain3);
            this.panel.Controls.Add(this.ball);
            this.panel.Controls.Add(this.plain);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1298, 537);
            this.panel.TabIndex = 2;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // bomb
            // 
            this.bomb.BackColor = System.Drawing.Color.Black;
            this.bomb.Location = new System.Drawing.Point(345, 253);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(27, 28);
            this.bomb.TabIndex = 7;
            this.bomb.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(473, 23);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(13, 13);
            this.score.TabIndex = 6;
            this.score.Text = "0";
            // 
            // plain2
            // 
            this.plain2.BackColor = System.Drawing.Color.Black;
            this.plain2.Location = new System.Drawing.Point(225, 414);
            this.plain2.Name = "plain2";
            this.plain2.Size = new System.Drawing.Size(17, 51);
            this.plain2.TabIndex = 4;
            this.plain2.TabStop = false;
            // 
            // plain3
            // 
            this.plain3.BackColor = System.Drawing.Color.Black;
            this.plain3.Location = new System.Drawing.Point(155, 414);
            this.plain3.Name = "plain3";
            this.plain3.Size = new System.Drawing.Size(17, 51);
            this.plain3.TabIndex = 3;
            this.plain3.TabStop = false;
            // 
            // ballTimer
            // 
            this.ballTimer.Tick += new System.EventHandler(this.ballTimer_Tick);
            // 
            // flower
            // 
            this.flower.BackColor = System.Drawing.Color.Yellow;
            this.flower.Location = new System.Drawing.Point(240, 92);
            this.flower.Name = "flower";
            this.flower.Size = new System.Drawing.Size(24, 27);
            this.flower.TabIndex = 8;
            this.flower.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 537);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.plain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plain2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plain3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox plain;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox plain3;
        private System.Windows.Forms.PictureBox plain2;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer ballTimer;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.PictureBox flower;
    }
}

