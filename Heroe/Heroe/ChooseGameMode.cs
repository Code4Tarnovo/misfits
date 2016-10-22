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
    public partial class ChooseGameMode : MetroFramework.Forms.MetroForm
    {
        private int ChosenGameMode;

        public ChooseGameMode()
        {
            InitializeComponent();
        }

        public int SendGameMode
        {
            get
            {
                return ChosenGameMode;
            }
        }

        private void pbSurvival_Click(object sender, EventArgs e)
        {
            //ChosenGameMode = 2;
            this.Close();
        }

        private void pbArcade_Click(object sender, EventArgs e)
        {
            //ChosenGameMode = 1;
            this.Close();
        }

        private void pbPractice_Click(object sender, EventArgs e)
        {
           // ChosenGameMode = 3;
            this.Close();
        }
    }
}
