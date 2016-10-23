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
    public partial class GameOver : MetroFramework.Forms.MetroForm
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            pbGameOver.Image = Properties.Resources.GameMode;
        }
    }
}
