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
            Width = 400;
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

            
                
            


            mapTileCanvas.Children.Clear();
            for (int i = 0; i < gridHeight; i++)
                for (int j = 0; j < gridWidth; j++)
                {
                    Button btn = new Button();

                    Canvas can = new Canvas();

                    Rectangle rect_ = new Rectangle();
                    rect_.Width = tileSize;
                    rect_.Height = tileSize;
                    rect_.Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                    //mapTileCanvas.Children.Add(rect_);
                    //Canvas.SetLeft(rect_, tileSize * j + j * 1);
                    //Canvas.SetTop(rect_, tileSize * i + i * 1);





                }

        }

        // my config file
        //myConfigFile cfgFile = new myConfigFile();

        //// number of columns considered
        //// (shouldnt this be stored in the config file?!)
        //const int cols = 23;
        //// number of rows considered
        //// (shouldnt this be stored in the config file?!)
        //const int rows = 21;

        // size, in pixels, of tiles considered
        // (shouldnt this be stored in the config file?!)
        private int tileSize = 32;

       

        List<Image> images = new List<Image>();

        List<Rectangle> tiles = new List<Rectangle>();

       

        private Rectangle rect = new Rectangle();

        Image GetImg = new Image();

        // this is a special type of collection which automatically updates the UI element it is bound to 
        ObservableCollection<Image> panelImages = new ObservableCollection<Image>();
        ObservableCollection<Image> mapImages = new ObservableCollection<Image>();
        Collection<Image> collectionImages = new Collection<Image>();
        
        // drag and drop
        Point mouseOffset;
        private bool isDragging = false;

        //private int _boundNumber;
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

        //private void checkBoxShowPending_CheckedChanged(object sender, EventArgs e)
        //{
        //    //checking showPending.Value here.  It's always false
        //    showPending = true;
        //}

        

        

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

                    

                    //for (int i = 0; i < gridHeight; i++)
                    //    for (int j = 0; j < gridWidth; j++)
                    //    {
                    //        this.map[i, j] = new MapCell();
                    //        this.map[i, j].X0 = j * 32;
                    //        this.map[i, j].Y0 = i * 32;
                    //        this.map[i, j].X1 = (j + 1) * 32;
                    //        this.map[i, j].Y1 = (i + 1) * 32;
                    //    }

                    //mapTileCanvas.Children.Clear();
                    for (int i = 0; i < gridHeight; i++)
                        for (int j = 0; j < gridWidth; j++)
                        {
                            Button btn = new Button();

                            Canvas can = new Canvas();
                            Grid grid = new Grid();
                            Rectangle rect_ = new Rectangle();
                            rect_.Width = tileSize;
                            rect_.Height = tileSize;
                            rect_.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                            //mapTileCanvas.Children.Add(rect_);
                            //Canvas.SetLeft(rect_, tileSize * j + j * 1);
                            //Canvas.SetTop(rect_, tileSize * i + i * 1);

                            




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

                    for (int i = 0; i < 1000; i++)
                        for (int j = 0; j < 1000; j++)
                        {
                            this.map[i, j] = new MapCell();
                            this.map[i, j].X0 = j * 32;
                            this.map[i, j].Y0 = i * 32;
                            this.map[i, j].X1 = (j + 1) * 32;
                            this.map[i, j].Y1 = (i + 1) * 32;
                        }

                    //mapTileCanvas.Children.Clear();
                    for (int i = 0; i < gridHeight; i++)
                        for (int j = 0; j < gridWidth; j++)
                        {
                            Button btn = new Button();

                            Canvas can = new Canvas();

                            Rectangle rect_ = new Rectangle();
                            rect_.Width = tileSize;
                            rect_.Height = tileSize;
                            rect_.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));

                            //mapTileCanvas.Children.Add(rect_);
                            //Canvas.SetLeft(rect_, tileSize * j + j * 1);
                            //Canvas.SetTop(rect_, tileSize * i + i * 1);
                            
                            



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
        
        Image img2 = new Image();
       
        private void DrawTexture(object sender, double x, double y)
        {
            if (SpriteSheetList.SelectedItem != null)
            {
                for (int i = 0; i < gridHeight; i++)
                    for (int j = 0; j < gridWidth; j++)
                    {
                        if (x >= this.map[i, j].X0 && x <= this.map[i, j].X1
                            && y >= this.map[i, j].Y0 && y <= this.map[i, j].Y1)
                        {
                            //MessageBox.Show($"({this.map[i, j].X0};{this.map[i, j].Y0}) — ({this.map[i, j].X1};{this.map[i, j].Y1})");
                            Image img = new Image();
                            
                             
                            img.Source = ((Image)SpriteSheetList.SelectedItem).Source;

                            

                            img.Width = tileSize;
                            img.Height = tileSize;
                            
                            Canvas.SetLeft(img, this.map[i, j].X0);
                            Canvas.SetTop(img, this.map[i, j].Y0);

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
                            if (CollisionButton.IsChecked == true)
                            {
                                Canvas.SetZIndex(img, 4);
                                img.Uid = "Collision";
                                CollisionIndex.Add(true);
                                LayerIndex.Add(4);
                            }
                            
                            //Canvas.SetZIndex(img, 1);
                            this.mapTileCanvas.Children.Add(img);
                            this.CanvasList.Add(img);
                            this.mapPositionX.Add(this.map[i, j].X0);
                            this.mapPositionY.Add(this.map[i, j].Y0);
                            ImageIndex.Add(SpriteSheetList.SelectedIndex);


                            break;

                            

                        }
                        
                    }

                
            }
        }
        private void DeleteTexture(object sender, double x, double y)
        {
            if (SpriteSheetList.SelectedItem != null)
            {
                for (int i = 0; i < 1000; i++)
                    for (int j = 0; j < 1000; j++)
                    {
                        if (x >= this.map[i, j].X0 && x <= this.map[i, j].X1
                            && y >= this.map[i, j].Y0 && y <= this.map[i, j].Y1)
                        {
                           
                                //MessageBox.Show($"({this.map[i, j].X0};{this.map[i, j].Y0}) — ({this.map[i, j].X1};{this.map[i, j].Y1})");
                                Image img = new Image();
                                Image img2 = new Image();
                                //img.Source = 
                                //img.Source = ((Image)SpriteSheetList.SelectedItem).Source;
                                img.Width = tileSize;
                                img.Height = tileSize;
                                
                                img.Source = null;
                                Rectangle rect_ = new Rectangle();
                                rect_.Width = tileSize;
                                rect_.Height = tileSize;
                                rect_.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            //Canvas.SetZIndex(rect_, 5);


                            foreach (UIElement element in mapTileCanvas.Children)
                            {
                                if (mapTileCanvas != null)
                                {
                                    if(layer1Button.IsChecked == true)
                                    { 
                                        if (element.IsMouseDirectlyOver && element.Uid == "Layer 1")
                                        {
                                            element.Uid = "Delete";
                                        
                                            //UIElementIndex.Add(element);
                                            element.Visibility = Visibility.Hidden;

                                        }
                                    }
                                    else if (layer2Button.IsChecked == true)
                                    {
                                        if (element.IsMouseDirectlyOver && element.Uid == "Layer 2")
                                        {
                                            element.Uid = "Delete";

                                            //UIElementIndex.Add(element);
                                            element.Visibility = Visibility.Hidden;

                                        }
                                    }

                                    else if (layer3Button.IsChecked == true)
                                    {
                                        if (element.IsMouseDirectlyOver && element.Uid == "Layer 3")
                                        {
                                            element.Uid = "Delete";

                                            //UIElementIndex.Add(element);
                                            element.Visibility = Visibility.Hidden;

                                        }
                                    }

                                    else if (CollisionButton.IsChecked == true)
                                    {
                                        if (element.IsMouseDirectlyOver && element.Uid == "Collision")
                                        {
                                            element.Uid = "Delete";

                                            //UIElementIndex.Add(element);
                                            element.Visibility = Visibility.Hidden;

                                        }
                                    }
                                }
                            }
                            
                            

                            //foreach (UIElement el in UIElementIndex)
                            //{

                            //    mapTileCanvas.Children.Remove(el);

                            //}
                            




                            //Canvas.SetLeft(rect_, this.map[i, j].X0);
                            //Canvas.SetTop(rect_, this.map[i, j].Y0);


                            //layer
                            //this.mapTileCanvas.Children.Add(img);
                            //this.mapTileCanvas.Children.Add(img);
                            //this.mapTileCanvas.Children.Add(rect_);

                            break;
                            
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

        private void btn_AddTileToMap(object sender, RoutedEventArgs e)
        {
            if (SpriteSheetList.SelectedItem != null)
            {
                //Image img = new Image();
                ////img.Source = 
                //img.Source = ((Image)SpriteSheetList.SelectedItem).Source; Height = tileSize;
                //mapTileCanvas.Children.Add(img);
                mapTileCanvas.Children.Insert(10,new Image() { Source = ((Image)SpriteSheetList.SelectedItem).Source, Height = tileSize });
                
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


                //XElement gameTiles = root.Element("GameTiles");
                //SetCanvas(Convert.ToInt16(gameTiles.Attribute("MapIndex").Value), Convert.ToInt16(gameTiles.Attribute("ImageIndex").Value));

                
                
                // Attempt to construct the grid.
                ClearData();
                FillFromXElement(root.Element("GameTiles"), root);

                //UpdateGridVisuals();
                
                return true; // ?
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

        private void FillFromXElement(XElement gameTiles, XElement root)
        {
            IEnumerable<XElement> elements = gameTiles.Elements("GameTiles");
            IEnumerable<XElement> elementRoot = root.Elements("GameTiles");


            
            // Attempt to read all the data.

            //foreach (UIElement ui in mapTileCanvas.Children)
            //{
            //    mapTileCanvas.Children.Remove(ui);

            //}

            //foreach (Image img in CanvasList)
            //{
            //    CanvasList.Remove(img);
            //}

            BitmapImage bitmap = new BitmapImage(new Uri(gameTiles.Attribute("Sprite").Value, UriKind.Relative));

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

                    SpriteSheetList.ItemsSource = new ObservableCollection<Image>(panelImages);
                }

            foreach (XElement element in elementRoot)
            {
                
                Image img = new Image();
                img.Source = panelImages[Convert.ToInt16(element.Attribute("ImageIndex").Value)].Source;
                img.Width = tileSize;
                img.Height = tileSize;
                //this.mapTileCanvas.Children.Add(img);

                Canvas.SetLeft(img, Convert.ToInt16(element.Attribute("PositionX").Value));
                Canvas.SetTop(img, Convert.ToInt16(element.Attribute("PositionY").Value));
                this.mapTileCanvas.Children.Add(img);
                this.CanvasList.Add(img);
                this.mapPositionX.Add(Convert.ToInt16(element.Attribute("PositionX").Value));
                this.mapPositionY.Add(Convert.ToInt16(element.Attribute("PositionY").Value));
                ImageIndex.Add(Convert.ToInt16(element.Attribute("ImageIndex").Value));
                LayerIndex.Add(Convert.ToInt16(element.Attribute("Layer").Value));
                CollisionIndex.Add(Convert.ToBoolean(element.Attribute("IsCollidable").Value));
                
                //this.mapTileCanvas.Children.Add(img);


            }
            

        }

        private void UpdateDimensions(int newWidth, int newHeight)
        {
            gridWidth = newWidth;
            gridHeight = newHeight;

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
                                            new XAttribute("Width", gridWidth), new XAttribute("Height", gridHeight));

            // Traverse the deep maze of game tiles producing the XML.
            //XElement gameTiles = new XElement("GameTiles", new XAttribute("Sprite", sFilenames), new XAttribute(");


            //XElement gameTiles = new XElement("GameTiles");
            //XElement gameTiles = new XElement("GameTiles");

            
            CanvasList.Count();

            //for (int k = 0; mapTileCanvas.Children[k] == null; k++)
            //{
            //    XElement gameTiles2 = new XElement("GameTiles");
            //    canvas.Add(gameTiles2);
            //}

            //foreach (UIElement element in mapTileCanvas.Children)
            //{
            //    if (element.Uid == "Collision")
            //    {
            //        Collidable = true;
            //        CollisionIndex.Add(Collidable);
            //    }
            //    else
            //    {
            //        Collidable = false;
            //        CollisionIndex.Add(Collidable);
            //    }


            //}

            // Traverse the deep maze of game tiles producing the XML.
            //for (int i = 0; i < CanvasList.Count(); i++)
            //{

            //    XElement gameTiles = new XElement("GameTiles", new XAttribute("Sprite", sFilenames), new XAttribute("PositionX", mapPositionX[i]),
            //        new XAttribute("PositionY", mapPositionY[i]), new XAttribute("ImageIndex", ImageIndex[i]), new XAttribute("IsCollidable", CollisionIndex[i]), new XAttribute("Layer", LayerIndex[i]));

            //    canvas.Add(gameTiles);

            //}

            int i = 0;

            foreach (UIElement element in mapTileCanvas.Children)
            {
                if (element.Uid != "Delete")
                {
                    XElement gameTiles = new XElement("GameTiles", new XAttribute("Sprite", sFilenames), new XAttribute("PositionX", mapPositionX[i]),
                           new XAttribute("PositionY", mapPositionY[i]), new XAttribute("ImageIndex", ImageIndex[i]), new XAttribute("IsCollidable", CollisionIndex[i]), new XAttribute("Layer", LayerIndex[i]));

                    canvas.Add(gameTiles);
                    i++;
                }
                else if(element.Uid == "Delete")
                {
                    i++;
                }
                //XElement gameTiles2 = new XElement("GameTiles", new XAttribute("Sprite", sFilenames), new XAttribute("PositionX", 0),
                //           new XAttribute("PositionY", 0), new XAttribute("ImageIndex", 0), new XAttribute("IsCollidable", false), new XAttribute("Layer", 0));

                //canvas.Add(gameTiles2);
            }


            //foreach (UIElement element in mapTileCanvas.Children)
            //{
            //    XElement gameTiles2 = new XElement("GameTiles");
            //    canvas.Add(gameTiles2);

            //}



            //}

            //foreach (Nullable in mapTileCanvas.Children)
            //{

            //    gameTiles.c(gameTile);
            //}

            // Finally construct the XML document, ready to return.

            //xml.Add(canvas);

            //canvas.Add(gameTiles);
            xml.Add(canvas);

            return xml;
        }

        private void Mouse_overCanvas(object sender, MouseEventArgs e)
        {
            Point point = e.GetPosition((UIElement) sender);

            //Rectangle rect_ = new Rectangle();
            //rect_.Width = tileSize;
            //rect_.Height = tileSize;
            //rect_.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            //SpriteSheetList.Children.RemoveAt(0);
            //SpriteSheetList.Children.Insert(1, rect);
            Image newImg = new Image();
            //mapTileCanvas.Children.Add(new Image() { Source = ((Image)newImg).Source, Height = tileSize});
            
            //images.Insert(1, newImg);

            //mapTileCanvas.Children.Add()
            
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

                        SpriteSheetList.ItemsSource = new ObservableCollection<Image>(panelImages);
                        
                        
                        //Canvas.SetTop(newImg, i * tileSize);
                       // Canvas.SetLeft(newImg, j * tileSize); 
                        //images.Add(newImg);
                        //newImg.MouseLeftButtonDown += Image_MouseDown;

                        //GetImg = newImg;
                        
                        
                        //panelImages.Last().MouseLeftButtonDown += Image_MouseDown;
                        //collectionImages.Add(newImg);
                    }
                //SpriteSheetList.ItemsSource = new ObservableCollection<Image>(panelImages);
               
                

            }

        }

       

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Dragging mode begins
            isDragging = true;
            Image img = (Image)sender;

            // Get the position of the click relative to the image
            // so the top-left corner of the image is (0,0)
            mouseOffset = e.GetPosition(img);

            // Watch this image for more mouse events
            img.MouseMove += Image_MouseMove;
            img.MouseLeftButtonUp += Image_MouseUp;

            // Capture the mouse. This way you'll keep receiving
            // the MouseMove event even if the user jerks the mouse
            // off the image
            img.CaptureMouse();
        }

        private void Image_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Image img = (Image)sender;

                // Get the position of the image relative to the Canvas
                Point point = e.GetPosition(SpriteSheetList);

                img.SetValue(Canvas.TopProperty, point.Y - mouseOffset.Y);
                img.SetValue(Canvas.LeftProperty, point.X - mouseOffset.X);
            }
        }
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (isDragging)
            {
                Image img = (Image)sender;

                // Don't watch the mouse events any longer
                img.MouseMove -= Image_MouseMove;
                img.MouseLeftButtonUp -= Image_MouseUp;
                img.ReleaseMouseCapture();

                isDragging = false;
            }
        }

        private void ExitEditorCommand(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menuLoadTiles(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }

        // add the selected tile to the map
        //private void btn_AddTileToMap(object sender, RoutedEventArgs e)
        //{
        //    if (SpriteSheetList.SelectedItem != null)
        //    {
        //        mapImages.Add(new Image() { Source = ((Image)SpriteSheetList.SelectedItem).Source, Height = tileSize });

        //    }
        //}


    }
}
