   M S B A M L   `   `   `  ����H  DUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:UserInterface.EmployeeAbilitys.Manager&UserInterface.EmployeeAbilitys.Manager  5   	   6    0UserInterface.EmployeeAbilitys.Manager.OrderMenu   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:UserInterface.EmployeeAbilitys.Manager     5   	     � Title$  	OrderMenu��5   	   $	��500��6   $	��900��6(    � SizeToContent$ Width=�64   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	OrderShow��5
      $��	0,114,0,0q�6&   $��14(�69      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Order ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
Order_ID+  5      $ Costumer Name��6%    6<   �� *costumer.Costumer_Name+  5      $ 
Order Date��6%    69   �� *
Order_Date+  5      $ 	Ship Date��6%    68   �� *	Ship_Date+  5      $ Costumer Address��6%    6?   �� *Costumer_Address+  5      $ Handling Employee��6%    6@   �� *Employee_ID+  5      $ 
Total Cost��6%    69   �� *
Total_Cost+  5      $ Total Wight��6%    6:   �� *Total_Weiget+4  .System.Windows.Controls.DataGridTemplateColumn  5         HeaderTemplate 5      �� 5      .R�5      �� $��Action��6(   5         CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� 	 ��Name$	 ShowOrderDetails��6)   -   5        $��Show Items On order��5   C   6a   5      5       5"      5$      (  "System.Windows.Controls.DatePicker  5%   
   -   5        
  Name$
 	StartDate��5%      $
��Left=�6(   $��2,36,0,0q�6C   $	��Top=�6U   $	��113��6m      Text$  ��6y     5&   
   -   5        $
 EndDate��5&      $
��Left=�6&   $��
134,36,0,0q�6A   $	��Top=�6U   $	��113��6m   �� 5'   
   -   5         ��Name$
 ById��5'      $
��Left=�6    $��
272,39,0,0q�6;    �� TextWrapping$
 Wrap=�6O   $	��Top=�6c   $	��120��6{   $��21��6�   �� 5(   
   -   5        $ orderid��5(      $
��Left=�6#   $��
400,39,0,0q�6>   $
 Wrap=�6R   $	��Top=�6f   $	��120��6~   $��21��6�   �� 5)   
   $��
From Date:��6   $
��Left=�6%   $��2,0,0,0q�6@   $	��Top=�6Q   $	��113��6i   �� 5*   
   $��To Date:��6   $
��Left=�6#   $��	134,0,0,0q�6>   $	��Top=�6Q   $	��113��6i   �� 5+   
   $��costumer ID:��6   $
��Left=�6'   $��	272,0,0,0q�6B   $	��Top=�6U   $	��113��6m   �� 5,   
   $��	Order Id:��6   $
��Left=�6$   $��	400,0,0,0q�6?   $	��Top=�6R   $	��113��6j   �� 5-   
   -   5        $	 Search��5-      $��Search��66   $
��Left=�6G   $��2,65,0,0q�6b   $	��Top=�6t   $��26��6�   $��96��6�   5/      50      