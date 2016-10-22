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
    public partial class Survival : MetroFramework.Forms.MetroForm
    {
        private Point heroLocation = new Point(250, 250);
        private int heroSize = 50;
        private Image heroImage = Image.FromFile(@"C:\Users\Andi\Desktop\misfits\Heroe\Heroe\Resources\hero.png");
        private Image map = Image.FromFile(@"C:\Users\Andi\Desktop\misfits\Heroe\Heroe\Resources\MapDefault.png");

        public Survival()
        {
            this.Load += Survival_Load;
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (heroLocation.X < pbSurvival.Size.Height - heroSize)
                {
                    heroLocation.X += heroSize;
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                if (heroLocation.X > heroSize)
                {
                    heroLocation.X -= heroSize;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (heroLocation.Y < pbSurvival.Size.Width - heroSize)
                {
                    heroLocation.Y += heroSize;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (heroLocation.Y > heroSize)
                {
                    heroLocation.Y -= heroSize;
                }
            }
            ChangeHeroLocation();
        }

        private void ChangeHeroLocation()
        {
            Bitmap mapBitmap = Properties.Resources.MapDefault;
            Graphics mapGraphics = Graphics.FromImage(mapBitmap);
            pbHero.Location = heroLocation;
        }


        private void Survival_Load(object sender, EventArgs e)
        {
            Bitmap mapBitmap = Properties.Resources.MapDefault;
            pbSurvival.Image = mapBitmap;

            pbHero.Image = heroImage;
            ChangeHeroLocation();
        }
    }
}
