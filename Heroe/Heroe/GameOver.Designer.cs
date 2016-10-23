namespace Heroe
{
    partial class GameOver
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
            this.btTryAgain = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.pbGameOver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // btTryAgain
            // 
            this.btTryAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btTryAgain.Location = new System.Drawing.Point(71, 250);
            this.btTryAgain.Name = "btTryAgain";
            this.btTryAgain.Size = new System.Drawing.Size(75, 48);
            this.btTryAgain.TabIndex = 1;
            this.btTryAgain.Text = "Try again";
            this.btTryAgain.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.Location = new System.Drawing.Point(216, 250);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 48);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pbGameOver
            // 
            this.pbGameOver.Location = new System.Drawing.Point(6, 2);
            this.pbGameOver.Name = "pbGameOver";
            this.pbGameOver.Size = new System.Drawing.Size(346, 240);
            this.pbGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGameOver.TabIndex = 0;
            this.pbGameOver.TabStop = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 321);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btTryAgain);
            this.Controls.Add(this.pbGameOver);
            this.Name = "GameOver";
            this.Load += new System.EventHandler(this.GameOver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGameOver;
        private System.Windows.Forms.Button btTryAgain;
        private System.Windows.Forms.Button btExit;
    }
}