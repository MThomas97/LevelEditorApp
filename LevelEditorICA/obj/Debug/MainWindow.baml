   M S B A M L   `   `   `  ����X  TXceed.Wpf.Toolkit, Version=1.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit  5   	   I ELevelEditorICA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LevelEditorICALevelEditorICA 5   	      LevelEditorICA.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   NwpfTool:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit     5   	   .localclr-namespace:LevelEditorICA     5   	     � Title$  Game Editor��5	   	   $	��800��6   $��800         ��6*    � 
ResizeMode$ 	CanResize=�5
      .��5      � -   5         �Name$ mainGrid��5      $	��769��6   $	��Top=�6*    � RowDefinitions 5   
   �� 5      $	��56* �6   �� 5      $
��713* �6    � ColumnDefinitions 5   
   �� 5      $
��232* �6   �� 5      $	��79* �6   .+�5   
   `�  `� 
Background
 �����$��2��6*   $��2��6>   .�5      c�  c� Band$ 1��6    c� 	BandIndex$ 1��6   $��0,0,-310,-45q�6-   ��5      �� 5      .@�5      �� 6   �� 5      -   5         ��Name$ LoadSpritebtn��5      .��5      �� $��Images/ImageIcon.png��6   $��32��6:   $��32��6E   6S   	 � ToolTip	 5      _� 5      .��5      �� .+�5    "   �� $
��bold"�6,   
Load Image6J   �� 5!   "   1/Loads the selected spritesheet into the editor.6]   5"      5#      5%      �� 5&      -   5        $ 
LoadXMLbtn��5&      .��5'      �� $��Images/AddFile.png��6   $��32��68   $��32��6C   6Q   	 5(      _� 5)      .��5*      �� .+�5+   "   �� $
��bold"�6,   
Load Map6H   �� 5,   "   53Loads the selected XML file and displays the level.6a   5-      5.      50      �� 51      -   5        $ 
SaveXMLbtn��51      .��52      �� $��Images/SaveAs.png��6   $��32��67   $��32��6B   6P   	 53      _� 54      .��55      �� .+�56   "   �� $
��bold"�6,   Save XML file6M   �� 57   "   ><Saves the XML file which can be loaded back into the editor.6j   58      59      5;      �� 5<      6   	� 5=      -   5        
 	�Name$
 Draw_Button��5=       d� 	IsChecked$
 TrueY�63   .��5>      �� $��Images/write.png��6   $��32��66   $��32��6A   6O   	 5?      _� 5@      .��5A      �� .+�5B   "   �� $
��bold"�6,   Draw6D   �� 5C   "   " Allows you to draw onto the map.6N   5D      5E      5G      	� 5H      -   5        $
 Erase_button��5H      .��5I      �� $��Images/Eraser.png��6   $��32��67   $��32��6B   6P   	 5J      _� 5K      .��5L      �� .+�5M   "   �� $
��bold"�6,   Erase6E   �� 5N   "   ,*Deletes images on the map when clicked on.6X   5O      5P      5R      �� 5S      6   �� 5T      -   5        .��5U      �� $��Images/FileNew.png��6   $��32��68   $��32��6C   6Q   	 5V      _� 5W      .��5X      �� .+�5Y   "   �� $
��bold"�6,   New6C   �� 5Z   "   %#Clears the screen of previous work.6Q   5[      5\      5^      �� 5_      -   5        .��5`      �� $��Images/exit.png��6   $��32��65   $��32��6@   6N   	 5a      _� 5b      .��5c      �� .+�5d   "   �� $
��bold"�6,   Exit6D   �� 5e   "   Exits the application.6D   5f      5g      5i      5j      5k      �� 5m   
   $
��Auto=�6   $
��Auto=�6<   $��27,10,122,15q�6_   $��1��6u   $��Center=�6�   $	��688��6�   $��Center=�6�   $��Center=�6�   .��5n      �  � ShowGridLines . $��Center=�6)   $��Center=�6F   ��6a   ��  �� Path$ SetGridHeight� �� Mode$ TwoWay=���6�   �� $ SetGridWidth�$ TwoWay=�.+�5o      �� -	   5         ��Name$ mapTileCanvas��5o      $��0,0,0,42q�5p   w   $��Visible=�6�    � IsSharedSizeScope . $��Center=�6�   ��6   �� $ SetGridWidth�$ TwoWay=���6D   �� $ SetGridHeight�$ TwoWay=���5q      L� 5r       j� TileMode$
 Tile=�6'    j� Viewport$ 	0,0,32,32�5s       j� ViewportUnits$ Absolute=�5t       L� Drawing 5u      � 5v   "    � Geometry 5w   &   �� 5x   *    �� Rect$ 	0,0,34,34�6<   
 � Pen 5z   &   >� 5{   *    >� Brush
 ����� >� 	Thickness$ 1Q�6;   5}   #   5      5�      5�      5�      �� 5�   
   ���	#FF707070$��5q�6)   $��	0,52,10,0q�6=   ���	#00808080$��Right=�6g   $	��288��6�   $��2��6�   $��2��6�   $	��707��6�   $	��Top=�6�   �� 5�   
   ���	#FF707070$��5q�6)   $��
0,568,10,0q�6=   $��Right=�6Q   $	��288��6m   $��2��6y   $��1��6�   $	��135��6�   $	��Top=�6�   �� 5�   
   -
   5         ��Name$ SpriteSheetList��5�      $��Visible=�6,   $��Disabled=�6_   $��Center=�6�   $��0q�6�   $��2��6�   $	��277��6�   $	��567��6�   $	��277��6�   $��0,0,16,0q�6
  $��1��6  $��Right=�6)  $	��567��6E  $	��Top=�6R  ��5�      �� 5�      .R�5�      �  � Orientation$ 
Horizontal=�6    6=   5�      5�      �� 5�   
   -   5         ��Name$ MapList��5�      $��
0,573,14,0q�6#   $��2��67   $��1��6K   $��Right=�6X   $	��279��6t   $	��125��6�   $	��Top=�6�   .@�5�      c� $��104.667��6   $��252.63��6'   
�������$*��$Map Width:

Map Height:

Tile Width:��6I   $��Right=�6�   $��Center=�6�   $	��Top=�6�   .@�5�      �� $��0,0,0,0q�6   $	��100��6.   $��Bottom=�6;   .+�5�      %   Xceed.Wpf.Toolkit.IntegerUpDown  -   5          Name$ MapWidth��5�   -   $��0,10,0,0q�6n   �   �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 6?   �� $ 
BoundWidth�$ TwoWay=�6�     5�      -   5        $ 	MapHeight��5�   ,   $��0,10,0,0q�6o    6?   �� $ BoundHeight�$ TwoWay=�6�     5�      -   5        $ 	TileWidth��5�   >   ,   &Xceed.Wpf.Toolkit.Primitives.InputBase   
IsReadOnly . $��0,15,0,0q�6�    6R   �� $ BoundNumber�$ TwoWay=�6�   5�      �� 5�      $��10,0,0,0q�6   60   �� 5�      .+�5�      	� -   5        $
 layer1Button��5�   "   $��5q�68     	� 	GroupName$  layer��6C   $��Layer 1��6U   $
 TrueY�6g   	� 5�      -   5        $
 layer2Button��5�   "   $��5q�68   $  layer��6C   $��Layer 2��6U   	� 5�      -   5        $
 layer3Button��5�   "   $��5q�68   $  layer��6C   $��Layer 3��6U   	� 5�      -   5        $
 CollisionButton��5�   "   $��5q�6;   $  layer��6F   $��	Collision��6X   5�      �� 5�      .+�5�      � .+�5�      �� -   5        ! ��Name$! Layer1CheckBox��5�   #   $��Center=�6�   $��0,4.284,0,80.282q�6�    6P   �� $ Layer1Check�$ TwoWay=�6�   �� 5�      -   5        $! Layer2CheckBox��5�   #   $��Center=�6�   $��0,29.284,0,55.283q�6�    6P   �� $ Layer2Check�$ TwoWay=�6�   �� 5�      -   5        $! Layer3CheckBox��5�   #   $��Center=�6�   $��0,54.284,0,30.283q�6�    6P   �� $ Layer3Check�$ TwoWay=�6�   �� 5�      -   5        $! CollisionCheckBox��5�   #   $	��Top=�6�   $��0,79.284,0,0q�6�    6S   �� $ CollisionCheck�$ TwoWay=�6�   5�      5�      5�      5�      5�      5�      