using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapEditor;

namespace StudentSim
{
    public partial class GForm : Form
    {
        private City city; //Проба гита, проба
        public static Student student;
        public GForm()
        {
            InitializeComponent();
            student = new Student(4, 3, 12);
            city = City.Load(student.location);           
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Map_Paint(object sender, PaintEventArgs e)
        {
            Color[] colors = new Color[2] { Color.Orange, Color.Brown};
            city.Draw(e.Graphics, colors);
           // student.DrawGrid(e.Graphics, city);
            student.Draw(e.Graphics, city.width, Color.DarkViolet);          
        }

     

        private void Map_MouseDown(object sender, MouseEventArgs e)
        {
         /*   int x = e.X / (city.width + 1);
            int y = e.Y / (city.width + 1);*/
            if (student.startMove == false /*&& city.Map[y][x] == 0*/)
            {
                int x = e.X / (city.width + 1);
                int y = e.Y / (city.width + 1);

                if (student.findPath(city, new Point(x, y)))
                {
                    student.startMove = true;
                    //MessageBox.Show("Начало движения!");
                }             
                               
            }
           
        }

        private void actionsTime_Tick(object sender, EventArgs e)
        {
            if (student.startMove)
            {
              //  MessageBox.Show(student.pathLen.ToString());
                student.pathLen--;
              //  MessageBox.Show(student.pathLen.ToString());
                if (student.pathLen < 0)
                {
                    student.startMove = false;
                    if (student.start.X == city.Map[1].Length - 1)
                    {
                       // DialogResult dialogResult = MessageBox.Show("Вы хотите перейти в другую локацию?", "Сообщение", MessageBoxButtons.YesNo);
                      //  if (dialogResult == DialogResult.Yes)
                      //  {
                            student.start.X = 0;
                            student.location++;
                            city = City.Load(student.location);
                      //  }
                    }
                    else if (student.start.X == 0)
                    {
                      //  DialogResult dialogResult = MessageBox.Show("Вы хотите перейти в другую локацию?", "Сообщение", MessageBoxButtons.YesNo);
                    //    if (dialogResult == DialogResult.Yes)
                    //    {
                            student.start.X = city.Map[1].Length -1;
                            student.location--;
                            city = City.Load(student.location);
                      //  }
                    }
                    else if (student.start.Y == 0)
                    {
                       // DialogResult dialogResult = MessageBox.Show("Вы22 хотите перейти в другую локацию?", "Сообщение", MessageBoxButtons.YesNo);
                      //  if (dialogResult == DialogResult.Yes)
                      //  {                         
                            student.start.Y = city.Map.Length - 1;
                            student.location -= 3;
                            city = City.Load(student.location);
                      //  }

                    }
                    else if (student.start.Y == city.Map.Length - 1)
                    {
                        student.start.Y = 0;
                        student.location += 3;
                        city = City.Load(student.location);

                    }
                }
                  else
                  {
                    /*if (student.path[student.pathLen].X > student.start.X)
                    {
                        student.start.X++; 
                    }
                    else if (student.path[student.pathLen].X < student.start.X)
                    {
                        student.start.X--;
                    }
                    else if (student.path[student.pathLen].Y > student.start.Y)
                    {
                        student.start.Y++;
                    }
                    else
                    {
                        student.start.Y--;
                    }*/
                    student.start.X = student.path[student.pathLen].X;
                    student.start.Y = student.path[student.pathLen].Y;
                }
                Map.Invalidate();               
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test t = new test();
            t.Show();
        }

        private void personalPanel_Paint(object sender, PaintEventArgs e)
        {
            student.DrawPanel(e.Graphics);
        }
    }
}
