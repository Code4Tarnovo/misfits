namespace Heroe
{
    partial class PauseGame
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
            this.lbPausedGame = new MaterialSkin.Controls.MaterialLabel();
            this.btnContinue = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnOptions = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnShop = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnQuitGame = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lbPausedGame
            // 
            this.lbPausedGame.AutoSize = true;
            this.lbPausedGame.Depth = 0;
            this.lbPausedGame.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPausedGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPausedGame.Location = new System.Drawing.Point(74, 17);
            this.lbPausedGame.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPausedGame.Name = "lbPausedGame";
            this.lbPausedGame.Size = new System.Drawing.Size(129, 19);
            this.lbPausedGame.TabIndex = 0;
            this.lbPausedGame.Text = "Game is PAUSED ";
            // 
            // btnContinue
            // 
            this.btnContinue.AutoSize = true;
            this.btnContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContinue.Depth = 0;
            this.btnContinue.Location = new System.Drawing.Point(97, 66);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnContinue.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Primary = false;
            this.btnContinue.Size = new System.Drawing.Size(79, 36);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.AutoSize = true;
            this.btnOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOptions.Depth = 0;
            this.btnOptions.Location = new System.Drawing.Point(97, 114);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOptions.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Primary = false;
            this.btnOptions.Size = new System.Drawing.Size(70, 36);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnShop
            // 
            this.btnShop.AutoSize = true;
            this.btnShop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShop.Depth = 0;
            this.btnShop.Location = new System.Drawing.Point(108, 162);
            this.btnShop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShop.Name = "btnShop";
            this.btnShop.Primary = false;
            this.btnShop.Size = new System.Drawing.Size(48, 36);
            this.btnShop.TabIndex = 3;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.AutoSize = true;
            this.btnQuitGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitGame.Depth = 0;
            this.btnQuitGame.Location = new System.Drawing.Point(92, 199);
            this.btnQuitGame.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitGame.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Primary = false;
            this.btnQuitGame.Size = new System.Drawing.Size(84, 36);
            this.btnQuitGame.TabIndex = 4;
            this.btnQuitGame.Text = "Quit game";
            this.btnQuitGame.UseVisualStyleBackColor = true;
            // 
            // PauseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnQuitGame);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lbPausedGame);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PauseGame";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.PauseGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbPausedGame;
        private MaterialSkin.Controls.MaterialFlatButton btnContinue;
        private MaterialSkin.Controls.MaterialFlatButton btnOptions;
        private MaterialSkin.Controls.MaterialFlatButton btnShop;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitGame;
    }
}