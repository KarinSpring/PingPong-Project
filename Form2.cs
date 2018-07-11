using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnStart.Text = "Start";
                        
            }
            
        //Old Code
        /*private bool up = false;
        private bool left = false; */


        //variable decleration
        private int score = 0;
        private int XCord = 5, YCord = 5;



        //Main game 
        private void tmrGame_Tick_1(object sender, EventArgs e)
        {
            int x = ovsBall.Location.X;
            int y = ovsBall.Location.Y;
            

            #region OldCode
            //move ovsBall
            /*if (ovsBall.Location.Y + ovsBall.Size.Height < playGround.Size.Height && !up)
            { {
                    y += 20;
                    up = false;
                }
            }
            //border abouve 
            else if (ovsBall.Location.Y > 0 && up)
            {
                y -= 20;
                up = true;
            }
            else
            {
                up = !up;
            }

            //border right
            if (ovsBall.Location.X + ovsBall.Size.Width < playGround.Size.Width && !left)
            {
                x += 20;
                left = false;
            }
            //else if (ovsBall.Location.X > 0 && left) 
            //{
              //  x -= 20;
                //left = true;
            //}
            
            else
            {
                left = !left;
            }
            
            //pctRacket 
            if (ovsBall.Location.X + ovsBall.Size.Width >= pctRacket.Location.X)
            {
                if (ovsBall.Location.Y + (ovsBall.Size.Height / 2) > pctRacket.Location.Y + pctRacket.Size.Height)
                {
                    tmrGame.Stop();
                    Form newForm = new Form3();
                    newForm.Show(this);
                }


                else if (ovsBall.Location.Y + (ovsBall.Size.Height / 2) < pctRacket.Location.Y)
                {
                    tmrGame.Stop();
                    Form newForm = new Form3();
                    newForm.Show(this);
                }
                else
                {
                    x -= 20;
                    left = true;
                }
            }*/
            #endregion

            
            if(x + ovsBall.Size.Width > pctRacket.Location.X + pctRacket.Size.Width)
            {
                //Stop Game, Highscore (Form3) opens
                tmrGame.Stop();
                Form newForm= new Form3();
                newForm.Show(this);

                return;
            }


            if(y < 0 || y + ovsBall.Size.Height > playGround.Size.Height)
            {
                YCord *= -1;
            }

            //Define Racket
            if (x < 0 || ( x + ovsBall.Size.Width >= pctRacket.Location.X &&
                ovsBall.Location.Y + ovsBall.Size.Height/2 > pctRacket.Location.Y &&
                ovsBall.Location.Y + ovsBall.Size.Height/2 < pctRacket.Location.Y + pctRacket.Size.Height))
            {
                XCord *= -1;

                //Give points +10 every time the racket gets the ball
                if (x + ovsBall.Size.Width >= pctRacket.Location.X &&
                ovsBall.Location.Y + ovsBall.Size.Height / 2 > pctRacket.Location.Y &&
                ovsBall.Location.Y + ovsBall.Size.Height / 2 < pctRacket.Location.Y + pctRacket.Size.Height)
                {
                score += 10;
                this.lblPoints.Text = score.ToString();
                }
                
            }

                //new ovsBall position
                ovsBall.Location = new Point(x + XCord, y + YCord);
        }
               
        
        //Pause game
        private void btnStart_Click(object sender, EventArgs e)

        {
            if (btnStart.Text == "Start")
            {
                tmrGame.Start();
                btnStart.Text = "Pause";
            }

            else
            {
                tmrGame.Stop();
                btnStart.Text = "Start";
            }
        }


        //New game 
        private void btnNew_Click(object sender, EventArgs e)
        {

            ovsBall.Location = new Point(0, 0); //Ball restart in the left corner
            btnStart.Focus();
            lblPoints.Text = score.ToString(); //Reset points

        }

        //Ball, change direction with the arrow keys
        private void btnUp_MouseClick(object sender, MouseEventArgs e)
        {
            ovsBall.Location = new Point(ovsBall.Location.X, ovsBall.Location.Y - 10);
        }
      
        private void btnLeft_MouseClick(object sender, MouseEventArgs e)
        {
            ovsBall.Location = new Point(ovsBall.Location.X - 10, Location.Y);
        }

        private void btnDown_MouseClick(object sender, MouseEventArgs e)
        {
            ovsBall.Location = new Point(ovsBall.Location.X, ovsBall.Location.Y + 10);
        }

        private void btnRight_MouseClick(object sender, MouseEventArgs e)
        {
            ovsBall.Location = new Point(ovsBall.Location.X + 10, ovsBall.Location.Y);
        }


        //Racket; change direction with w & s
        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w' && pctRacket.Location.Y > 0)
            {
                pctRacket.Location = new Point(pctRacket.Location.X, pctRacket.Location.Y - 25);
            }
            else if (e.KeyChar == 's' && pctRacket.Location.Y + pctRacket.Size.Height + 1 < playGround.Size.Height)
            {
                pctRacket.Location = new Point(pctRacket.Location.X, pctRacket.Location.Y + 25);
            }
       }
    }
}
       
       