   M S B A M L   `   `   `  ����l  hXceed.Wpf.Toolkit.LiveExplorer, Version=3.2.6555.41989, Culture=neutral, PublicKeyToken=3e4669d2f30244f4O,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorerXceed.Wpf.Toolkit.LiveExplorer  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      P    JXceed.Wpf.Toolkit.LiveExplorer.Samples.Text.Views.WatermarkPasswordBoxView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      >local,clr-namespace:Xceed.Wpf.Toolkit.LiveExplorer     5      X TXceed.Wpf.Toolkit, Version=3.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      0sys&clr-namespace:System;assembly=mscorlib  5      -   'Xceed.Wpf.Toolkit.LiveExplorer.DemoView    Title$  WatermarkPasswordBox��5         Description 5      J� 5      $��14(�6   $��Segoe)�5      .*�6%   ��The WatermarkPasswordBox is a PasswordBox where you can enter a secure password and display a watermark when the password is not defined.5   	    � 	Resources 5         WatermarkTemplate1  WatermarkTemplate2��%{  &	        &	 �     �� 5       .R�5!      � .+�5"      �� 
����  �
��� ���$��12(�5%      $��Center=�5&      $��Center=�5'      ��5"      �� 5'      5(      5)   	   �� 5+      .R�5,      �� 
���  ��$��1q�5-      ._�5.      �� 
���  ��$
��Bold"�50      |�.  $��4,0,4,0q�52      ��5.      �� 52      53      54   	   55      .��57      �� .+�58      �� $��Features��6   .��59      � $��5q�6    � RowDefinitions 5:      �� 5;      $
��Auto �6   �� 5<      $
��Auto �6    � ColumnDefinitions 5>      �� 5?      $
��Auto �6"   �� 5@      $
��Auto �6"   �� 5A      $
��Auto �6"   �� 5B      $
��Auto �6"   .+�5F      �� $��PasswordChar: ��6   $��Center=�5G      �� 5H      $��1��6    �� 	MaxLength$ 1��5I      $��18��5K      $��5,5,25,5q�5L      $
��Left=�5M      $��Center=�5N      ��5J      �� *PasswordChar+ �� ElementName$ _watermarkPasswordBox��5N      �� 5P      $��1��6   $��
Password: ��5Q      $��Center=�5R      �� 5S      -   5         ��Name$ _passwordTextBlock��5U      $��1��5S      $��1��5T      $	��190��5V      $��5,5,25,5q�5W      $
��Left=�5X      $��Center=�5Y      �� 5\      $��2��6   $��Watermark: ��5]      $��5q�5^      $��Center=�5_      �� 5`      $��3��6   $	��190��5b      $��5,5,25,5q�5c      $
��Left=�5d      $��Center=�5e      ��5a      �� *	Watermark+$ _watermarkPasswordBox��5e      �� 5g      $��1��6   $��2��5h      $��Watermark Template: ��5i      $��5q�5j      $��Center=�5k      �� 5l      $��1��6   $��3��5m      $	��100��5n      $��5,5,25,5q�5o       �� SelectedValuePath$	 Tag��5q      $
��Left=�5r      $��Center=�5s      	 �� SelectedValue	 5p      �� *WatermarkTemplate+$ _watermarkPasswordBox��.@�5t      �� $��Default��6   

 � Tag
 5u      Z� �� 5v      $��
Template 1��6   #
 [  5w      �� 5x      $��
Template 2��6   #
 [ 5y      5z      5{      5|   	   �� 5~      .+�5      �� $��Usage:��6    
 Header#��[ 5�      �� 5�      $��10q�6   .+�5�      �� $��Default:��6   #��[ 5�      ,  &Xceed.Wpf.Toolkit.WatermarkPasswordBox  5�      -   5          Name$ _watermarkPasswordBox��5�   (   $��5q�5�   (   $	��200��5�   (   (  "Xceed.Wpf.Toolkit.WatermarkTextBox   	Watermark$ Enter Password here...��5�   (      PasswordChar$	 ●��5�   (   $ 10��5�   (      KeepWatermarkOnGotFocus .    WatermarkTemplate 5�   (   Z� 5�   (   5�      5�   	   5�      5�      