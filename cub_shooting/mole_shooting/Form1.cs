using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mole_shooting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int score = 0;
        int total_shots = 0;
        int miss_shot = 0;

        void fn_shot()
        {
            score++;
            label1.Text = "Score:" + score;
            total_shots++;
            label3.Text = "Total Shot:" + total_shots;
        }

        void fn_miss_shot()
        {
            miss_shot++;
            label2.Text = "Miss Shot:" + miss_shot;
            total_shots++;
            label3.Text = "Total Shot:" + total_shots;
        }

        void reset()
        {
            score = 0;
            total_shots = 0;
            miss_shot = 0;
            label1.Text = "Score:" + score;
            label2.Text = "Miss Shot:" + miss_shot;
            label3.Text = "Total Shot:" + total_shots;

            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fn_shot();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "CUB SHOOTING";
            this.label1.Text = "Score:0";
            this.label2.Text = "Miss Shot:0";
            this.label3.Text = "Total Shot:0";
            this.button1.Text = "Restart";
            this.button2.Text = "Exit";
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.button1.BackColor = Color.Transparent;
            this.button2.BackColor = Color.Transparent;

            this.timer1.Enabled = true;
            this.DoubleBuffered = true;
            this.Cursor = Cursors.NoMove2D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = r.Next(0, 500);
            y = r.Next(200, 300);
            pictureBox1.Location = new Point(x, y);

            if (miss_shot >= 10)
            {
                timer1.Stop();
                MessageBox.Show("Game Over");
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            fn_miss_shot();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
