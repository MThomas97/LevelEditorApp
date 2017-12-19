using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace LevelEditorICA
{
    [Serializable]
    public class MapCell
    {
        private int x0, x1, y0, y1;
        private string topItem;
        private string floor;

        public int X0
        {
            get { return x0; }
            set { x0 = value; }
        }
        public int Y0
        {
            get { return y0; }
            set { y0 = value; }
        }
        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public string Item
        {
            get { return topItem; }
            set { topItem = value; }
        }
        public string Floor
        {
            get { return floor; }
            set { floor = value; }
        }

        public MapCell()
        {
            this.x0 = 0;
            this.x1 = 0;
            this.y0 = 0;
            this.y1 = 0;
            this.Item = string.Empty;
            this.Floor = string.Empty;
        }
        public MapCell(int X0, int Y0, int X1, int Y1)
        {
            this.x0 = X0;
            this.y0 = Y0;
            this.x1 = X1;
            this.y1 = Y1;
            this.Item = string.Empty;
            this.Floor = string.Empty;
        }
        public MapCell(int X0, int Y0, int X1, int Y1, string floor)
        {
            this.x0 = X0;
            this.y0 = Y0;
            this.x1 = X1;
            this.y1 = Y1;
            this.Item = string.Empty;
            this.Floor = floor;
        }
        public MapCell(int X0, int Y0, int X1, int Y1, string floor, string item)
        {
            this.x0 = X0;
            this.y0 = Y0;
            this.x1 = X1;
            this.y1 = Y1;
            this.Item = item;
            this.Floor = floor;
        }
        public MapCell(MapCell cell)
        {
            this.x0 = cell.X0;
            this.y0 = cell.Y0;
            this.x1 = cell.X1;
            this.y1 = cell.Y1;
            this.Item = cell.Item;
            this.Floor = cell.Floor;
        }
    }

    public class TextureCell
    {
        private string title;
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        private BitmapImage imageData;
        public BitmapImage ImageData
        {
            get { return this.imageData; }
            set { this.imageData = value; }
        }
    }
}
