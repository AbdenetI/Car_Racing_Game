namespace Car_racing_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Over.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();
        }
        int collectedcoin = 0;

        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 200);
                //y = r.Next(0, 400);
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);
                //y = r.Next(0, 400);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 350);
                //y = r.Next(0, 400);
                enemy3.Location = new Point(x, 0);

            }
            else
            {
                enemy3.Top += speed;
            }

        }

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);
                //y = r.Next(0, 400);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }
            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);
                //y = r.Next(0, 400);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top >= 500)
            {
                x = r.Next(50, 300);
                //y = r.Next(0, 400);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
            if (coin4.Top >= 500)
            {
                x = r.Next(0, 400);
                //y = r.Next(0, 400);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }


        }
        void coinscollection()
        {
            if (Car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins" + collectedcoin.ToString();
                x = r.Next(50, 300);
                //y = r.Next(0, 400);
                coin1.Location = new Point(x, 0);

            }
            if (Car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins" + collectedcoin.ToString();
                x = r.Next(50, 300);
                //y = r.Next(0, 400);
                coin2.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins" + collectedcoin.ToString();
                x = r.Next(50, 300);
                //y = r.Next(0, 400);
                coin3.Location = new Point(x, 0);
            }
            if (Car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins" + collectedcoin.ToString();
                x = r.Next(50, 300);
                //y = r.Next(0, 400);
                coin4.Location = new Point(x, 0);
            }

        }
        void gameover()
        {
            if (Car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
            if (Car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
            if (Car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
        }

        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            //pictureBox1.Top += speed;
            //pictureBox2.Top += speed;
            //pictureBox3.Top += speed;
            //pictureBox4.Top += speed;



        }

        private void Car_Click(object sender, EventArgs e)
        {

        }
        int gamespeed = 0;


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (Car.Left > 0)
                    Car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (Car.Right < 380)
                    Car.Left += 8;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
