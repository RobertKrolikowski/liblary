   M S B A M L   `   `   `  ����B  >library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:librarylibrary  5   	       library.AddAuthorWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:library     5   	   -   5          � Title$  	AddAuthor��5   	   $	��300��6   $	��400��6(   $��20(�64    � SizeToContent$ WidthAndHeight=�6B   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��10 �6   .+�5   
   �� -   5         ��Name$ firstNameBlock��5      $��First Name:��6,   $��1��5      $��1��6$   $��5q�61   �� 5   
   -   5         ��Name$ firstNameBox��5      $��2��6(   $��1��68   $��5q�5      $	��200��6   �� 5   
   -   5        $ lastNameBlock��5      $��
Last Name:��6+   $��1��5      $��2��6$   $��5q�61   �� 5    
   -   5        $ lastNameBox��5       $��2��6'   $��2��67   $��5q�5!      $	��200��6   �� 5"   
   -   5        $ countryBlock��5"      $��Country:��6*   $��1��5#      $��3��6$   $��5q�61   $��Right=�6<   �� 5$   
   -   5        $ 
countryBox��5$      $��2��6&   $��3��66   $��5q�5%      $	��200��6   �� 5'   
   -   5         ��Name$ 	addButton��5'      $��1��6$   $��2��64   $��5��5(      $	��Add��6   $��5q�6,   $	��100��67   6F   �� 5)   
   -	   5        $ 
backButton��5)      $��3��6%   $��5��5*      $
��Back��6   $��5q�6-   $	��100��68   6G   5+      5,      