namespace Heroe
{
    partial class Survival
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
            this.pbSurvival = new System.Windows.Forms.PictureBox();
            this.Turn = new System.Windows.Forms.Timer(this.components);
            this.pbHero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurvival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHero)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSurvival
            // 
            this.pbSurvival.Location = new System.Drawing.Point(0, 0);
            this.pbSurvival.Name = "pbSurvival";
            this.pbSurvival.Size = new System.Drawing.Size(600, 600);
            this.pbSurvival.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSurvival.TabIndex = 0;
            this.pbSurvival.TabStop = false;
            // 
            // Turn
            // 
            this.Turn.Interval = 500;
            this.Turn.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbHero
            // 
            this.pbHero.Location = new System.Drawing.Point(250, 250);
            this.pbHero.Name = "pbHero";
            this.pbHero.Size = new System.Drawing.Size(50, 50);
            this.pbHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHero.TabIndex = 1;
            this.pbHero.TabStop = false;
            // 
            // Survival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.pbHero);
            this.Controls.Add(this.pbSurvival);
            this.KeyPreview = true;
            this.Name = "Survival";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Survival_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Survival_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbSurvival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSurvival;
        private System.Windows.Forms.Timer Turn;
        private System.Windows.Forms.PictureBox pbHero;
    }
}