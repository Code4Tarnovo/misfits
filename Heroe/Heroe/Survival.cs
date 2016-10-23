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
        private Image heroImage = Image.FromFile(@"C:\Users\Andi\Desktop\Heroe\Heroe\Resources\heroe.png");
        private Image map = Image.FromFile(@"C:\Users\Andi\Desktop\Heroe\Heroe\Resources\MapDefault.png");
        private bool[] mapObjects;
        private int freeMapPlaces_Count = 99;
        private int[] freeMapPlaces;
        private int heroTurns = 0;

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
            //Bitmap mapBitmap = Properties.Resources.MapDefault;
            //Graphics mapGraphics = Graphics.FromImage(mapBitmap);
            pbHero.Location = heroLocation;
        }


        private void Survival_Load(object sender, EventArgs e)
        {
            Bitmap mapBitmap = Properties.Resources.MapDefault;
            pbSurvival.Image = mapBitmap;

            pbHero.Image = heroImage;
            ChangeHeroLocation();

            mapObjects = new bool[100];

            randomPictureBoxTrap();
        }

        private void Survival_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode==Keys.P)
            {
                using (PauseGame pauseGame = new PauseGame())
                {
                    
                       
                        pauseGame.ShowDialog();
                    
                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (heroLocation.X < pbSurvival.Size.Height - heroSize * 2)
                {
                    heroLocation.X += heroSize;
                }
            }
            if (e.KeyCode == Keys.A)
            {
                if (heroLocation.X > heroSize)
                {
                    heroLocation.X -= heroSize;
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (heroLocation.Y < pbSurvival.Size.Width - heroSize * 2)
                {
                    heroLocation.Y += heroSize;
                }
            }
            if (e.KeyCode == Keys.W)
            {
                if (heroLocation.Y > heroSize)
                {
                    heroLocation.Y -= heroSize;
                }
            }
            ChangeHeroLocation();
        }


        private void Survival_KeyDown(object sender, KeyPressEventArgs e)
        {

        }

        private void randomPictureBoxTrap()
        {
            Random randomNumber = new Random();
            int position = randomNumber.Next(0, freeMapPlaces_Count);
            mapObjects[position] = true;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(((position / 10) + 1) * 50, ((position % 10) + 1) * 50);
            pictureBox.Name = "pbTrapImage" + (100 - freeMapPlaces_Count);
            pictureBox.Size = new Size(50, 50);
            pictureBox.Image = Properties.Resources.BlockBrake3;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Visible = true;
            this.Controls.Add(pictureBox);

            freeMapPlaces_Count--;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            heroTurns++;
            if (heroTurns == 5)
            {
                randomPictureBoxTrap();
                heroTurns = 0;
            }
        }
    }
}
