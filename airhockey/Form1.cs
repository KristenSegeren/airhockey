using System;
using System.Drawing;
using System.Media;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace airhockey
{
    public partial class Form1 : Form
    {
        int puckStart = 0;
        Rectangle player1 = new Rectangle(100, 185, 10, 60);
        Rectangle player2 = new Rectangle(580, 185, 10, 60);
        Rectangle ball = new Rectangle(350, 195, 10, 10);
        Rectangle outline = new Rectangle(0, 40, 700, 360);
        Rectangle p1Goal = new Rectangle(30, 167, 10, 90);
        Rectangle p2Goal = new Rectangle(660, 167, 10, 90);
        Rectangle half = new Rectangle(350, 40, 5, 320);
        Rectangle p1bottom = new Rectangle(100, 245, 10, 1);
        Rectangle p1top = new Rectangle(100, 185, 10, 1);
        Rectangle p1back = new Rectangle(100, 185, 1, 60);
        Rectangle p2bottom = new Rectangle(580, 245, 10, 1);
        Rectangle p2top = new Rectangle(580, 185, 10, 1);
        Rectangle p2back = new Rectangle(590, 185, 1, 60);
        Rectangle p1blue = new Rectangle(150, 40, 5, 320);
        Rectangle p2blue = new Rectangle(530, 40, 5, 320);
        private void position()
        {
            player1.X = 100;
            player1.Y = 185;
            player2.X = 580;
            player2.Y = 185;
            p1top.X = 100;
            p1top.Y = 185;
            p1back.X = 100;
            p1back.Y = 185;
            p1bottom.X = 100;
            p1bottom.Y = 245;
            p2top.X = 580;
            p2top.Y = 185;
            p2back.X = 590;
            p2back.Y = 185;
            p2bottom.X = 580;
            p2bottom.Y = 245;
        }
        int player1Score = 0;
        int player2Score = 0;

        int playerSpeed = 5;
        int ballXSpeed = -6;
        int ballYSpeed = 6;

        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool aDown = false;
        bool dDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;

        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        Pen blueColor = new Pen(Color.Blue);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SoundPlayer contact = new SoundPlayer(Properties.Resources.contact);
        SoundPlayer goal = new SoundPlayer(Properties.Resources.better);

       // SoundPlayer test = new SoundPlayer(Properties.Resources.)
        private object e;

        public Form1()
        {

            InitializeComponent();
            outline = new Rectangle(40, 40, this.Width - 80, this.Height - 80);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;

            }
        }
        public void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawRectangle(blueColor, outline);
            e.Graphics.FillRectangle(blackBrush, p1Goal);
            e.Graphics.FillRectangle(blackBrush, p2Goal);
            e.Graphics.FillRectangle(redBrush, half);
            e.Graphics.FillRectangle(redBrush, p1top);
            e.Graphics.FillRectangle(redBrush, p1bottom);
            e.Graphics.FillRectangle(redBrush, p1back);
            e.Graphics.FillRectangle(redBrush, p2back);
            e.Graphics.FillRectangle(redBrush, p2top);
            e.Graphics.FillRectangle(redBrush, p2bottom);
            e.Graphics.FillRectangle(blueBrush, p1blue);
            e.Graphics.FillRectangle(blueBrush, p2blue);
            e.Graphics.FillRectangle(redBrush, player1);
            e.Graphics.FillRectangle(redBrush, player2);
            e.Graphics.FillRectangle(blackBrush, ball);
        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move player 1 
            if (wDown == true && player1.Y > 40)
            {
                player1.Y -= playerSpeed;
                p1top.Y -= playerSpeed;
                p1bottom.Y -= playerSpeed;
                p1back.Y -= playerSpeed;
            }

            if (sDown == true && player1.Y < this.Height - 40 - player1.Height)
            {
                player1.Y += playerSpeed;
                p1top.Y += playerSpeed;
                p1bottom.Y += playerSpeed;
                p1back.Y += playerSpeed;
            }

            if (aDown == true && player1.X > 40)
            {
                player1.X -= playerSpeed;
                p1top.X -= playerSpeed;
                p1bottom.X -= playerSpeed;
                p1back.X -= playerSpeed;
            }

            if (dDown == true && player1.X < 340)
            {
                player1.X += playerSpeed;
                p1top.X += playerSpeed;
                p1bottom.X += playerSpeed;
                p1back.X += playerSpeed;
            }

            //move player 2
            if (upArrowDown == true && player2.Y > 40)
            {
                player2.Y -= playerSpeed;
                p2top.Y -= playerSpeed;
                p2bottom.Y -= playerSpeed;
                p2back.Y -= playerSpeed;
            }

            if (downArrowDown == true && player2.Y < this.Height - 40 - player2.Height)
            {
                player2.Y += playerSpeed;
                p2top.Y += playerSpeed;
                p2bottom.Y += playerSpeed;
                p2back.Y += playerSpeed;

            }

            if (leftArrowDown == true && player2.X > 350)
            {
                player2.X -= playerSpeed;
                p2top.X -= playerSpeed;
                p2bottom.X -= playerSpeed;
                p2back.X -= playerSpeed;
            }

            if (rightArrowDown == true && player2.X < 650)
            {
                player2.X += playerSpeed;
                p2top.X += playerSpeed;
                p2bottom.X += playerSpeed;
                p2back.X += playerSpeed;
            }

            //check if ball hits either player. If it does change the direction 
            //and place the ball in front of the player hit 
            if (player1.IntersectsWith(ball))
            {
                puckStart = 1;
                contact.Play();


                if (p1back.IntersectsWith(ball))
                {
                    ballXSpeed *= -1;
                }
                else if (p1top.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                }
                else if (p1bottom.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                }
                else
                {
                    ballXSpeed *= -1;
                    ball.X = player1.X + ball.Width;
                }
            }
            else if (player2.IntersectsWith(ball))
            {

                puckStart = 1;
                contact.Play();



                if (p2back.IntersectsWith(ball))
                {
                    ballXSpeed *= -1;
                }
                else if (p2top.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                }
                else if (p2bottom.IntersectsWith(ball))
                {
                    ballYSpeed *= -1;
                }
                else
                {
                    ballXSpeed *= -1;
                    ball.X = player2.X - ball.Width;
                }
            }

            if (ball.Y <= 40)
            {
                ballYSpeed *= -1;
                contact.Play();
            }
            else if (ball.Y >= 350)
            {
                ballYSpeed *= -1;
                contact.Play();
            }
            //player intersection


            if (ball.X < 40)
            {
                ballXSpeed *= -1;
                contact.Play();
            }

            if (ball.X > 650)
            {
                ballXSpeed *= -1;
                contact.Play();
            }

            //check if a player missed the ball and if true add 1 to score of other player  
            if (ball.X < 40 && ball.Y >= 167 && ball.Y <= 257)
            {
                player2Score++;
                p2Sxore.Text = $"{player2Score}";

                ball.X = 295;
                ball.Y = 195;
                goal.Play();

                position();

            }
            if (ball.X > 650 && ball.Y >= 167 && ball.Y <= 257)
            {
                player1Score++;
                p1Score.Text = $"{player1Score}";

                ball.X = 295;
                ball.Y = 195;
                goal.Play();

                position();
            }


            // check score and stop game if either player is at 3 
            if (player1Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 1 Wins!!";
            }
            else if (player2Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 2 Wins!!";
            }

            if (puckStart == 1)
            {
                ball.X += ballXSpeed;
                ball.Y += ballYSpeed;
            }

            Refresh();

        }
    }
}





