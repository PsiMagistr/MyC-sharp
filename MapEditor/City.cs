using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MapEditor
{
    [Serializable]
    public class City
    {
        public int[][] Map;
        public int width = 20;
        [NonSerialized]
        public bool flag = false;
        [NonSerialized]
        public int[,] Grid;

        public void Bild(int h, int w)
        {
            Map = new int[h][];
            for (int i = 0; i < h; i++)
            {
                Map[i] = new int[w];
            }
        }

        public void Save(String path) //
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);
            }
        }

        public static City Load(String path)
        {
            //String path = Environment.CurrentDirectory + @"\maps\" + location + ".dat";
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                City city = (City)formatter.Deserialize(fs);
                city.Grid = new int[city.Map.Length, city.Map[0].Length];
                return city;
            }
        }

        //Перегрузка

        public static City Load(int location)
        {
            String path = Environment.CurrentDirectory + @"\maps\" + location + ".dat";
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                City city = (City)formatter.Deserialize(fs);
                city.Grid = new int[city.Map.Length, city.Map[0].Length];
                return city;
            }
        }

        public void Draw(Graphics g, Color[] colors)
        {
            //Color color = new Color();
            for (int y = 0; y < Map.Length; y++)
            {
                for (int x = 0; x < Map[y].Length; x++)
                {                   
                    int index = Map[y][x];
                    g.FillRectangle(new SolidBrush(colors[index]), x * width + 1 * (x + 1), y * width + 1 * (y + 1), width, width);
                }
            }

        }
    }
}
