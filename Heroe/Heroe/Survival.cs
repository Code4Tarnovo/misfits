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
        private PictureBox pictureBox;

        public Survival()
        {
            this.Load += Survival_Load;
            InitializeComponent();

        }

        private void ChangeHeroLocation()
        {
            //Bitmap mapBitmap = Properties.Resources.MapDefault;
            //Graphics mapGraphics = Graphics.FromImage(mapBitmap);
            pbHero.Location = heroLocation;
            int location = ((heroLocation.X / 50) - 1) * 10 + (heroLocation.Y / 50) - 1;
            if (mapObjects[location] == true)
            {
                using (GameOver gameOverForm = new GameOver())
                {
                    if (gameOverForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        gameOverForm.ShowDialog();
                    }
                }
            }
        }


        private void Survival_Load(object sender, EventArgs e)
        {
            Bitmap mapBitmap = Properties.Resources.MapDefault;
            pbSurvival.Image = mapBitmap;

            pbHero.Image = heroImage;
            mapObjects = new bool[100];

            ChangeHeroLocation();
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
            HeroTurn();
        }


        private void Survival_KeyDown(object sender, KeyPressEventArgs e)
        {

        }

        private void RandomPictureBoxTrap()
        {
            Random randomNumber = new Random();
            int position = randomNumber.Next(0, freeMapPlaces_Count);
            mapObjects[position] = true;

            pictureBox = new PictureBox();
            pictureBox.Location = new Point(((position / 10) + 1) * 50, ((position % 10) + 1) * 50);
            pictureBox.Name = "pbTrapImage" + (100 - freeMapPlaces_Count);
            pictureBox.Size = new Size(50, 50);
            pictureBox.Image = Properties.Resources.BlockBrake1;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Visible = true;
            this.Controls.Add(pictureBox);

            mapObjects[position] = true;

            pictureBox.BringToFront();
            pbHero.BringToFront();
            freeMapPlaces_Count--;
        }

        private void SecondTypeTrap()
        {
            pictureBox.Image = Properties.Resources.BlockBrake2;
        }

        private void ThirdTypeTrap()
        {
            pictureBox.Image = Properties.Resources.BlockBrake3;
        }

        private void HeroTurn()
        {
            heroTurns++;
            if (heroTurns == 8)
            {
                RandomPictureBoxTrap();
            }
            if (heroTurns == 9)
            {
                SecondTypeTrap();
            }
            if (heroTurns == 10)
            {
                ThirdTypeTrap();
                heroTurns = 0;
            }
        }
    }
}
