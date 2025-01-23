using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace goofy_platformer
{
    //notes
    // chose to use picture boxes over graphics due to the tedious nature of graphics
    // though learning to use them was more work then required
    // i now have the knowledge to use them and make a mildly more complicated game
   
    //known issues
    //if you die sounds dont play anymore
    //some how possible to float cant recreate

    //etc
    //ran out of time did not add momentum

    public partial class Form1 : Form
    { //global variables
        int money = 0;

        int hp = 3;
        int player1Speed = 9;
        int jumpspeed;
        int grav;

        bool talked = false;
        bool jump = false;
        bool aPressed = false;
        bool sPressed = false;
        bool dPressed = false;
        bool enterpressed = false;
        bool escpressed = false;
        bool gameOver = false;
        bool key = false;
        bool talked2 = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load starter position and text 
            player1.Left = 26;
            player1.Top = 701;
            qtext.Text = $"Quest's: talk to cubius";
            hp = 3;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {//allow binds on down movement
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
            //jump false so you can jump once
            if (e.KeyCode == Keys.W && jump == false)
            {
                jump = true;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._727650__cjspellsfish__basic_retro_jump);
                player.Play();
            }
            //game over keys active on death
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                reset();
            }
            if (e.KeyCode == Keys.Escape && gameOver == true)
            {
                Application.Exit();
            }
            //level skip key for dev
            if (e.KeyCode == Keys.P)
            {
                level2 levelTwo = new level2();
                this.Hide();
                gameTimer.Stop();
                levelTwo.Show();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {//deactivate binds on up movement
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
            //allowing jump
            points.Text = $"CASH:{money}$";
            player1.Top += jumpspeed;
            hpl.Text = $"HP:{hp}";
            //if bind is pressed add speed in either negative or postive to determine which direction you move towards
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
                //if falling and jump is not active you can jump 
                jump = false;
            }
            if (jump == true)
            {
                jumpspeed = -8;
                //jumpspeed 0 you cant jump any more
                grav -= 1;
                //if jump is active grav is negative to make you fall at a reasonable speed
            }
            else
            {
                jumpspeed = 10;
            }

            //foreach 1 used for determening if player is touching platforms, killboxes, portals 
            //by going through everything contained in it one by one to check if any statements are currently active
            //if not it exits then goes to the next section
            //if you touched one it will run whats contained in the interacts with if statemeant same is true for
            //all foreach's usedc on this program
            foreach (Control x in this.Controls)
            { //declare x as control

                if (x is PictureBox)
                { //declare x as picture box
                    //anything under this with whatever tag is given will be given properties includimg sounds and player ineractions
                    //more on level2
                    if ((string)x.Tag == "plat")
                    { 
                        if (player1.Bounds.IntersectsWith(x.Bounds))
                        {
                            //if you interact with plat it gives you a mild float/pop when going through them
                            grav = 8;
                            player1.Top = x.Top - player1.Height;
                        }
                        //brings you to the front so you dont look like your clipping
                        x.BringToFront();
                    }
                    if ((string)x.Tag == "portal" && key == true)
                    {
                        if (player1.Bounds.IntersectsWith(x.Bounds))
                        {//next level and sound
                            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._659369__matrixxx__retro_portal_opens_up_or_closes);
                            player.Play();
                            player1.Left = 81;
                            player1.Top = 267;
                            level2 levelTwo = new level2();
                            this.Hide();
                            gameTimer.Stop();
                            levelTwo.Show();
                        }
                    }
                    if ((string)x.Tag == "killbox")
                    {
                        if (player1.Bounds.IntersectsWith(x.Bounds))
                        {
                            //death on interaction and sound
                            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._381690__stumpbutt__retro_death_sfx2);
                            player.Play();
                            player1.Left = 26;
                            player1.Top = 713;
                            hp -= 1;
                        }
                    }
                }
            }

            //foreach 2 used to determine if you are touching a chat box it will run through whats contained 
            //if nothing is interacted with it will go to the next section
            //if you interact with one of the interacts it will
            //run through everything one by one till it lands on the one you interacted with
            //then locks you in place and then runs the text then
            //it exits the foreach
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "chbox" && talked2 == true)
                {
                    if (player1.Bounds.IntersectsWith(x.Bounds))
                    {//wrote it as indvisual letters so it looked like retro games npc chats when it comes out 
                        //letter by letter
                        player1.Left = 503;
                        player1.Top = 343;
                        npctxt.Text = $"cubius:";
                        qtext.Text = $"Quest's:";
                        Refresh();
                        Thread.Sleep(200);
                        npctxt.Text += $" y";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"o";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"u";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $" o";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"w";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"e";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $" m";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"e";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $" 40$";
                        Refresh();
                        Thread.Sleep(800);
                        npctxt.Text = $"";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"cubius:";
                        Refresh();
                        Thread.Sleep(200);
                        npctxt.Text += $" y";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"o";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"u";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $" b";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"e";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"t";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"t";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"e";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"r";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $" g";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"e";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"t";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $" m";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"y";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $" m";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"o";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"n";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"e";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"y";
                        Refresh();
                        Thread.Sleep(800);
                        npctxt.Text = $"";
                        Refresh();
                        Thread.Sleep(300);
                        npctxt.Text += $"cubius:";
                        Refresh();
                        Thread.Sleep(200);
                        npctxt.Text += $" o";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"r";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $" e";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"l";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"s";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $"e";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $".";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $".";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $".";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $".";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $".";
                        Refresh();
                        Thread.Sleep(100);
                        npctxt.Text += $".";
                        Refresh();
                        Thread.Sleep(800);
                        npctxt.Text = $"";
                        Refresh();
                        qtext.Text = $"Quest's: go thorugh the portal";
                        //allow use of other chat box
                        talked = true;
                        talked2 = false;
                    }
                }
                if ((string)x.Tag == "chbox2")
                {
                    if (talked == true)
                    {//true due to above
                        if (player1.Bounds.IntersectsWith(x.Bounds))
                        {
                            player1.Left = 426;
                            player1.Top = 343;
                            npctxt.Text = $"cubius:";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $" g";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"o";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $" t";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"h";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"r";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"o";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"u";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"g";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"h";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $" t";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"h";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"e";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $" p";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"o";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"r";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"t";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"a";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"l";
                            Refresh();
                            Thread.Sleep(800);
                            npctxt.Text = $"";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"cubius:";
                            Refresh();
                            Thread.Sleep(300);
                            npctxt.Text += $" w";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"h";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"a";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"t";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $" y";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"o";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"u";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $" o";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"w";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"e";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $" l";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"i";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"e";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"s";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $" a";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"h";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"e";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"a";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $"d";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $".";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $".";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $".";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $".";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $".";
                            Refresh();
                            Thread.Sleep(100);
                            npctxt.Text += $".";
                            Refresh();
                            talked = false;
                            //allow use of portal
                            key = true;
                        }
                    }
                }
            }
            //death if hp is less than 1
            if (hp < 1)
            {
                death();
            }
          //refresh loop
            Refresh();
        }

        void death()
        {
            //movement lock till binds pressed
            jump = false;
            aPressed = false;
            sPressed = false;
            dPressed = false;

            money = 0;

            points.Text = $"money: {money}$";
            qtext.Text = $"";
            npctxt.Text = $"";
            gover.Text = $"GAME OVER\npress ENTER to restart\npress ESC to exit";

            //music on death
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._518307__mrthenoronha__death_song_8_bit);
            player.Play();
            Thread.Sleep(100);
            gameOver = true;
        }

        private void reset()
        {
         //custom reset function
            jump = false;
            aPressed = false;
            sPressed = false;
            dPressed = false;
            gameOver = false;

            money = 0;
            hp = 3;

            points.Text = $"money: {money}$";
            gover.Text = $"";

            //reset postition
            player1.Left = 26;
            player1.Top = 713;
            cubius.Left = 601;
            cubius.Top = 343;

            gameTimer.Start();
        }
    }
}




