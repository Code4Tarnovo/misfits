namespace Heroe
{
    partial class Register
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
            this.lbUsername = new MaterialSkin.Controls.MaterialLabel();
            this.lbFirstName = new MaterialSkin.Controls.MaterialLabel();
            this.lbPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lbLastName = new MaterialSkin.Controls.MaterialLabel();
            this.lbConfirmPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnRegister = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Depth = 0;
            this.lbUsername.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUsername.Location = new System.Drawing.Point(-1, 33);
            this.lbUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(77, 19);
            this.lbUsername.TabIndex = 5;
            this.lbUsername.Text = "Username";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Depth = 0;
            this.lbFirstName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFirstName.Location = new System.Drawing.Point(9, 81);
            this.lbFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(80, 19);
            this.lbFirstName.TabIndex = 6;
            this.lbFirstName.Text = "First name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Depth = 0;
            this.lbPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPassword.Location = new System.Drawing.Point(-1, 193);
            this.lbPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(75, 19);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Password";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Depth = 0;
            this.lbLastName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbLastName.Location = new System.Drawing.Point(-1, 137);
            this.lbLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(85, 19);
            this.lbLastName.TabIndex = 7;
            this.lbLastName.Text = "*Last name";
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Depth = 0;
            this.lbConfirmPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbConfirmPassword.Location = new System.Drawing.Point(9, 241);
            this.lbConfirmPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(132, 19);
            this.lbConfirmPassword.TabIndex = 8;
            this.lbConfirmPassword.Text = "Confirm password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(188, 34);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(188, 80);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(188, 136);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(121, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(188, 192);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(188, 240);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(121, 20);
            this.txtConfirmPass.TabIndex = 13;
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.Depth = 0;
            this.btnRegister.Location = new System.Drawing.Point(24, 294);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Primary = false;
            this.btnRegister.Size = new System.Drawing.Size(107, 36);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Registration";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(188, 294);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(64, 36);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 347);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbConfirmPassword);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbUsername);
            this.Name = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbUsername;
        private MaterialSkin.Controls.MaterialLabel lbFirstName;
        private MaterialSkin.Controls.MaterialLabel lbPassword;
        private MaterialSkin.Controls.MaterialLabel lbLastName;
        private MaterialSkin.Controls.MaterialLabel lbConfirmPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private MaterialSkin.Controls.MaterialFlatButton btnRegister;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
    }
}