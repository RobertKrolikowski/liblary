   M S B A M L   `   `   `  ����B  >library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:librarylibrary  5   	       library.SearchBookWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:library     5   	   -   5          � Title$  
SearchBook��5   	   $	��720��6   $
��1278��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��10 �6   .+�5   
   �� -   5         ��Name$ 	searchBox��5      $��1��6%   $��4��65   $��1��5      $��5q�6   $	��300��6*   $��Search Book��69   $��26(�5      6    �� 5!   
   -   5         ��Name$ searchButton��5!      $��5��6'   $��1��67   $��5q�5"      $��Search��6   $��26(�6-   6;   �� 5#   
   -   5        $ 
backButton��5#      $��5��6%   $��4��65   $
��Back��5$      $��26(�6    $��5q�6.   69   �� 5%   
   -   5        $ removeButton��5%      $��2��6'   $��4��67   $��Delete��6D   $��5q�5&      $��26(�6   $	��100��6*   �� 5'   
   -   5        $ 
editButton��5'      $��3��6%   $��4��65   $
��Edit��6B   $��5q�5(      $��26(�6   $	��100��6*   5)      5+      