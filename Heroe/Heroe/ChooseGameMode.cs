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

        public ChooseGameMode()
        {
            InitializeComponent();
        }


        private void pbSurvival_Click(object sender, EventArgs e)
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

        private void pbArcade_Click(object sender, EventArgs e)
        {
            using (Arcade arcadeForm = new Arcade())
            {
                if (arcadeForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Hide();
                    arcadeForm.ShowDialog();

                }
            }
        }

        private void pbPractice_Click(object sender, EventArgs e)
        {

            using (Practice practiceForm = new Practice())
            {
                if (practiceForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Hide();
                    practiceForm.ShowDialog();

                }
            }
        }
    }
}
