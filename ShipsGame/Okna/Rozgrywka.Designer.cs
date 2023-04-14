namespace ShipsGame.Okna
{
    partial class Rozgrywka
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
            this.planszaKomputera = new System.Windows.Forms.PictureBox();
            this.planszaGracza = new System.Windows.Forms.PictureBox();
            this.timerRuchKomputera = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.planszaKomputera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).BeginInit();
            this.SuspendLayout();
            // 
            // planszaKomputera
            // 
            this.planszaKomputera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planszaKomputera.Image = global::ShipsGame.Properties.Resources.board;
            this.planszaKomputera.Location = new System.Drawing.Point(12, 12);
            this.planszaKomputera.Name = "planszaKomputera";
            this.planszaKomputera.Size = new System.Drawing.Size(400, 400);
            this.planszaKomputera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planszaKomputera.TabIndex = 0;
            this.planszaKomputera.TabStop = false;
            this.planszaKomputera.Click += new System.EventHandler(this.planszaKomputera_Click);
            this.planszaKomputera.Paint += new System.Windows.Forms.PaintEventHandler(this.planszaKomputera_Paint);
            this.planszaKomputera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.planszaKomputera_MouseMove);
            // 
            // planszaGracza
            // 
            this.planszaGracza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planszaGracza.Image = global::ShipsGame.Properties.Resources.board;
            this.planszaGracza.Location = new System.Drawing.Point(510, 12);
            this.planszaGracza.Name = "planszaGracza";
            this.planszaGracza.Size = new System.Drawing.Size(400, 400);
            this.planszaGracza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planszaGracza.TabIndex = 1;
            this.planszaGracza.TabStop = false;
            this.planszaGracza.Paint += new System.Windows.Forms.PaintEventHandler(this.planszaGracza_Paint);
            // 
            // timerRuchKomputera
            // 
            this.timerRuchKomputera.Interval = 1000;
            this.timerRuchKomputera.Tick += new System.EventHandler(this.timerRuchKomputera_Tick);
            // 
            // Rozgrywka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.planszaGracza);
            this.Controls.Add(this.planszaKomputera);
            this.Name = "Rozgrywka";
            this.Text = "Rozgrywka";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rozgrywka_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.planszaKomputera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox planszaKomputera;
        private System.Windows.Forms.PictureBox planszaGracza;
        private System.Windows.Forms.Timer timerRuchKomputera;
    }
}