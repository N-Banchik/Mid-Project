   M S B A M L   `   `   `  ����H  DUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:UserInterface.UserAbilitysUserInterface.UserAbilitys  5   	   0    *UserInterface.UserAbilitys.User_viewOrders   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:UserInterface.UserAbilitys     5   	     � Title$  User_viewOrders��5   	   $	��450��6!   $	��800��6.   .��5	      ]� .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ OrderViewer��5
      $��0,0,0,34q�6(   $	��434��6:      AutoGenerateColumns$ False��6G      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
Order_ID+  5      $ 
Order Date��6%    69   �� *
Order_Date+  5      $ 	Ship Date��6%    68   �� *	Ship_Date+  5      $ 
Total Cost��6%    69   �� *
Total_Cost+  5      $ Total Weight��6%    6;   �� *Total_Weiget+  5      $ Address��6%      
IsReadOnly$
 True��6[    66   �� *Costumer_Address+6[   4  .System.Windows.Controls.DataGridTemplateColumn  5         HeaderTemplate 5      �� 5      .R�5      �� $��Details��6(   5         CellTemplate 5      �� 5      .R�5      �� 	 �� Orientation$	 
Horizontal=�6)   .+�5   "   �� 
 ��Name$
 Details��6)   -   5        $��Show Details��5   :   6Q   5      5      5      5!      5"      5#      