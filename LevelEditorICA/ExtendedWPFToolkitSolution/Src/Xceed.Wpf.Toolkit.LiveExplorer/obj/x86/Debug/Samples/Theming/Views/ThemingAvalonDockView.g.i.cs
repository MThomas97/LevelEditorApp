﻿#pragma checksum "..\..\..\..\..\..\Samples\Theming\Views\ThemingAvalonDockView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5710A5FA626586B0276F2E86A2A8E601296F6312"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Xceed.Wpf.AvalonDock;
using Xceed.Wpf.AvalonDock.Controls;
using Xceed.Wpf.AvalonDock.Converters;
using Xceed.Wpf.AvalonDock.Layout;
using Xceed.Wpf.AvalonDock.Themes;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.LiveExplorer;
using Xceed.Wpf.Toolkit.LiveExplorer.Samples.Theming.Views;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Xceed.Wpf.Toolkit.LiveExplorer.Samples.Theming.Views {
    
    
    /// <summary>
    /// ThemingAvalonDockView
    /// </summary>
    public partial class ThemingAvalonDockView : Xceed.Wpf.Toolkit.LiveExplorer.DemoView, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\..\Samples\Theming\Views\ThemingAvalonDockView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.LiveExplorer.Samples.Theming.Views.ThemingAvalonDockView _demo;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\..\..\Samples\Theming\Views\ThemingAvalonDockView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _themeCombo;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\..\..\..\Samples\Theming\Views\ThemingAvalonDockView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.LiveExplorer.Samples.Theming.Views.AvalonDockComboBoxItem metroDarkComboBoxItem;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\..\..\..\..\Samples\Theming\Views\ThemingAvalonDockView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.LiveExplorer.Samples.Theming.Views.AvalonDockComboBoxItem metroLightComboBoxItem;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\..\..\..\Samples\Theming\Views\ThemingAvalonDockView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border SampleBorder;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\..\..\..\..\Samples\Theming\Views\ThemingAvalonDockView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.AvalonDock.DockingManager _dockingManager;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\..\..\..\..\Samples\Theming\Views\ThemingAvalonDockView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.AvalonDock.Layout.LayoutRoot _layoutRoot;
        
        #line default
        #line hidden
        
        
        #line 309 "..\..\..\..\..\..\Samples\Theming\Views\ThemingAvalonDockView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image _openSourceScreenShot;
        
        #line default
        #line hidden
        
        
        #line 310 "..\..\..\..\..\..\Samples\Theming\Views\ThemingAvalonDockView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel _openSourceTextHyperlink;
        
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
            System.Uri resourceLocater = new System.Uri("/Xceed.Wpf.Toolkit.LiveExplorer;component/samples/theming/views/themingavalondock" +
                    "view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Samples\Theming\Views\ThemingAvalonDockView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this._demo = ((Xceed.Wpf.Toolkit.LiveExplorer.Samples.Theming.Views.ThemingAvalonDockView)(target));
            return;
            case 2:
            
            #line 33 "..\..\..\..\..\..\Samples\Theming\Views\ThemingAvalonDockView.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 3:
            this._themeCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.metroDarkComboBoxItem = ((Xceed.Wpf.Toolkit.LiveExplorer.Samples.Theming.Views.AvalonDockComboBoxItem)(target));
            return;
            case 5:
            this.metroLightComboBoxItem = ((Xceed.Wpf.Toolkit.LiveExplorer.Samples.Theming.Views.AvalonDockComboBoxItem)(target));
            return;
            case 6:
            this.SampleBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            this._dockingManager = ((Xceed.Wpf.AvalonDock.DockingManager)(target));
            return;
            case 8:
            this._layoutRoot = ((Xceed.Wpf.AvalonDock.Layout.LayoutRoot)(target));
            return;
            case 9:
            this._openSourceScreenShot = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this._openSourceTextHyperlink = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 11:
            
            #line 313 "..\..\..\..\..\..\Samples\Theming\Views\ThemingAvalonDockView.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

