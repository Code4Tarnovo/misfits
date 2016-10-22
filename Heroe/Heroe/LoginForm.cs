using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heroe
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {

        private int ClickedGameMode;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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
                    ClickedGameMode = chooseGameModeForm.SendGameMode;
                    chooseGameModeForm.Close();
                }
                ClickedGameMode = 2;
            }
            if (ClickedGameMode == 1)
            {

            }
            if (ClickedGameMode == 2)
            {
                using (Survival survivalForm = new Survival())
                {
                    if (survivalForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.Hide();
                        survivalForm.ShowDialog();

                    }
                }
            }
            if (ClickedGameMode == 3) 
            {
            
            }
        }
    }
}
