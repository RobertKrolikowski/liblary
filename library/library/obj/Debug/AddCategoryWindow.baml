   M S B A M L   `   `   `  ����B  >library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:librarylibrary  5   	       library.AddCategoryWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:library     5   	   -   5          � Title$  addCategoryWindow��5   	   $	��300��6#   $	��400��60    � SizeToContent$ WidthAndHeight=�6<   $��20(�6[   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��10 �6   .+�5   
   �� -   5         ��Name$ categoryBlock��5      $��	Category:��6+   $��1��5      $��1��6$   $��5q�61   �� 5   
   -   5         ��Name$ categoryBox��5      $��2��6'   $��1��67   $��5q�5      $	��200��6   �� 5   
   -   5         ��Name$ 	addButton��5      $��2��6$   $��2��5      $	��Add��6   $��5q�6,   $	��100��67   6F   �� 5   
   -   5        $ 
backButton��5      $��3��6%   $��2��5      $
��Back��6   $��5q�6-   $	��100��68   6G   5      5       