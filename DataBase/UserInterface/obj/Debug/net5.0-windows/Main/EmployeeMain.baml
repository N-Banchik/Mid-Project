   M S B A M L   `   `   `  ����H  DUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:UserInterface.MainUserInterface.Main  5   	   %    UserInterface.Main.EmployeeMain   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:UserInterface.Main     5   	     � Title$  EmployeeMain��5   	   $	��500��6   $	��800��6+   .��5	      � .+�5
   
   �� -   5         ��Name$ HelloBox��5
      $��2q�6$   $��Center=�6Q    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��800��6�    �� TextAlignment$ Center=�6�   $��16(�6�   �� 5   
   -   5         ��Name$ 	GetShifts��5      $��See all my shifts��6$   $
��Left=�6X   $��
656,30,0,0q�6s   $	��Top=�6�   $��68��6�   $	��134��6�   �� 5   
   -   5        $ 	Orderwork��5      $��Fulfill next Order��6$   $
��Left=�6Y   $��
360,30,0,0q�6t   $	��Top=�6�   $��68��6�   $	��134��6�   �� 5   
   -   5        $ Close��5      $��Close and end Shift��6    $
��Left=�6R   $��	10,30,0,0q�6m   $	��Top=�6�   $��53��6�   $	��113��6�   ���	#FFF17E7E6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	Shiftdata��5      $	��Top=�6&   $	��290��6>   $��	0,191,0,0q�6K   5      �� 5   
   -   5        $ EditInfo��5      $��Edit personal info��6#   $
��Left=�6W   $��
508,30,0,0q�6r   $	��Top=�6�   $��68��6�   $	��134��6�   5      5      