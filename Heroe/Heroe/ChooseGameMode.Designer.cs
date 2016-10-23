namespace Heroe
{
    partial class ChooseGameMode
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbPractice = new System.Windows.Forms.PictureBox();
            this.pbSurvival = new System.Windows.Forms.PictureBox();
            this.pbArcade = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPractice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurvival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArcade)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(85, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(185, 73);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pbPractice
            // 
            this.pbPractice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pbPractice.Location = new System.Drawing.Point(90, 212);
            this.pbPractice.Name = "pbPractice";
            this.pbPractice.Size = new System.Drawing.Size(175, 41);
            this.pbPractice.TabIndex = 2;
            this.pbPractice.TabStop = false;
            this.pbPractice.Click += new System.EventHandler(this.pbPractice_Click);
            // 
            // pbSurvival
            // 
            this.pbSurvival.BackColor = System.Drawing.Color.White;
            this.pbSurvival.Image = global::Heroe.Properties.Resources.Survive;
            this.pbSurvival.Location = new System.Drawing.Point(90, 153);
            this.pbSurvival.Name = "pbSurvival";
            this.pbSurvival.Size = new System.Drawing.Size(180, 53);
            this.pbSurvival.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSurvival.TabIndex = 1;
            this.pbSurvival.TabStop = false;
            this.pbSurvival.Click += new System.EventHandler(this.pbSurvival_Click);
            // 
            // pbArcade
            // 
            this.pbArcade.BackColor = System.Drawing.Color.White;
            this.pbArcade.Image = global::Heroe.Properties.Resources.Arcade;
            this.pbArcade.Location = new System.Drawing.Point(90, 96);
            this.pbArcade.Name = "pbArcade";
            this.pbArcade.Size = new System.Drawing.Size(180, 51);
            this.pbArcade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArcade.TabIndex = 0;
            this.pbArcade.TabStop = false;
            this.pbArcade.Click += new System.EventHandler(this.pbArcade_Click);
            // 
            // ChooseGameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 301);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pbPractice);
            this.Controls.Add(this.pbSurvival);
            this.Controls.Add(this.pbArcade);
            this.Name = "ChooseGameMode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPractice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurvival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArcade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArcade;
        private System.Windows.Forms.PictureBox pbSurvival;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pbPractice;
    }
}