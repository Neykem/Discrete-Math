   M S B A M L   `   `   `  ����H  DDiscrete Math, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Discrete_MathDiscrete_Math  5   	       Discrete_Math.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Discrete_Math     5   	   -   5          � Title$  
MainWindow��5   	   $	��470��6   $
��700.��6)    � 
ResizeMode$ NoResize=�66    � WindowStyle$
 None=�6L    � WindowStartupLocation$ CenterScreen=�5	   :    � 	Resources 5
       �� 
TargetType 
  Button  TemplateButtonClose  TemplateButtonHidden  TemplateButtonMinimized  TemplateButtonCommon��%�  &	        &	 !     &	 �     &	 s    &	     �� 5   
   " ��6   5      �� 5   
   " ��6   .R�5      � .+�5      A� ���	#FFFF4C306-   �� 5      #��z��6   $��Center=�6<   $��Center=�5       6=   5      5      �� 5   
   " ��6   .R�5      � .+�5      A� ���	#FFFF9B236-   �� 5      #��z��6   $��Center=�6<   $��Center=�5       6=   5      5      �� 5   
   " ��6   .R�5      � .+�5      A� ���	#FF30B4FF6-   �� 5      #��z��6   $��Center=�6<   $��Center=�5       6=   5       5!      �� 5"   
   " ��6   .R�5#      � ��6   Z� .+�5%      �� ���	#FF4D4D4D$��0,0,0,5q�61   
�������._�5&      �� $��5q�6%   $��Center=�60   $��Center=�6M   5'      �� 5)      #��z��6   $��Center=�6<   $��Center=�5*       
���   �$��Segoe UI)�6d   $��14(�6z   $��Normal"�6�   ��6;   Z� 6�   5+      5,      5-      .��5/      � $��0,20,0,0q�6   
������� � ColumnDefinitions 51   
   �� 52      .+�56   
   �� $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $��	UtterForm��6V   $	��Top=�6g   $��24(�6   $��Segoe UI Symbol)�6�   ��6�   Z� 6�   �� 57   
   -   5        $��
ButtonPSNF��57   B   #��[ 6   $��СКНФ��6U   $��553,208,27,197q�6d   $��Center=�6|   $	��120��6�   $
��Bold"�6�   $��45��6�   $��Center=�6�    K� ZIndex$ 2��6�   �� 58   
   -   5        $��
ButtonMenu��58      $��Center=�6#   $��652,10,10,402q�6@   $��Center=�6W   $��38��6r   $��38��6}   ���	#FF252525$ 5��6�   ��6�   Z�  J� OpacityMask 5:      �� 5;      	 �� ImageSource$	 menuButton.png��6   5=      �� 5?   
   -   5        $��ButtonCalcPDNF��5?   B   #��[ 6   $��СДНФ��6X   $��553,158,27,247q�6g   $��Center=�6   $	��120��6�   $
��Bold"�6�   $��45��6�   $��Center=�6�   $ 2��6�   �� 5@   
   -   5        $��ButtonTruthTable��5@   B   #��[ 6   $��Таблица Ист-и��6[   $��553,108,27,297q�6s   $��Center=�6�   $	��120��6�   $
��Bold"�6�   $��45��6�   $��Center=�6�   
�������
 J� SnapsToDevicePixels
 . $ 2��6Q  ��6  Z� 6Q  �� 5A   
   -   5        $��ButtonSaveTXT��5A   B   #��[ 6   $$��Сохранить файл...��6W   $��553,369,0,36q�6s   $
��Left=�6�   $	��120��6�   $
��Bold"�6�   $ 2��6�   � 5B   
   $��0,-20,0,450q�6   
�������$��20��67   $��Center=�6C   $��Center=�6^   $	��700��6{   $ 7��6�    J� Effect 5C      3  -System.Windows.Media.Effects.DropShadowEffect  5D         Opacity$	 0.3Q�6#      
BlurRadius$ 20Q�61      	Direction$	 270Q�6A   5F      �� 5G   
   -   5        $��ButtonClose��5G   A   #��[ 6   $
��Left=�6T   $��681,-18,0,0q�6o   $	��Top=�6�   $��15��6�   $��15��6�   $��0q�6�   $ 8��6
  ��6�   Z� ��6�   Z� ��6�   Z� 6  �� 5H   
   -   5        $��ButtonHidden��5H   E   #��[ 6   $�� ��6Y   $
��Left=�6d   $��663,-18,0,453q�6   $��15��6�   $��15��6�   $��Bottom=�6�   ���	#FFFFB415$ 8��6�   6�   �� 5I   
   -	   5        $��ButtonMinimized��5I   B   #��[ 6   $�� ��6Y   $
��Left=�6d   $��645,-18,0,0q�6   $	��Top=�6�   $��15��6�   $��15��6�   $ 8��6�   6�   �� 5J   
   -
   5        $��TextBoxContent��5J      $
��Left=�6(   $��5q�6C   $	��356��6O   $��	10,84,0,0q�6\    �� TextWrapping$
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��517��6�   ���	#FFFFFCFC
�������
���   � �� SelectionBrush �	#FF5F5F5F �� TextDecorations 6�   Z� .��6#   5K        5L      $	 0.1Q�6#   $ 0Q�61   $ 10Q�6?   .��5M      5N      �� 5O   
   $
��Left=�6   $��2��6/   $��	10,42,0,0q�6:   ���	#FF1F1F1F$	��Top=�6`   $	��517��6x   ��5P      
� 5Q      .��5S      �  � Color$ 	#FF0F0F0F��5T       � Offset$ 0Q�6#   � 5U      $ 	#FF1D1D1D��5V      $ 1Q�6#   5W      5Y      � 5Z   
   -   5        $��GridMenu��5Z      $
��Left=�6   $	��453��6:   $��
532,-3,0,0q�6G   $	��Top=�6[   $	��168��6s   
�������$ -4��6�   � 5[   
    � RowDefinitions 5\      �� 5]      �� 5^      $
��Auto �6    .+�5`      &   System.Windows.Controls.DataGrid  -   5        $��DataGridCommon��5`         AutoGenerateColumns .  $��0��5a      $��543,63,10,58q�6   $y�Hidden=�62   ��5`   -   �� *Elements[Item]+   Columns 5b      0  *System.Windows.Controls.DataGridTextColumn  5c      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5d      �� *Attribute[ID].Value+  5e      $ Название��6)    5f      �� *Attribute[Name].Value+  5g      $ H1��6)    5h      �� *Attribute[N1].Value+  5i      $ H2��6)    5j      �� *Attribute[N2].Value+5l      �� 5m      -   5        $��ButtonMenuAdd��5m      #��[ 6*   $��Добавить��6[   $��557,397,23,10q�6~   $��10(�6�   $y�Hidden=�6�   5n      �� 5o   
   -   5        $��TextBoxName��5o       �� Padding$ 5q�6'   $
��Left=�63   $��	10,52,0,0q�6N   $�� ��6a   $	��Top=�6i   $��27��6�   $	��517��6�   
�������$
��Wrap=�6�    5p        5q      $ 10Q�6#   $	 0.1Q�63   $ 0Q�6A   5s      �� 5t   
   -   5         ��Name$ ButtonClear��5t   B   #��[ 6   $��Очистить��6X   $��553,258,27,147q�6k   $��Center=�6�   $	��120��6�   $
��Bold"�6�   $��45��6�   $��Center=�6�   $ 2��6�   5u      5v      