﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FA77374ACEF79D2AB9E82F22217D1E4F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LevelEditorICA;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Xceed.Wpf.Toolkit;


namespace LevelEditorICA {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadSpritebtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadXMLbtn;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveXMLbtn;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Draw_Button;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Erase_button;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas mapTileCanvas;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView SpriteSheetList;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox MapList;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown MapWidth;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown MapHeight;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.IntegerUpDown TileWidth;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton layer1Button;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton layer2Button;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton layer3Button;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton CollisionButton;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Layer1CheckBox;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Layer2CheckBox;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Layer3CheckBox;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CollisionCheckBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LevelEditorICA;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.LoadSpritebtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\MainWindow.xaml"
            this.LoadSpritebtn.Click += new System.Windows.RoutedEventHandler(this.BtnOpenFile_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LoadXMLbtn = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\MainWindow.xaml"
            this.LoadXMLbtn.Click += new System.Windows.RoutedEventHandler(this.BtnLoadXML_click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SaveXMLbtn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\MainWindow.xaml"
            this.SaveXMLbtn.Click += new System.Windows.RoutedEventHandler(this.Menu_SaveClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Draw_Button = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.Erase_button = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            
            #line 84 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Menu_NewClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 95 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExitEditorCommand);
            
            #line default
            #line hidden
            return;
            case 9:
            this.mapTileCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 111 "..\..\MainWindow.xaml"
            this.mapTileCanvas.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.canvasMap_MouseDown);
            
            #line default
            #line hidden
            
            #line 111 "..\..\MainWindow.xaml"
            this.mapTileCanvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.canvasMap_MouseMove);
            
            #line default
            #line hidden
            
            #line 111 "..\..\MainWindow.xaml"
            this.mapTileCanvas.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.canvasMap_MouseDown);
            
            #line default
            #line hidden
            
            #line 111 "..\..\MainWindow.xaml"
            this.mapTileCanvas.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.canvasMap_MouseUp);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SpriteSheetList = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            this.MapList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 12:
            this.MapWidth = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 13:
            this.MapHeight = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 14:
            this.TileWidth = ((Xceed.Wpf.Toolkit.IntegerUpDown)(target));
            return;
            case 15:
            this.layer1Button = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 16:
            this.layer2Button = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 17:
            this.layer3Button = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 18:
            this.CollisionButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 19:
            this.Layer1CheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 157 "..\..\MainWindow.xaml"
            this.Layer1CheckBox.Click += new System.Windows.RoutedEventHandler(this.UpdateCanvas);
            
            #line default
            #line hidden
            return;
            case 20:
            this.Layer2CheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 158 "..\..\MainWindow.xaml"
            this.Layer2CheckBox.Click += new System.Windows.RoutedEventHandler(this.UpdateCanvas);
            
            #line default
            #line hidden
            return;
            case 21:
            this.Layer3CheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 159 "..\..\MainWindow.xaml"
            this.Layer3CheckBox.Click += new System.Windows.RoutedEventHandler(this.UpdateCanvas);
            
            #line default
            #line hidden
            return;
            case 22:
            this.CollisionCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 160 "..\..\MainWindow.xaml"
            this.CollisionCheckBox.Click += new System.Windows.RoutedEventHandler(this.UpdateCanvas);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

