   M S B A M L   `   `   `  ����H  DUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:UserInterface.EmployeeAbilitys.Manager.ItemsMenu0UserInterface.EmployeeAbilitys.Manager.ItemsMenu  5   	   ?    9UserInterface.EmployeeAbilitys.Manager.ItemsMenu.Itemmenu   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Plocal>clr-namespace:UserInterface.EmployeeAbilitys.Manager.ItemsMenu     5   	     � Title$  Itemmenu��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5
   
   �� -   5         ��Name$ Categorybox��5
      $
��Left=�6(   $��	10,49,0,0q�6C   $	��Top=�6V   $	��120��6n    �� DisplayMemberPath$ Category_Name��6�    �� SelectedValuePath$ Category_Name��6�   �� 5   
   -   5        $ Brandbox��5      $
��Left=�6%   $��
164,49,0,0q�6@   $	��Top=�6T   $	��120��6l   $ 
Brand_Name��6x   $ 
Brand_Name��6�   �� 5   
   $��	Item Name��6   $
��Left=�6$   $��
333,18,0,0q�6?   $	��Top=�6S   $��77��6k   �� 5   
   $��Category��6   $
��Left=�6#   $��	10,18,0,0q�6>   $	��Top=�6Q   $��93��6i   �� 5   
   $��Brand��6   $
��Left=�6    $��
164,18,0,0q�6;   $	��Top=�6O   $��67��6g   �� 5   
   -   5         ��Name$ Itemname��5      $
��Left=�6$   $��
333,49,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��120��6   $��22��6�   
���   �6�   �� 5   
   -   5         ��Name$ search��5      $��search��66   $
��Left=�6G   $��	30,95,0,0q�6b   $	��Top=�6u   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	ItemsShow��5      $��	0,141,0,0q�6&      AutoGenerateColumns$ False��69   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Item ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	Item_ID+  5      $
 	item name��6%    68   �� *	Item_Name+  5      $
 Category name��6%    6<   �� *Category.Category_Name+  5      $
 Brand��6%    64   �� *Brand.Brand_Name+  5      $
 Price��6%    64   �� *Price+  5      $
 Units in Inventory��6%    6A   �� *Units_In_Inventory+  5      $
 Minimum in Inventory��6%    6C   �� *Minimum_Units_In_Inventory+4  .System.Windows.Controls.DataGridTemplateColumn  5         HeaderTemplate 5      �� 5      .R�5      �� $��Action��6(   5         CellTemplate 5       �� 5!      .R�5"      ��  �� Orientation$ 
Horizontal=�6)   .+�5#   "   �� $ 	updateBtn��6)   -   5        $��Update��5#   <   6M   �� 5$   "   $ 	deleteBtn��6)   -   5        $��Delete��5$   <   6M   5%      5&      5(      5,      �� 5-   
   -   5        $ 
Additembtn��5-      $��	Add items��6>   $
��Left=�6R   $��
487,38,0,0q�6m   $	��Top=�6�   $��43��6�   $��71��6�   5/      50      