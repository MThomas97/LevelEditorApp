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


namespace LevelEditorICA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();

            #region IMAGES
            //////////////////////////////////////////////////////////////
            // initialise the source of tiles
            SpriteSheetList.ItemsSource = panelImages;
            // initialise the source of map's tiles
            SpriteSheetList.ItemsSource = mapImages;
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
                    rect_.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    mapTileCanvas.Children.Add(rect_);
                    Canvas.SetLeft(rect_, tileSize * j + j * 1);
                    Canvas.SetTop(rect_, tileSize * i + i * 1);





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
        int tileSize = 32;

        int gridHeight = 5;
        int gridWidth = 5;

        List<Rectangle> tiles = new List<Rectangle>();

        private Rectangle rect = new Rectangle();
 
        // this is a special type of collection which automatically updates the UI element it is bound to 
        ObservableCollection<Image> panelImages = new ObservableCollection<Image>();
        ObservableCollection<Image> mapImages = new ObservableCollection<Image>();

        // drag and drop
        //Point mouseOffset;
        //private bool isDragging = false;

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
                    mapTileCanvas.MaxWidth = gridWidth * tileSize;

                    OnPropertyChanged();

                    mapTileCanvas.Children.Clear();
                    for (int i = 0; i < gridHeight; i++)
                        for (int j = 0; j < gridWidth; j++)
                        {
                            Button btn = new Button();

                            Canvas can = new Canvas();

                            Rectangle rect_ = new Rectangle();
                            rect_.Width = tileSize;
                            rect_.Height = tileSize;
                            rect_.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                            mapTileCanvas.Children.Add(rect_);
                            Canvas.SetLeft(rect_, tileSize * j + j * 1);
                            Canvas.SetTop(rect_, tileSize * i + i * 1);
                            




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
                    mapTileCanvas.MaxHeight = gridHeight * tileSize;

                    OnPropertyChanged();

                    mapTileCanvas.Children.Clear();
                    for (int i = 0; i < gridHeight; i++)
                        for (int j = 0; j < gridWidth; j++)
                        {
                            Button btn = new Button();

                            Canvas can = new Canvas();

                            Rectangle rect_ = new Rectangle();
                            rect_.Width = tileSize;
                            rect_.Height = tileSize;
                            rect_.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                            mapTileCanvas.Children.Add(rect_);
                            Canvas.SetLeft(rect_, tileSize * j + j * 1);
                            Canvas.SetTop(rect_, tileSize * i + i * 1);





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

                string filename = openFileDialog.FileName;
                for (int i = 0; i < bitmap.PixelHeight / tileSize; i++)
                    for (int j = 0; j < bitmap.PixelWidth / tileSize; j++)
                    {
                        panelImages.Add(new Image
                        {
                            Source = new CroppedBitmap(bitmap,
                                                 new Int32Rect(j * tileSize, i * tileSize, tileSize, tileSize)),
                            Height = tileSize
                    });

                        
                        //panelImages.Last().MouseLeftButtonDown += Image_MouseDown;
                    }
                SpriteSheetList.ItemsSource = new ObservableCollection<Image>(panelImages);
                
               
            }

        }

        private void ExitEditorCommand(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // add the selected tile to the map
        private void btn_AddTileToMap(object sender, RoutedEventArgs e)
        {
            if (SpriteSheetList.SelectedItem != null)
            {
                mapImages.Add(new Image() { Source = ((Image)SpriteSheetList.SelectedItem).Source, Height = tileSize });
            }
        }

        
    }
}
