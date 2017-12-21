using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Xml;
using System.Xml.Linq;

namespace LevelEditorICA
{
    class XmlClass
    {
        private void FillFromXElement(XElement gameTiles)
        {
            IEnumerable<XElement> elements = gameTiles.Elements("GameTile");
            

            // Attempt to read all the data.
            foreach (XElement element in elements)
            {
                
            }

            
        }

        public bool CreateFromXML(XDocument xml)
        {
            // Attempt the loading process.
            try
            {
                // Obtain the working set of data.
                XElement root = xml.Root;
                UpdateDimensions(Convert.ToInt16(root.Attribute("Width").Value), Convert.ToInt16(root.Attribute("Height").Value));


                XElement gameTiles = root.Element("GameTiles");
                //SetCanvas(Convert.ToInt16(gameTiles.Attribute("MapIndex").Value), Convert.ToInt16(gameTiles.Attribute("ImageIndex").Value));

                // Attempt to construct the grid.
                //ClearData();
                FillFromXElement(root.Element("GameTiles"));

                //UpdateGridVisuals();

                return true; // ?
            }

            catch (Exception)
            {
                // Take care of illegal data by simply clearing it.
                //ResetToSafeValues();
                //ClearData();
                //UpdateGridVisuals();
            }

            return false;
        }

        private void UpdateDimensions(int newWidth, int newHeight)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.BoundWidth = newWidth;
            mainWindow.BoundHeight = newHeight;
            //gridHeight = newHeight;

        }

        //private void SetCanvas(int MapIndex, int ImageIndex)
        //{
        //    Image newimg = new Image();

        //    newimg.Source = panelImages[ImageIndex].Source;

        //    mapTileCanvas.Children.Insert(MapIndex, newimg);

        //}
    }
}
