   M S B A M L   `   `   `  ����H  DUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullyAclr-namespace:UserInterface.EmployeeAbilitys.Manager.Employeemenu3UserInterface.EmployeeAbilitys.Manager.Employeemenu  5   	   A    ;UserInterface.EmployeeAbilitys.Manager.Employeemenu.EmpMenu   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   SlocalAclr-namespace:UserInterface.EmployeeAbilitys.Manager.Employeemenu     5   	     � Title$  EmpMenu��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ UserShow��5
      $��	0,140,0,0q�6%      AutoGenerateColumns$ False��68      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Costumer_ID+  5      $ 
First Name��6%    69   �� *
First_Name+  5      $ 	Last Name��6%    68   �� *	last_Name+  5      $ Date of Birth��6%    6<   �� *	Birthdate+  5      $ 	Hire Date��6%    68   �� *	Hire_Date+  5      $ Email��6%    64   �� *Email+  5      $ Phone Number��6%    6;   �� *Phone_Number+  5      $ Address��6%    66   �� *	Address+4  .System.Windows.Controls.DataGridTemplateColumn  5         HeaderTemplate 5      �� 5      .R�5      �� $��Action��6(   5         CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� 	 ��Name$	 	EmpOrders��6)   -   5        $��View Employee orders��5   <   6[   5       5!      5#      5%      �� 5&   
   -   5        $	 ShowUers��5&      $��
Show Users��6:   $
��Left=�6O   $��
647,88,0,0q�6j   $	��Top=�6~   $��34��6�   $��87��6�   �� 5'   
   $��By Id:��6   $
��Left=�6!   $��	29,10,0,0q�6<   $	��Top=�6O   $��27��6g   $	��105��6s   $��14(�6   �� 5(   
   -   5        
 ��Name$
 IDBox��5(      $
��Left=�6!   $��	29,42,0,0q�6<   $�� ��6O    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��128��6�   $��23��6�   $��14(�6�   �� 5)   
   $��By Name:��6   $
��Left=�6#   $��
183,10,0,0q�6>   $	��Top=�6R   $��27��6j   $	��105��6v   $��14(�6�   �� 5*   
   -   5        $
 NameBox��5*      $
��Left=�6#   $��
183,42,0,0q�6>   $�� ��6R   $
 Wrap=�6Z   $	��Top=�6n   $	��128��6�   $��23��6�   $��14(�6�   �� 5+   
   $��By Phone number:��6   $��Center=�6+   $��0,10,0,0q�6H   $	��Top=�6Z   $��27��6r   $	��128��6~   $��14(�6�   �� 5,   
   -   5        $
 Phonebox��5,      $��Center=�6$   $��0,42,0,0q�6A   $�� ��6S   $
 Wrap=�6[   $	��Top=�6o   $	��128��6�   $��23��6�   $��14(�6�   �� 5-   
   $��	By Email:��6   $
��Left=�6$   $��
486,10,0,0q�6?   $	��Top=�6S   $��27��6k   $	��128��6w   $��14(�6�   �� 5.   
   -   5        $
 EmailBox��5.      $
��Left=�6$   $��
486,42,0,0q�6?   $�� ��6S   $
 Wrap=�6[   $	��Top=�6o   $	��128��6�   $��23��6�   $��14(�6�   �� 5/   
   -   5        $	 NewEmp��5/      $��
Show Users��66   $
��Left=�6K   $��
550,88,0,0q�6f   $	��Top=�6z   $��34��6�   $��87��6�   51      52      