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


namespace LevelEditorICA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        private MapCell[,] map = new MapCell[5, 5];

        private BitmapImage activeTexture;
        private BitmapImage secondTexture;

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
            for (int i = 0; i < gridHeight; i++)
                for (int j = 0; j < gridWidth; j++)
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

        private int gridHeight = 5;
        private int gridWidth = 5;

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

        public bool ShowPending
        {
            get { return this.showPending; }
            set { this.showPending = value; }
        }

        private bool showPending = true;

        private void checkBoxShowPending_CheckedChanged(object sender, EventArgs e)
        {
            //checking showPending.Value here.  It's always false
            showPending = true;
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

        private void DrawTexture(object sender, double x, double y)
        {
            if (SpriteSheetList.SelectedItem != null)
            {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                    {
                        if (x >= this.map[i, j].X0 && x <= this.map[i, j].X1
                            && y >= this.map[i, j].Y0 && y <= this.map[i, j].Y1)
                        {
                            //MessageBox.Show($"({this.map[i, j].X0};{this.map[i, j].Y0}) — ({this.map[i, j].X1};{this.map[i, j].Y1})");
                            Image img = new Image();
                            //img.Source = 
                            img.Source = ((Image)SpriteSheetList.SelectedItem).Source;
                            img.Width = tileSize;
                            img.Height = tileSize;
                            Canvas.SetLeft(img, this.map[i, j].X0);
                            Canvas.SetTop(img, this.map[i, j].Y0);
                            Canvas.SetZIndex(img, 1);
                            
                            this.mapTileCanvas.Children.Add(img);
                            break;
                        }
                    }
            }
        }
        private void DeleteTexture(object sender, double x, double y)
        {
            if (SpriteSheetList.SelectedItem != null)
            {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                    {
                        if (x >= this.map[i, j].X0 && x <= this.map[i, j].X1
                            && y >= this.map[i, j].Y0 && y <= this.map[i, j].Y1)
                        {
                            //MessageBox.Show($"({this.map[i, j].X0};{this.map[i, j].Y0}) — ({this.map[i, j].X1};{this.map[i, j].Y1})");
                            Image img = new Image();
                            //img.Source = 
                            img.Source = ((Image)SpriteSheetList.SelectedItem).Source;
                            img.Width = tileSize;
                            img.Height = tileSize;
                            Canvas.SetLeft(img, this.map[i, j].X0);
                            Canvas.SetTop(img, this.map[i, j].Y0);
                            Canvas.SetZIndex(img, 0); //layer
                            this.mapTileCanvas.Children.Add(img);

                            break;
                        }
                    }
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
                mapTileCanvas.Children.Add(new Image() { Source = ((Image)SpriteSheetList.SelectedItem).Source, Height = tileSize });
            }
        }

        private void canvasMap_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var clickedPoint = e.GetPosition((Canvas)sender);
            double x = clickedPoint.X;
            double y = clickedPoint.Y;
            if (e.ChangedButton == MouseButton.Left)
                this.DrawTexture(sender, x, y);
            else if (e.ChangedButton == MouseButton.Right)
                this.DeleteTexture(sender, x, y);
        }
        private void canvasMap_MouseMove(object sender, MouseEventArgs e)
        {
            var clickedPoint = e.GetPosition((Canvas)sender);
            double x = clickedPoint.X;
            double y = clickedPoint.Y;
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DrawTexture(sender, x, y);
            else if (e.RightButton == MouseButtonState.Pressed)
                this.DeleteTexture(sender, x, y);
        }

        private void menuLoadTiles(object sender, RoutedEventArgs e)
        {
            /*if (gridMapTiles != null)
            {
                
                gridMapTiles.Children.Clear();
                gridMapTiles.RowDefinitions.Clear();
                gridMapTiles.ColumnDefinitions.Clear();
                gridMapTiles.ShowGridLines = showPending;

                //if (mapImages.Count < 1)
                //{
                    // images for sprites
                    //BtnOpenFile_Click();
                    //createTilesListOnCanvas();

                    //int gridHeight = int.Parse(MapHeight.Text);
                    //int gridWidth = int.Parse(MapWidth.Text);
                    for (int i = 0; i < gridHeight; i++)
                        gridMapTiles.RowDefinitions.Add(
                            new RowDefinition()
                            { Height = new GridLength(tileSize) }
                          );
                    for (int i = 0; i < gridWidth; i++)
                        gridMapTiles.ColumnDefinitions.Add(new ColumnDefinition()
                        { Width = new GridLength(tileSize) });

                    for (int i = 0; i < gridHeight; i++)
                        for (int j = 0; j < gridWidth; j++)
                        {
                            Button btn = new Button();

                            Canvas can = new Canvas();

                            if (gridWidth < j)
                                gridMapTiles.Children.Remove(can);

                        Grid.SetRow(can, i);
                        Grid.SetColumn(can, j);
                        gridMapTiles.Children.Add(can);*/
                        /*Rectangle rect_ = new Rectangle();
                        rect_.Width = tileSize;
                        rect_.Height = tileSize;
                        rect_.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                        mapTileCanvas.Children.Add(rect_);
                        Canvas.SetLeft(rect_, gridWidth * j + j * 1);
                        Canvas.SetTop(rect_, gridHeight * i + i * 1);*/

                    //}
                
                //}

            //}
        }

        private void BtnLoadXML_click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            //openFileDialog.InitialDirectory = "c://";
            openFileDialog.FileName = "";
            openFileDialog.DefaultExt = ".XML";
            openFileDialog.Filter = "XML files (.XML)|*.XML";
            openFileDialog.RestoreDirectory = true;
            Nullable<bool> result = openFileDialog.ShowDialog();

            if (result.HasValue && result.Value)
            {
                   
                string sFilenames = "";

                foreach (string sFilename in openFileDialog.FileNames)
                {
                    sFilenames += ";" + sFilename;
                }
                sFilenames = sFilenames.Substring(1);
            }

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

                string sFilenames = "";

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
