   M S B A M L   `   `   `  ����l  hXceed.Wpf.Toolkit.LiveExplorer, Version=3.2.6555.41989, Culture=neutral, PublicKeyToken=3e4669d2f30244f4O,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorerXceed.Wpf.Toolkit.LiveExplorer  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      H    BXceed.Wpf.Toolkit.LiveExplorer.Samples.Button.Views.IconButtonView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      >local,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorer     5      X TXceed.Wpf.Toolkit, Version=3.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      0sys&clr-namespace:System;assembly=mscorlib  5      -   'Xceed.Wpf.Toolkit.LiveExplorer.DemoView    Title$  
IconButton��5         Description 5      J� 5   
   $��14(�6   $��Segoe)�6"   .*�65   ��The IconButton control is a Button that contains an icon and some data. The Foreground, Background and BorderBrush can be easily modified with properties while the Icon location is customizable.5       � 	Resources 5      G  AXceed.Wpf.Toolkit.Core.Converters.SolidColorBrushToColorConverter #  SolidColorBrushToColorConverter 
 Image1 
 Image2  ButtonLocationEnumData S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%d  &	        &	      &	 q     &	 �       5      6-   �� 5!      $#��../Resources/PencilTool16.png��5"      $��20��5#      $��5q�5$      �� 5%      $��../Resources/Default.jpg��5&      $��25��5'      $��5q�5(      S� 5*      $ 	GetValues��5+      "  5,       5-      M� 5.      $ xctk:Location��6   50   	   51      .��53      �  � RowDefinitions 54      �� 55      $
��Auto �6   �� 56      $��* �6   .+�59      �� $��Features��6   $��0��6#   $��5q�60   .��5:      � $��5q�6    5;      �� 5<      $
��Auto �6   �� 5=      $
��Auto �6   �� 5>      $
��Auto �6   �� 5?      $
��Auto �6   �� 5@      $
��Auto �6   �� 5A      $
��Auto �6    � ColumnDefinitions 5C      �� 5D      $
��Auto �6"   �� 5E      $	��100 �6"   �� 5F      $
��Auto �6"   �� 5G      $	��100 �6"   .+�5K      �� $��Icon:��6   $��Center=�5L      �� 5M      $��1��6   $��5q�5N      $��Center=�5O      	 �� SelectedValuePath$		 Tag��5Q      
 �� SelectedValue
 5P      �� *Icon+ �� ElementName$ _iconButton��.@�5R      �� $
��None��6   
 � Tag 5S      Z� �� 5T      $��Image 1��6   # [ 5U      �� 5V      $��Image 2��6   # [ 5W      5X      �� 5Z      $��1��6   $��Icon Location: ��5[      $��Center=�5\      �� 5]      $��1��6   $��1��5^      $��5q�5a      $��Center=�5b      ��5_      ��  �� Source# [  �� SelectedItem 5`      �� *IconLocation+$ _iconButton��5b      �� 5e      $��MouseOver Foreground:��6   $��2��5f      $��Center=�5g      $��10,0,0,0q�5h      #  Xceed.Wpf.Toolkit.ColorPicker  5i      $��3��6   $��5q�5j         SelectedColor 5k      �� *MouseOverForeground+$ _iconButton�� �� 	Converter# [  �� 5m      $��MousePressed Foreground:��6   $��1��5n      $��2��5o      $��Center=�5p      $��10,0,0,0q�5q        5r      $��1��6   $��3��5s      $��5q�5t       5u      �� *MousePressedForeground+$ _iconButton��# [  �� 5w      $��MouseOver Background:��6   $��2��5x      $��2��5y      $��Center=�5z      $��10,0,0,0q�5{        5|      $��2��6   $��3��5}      $��5q�5~       5      �� *MouseOverBackground+$ _iconButton��# [  �� 5�      $��MousePressed Background:��6   $��3��5�      $��2��5�      $��Center=�5�      $��10,0,0,0q�5�        5�      $��3��6   $��3��5�      $��5q�5�       5�      �� *MousePressedBackground+$ _iconButton��# [  �� 5�      $��MouseOver BorderBrush:��6   $��4��5�      $��2��5�      $��Center=�5�      $��10,0,0,0q�5�        5�      $��4��6   $��3��5�      $��5q�5�       5�      �� *MouseOverBorderBrush+$ _iconButton��# [  �� 5�      $��MousePressed BorderBrush:��6   $��5��5�      $��2��5�      $��Center=�5�      $��10,0,0,0q�5�        5�      $��5��6   $��3��5�      $��5q�5�       5�      �� *MousePressedBorderBrush+$ _iconButton��# [  5�      5�   	   �� 5�      $��1��6   $��10q�6    .+�5�      �� $��Usage:��6    
 Header#��[ 6#   "  Xceed.Wpf.Toolkit.IconButton  5�      -   5          Name$ _iconButton��5�      $
��Test��5�         Icon# [ 5�         IconLocation$
 Left=�5�         MouseOverForeground
 �   �   MousePressedForeground
 �����   MouseOverBackground
 ��ح�   MousePressedBackground
 ��  �   MouseOverBorderBrush
 �����   MousePressedBorderBrush
 �����$��10q�5�      $
��20,3q�5�      $��Center=�5�      5�      5�   	   5�      5�      