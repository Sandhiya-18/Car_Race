using System;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        
        private void  pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick_1(object sender, EventArgs e )
        {
            moveline(gamespeed  );
            enemy(gamespeed);
            coins(gamespeed);
            coinscolloection();
            gameover();
        }

        //Enemy car reappearing Logic//

        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if(Enemy1.Top>=500)
            { x = r.Next(0, 200);
                

                Enemy1.Location = new Point(x, 0);
            }
            else
            { Enemy1.Top += speed; }


            if (Enemy2.Top >= 500)
            {
                x = r.Next(0, 400);
                

                Enemy2.Location = new Point(x, 0);
            }
            else
            { Enemy2.Top += speed; }

            if (Enemy3.Top >= 500)
            {
                x = r.Next(200, 350);
               

                Enemy3.Location = new Point(x, 0);
            }
            else
            { Enemy3.Top += speed; }
        }

        // Gameover Logic//
        void gameover()
        {
            if(car.Bounds.IntersectsWith(Enemy1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(Enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(Enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

        void coins(int speed)
        {
            //coin1//
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);


                coin1.Location = new Point(x, 0);
            }
            else
            { coin1.Top += speed; }
            
            //coin2//
            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);


                coin2.Location = new Point(x, 0);
            }
            else
            { coin2.Top += speed; }

            //coin3//
            if (coin3.Top >= 500)
            {
                x = r.Next(50, 300);


                coin3.Location = new Point(x, 0);
            }
            else
            { coin3.Top += speed; }

            //coin4//
            if (coin4.Top >= 500)
            {
                x = r.Next(0, 400);


                coin4.Location = new Point(x, 0);
            }
            else
            { coin4.Top += speed; }
        }


            //Moving Logic//
            void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)

            { pictureBox1.Top = 0; }
            else
            { pictureBox1.Top += speed; }


            if (pictureBox2.Top >= 500)

            { pictureBox2.Top = 0; }
            else
            { pictureBox2.Top += speed; }


            if (pictureBox3.Top>=500)
            { pictureBox3.Top = 0; }
            else
            { pictureBox3.Top += speed; }

            if(pictureBox4.Top>=500)
            { pictureBox4.Top = 0; }
            else
            { pictureBox4.Top += speed; }

            
            
        }
        //coinscalculation//
        int collectedcoin = 0;
        void coinscolloection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(50, 300);
                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(50, 300);
                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(50, 300);
                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(50, 300);
                coin4.Location = new Point(x, 0);
            }

        }

        //Controls Logic//

        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                if(car.Left>0)
                car.Left += -8;
            }
            if(e.KeyCode == Keys.Right)
            {
                if(car.Right<400)
                car.Left += 8;
            }
            if (e.KeyCode == Keys.Up)
            {


                if (gamespeed < 21)
                { gamespeed++; }
            }

            if (e.KeyCode == Keys.Down)
            {


                if (gamespeed > 0)
                { gamespeed--; }


            }
        }
    }
}
