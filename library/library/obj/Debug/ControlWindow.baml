   M S B A M L   `   `   `  ����B  >library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:librarylibrary  5   	       library.ControlWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:library     5   	   -   5          � Title$  ControlWindow��5   	   $
��auto��6   $
��auto��6-    � SizeToContent$ WidthAndHeight=�6S   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��10 �6   .+�5   
   �� -   5         ��Name$ bookSearchButton��5      $��26(�6+   $��5q�5      $��1��6   $��1��6,   $��Book Search��5      $	��150��6'   $	��150��5      6    �� 5   
   -   5        $ bookAddButton��5      $��26(�6(   $��5q�5       $��2��6   $��1��6,   $��Book Add��5!      $	��150��6$   $	��150��5"      6!   �� 5#   
   -   5        $ bookLendedButton��5#      $��26(�6+   $��5q�5$      $��2��6   $��1��6,   $��Book Lended��5%      $	��150��6'   $	��150��5&      6!   �� 5)   
   -   5        $ personSearchButton��5)      $��26(�6-   $��5q�5*      $��1��6   $��2��6,   $��Person Search��5+      $	��150��6)   $	��150��5,      6!   �� 5-   
   -   5        $ personAddButton��5-      $��26(�6*   $��5q�5.      $��2��6   $��2��6,   $��
Person Add��5/      $	��150��6&   $	��150��50      6!   �� 52   
   -   5        $ logoutButton��52      $��26(�6'   $��5q�53      $��2��6   $��3��6,   $	��150��54      $	��150��6!   $��Logout��60   6A   57      58      