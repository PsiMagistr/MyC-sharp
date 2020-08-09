using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapEditor
{
    public partial class MapEditor : Form
    {
        private City city;        

        public MapEditor()
        {
            InitializeComponent();
            city = new City();            
            city.Bild((int)h.Value, (int)w.Value);
           // Bild((int)h.Value, (int)w.Value);
        }

        private void Btnbild_Click(object sender, EventArgs e)
        {            
            city.Bild((int)h.Value, (int)w.Value);
            Mappic.Invalidate();
        }

        private void Mappic_Paint(object sender, PaintEventArgs e)
        {
            //MessageBox.Show(city.Map[0][0].ToString());
            Color[] colors = new Color[2] { Color.Orange, Color.Brown};
            city.Draw(e.Graphics, colors);
        }

        private void MapEditor_Load(object sender, EventArgs e)
        {
            colorslst.SelectedIndex = 0;
        }

        private void Mappic_MouseMove(object sender, MouseEventArgs e)
        {
            if (city.flag == true && e.X > -1 && e.X <= city.width * city.Map[0].Length + city.Map[0].Length -1 && e.X > -1 && e.Y > -1 && e.Y <= city.width * city.Map.Length + city.Map.Length - 1)
            {
               // MessageBox.Show((10 * Map.GetLength(1) + Map.GetLength(1)).ToString());
                int x = e.X / 21;
                int y = e.Y / 21;
                city.Map[y][x] = colorslst.SelectedIndex;
                Mappic.Invalidate();
            }
          
        }

        private void Mappic_MouseDown(object sender, MouseEventArgs e)
        {
            city.flag = true;
        }

        private void Mappic_MouseUp(object sender, MouseEventArgs e)
        {
            city.flag = false;
        }

        private void btnSavemap_Click(object sender, EventArgs e)
        {
            if (SD.ShowDialog() == DialogResult.OK)
            {
                city.Save(SD.FileName); 
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
              if (OD.ShowDialog() == DialogResult.OK)
              {
               city = City.Load(OD.FileName);                              
               Mappic.Invalidate();
              }
             // city.test();
            }
    }
}
