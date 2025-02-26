namespace Car_racing_game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Car = new PictureBox();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            enemy3 = new PictureBox();
            Over = new Label();
            coin3 = new PictureBox();
            coin4 = new PictureBox();
            coin1 = new PictureBox();
            coin2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Car).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = SystemColors.ButtonHighlight;
            pictureBox8.Location = new Point(377, -4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(12, 471);
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = SystemColors.ButtonHighlight;
            pictureBox9.Location = new Point(-1, -4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(11, 471);
            pictureBox9.TabIndex = 8;
            pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(184, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 99);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(184, 117);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 102);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Location = new Point(184, 242);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 105);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Location = new Point(184, 367);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 100);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Car
            // 
            Car.Image = Properties.Resources.whiteVehicle;
            Car.Location = new Point(41, 386);
            Car.Name = "Car";
            Car.Size = new Size(32, 51);
            Car.SizeMode = PictureBoxSizeMode.StretchImage;
            Car.TabIndex = 10;
            Car.TabStop = false;
            Car.Click += Car_Click;
            // 
            // enemy1
            // 
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(27, 136);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(35, 43);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 10;
            enemy1.TabStop = false;
            enemy1.Click += Car_Click;
            // 
            // enemy2
            // 
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(200, 35);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(32, 42);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 10;
            enemy2.TabStop = false;
            enemy2.Click += Car_Click;
            // 
            // enemy3
            // 
            enemy3.Image = (Image)resources.GetObject("enemy3.Image");
            enemy3.Location = new Point(310, 196);
            enemy3.Name = "enemy3";
            enemy3.Size = new Size(31, 43);
            enemy3.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy3.TabIndex = 10;
            enemy3.TabStop = false;
            enemy3.Click += Car_Click;
            // 
            // Over
            // 
            Over.AutoSize = true;
            Over.BackColor = Color.Yellow;
            Over.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Over.ForeColor = Color.Red;
            Over.Location = new Point(116, 147);
            Over.Name = "Over";
            Over.Size = new Size(161, 32);
            Over.TabIndex = 11;
            Over.Text = "Game Over";
            Over.Click += label1_Click;
            // 
            // coin3
            // 
            coin3.Image = (Image)resources.GetObject("coin3.Image");
            coin3.Location = new Point(74, 262);
            coin3.Name = "coin3";
            coin3.Size = new Size(25, 25);
            coin3.SizeMode = PictureBoxSizeMode.StretchImage;
            coin3.TabIndex = 10;
            coin3.TabStop = false;
            coin3.Click += Car_Click;
            // 
            // coin4
            // 
            coin4.Image = (Image)resources.GetObject("coin4.Image");
            coin4.Location = new Point(316, 308);
            coin4.Name = "coin4";
            coin4.Size = new Size(25, 25);
            coin4.SizeMode = PictureBoxSizeMode.StretchImage;
            coin4.TabIndex = 10;
            coin4.TabStop = false;
            coin4.Click += Car_Click;
            // 
            // coin1
            // 
            coin1.Image = (Image)resources.GetObject("coin1.Image");
            coin1.Location = new Point(80, 12);
            coin1.Name = "coin1";
            coin1.Size = new Size(25, 25);
            coin1.SizeMode = PictureBoxSizeMode.StretchImage;
            coin1.TabIndex = 10;
            coin1.TabStop = false;
            coin1.Click += Car_Click;
            // 
            // coin2
            // 
            coin2.Image = (Image)resources.GetObject("coin2.Image");
            coin2.Location = new Point(316, 70);
            coin2.Name = "coin2";
            coin2.Size = new Size(25, 25);
            coin2.SizeMode = PictureBoxSizeMode.StretchImage;
            coin2.TabIndex = 10;
            coin2.TabStop = false;
            coin2.Click += Car_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(-1, -4);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 12;
            label1.Text = "Coins =  0";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(384, 461);
            Controls.Add(label1);
            Controls.Add(Over);
            Controls.Add(enemy3);
            Controls.Add(enemy2);
            Controls.Add(coin2);
            Controls.Add(coin1);
            Controls.Add(coin4);
            Controls.Add(coin3);
            Controls.Add(enemy1);
            Controls.Add(Car);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Car).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin4).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Car;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private PictureBox enemy3;
        private Label Over;
        private PictureBox coin3;
        private PictureBox coin4;
        private PictureBox coin1;
        private PictureBox coin2;
        private Label label1;
    }
}
