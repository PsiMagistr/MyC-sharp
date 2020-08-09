using MapEditor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentSim
{
    public class Student
    {
        //Проба
        //Proba2
        public Point start;
        public int location;
        public bool startMove = false;
        public int pathLen;
        private int size;
        public int Gold = 500;
        public List<Point> path = new List<Point>(); 
        public Student(int x, int y, int size)
        {
            start = new Point(x, y);
            location = 5;
            this.size = size;
        }

        public bool setWave(City city, Point finish)
        {
            //
            if (city.Map[finish.Y][finish.X] > 0)
            {
                return false; 
            }
            //
            city.Grid = new int[city.Map.Length, city.Map[0].Length];
            int counter = 0;
            List<Point> activ = new List<Point>();
            List<Point> temp = new List<Point>();
            activ.Add(start);
            while (activ.Count > 0)
            {
                counter++;                
                temp.Clear();
                for (int i = 0; i < activ.Count; i++)
                {
                    if (activ[i].X + 1 < city.Grid.GetLength(1) && city.Grid[activ[i].Y, activ[i].X + 1] == 0)
                    {
                        if (city.Map[activ[i].Y][activ[i].X + 1] == 0)
                        {
                            temp.Add(new Point(activ[i].X + 1, activ[i].Y));
                            city.Grid[activ[i].Y, activ[i].X + 1] = counter;
                        }

                        if (activ[i].X + 1 == finish.X && activ[i].Y == finish.Y)
                        {
                            city.Grid[start.Y, start.X] = 0;
                            return true;
                        }
                       
                    }                  

                    if (activ[i].X - 1 > -1 && city.Grid[activ[i].Y, activ[i].X - 1] == 0)
                    {
                        if (city.Map[activ[i].Y][activ[i].X - 1] == 0)
                        {
                            temp.Add(new Point(activ[i].X - 1, activ[i].Y));
                            city.Grid[activ[i].Y, activ[i].X - 1] = counter;
                        }

                        if (activ[i].X - 1 == finish.X && activ[i].Y == finish.Y)
                        {
                            city.Grid[start.Y, start.X] = 0;
                            return true;
                        }                    }
                   
                    if (activ[i].Y + 1 < city.Grid.GetLength(0) && city.Grid[activ[i].Y + 1, activ[i].X] == 0)
                    {
                        if (city.Map[activ[i].Y + 1][activ[i].X] == 0)
                        {
                            temp.Add(new Point(activ[i].X, activ[i].Y + 1));
                            city.Grid[activ[i].Y + 1, activ[i].X] = counter;
                        }

                        if (activ[i].X == finish.X && activ[i].Y + 1 == finish.Y)
                        {
                            city.Grid[start.Y, start.X] = 0;
                            return true;
                        }

                    }
                    
                    if (activ[i].Y - 1 > -1 && city.Grid[activ[i].Y - 1, activ[i].X] == 0)
                    {
                        if (city.Map[activ[i].Y - 1][activ[i].X] == 0)
                        {
                            temp.Add(new Point(activ[i].X, activ[i].Y - 1));
                            city.Grid[activ[i].Y - 1, activ[i].X] = counter;
                        }

                        if (activ[i].X == finish.X && activ[i].Y - 1 == finish.Y)
                        {
                            city.Grid[start.Y, start.X] = 0;
                            return true;
                        }

                    }
                                     
                }
                  activ.Clear();                
                  for (int j = 0; j < temp.Count; j++)
                  {                    
                      activ.Add(temp[j]);                   
                  }                 

            }
           // MessageBox.Show("Волна не прошла!");
            return false;
        }

        public bool findPath(City city, Point finish) //
        {
            path.Clear();
            if (setWave(city, finish))
            {               
                 path.Add(finish);
                 List<Point> temp = new List<Point>();
                 Point last;
                 bool prov = false;
                  while (prov == false)
                  {                  
                     temp.Clear();
                     last = path.Last();
                     if (last.X + 1 < city.Grid.GetLength(1))
                     {
                          temp.Add(new Point(last.X + 1, last.Y));

                     }

                     if (last.X - 1 > -1)
                     {
                          temp.Add(new Point(last.X - 1, last.Y));

                     }

                     if (last.Y + 1 < city.Grid.GetLength(0))
                     {
                          temp.Add(new Point(last.X, last.Y + 1));                         

                     }

                     if (path[path.Count - 1].Y - 1 > -1)
                     {                          
                          temp.Add(new Point(last.X, last.Y - 1));

                     }

                     foreach (Point item in temp)
                     {                       
                            if (city.Grid[item.Y, item.X] == city.Grid[last.Y, last.X] - 1)
                            {                             
                                path.Add(item);                            
                                break;
                            }                       
                     }                    
                     prov = city.Grid[path.Last().Y, path.Last().X] == 0;                 
                 }
                 path.Remove(path.Last());
                 pathLen = path.Count;
               //  MessageBox.Show(city.Grid[0,0].ToString());
                 return true;
            }
            else
            {
                 return false;
            }          
        }

        public void DrawPath(Graphics g, City city)
        {
            foreach (var elem in path)
            {
                g.FillRectangle(new SolidBrush(Color.Gray), elem.X * city.width + 1 * (elem.X + 1), elem.Y * city.width + 1 * (elem.Y + 1), city.width, city.width);
            } 
        }

        public void Draw(Graphics g, int width, Color color)
        {
            g.FillRectangle(new SolidBrush(color), start.X * width + 1 * (start.X + 1) + width / 2 - size / 2, start.Y * width + 1 * (start.Y + 1) + width / 2 - size / 2, size, size);

        }

        public void DrawPanel(Graphics g)
        {
            String picpath = Environment.CurrentDirectory + @"\images\male\2.jpg";
            Image img = Image.FromFile(picpath); 
            g.DrawImage(img, 1, 1);

            g.DrawRectangle(new Pen(Color.Black), img.Width + 4, img.Height - 39, 300, 15);
            g.DrawRectangle(new Pen(Color.Black), img.Width + 4, img.Height - 27, 300, 15);
            g.DrawRectangle(new Pen(Color.Black), img.Width + 4, img.Height -15, 300, 15);
            g.DrawString("Настроение", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), img.Height + 305, img.Height - 13);
            g.DrawString("Сытость", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), img.Height + 305, img.Height - 26);
            g.DrawString("Здоровье", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), img.Height + 305, img.Height - 40);

        }

        public void DrawGrid(Graphics g, City city)
        {
            StringFormat f = new StringFormat();
            f.Alignment = StringAlignment.Center;
            f.LineAlignment = StringAlignment.Center;
            for (int y = 0; y < city.Grid.GetLength(0); y++)
            {
                for (int x = 0; x < city.Grid.GetLength(1); x++)
                {
                    if (city.Grid[y, x] > 0)
                    {
                        String text = city.Grid[y, x].ToString();
                        g.DrawString(text, new Font("Arial", 7, FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(x * city.width + 1 * (x + 1), y * city.width + 1 * (y + 1), city.width, city.width), f);
                    }
                   
                }
            }
                        
        }
    }
}
