   M S B A M L   `   `   `  ����H  DUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:UserInterface.EmployeeAbilitys.Manager&UserInterface.EmployeeAbilitys.Manager  5   	   6    0UserInterface.EmployeeAbilitys.Manager.ShiftMenu   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:UserInterface.EmployeeAbilitys.Manager     5   	     � Title$  	ShiftMenu��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	ShiftShow��5
      $��	0,151,0,0q�6&   $��14(�69      AutoGenerateColumns$ False��6G      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Employee.ID+  5      $ 
First Name��6%    69   �� *Employee.First_Name+  5      $ 	Last Name��6%    68   �� *Employee.last_Name+  5      $ Shift Start��6%    6:   �� *Shift_Start+  5      $ 	Shift End��6%    68   �� *	Shift_End+4  .System.Windows.Controls.DataGridTemplateColumn  5         HeaderTemplate 5      �� 5      .R�5      �� $��Action��6(   5         CellTemplate 5      �� 5      .R�5      ��  ��Name$ Employeeinfo��6%   -   5        $��Show Employee info��5   ;   6X   5      5      5      (  "System.Windows.Controls.DatePicker  5    
   -   5        	  Name$	 	StartDate��5       $
��Left=�6(   $��	10,58,0,0q�6C   $	��Top=�6V   $	��113��6n     5!   
   -   5        $	 EndDate��5!      $
��Left=�6&   $��
142,58,0,0q�6A   $	��Top=�6U   $	��113��6m   �� 5"   
   -   5        
 ��Name$

 ById��5"      $
��Left=�6    $��
280,61,0,0q�6;    �� TextWrapping$
 Wrap=�6O   $	��Top=�6c   $	��120��6{   $��21��6�   �� 5#   
   $��
From Date:��6   $
��Left=�6%   $��	10,22,0,0q�6@   $	��Top=�6S   $	��113��6k   �� 5$   
   $��To Date:��6   $
��Left=�6#   $��
142,22,0,0q�6>   $	��Top=�6R   $	��113��6j   �� 5%   
   $	��ID:��6   $
��Left=�6   $��
280,22,0,0q�69   $	��Top=�6M   $	��113��6e   �� 5&   
   -   5        $ Search��5&      $��Search��66   $
��Left=�6G   $��
10,120,0,0q�6b   $	��Top=�6v   $��26��6�   $��96��6�   �� 5'   
   -   5        $ 	ShowToday��5'      $��Show on now��6<   $
��Left=�6R   $��142,120,0,0q�6m   $	��Top=�6�   $��26��6�   $��96��6�   5(      5)      