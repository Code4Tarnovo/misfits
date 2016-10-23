using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Heroe
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {

        public int ClickedGameMode;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void pbGuest_Click(object sender, EventArgs e)
        {
            using (ChooseGameMode ChooseGameModeForm = new ChooseGameMode())
            {
                if (ChooseGameModeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ChooseGameModeForm.Show();
                }
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            using (ChooseGameMode chooseGameModeForm = new ChooseGameMode())
            {
                if (chooseGameModeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Hide();
                    chooseGameModeForm.ShowDialog();
                    chooseGameModeForm.Close();
                }

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pbLogo.Image = Properties.Resources.Logo;
            pbUsername.Image = Properties.Resources.UserName;
            pbPassword.Image = Properties.Resources.Password;
            pbRegister.Image = Properties.Resources.Register;
            pbPlay.Image = Properties.Resources.Play;
        }

        private void pbPlay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Andi\Desktop\Heroe\Heroe\Database1.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From UserInfo where Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'", con);
            if (txtPassword.Text == null && txtUsername.Text == null)
            {
                MessageBox.Show("Pleas enter password or username!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    using (ChooseGameMode ChooseGameModeForm = new ChooseGameMode())
                    {
                        if (ChooseGameModeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            ChooseGameModeForm.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username or password!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pbRegister_Click(object sender, EventArgs e)
        {
            using (Register registerForm = new Register())
            {
                if (registerForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Hide();
                    registerForm.ShowDialog();

                }
            }
        }
    }
}
