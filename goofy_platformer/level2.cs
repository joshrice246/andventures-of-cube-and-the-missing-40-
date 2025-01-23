using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
namespace goofy_platformer
{
    public partial class level2 : Form
    {
        int money = 0;

        int hp = 3;
        int player1Speed = 9;
        int jumpspeed;
        int grav;

        bool jump = false;
        bool aPressed = false;
        bool sPressed = false;
        bool dPressed = false;
        bool enterpressed = false;
        bool escpressed = false;
        bool gameOver = false;
        bool amoney = false;

        public level2()
        {
            InitializeComponent();
        }

        private void level2_Load(object sender, EventArgs e)
        {
            qtext.Text = $"Quest's: obtain money";
            hp = 3;
        }

        private void level2_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.Enter:
                    enterpressed = false;
                    break;
                case Keys.Escape:
                    escpressed = false;
                    break;
            }
        }

        private void level2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
            }

            if (e.KeyCode == Keys.W && jump == false)
            {
                jump = true;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._727650__cjspellsfish__basic_retro_jump);
                player.Play();
            }
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                reset();
            }
            if (e.KeyCode == Keys.Escape && gameOver == true)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.P)
            {
                level3 levelThree = new level3();
                this.Hide();
                gameTimer.Stop();
                levelThree.Show();
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            points.Text = $"CASH:{money}$";
            player1.Top += jumpspeed;
            hpl.Text = $"HP:{hp}";
            qtext.Text = $"Quest's: obtain 40$";

            if (money == 15)
            {
                amoney = true;
            }

            if (aPressed == true)
            {
                player1.Left -= player1Speed;
            }
            if (dPressed == true)
            {
                player1.Left += player1Speed;
            }

            if (jump == true && grav < 0)
            {
                jump = false;
            }

            if (jump == true)
            {
                jumpspeed = -8;
                grav -= 1;
            }
            else
            {
                jumpspeed = 10;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "plat")
                    {
                        if (player1.Bounds.IntersectsWith(x.Bounds))
                        {
                            grav = 8;
                            player1.Top = x.Top - player1.Height;
                        }
                        x.BringToFront();
                    }
                    if ((string)x.Tag == "platv")
                    {
                        if (player1.Bounds.IntersectsWith(x.Bounds))
                        {
                            grav = 8;
                            player1.Top = x.Top - player1.Height;
                        }
                        x.BringToFront();
                    }
                    if ((string)x.Tag == "killbox")
                    {
                        if (player1.Bounds.IntersectsWith(x.Bounds))
                        {
                            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._381690__stumpbutt__retro_death_sfx2);
                            player.Play();
                            player1.Left = 26;
                            player1.Top = 713;
                            hp -= 1;
                        }
                    }
                }
            }
            //money foreach checks if you have touched money or not if yes it will be made invisable and moved to the top of screen
            //more on level 3
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "money")
                    {
                        if (player1.Bounds.IntersectsWith(x.Bounds))
                        {
                            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._350869__cabled_mess__coin_c_06);
                            player.Play();
                            money += 1;
                            x.Top = 426;
                            x.Left = 3;
                            x.Visible = false;
                        }
                    }
                }
            }

            if (hp < 1)
            {
                death();
            }
          
            //if money is greater then or equal to 15 allow exit 
            if (money >= 15)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._659369__matrixxx__retro_portal_opens_up_or_closes);
                player.Play();
                level3 levelThree = new level3();
                this.Hide();
                gameTimer.Stop();
                levelThree.Show();
            }

            Refresh();
        }


        void death()
        {
            //movement lock till bind pressed
            jump = false;
            aPressed = false;
            sPressed = false;
            dPressed = false;

            points.Text = $"money: {money}$";
            qtext.Text = $"";
            gover.Text = $"GAME OVER\npress ENTER to restart\npress ESC to exit";

            //music on death
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._518307__mrthenoronha__death_song_8_bit);
            player.Play();
            Thread.Sleep(100);
            gameOver = true;
        }

        private void reset()
        {
            jump = false;
            aPressed = false;
            sPressed = false;
            dPressed = false;
            gameOver = false;

            points.Text = $"money: {money}$";
            qtext.Text = $"";
            gover.Text = $"";
            hp = 3;

            player1.Left = 26;
            player1.Top = 713;

            gameTimer.Start();
        }
    }
}
