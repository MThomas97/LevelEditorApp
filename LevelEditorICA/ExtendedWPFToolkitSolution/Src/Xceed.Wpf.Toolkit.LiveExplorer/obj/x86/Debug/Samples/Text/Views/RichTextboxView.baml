   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      l hXceed.Wpf.Toolkit.LiveExplorer, Version=3.2.6555.41989, Culture=neutral, PublicKeyToken=3e4669d2f30244f4O,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorerXceed.Wpf.Toolkit.LiveExplorer 5      u?clr-namespace:Xceed.Wpf.Toolkit.LiveExplorer.Samples.Text.Views1Xceed.Wpf.Toolkit.LiveExplorer.Samples.Text.Views 5      G   AXceed.Wpf.Toolkit.LiveExplorer.Samples.Text.Views.RichTextboxView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      6sys&clr-namespace:System;assembly=mscorlib     5      >local,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorer     5      X TXceed.Wpf.Toolkit, Version=3.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      Jrich?clr-namespace:Xceed.Wpf.Toolkit.LiveExplorer.Samples.Text.Views  5      -  'Xceed.Wpf.Toolkit.LiveExplorer.DemoView    Title$  RichTextBox��5         Description 5      J� 5   
   $��14(�6   $��Segoe)�6"   .*�65   ��The RichTextBox is a TextBox that allows you to edit formatted text based on TextFormatters. The RichTextBoxFormatBar is a contextual formatting toolbar that mimics the behavior of the Microsoft Office 2010 formatting bar on selection.5      .��5      �  � RowDefinitions 5    
   �� 5!      $
��Auto �6   �� 5"      $��* �6   .+�5%   
   �� $��Features��6   $��0��6%   $��5q�62   .��5&      � $��5q�6   $
��Left=�6    5'      �� 5(      $
��Auto �6$   �� 5)      $
��Auto �6$    � ColumnDefinitions 5+      �� 5,      $
��Auto �6'   �� 5-      $��* �6'   .+�5/      �� $��TextFormatter:��6   $��Center=�62   �� 50      -   5         ��Name$ _textFormatter��50       �� SelectedIndex$ 0��63   $��1��6o   $	��150��6   $��5q�6�   $
��Left=�6�   .@�51      �� I  CXceed.Wpf.Toolkit.LiveExplorer.Samples.Text.Views.TextFormatterEnum   	PlainText
 � Tag# Z 6#   .��6U   
Plain Text6a   �� 52      
   Rtf# Z 6#   .��6O   RTF6T   �� 53      	   Xaml# Z	 6#   .��6P   Xaml6V   54      �� 55      $��Text:��6   $��1��6)   $��Center=�66   �� 56      -   5        
 ��Name$
 _text��56      $��1��6)   $��1��66    �� TextWrapping$
 Wrap=�6F    �� 
IsReadOnly . $	��500��6l   $��70��6x   $��5q�6�   $
��Auto=�6�   ��57      ��  �� ElementName$ _richTextBox�� �� Path$
 Text� �� Mode$ OneWay=�58      59      �� 5;   
   $��1��6   $��10q�6"   .+�5<      �� $��Usage:��6    
  Header#��[  6&   #  Xceed.Wpf.Toolkit.RichTextBox  5=      -   5          Name$ _richTextBox��5=      $��1��65   $��5q�6E   
�������$��10q�6c   $	��350��6p   3  -Xceed.Wpf.Toolkit.RichTextBoxFormatBarManager   	FormatBar 5>      ,  &Xceed.Wpf.Toolkit.RichTextBoxFormatBar  5?       �5A      /� 5B      .T�5C      J� .*�6   .*�6+   This is the �� .�60   RichTextBox6>   !6F   5D      5F      5G      5H      5I      