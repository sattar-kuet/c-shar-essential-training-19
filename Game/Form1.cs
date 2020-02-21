using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int car_speed = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            move_line(car_speed);
            enemy(car_speed);


        }

        private void enemy(int speed)
        {
            Random r = new Random();
            int x, y;
            y = 0;
            if (enemy1.Top > 500)
            {
                x = r.Next(0,180);
                enemy1.Location = new Point(x,y);

            }
            else
            {
                enemy1.Top += speed;
            }
            if (enemy2.Top > 500)
            {
                x = r.Next(200, 380);
                enemy2.Location = new Point(x, y);
  
            }
            else
            {
                enemy2.Top += speed;
            }
            if (enemy3.Top > 500)
            {
                x = r.Next(400, 550);
                enemy3.Location = new Point(x, y);
            }
            else
            {
                enemy3.Top += speed;
            }

        }
        public void move_line(int speed)
        {
            if (divider1.Top > 550)
            {
                divider1.Top = 0;
            }
            else
            {
                divider1.Top += speed;
            }

            if (divider2.Top > 550)
            {
                divider2.Top = 0;
            }
            else
            {
                divider2.Top += speed;
            }


            if (divider3.Top > 550)
            {
                divider3.Top = 0;
            }
            else
            {
                divider3.Top += speed;
            }

            if (divider4.Top > 550)
            {
                divider4.Top = 0;
            }
            else
            {
                divider4.Top += speed;
            }
        }

       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                if(car_speed<10)
                   car_speed += 1;
               
            }

            if(e.KeyCode == Keys.Space)
            {
                car_speed = 0;
            }
            if(e.KeyCode == Keys.Left)
            {
                if(car.Left>20)
                  car.Left -= 10;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 610)
                    car.Left += 10;
            }
        }
    }
}
