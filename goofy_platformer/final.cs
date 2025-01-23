using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace goofy_platformer
{

    public partial class final : Form
    {
        int money = 40;
        int hp = 3;
        int player1Speed = 9;
        int jumpspeed;
        int grav;
        int randgen;

        bool jump = false;
        bool aPressed = false;
        bool sPressed = false;
        bool dPressed = false;
        bool enterpressed = false;
        bool escpressed = false;
        bool gameOver = false;
        bool winner = false;
        bool loser = false;
        bool key = false;

        Random rand = new Random();

        public final()
        {
            InitializeComponent();
        }

        private void final_Load(object sender, EventArgs e)
        {
            qtext.Text = $"Quest's: talk to cubius";
            hp = 3;
        }

        private void final_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void final_KeyUp(object sender, KeyEventArgs e)
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

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            points.Text = $"CASH:{money}$";
            player1.Top += jumpspeed;
            hpl.Text = $"HP:{hp}";

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
                    if ((string)x.Tag == "portal" && key == true)
                    {
                        if (player1.Bounds.IntersectsWith(x.Bounds))
                        {
                            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._659369__matrixxx__retro_portal_opens_up_or_closes);
                            player.Play();
                            Application.Exit();
                            player1.Left = 81;
                            player1.Top = 267;
                          
                        }
                    }
                    if ((string)x.Tag == "chbox")
                    {//if you interact with chatbox it will lock you in place  make a random value 
                        //then use that value to determine if cubius is mean to you or not
                        //aka win/lose
                        if (player1.Bounds.IntersectsWith(x.Bounds))
                        {
                            player1.Left = 503;
                            player1.Top = 343;
                         
                            Refresh();


                            int randomval = rand.Next(1, 101);
                            //70% chance you win 30% you lose
                            if (randomval < 70)
                            {
                                winner = true;
                            }
                            else if(randomval < 30)
                            {
                                loser = true;
                            }  

                            if (winner == true)
                            {
                                player1.Left = 503;
                                player1.Top = 343;
                                Thread.Sleep(1000);
                                money = 0;
                                npctxt.Text = $"cubius:";
                                qtext.Text = $"Quest's:";
                                Thread.Sleep(200);
                                npctxt.Text += $" g";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"o";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"o";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"d";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $" j";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"o";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"b";
                                Refresh();
                                Thread.Sleep(2000);
                                npctxt.Text = $"cubius:......";
                                qtext.Text = $"Quest's:";
                                Refresh();
                                Thread.Sleep(2000);
                                npctxt.Text += $" y";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"o";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"u";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"r";
                                Refresh();
                                Thread.Sleep(1000);
                                npctxt.Text += $" f";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"r";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"e";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"e";
                                Refresh();
                                npctxt.Text += $" t";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"o";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $" g";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"o";
                                Refresh();
                                Thread.Sleep(200);
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._677080__silverillusionist__healing_soft_ripple);
                                player.Play();
                                Thread.Sleep(2000);
                                npctxt.Text = $"GOOD ENDING\nYOU MAY EXIT VIA PORTAL";
                                Refresh();
                                key = true;
                            }

                            if (loser == true)
                            {
                                player1.Left = 503;
                                player1.Top = 343;
                                money = 0;
                                npctxt.Text = $"cubius:";
                                qtext.Text = $"Quest's:";
                                Thread.Sleep(200);
                                npctxt.Text += $" g";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"o";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"o";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"d";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $" j";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"o";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"b";
                                Refresh();
                                Thread.Sleep(2000);
                                npctxt.Text = $"cubius:......";
                                qtext.Text = $"Quest's:";
                                Refresh();
                                Thread.Sleep(2000);
                                npctxt.Text += $" n";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"o";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"w";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $" G";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"E";
                                Refresh();
                                Thread.Sleep(100);
                                npctxt.Text += $"T";
                                Refresh();
                                Thread.Sleep(200);
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._350984__cabled_mess__lose_c_03);
                                player.Play();
                                Thread.Sleep(2000);
                                npctxt.Text = $"BAD ENDING\nYOU MAY EXIT VIA PORTAL";
                                Refresh();
                                key = true;
                            }
                        }
                    }
                }
            }

            if (hp < 1)
            {
                jump = false;
                aPressed = false;
                sPressed = false;
                dPressed = false;
                gameOver = true;
            }

            if (gameOver == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._518307__mrthenoronha__death_song_8_bit);
                player.Play();
            }

                Refresh();  
        }

        void reset()
        {
            jump = false;
            aPressed = false;
            sPressed = false;
            dPressed = false;
            gameOver = false;

            money = 0;
            hp = 3;

            points.Text = $"money: {money}$";
            qtext.Text = $"";
            npctxt.Text = $"";
            gover.Text = $"";

            player1.Left = 26;
            player1.Top = 713;
            cubius.Left = 601;
            cubius.Top = 343;

            gameTimer.Start();

        }
    }
}
