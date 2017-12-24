using Microsoft.Win32;
using System;
using System.Collections.Generic;
using DLL_DBWorker.Entities;
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
using System.IO;

namespace LevelEditorICA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    
    public partial class MainWindow : INotifyPropertyChanged
    {
        private MapCell[,] map = new MapCell[1000, 1000];

        

        private BitmapImage activeTexture;
        private BitmapImage secondTexture;

        #region Implementation data

        string sFilenames = "";
        private bool Collidable = false;
        private List<Image> Collectionlist = new List<Image>();
        private List<Image> CanvasList = new List<Image>();
        private List<int> mapPositionX = new List<int>();
        private List<int> mapPositionY = new List<int>();
        private List<int> ImageIndex = new List<int>();
        private List<bool> CollisionIndex = new List<bool>();
        private List<int> LayerIndex = new List<int>();
        private List<UIElement> UIElementIndex = new List<UIElement>();
        private bool layer1check = true;
        private bool layer2check = true;
        private bool layer3check = true;
        private bool collisioncheck = true;
        private int gridHeight = 5;
        private int gridWidth = 5;
        private int tileSize = 32;

        //private LevelGrid m_canvas = null;

        #endregion

        public BitmapImage ActiveTexture
        {
            get { return activeTexture; }
            set { activeTexture = value; }
        }
        public BitmapImage SecondTexture
        {
            get { return secondTexture; }
            set { secondTexture = value; }
        }

        public MainWindow()
        {
            
            for (int i = 0; i < 1000; i++)
                for (int j = 0; j < 1000; j++)
                {
                    this.map[i, j] = new MapCell();
                    this.map[i, j].X0 = j * 32;
                    this.map[i, j].Y0 = i * 32;
                    this.map[i, j].X1 = (j + 1) * 32;
                    this.map[i, j].Y1 = (i + 1) * 32;
                }
            DataContext = this;
            InitializeComponent();

            #region IMAGES
            //////////////////////////////////////////////////////////////
            // initialise the source of tiles
            SpriteSheetList.ItemsSource = panelImages;
            // initialise the source of map's tiles
            //SpriteSheetList.ItemsSource = mapImages;
            //////////////////////////////////////////////////////////////
            #endregion

        }

        // this is a special type of collection which automatically updates the UI element it is bound to 
        ObservableCollection<Image> panelImages = new ObservableCollection<Image>();
     
        public int BoundNumber
        {
            get { return tileSize; }
            set
            {
                if(tileSize != value)
                {
                    tileSize = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool Layer1Check
        {
            get { return this.layer1check; }
            set { this.layer1check = value; }
        }

        public bool Layer2Check
        {
            get { return this.layer2check; }
            set { this.layer2check = value; }
        }

        public bool Layer3Check
        {
            get { return this.layer3check; }
            set { this.layer3check = value; }
        }

        public bool CollisionCheck
        {
            get { return this.collisioncheck; }
            set { this.collisioncheck = value; }
        }

        public int BoundWidth
        {
            get { return gridWidth; }
            set
            {
                if (gridWidth != value)
                {
                    gridWidth = value;
                    mapTileCanvas.Width = gridWidth * tileSize;

                    OnPropertyChanged();
                    int i = 0;

                    foreach(UIElement element in mapTileCanvas.Children)
                    {
                        if(mapPositionX[i] >= mapTileCanvas.Width)
                        {
                            element.Uid = "Delete";
                            element.Visibility = Visibility.Hidden;
                            i++;
                        }
                        else if(mapPositionX[i] <= mapTileCanvas.Width)
                        {
                            i++;
                        }
                    }
                }
            }
        }

        public int BoundHeight
        {
            get { return gridHeight; }
            set
            {
                if (gridHeight != value)
                {
                    gridHeight = value;
                    mapTileCanvas.Height = gridHeight * tileSize;

                    OnPropertyChanged();

                    int i = 0;

                    foreach (UIElement element in mapTileCanvas.Children)
                    {
                        if (mapPositionY[i] >= mapTileCanvas.Height)
                        {
                            element.Uid = "Delete";
                            element.Visibility = Visibility.Hidden;
                            i++;
                        }
                        else if(mapPositionY[i] <= mapTileCanvas.Height)
                        {
                            i++;
                        }
                    }
                }
            }
        }

        public int SetGridHeight
        {
            get { return  gridHeight * tileSize; }
            set
            {
            }
        }

        public int SetGridWidth
        {
            get { return gridWidth * tileSize; }
            set
            {
                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName = null)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
          
        }
       
        private void DrawTexture(object sender, double x, double y)
        {
            
                for (int i = 0; i < gridHeight; i++)
                    for (int j = 0; j < gridWidth; j++)
                    {
                        if (x >= this.map[i, j].X0 && x <= this.map[i, j].X1
                            && y >= this.map[i, j].Y0 && y <= this.map[i, j].Y1)
                        {
                        if (SpriteSheetList.SelectedItem != null)
                        {

                            Image img = new Image();
                            Rectangle rect_ = new Rectangle();
                            rect_.Width = tileSize;
                            rect_.Height = tileSize;
                            rect_.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                            rect_.Opacity = 0.5;

                            img.Source = ((Image)SpriteSheetList.SelectedItem).Source;

                            img.Width = tileSize;
                            img.Height = tileSize;

                            if (layer1Button.IsChecked == true)
                            {
                                Canvas.SetZIndex(img, 1);
                                img.Uid = "Layer 1";
                                LayerIndex.Add(1);
                                CollisionIndex.Add(false);
                            }

                            if (layer2Button.IsChecked == true)
                            {
                                Canvas.SetZIndex(img, 2);
                                img.Uid = "Layer 2";
                                LayerIndex.Add(2);
                                CollisionIndex.Add(false);
                            }
                            if (layer3Button.IsChecked == true)
                            {
                                Canvas.SetZIndex(img, 3);
                                img.Uid = "Layer 3";
                                LayerIndex.Add(3);
                                CollisionIndex.Add(false);
                            }

                            if (CollisionButton.IsChecked == false)
                            {
                                if (mapTileCanvas.Children.Count >= 1)
                                {
                                    for (int k = 0; k < mapPositionX.Count(); k++)
                                    {
                                        foreach (UIElement element in mapTileCanvas.Children)
                                        {

                                            if (this.map[i, j].X0 == mapPositionX[k] && this.map[i, j].Y0 == mapPositionY[k] && ImageIndex[k] == SpriteSheetList.SelectedIndex && img.Uid == mapTileCanvas.Children[k].Uid)
                                            {

                                                LayerIndex.RemoveAt(LayerIndex.Last());
                                                CollisionIndex.RemoveAt(LayerIndex.Last());

                                                return;
                                            }
                                        }
                                    }
                                }

                                Canvas.SetLeft(img, this.map[i, j].X0);
                                Canvas.SetTop(img, this.map[i, j].Y0);
                                this.mapTileCanvas.Children.Add(img);
                                this.CanvasList.Add(img);
                                this.mapPositionX.Add(this.map[i, j].X0);
                                this.mapPositionY.Add(this.map[i, j].Y0);
                                ImageIndex.Add(SpriteSheetList.SelectedIndex);
                            }
                        }

                            if (CollisionButton.IsChecked == true)
                            {
                                Rectangle rect_ = new Rectangle();
                                rect_.Width = tileSize;
                                rect_.Height = tileSize;
                                rect_.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                                rect_.Opacity = 0.5;
                                rect_.Uid = "Collision";
                                CollisionIndex.Add(true);
                                LayerIndex.Add(4);

                                if (mapTileCanvas.Children.Count >= 1)
                                {
                                    for (int k = 0; k < mapPositionX.Count(); k++)
                                    {
                                        foreach (UIElement element in mapTileCanvas.Children)
                                        {

                                            if (this.map[i, j].X0 == mapPositionX[k] && this.map[i, j].Y0 == mapPositionY[k] && ImageIndex[k] == SpriteSheetList.SelectedIndex && rect_.Uid == mapTileCanvas.Children[k].Uid)
                                            {

                                                LayerIndex.RemoveAt(k);
                                                CollisionIndex.RemoveAt(k);

                                                return;
                                            }
                                        }
                                    }
                                }

                                Canvas.SetLeft(rect_, this.map[i, j].X0);
                                Canvas.SetTop(rect_, this.map[i, j].Y0);
                                Canvas.SetZIndex(rect_, 4);
                                this.mapTileCanvas.Children.Add(rect_);
                                this.mapPositionX.Add(this.map[i, j].X0);
                                this.mapPositionY.Add(this.map[i, j].Y0);
                                ImageIndex.Add(SpriteSheetList.SelectedIndex);
                            }

                            break;
                        }
                        

                    }
               
            
        }
        private void DeleteTexture(object sender, double x, double y)
        {
            
                            foreach (UIElement element in mapTileCanvas.Children)
                            {
                                if (mapTileCanvas != null)
                                {
                                    if(layer1Button.IsChecked == true)
                                    { 
                                        if (element.IsMouseOver && element.Uid == "Layer 1")
                                        {
                                            element.Uid = "Delete";
                                            element.Visibility = Visibility.Hidden;
                                        }
                                    }
                                    else if (layer2Button.IsChecked == true)
                                    {
                                        if (element.IsMouseOver && element.Uid == "Layer 2")
                                        {
                                            element.Uid = "Delete";
                                            element.Visibility = Visibility.Hidden;
                                        }
                                    }

                                    else if (layer3Button.IsChecked == true)
                                    {
                                        if (element.IsMouseOver && element.Uid == "Layer 3")
                                        {
                                            element.Uid = "Delete";
                                            element.Visibility = Visibility.Hidden;
                                        }
                                    }

                                    else if (CollisionButton.IsChecked == true)
                                    {
                                        if (element.IsMouseOver && element.Uid == "Collision")
                                        {
                                            element.Uid = "Delete";
                                            element.Visibility = Visibility.Hidden;
                                        }
                                    }
                                }
                            }

            
        }

        private void UpdateCanvas(object sender, RoutedEventArgs e)
        {
            foreach(UIElement element in mapTileCanvas.Children)
            {
                if(Layer1Check == false && element.Uid == "Layer 1")
                    element.Visibility = Visibility.Hidden;

                else if(Layer1Check == true && element.Uid == "Layer 1")
                         element.Visibility = Visibility.Visible;

                if (Layer2Check == false && element.Uid == "Layer 2")
                    element.Visibility = Visibility.Hidden;

                else if (Layer2Check == true && element.Uid == "Layer 2")
                    element.Visibility = Visibility.Visible;

                if (Layer3Check == false && element.Uid == "Layer 3")
                    element.Visibility = Visibility.Hidden;

                else if (Layer3Check == true && element.Uid == "Layer 3")
                    element.Visibility = Visibility.Visible;

                if (CollisionCheck == false && element.Uid == "Collision")
                    element.Visibility = Visibility.Hidden;

                else if (CollisionCheck == true && element.Uid == "Collision")
                    element.Visibility = Visibility.Visible;
            }
        }

        private void canvasMap_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var clickedPoint = e.GetPosition((Canvas)sender);
            double x = clickedPoint.X;
            double y = clickedPoint.Y;
            if (e.ChangedButton == MouseButton.Left && Draw_Button.IsChecked == true)
                this.DrawTexture(sender, x, y);
            else if (e.ChangedButton == MouseButton.Left && Erase_button.IsChecked == true)
                this.DeleteTexture(sender, x, y);
        }
        private void canvasMap_MouseMove(object sender, MouseEventArgs e)
        {
            var clickedPoint = e.GetPosition((Canvas)sender);
            double x = clickedPoint.X;
            double y = clickedPoint.Y;
            if (e.LeftButton == MouseButtonState.Pressed && Draw_Button.IsChecked == true)
                this.DrawTexture(sender, x, y);
            else if (e.LeftButton == MouseButtonState.Pressed && Erase_button.IsChecked == true)
                this.DeleteTexture(sender, x, y);
        }

        private void canvasMap_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var clickedPoint = e.GetPosition((Canvas)sender);
            double x = clickedPoint.X;
            double y = clickedPoint.Y;
            
            if (e.LeftButton == MouseButtonState.Pressed && Erase_button.IsChecked == true)
                this.DeleteTexture(sender, x, y);
        }

        private bool LoadLevel()
        {
            // Create the dialog box.
            OpenFileDialog openBox = new OpenFileDialog();
            openBox.Filter = "XML Files|*.xml";

            // Proceed with saving if necessary.
            if (openBox.ShowDialog() == true)
            {
                try
                {
                    // Attempt to load the XML.
                    XDocument xml = XDocument.Load(openBox.FileName);

                    if (CreateFromXML(xml))
                    {
                        return true;
                    }

                    throw new FileFormatException("Unable to load from XML, likely a corrupt file.");
                }

                catch (Exception error)
                {
                    string message = "An error occurred whilst attempting to load.\nError details: " + error.Message;
                    MessageBox.Show(this, message, "Error", MessageBoxButton.OK);
                }
            }

            return false;
        }

        private void BtnLoadXML_click(object sender, RoutedEventArgs e)
        {
            LoadLevel();
            
        }

        /// <summary>
        /// The save event which writes all data to storage.
        /// </summary>
        private void Menu_SaveClick(object sender, RoutedEventArgs e)
        {
            SaveToXML();
        }

        private void Menu_NewClick(object sender, RoutedEventArgs e)
        {
            ClearData();
        }

        private bool SaveToXML()
        {
            //Create a dialog box.
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "XML Files|*.xml";
            
           
            //Process with saving if necessary.
            if(saveFile.ShowDialog() == true)
            {
                try
                {
                    //Attempt to save the XML.
                    XDocument xml = GenerateXML();
                    xml.Save(saveFile.FileName);
                    return true;
                    
                }
                
                catch(Exception error)
                {
                    string message = "An error occurred attempting to save:" + error.Message;
                    MessageBox.Show(this, message, "Error", MessageBoxButton.OK);
                }
            }
            return false;
        }

        public bool CreateFromXML(XDocument xml)
        {
            // Attempt the loading process.
            try
            {
                // Obtain the working set of data.
                XElement root = xml.Root;
                UpdateDimensions(Convert.ToInt16(root.Attribute("Width").Value), Convert.ToInt16(root.Attribute("Height").Value));



                // Attempt to construct the grid.
                ClearData();
                FillFromXElement(root);

                
                
                return true;
            }

            catch (Exception)
            {
                // Take care of illegal data by simply clearing it.
                //ResetToSafeValues();
                ClearData();
                //UpdateGridVisuals();
            }

            return false;
        }

        private void FillFromXElement(XElement root)
        {
               
            IEnumerable<XElement> elementRoot = root.Elements("GameTiles");

            BitmapImage bitmap = new BitmapImage(new Uri(root.Attribute("Sprite").Value, UriKind.Relative));
            sFilenames = root.Attribute("Sprite").Value;
            SpriteSheetList.Height = bitmap.PixelHeight;
            SpriteSheetList.Width = bitmap.PixelWidth;
            for (int i = 0; i < bitmap.PixelHeight / tileSize; i++)
                for (int j = 0; j < bitmap.PixelWidth / tileSize; j++)
                {


                    panelImages.Add(new Image()
                    {

                        Source = new CroppedBitmap(bitmap,
                                             new Int32Rect(j * tileSize, i * tileSize, tileSize, tileSize)),
                        Height = tileSize
                    });

                    
                }

            SpriteSheetList.ItemsSource = new ObservableCollection<Image>(panelImages);

            foreach (XElement element in elementRoot)
            {
                Image img = new Image();
                img.Source = panelImages[Convert.ToInt16(element.Attribute("ImageIndex").Value)].Source;
                img.Width = tileSize;
                img.Height = tileSize;
                
                
                Rectangle rect_ = new Rectangle();
                rect_.Width = tileSize;
                rect_.Height = tileSize;
                rect_.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                rect_.Opacity = 0.5;

                if (element.Attribute("Layer").Value == "1")
                    img.Uid = "Layer 1";

                else if (element.Attribute("Layer").Value == "2")
                    img.Uid = "Layer 2";

                else if (element.Attribute("Layer").Value == "3")
                    img.Uid = "Layer 3";

                else if (element.Attribute("IsCollidable").Value == "true")
                {
                    rect_.Uid = "Collision";
                    Canvas.SetLeft(rect_, Convert.ToInt16(element.Attribute("PositionX").Value));
                    Canvas.SetTop(rect_, Convert.ToInt16(element.Attribute("PositionY").Value));
                    this.mapTileCanvas.Children.Add(rect_);
                    this.mapPositionX.Add(Convert.ToInt16(element.Attribute("PositionX").Value));
                    this.mapPositionY.Add(Convert.ToInt16(element.Attribute("PositionY").Value));
                    this.ImageIndex.Add(Convert.ToInt16(element.Attribute("ImageIndex").Value));
                    this.LayerIndex.Add(Convert.ToInt16(element.Attribute("Layer").Value));
                    this.CollisionIndex.Add(Convert.ToBoolean(element.Attribute("IsCollidable").Value));
                    
                }
                if (element.Attribute("IsCollidable").Value == "false")
                {
                    Canvas.SetLeft(img, Convert.ToInt16(element.Attribute("PositionX").Value));
                    Canvas.SetTop(img, Convert.ToInt16(element.Attribute("PositionY").Value));
                    this.mapTileCanvas.Children.Add(img);
                    this.CanvasList.Add(img);
                    this.mapPositionX.Add(Convert.ToInt16(element.Attribute("PositionX").Value));
                    this.mapPositionY.Add(Convert.ToInt16(element.Attribute("PositionY").Value));
                    this.ImageIndex.Add(Convert.ToInt16(element.Attribute("ImageIndex").Value));
                    this.LayerIndex.Add(Convert.ToInt16(element.Attribute("Layer").Value));
                    this.CollisionIndex.Add(Convert.ToBoolean(element.Attribute("IsCollidable").Value));
                }
            }
               
                
            
        }

        private void UpdateDimensions(int newWidth, int newHeight)
        {
            gridWidth = newWidth;
            gridHeight = newHeight;

            MapWidth.Value = newWidth;
            MapHeight.Value = newHeight;

            mapTileCanvas.Width = gridWidth * tileSize;
            mapTileCanvas.Height = gridHeight * tileSize;

        }



        private void ClearData()
        {
            mapTileCanvas.Children.Clear();

            CanvasList.Clear();
            mapPositionX.Clear();
            mapPositionY.Clear();
            ImageIndex.Clear();
            panelImages.Clear();
            mapTileCanvas.Children.Clear();
            CollisionIndex.Clear();
            LayerIndex.Clear();
            //SpriteSheetList.ItemsSource = null; //FIX SO THIS LISTVIEW IS CLEARED TOO
            //SpriteSheetList.DataContext = null;
            //SpriteSheetList.Items.Clear();
            
        }

        public XDocument GenerateXML()
        {
            // Create the document and add the grid parameters.
            XDocument xml = new XDocument();

            XElement canvas = new XElement("Canvas",
            new XAttribute("Width", gridWidth), new XAttribute("Height", gridHeight), new XAttribute("Sprite", sFilenames));

            int i = 0;

            foreach (UIElement element in mapTileCanvas.Children)
            {
                if (element.Uid != "Delete")
                {
                    if(element.Uid == "Collision")
                    {
                        XElement gameTilesCollison = new XElement("GameTiles", new XAttribute("Sprite", "No Sprite Collision"), new XAttribute("PositionX", mapPositionX[i]),
                          new XAttribute("PositionY", mapPositionY[i]), new XAttribute("ImageIndex", ImageIndex[i]), new XAttribute("IsCollidable", true), new XAttribute("Layer", 4));

                        canvas.Add(gameTilesCollison);
                        i++;
                    }
                    else
                    {
                        XElement gameTiles = new XElement("GameTiles", new XAttribute("Sprite", sFilenames), new XAttribute("PositionX", mapPositionX[i]),
                           new XAttribute("PositionY", mapPositionY[i]), new XAttribute("ImageIndex", ImageIndex[i]), new XAttribute("IsCollidable", false), new XAttribute("Layer", LayerIndex[i]));

                        canvas.Add(gameTiles);
                        i++;
                    }
                }
                else if(element.Uid == "Delete")
                {
                    i++;
                }
            }

            xml.Add(canvas);

            return xml;
        }

            private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            //openFileDialog.InitialDirectory = "c://";
            openFileDialog.FileName = "";
            openFileDialog.DefaultExt = ".png";
            openFileDialog.Filter = "Image documents (.png)|*.png";
            openFileDialog.RestoreDirectory = true;
            Nullable<bool> result = openFileDialog.ShowDialog();
           
            if (result.HasValue && result.Value)
            {
                foreach (string sFilename in openFileDialog.FileNames)
                {
                    sFilenames += ";" + sFilename;
                }
                sFilenames = sFilenames.Substring(1);
                
                BitmapImage bitmap = new BitmapImage(new Uri(sFilenames,UriKind.Relative));

                SpriteSheetList.Height = bitmap.PixelHeight;
                SpriteSheetList.Width = bitmap.PixelWidth;
                string filename = openFileDialog.FileName;
                for (int i = 0; i < bitmap.PixelHeight / tileSize; i++)
                    for (int j = 0; j < bitmap.PixelWidth / tileSize; j++)
                    {
                        panelImages.Add(new Image()
                        {
                            Source = new CroppedBitmap(bitmap,
                                                 new Int32Rect(j * tileSize, i * tileSize, tileSize, tileSize)),
                            Height = tileSize
                        });

                        Collectionlist.Add(new Image()
                        {
                            Source = new CroppedBitmap(bitmap,
                                                 new Int32Rect(j * tileSize, i * tileSize, tileSize, tileSize)),
                            Height = tileSize
                        });
                    }
                SpriteSheetList.ItemsSource = new ObservableCollection<Image>(panelImages);
            }
        }

        private void ExitEditorCommand(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
