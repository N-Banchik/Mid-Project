   M S B A M L   `   `   `  ����H  DUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:UserInterface.EmployeeAbilitys.Manager.BCMenu-UserInterface.EmployeeAbilitys.Manager.BCMenu  5   	   E    ?UserInterface.EmployeeAbilitys.Manager.BCMenu.BrandCategoryMenu   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Mlocal;clr-namespace:UserInterface.EmployeeAbilitys.Manager.BCMenu     5   	     � Title$  BrandCategoryMenu��5   	   $	��450��6#   $	��800��60   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��44* �6   �� 5      $
��173* �6    � ColumnDefinitions 5   
   �� 5      $	��80* �6   �� 5      $	��80* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Brands��5      $��1��6#   $��0,4,0,0q�60      AutoGenerateColumns$ False��6A      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
Brand_Id+  5      $
 Name��6%    63   �� *
Brand_Name+  5      $ Manufacturing Country��6%    6D   �� *Manufacturing_Country+4  .System.Windows.Controls.DataGridTemplateColumn  5         HeaderTemplate 5      �� 5      .R�5      �� $��Action��6(   5      	   CellTemplate	 5      �� 5      .R�5       �� 
 �� Orientation$
 
Horizontal=�6)   .+�5!   "   ��  ��Name$ updateBtnBrand��6)   -   5        $��Update��5!   A   6R   5"      5#      5%      5(        5*   
   -   5        $ Category��5*      $��1��6%   $��1��65   $��0,4,0,0q�6B   $ False��6S    5+        5,      $ ID��6%    61   �� *Category_ID+  5-      $
 Name��6%    63   �� *Category_Name+  5.      $ Description��6%    6:   �� *Description+  5/       50      �� 51      .R�52      �� $��Action��6(   53      	 55      �� 56      .R�57      �� $
 
Horizontal=�6)   .+�58   "   �� $ updateBtnCategory��6)   -   5        $��Update��58   D   6U   59      5:      5<      5?      �� 5@   
   -   5        $ 	SeeBrands��5@      $��
See Brands��6<   $
��Left=�6Q   $��7,63,0,0q�6l   $	��Top=�6~   $��77��6�   $��20��6�   �� 5A   
   -   5        $ SeeCategories��5A      $��See categories��6D   $
��Left=�6]   $��	23,63,0,0q�6x   $	��Top=�6�   $��90��6�   $��1��6�   $��20��6�   �� 5B   
   -   5        $ 	AddBrands��5B      $��Add new Brand��6<   $
��Left=�6T   $��
302,63,0,0q�6o   $	��Top=�6�   $��20��6�   $��85��6�   �� 5C   
   -   5        $ Addcategory��5C      $��Add new Category��6@   $
��Left=�6[   $��
288,63,0,0q�6v   $	��Top=�6�   $��1��6�   $��20��6�   $	��102��6�   5E      5F      