   M S B A M L   `   `   `  ����H  DUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:UserInterface.EmployeeAbilitysUserInterface.EmployeeAbilitys  5   	   >    8UserInterface.EmployeeAbilitys.PersonalInfoEdit_Employee   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:UserInterface.EmployeeAbilitys     5   	   -   5          � Title$  Personal Info��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ FirstNamebox��5
      $
��Left=�6(   $��
164,31,0,0q�6C   $�� ��6W    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��168��6�   $��19��6�   �� 5   
   -   5        $ Lastnamebox��5      $
��Left=�6'   $��
164,70,0,0q�6B   $�� ��6V   $
 Wrap=�6^   $	��Top=�6r   $	��168��6�   $��18��6�   �� 5   
   -   5        $ Emailbox��5      $
��Left=�6$   $��164,101,0,0q�6?   $�� ��6T   $
 Wrap=�6\   $	��Top=�6p   $	��168��6�   $��18��6�   �� 5   
   -   5        $ Phonebox��5      $
��Left=�6$   $��164,134,0,0q�6?   $�� ��6T   $
 Wrap=�6\   $	��Top=�6p   $	��168��6�   $��18��6�   �� 5   
   -   5        $ 	Streetbox��5      $
��Left=�6%   $��164,197,0,0q�6@   $�� ��6U   $
 Wrap=�6]   $	��Top=�6q   $	��168��6�   $��20��6�   �� 5   
   -   5        $ Housebox��5      $
��Left=�6$   $��164,237,0,0q�6?   $�� ��6T   $
 Wrap=�6\   $	��Top=�6p   $	��168��6�   $��19��6�   �� 5   
   -   5        $ Aptbox��5      $
��Left=�6"   $��164,267,0,0q�6=   $�� ��6R   $
 Wrap=�6Z   $	��Top=�6n   $	��168��6�   $��20��6�   �� 5   
   -	   5        $ Zipbox��5      $
��Left=�6"   $��526,237,0,0q�6=   $�� ��6R   $
 Wrap=�6Z   $	��Top=�6n   $	��168��6�   $��19��6�   �� 5   
   -
   5        $ Citybox��5      $
��Left=�6#   $��526,268,0,0q�6>   $�� ��6S   $
 Wrap=�6[   $	��Top=�6o   $	��168��6�   $��19��6�   �� 5   
   -   5         ��Name$ 	Updatebtn��5      $��Update��6<   $
��Left=�6M   $��226,354,0,0q�6h   $	��Top=�6}   $��57��6�   $	��132��6�   �� 5   
   $��First Name:��6   $
��Left=�6&   $��	10,31,0,0q�6A   $	��Top=�6T   �� 5   
   $��Email:��6   $
��Left=�6!   $��	10,93,0,0q�6<   $	��Top=�6O   $��68��6g   �� 5   
   $��Phone number:��6   $
��Left=�6(   $��
10,126,0,0q�6C   $	��Top=�6W   �� 5   
   $��Address:��6   $
��Left=�6#   $��
10,160,0,0q�6>   $	��Top=�6R   $��91��6j   �� 5   
   $��House number:��6   $
��Left=�6(   $��
10,230,0,0q�6C   $	��Top=�6W   �� 5   
   $��Apartment number:��6   $
��Left=�6,   $��
10,261,0,0q�6G   $	��Top=�6[   �� 5   
   $��
Last Name:��6   $
��Left=�6%   $��	10,62,0,0q�6@   $	��Top=�6S   �� 5   
   $��Street:��6   $
��Left=�6"   $��
10,192,0,0q�6=   $	��Top=�6Q   �� 5   
   $��Zipcode:��6   $
��Left=�6#   $��372,230,0,0q�6>   $	��Top=�6S   �� 5   
   $��City:��6   $��Center=�6    $��	0,261,0,0q�6=   $	��Top=�6P   G� 5   
   -   5         G�Name$ Passwordbox��5      $
��Left=�6+   $��
541,46,0,0q�6F   $	��Top=�6Z   $	��120��6r    � ToolTip$. (Password Must be between 8-12 characters��6~    G� PasswordChar$ *��6�   G� 5   
   -   5        $ Repasswordbox��5      $
��Left=�6-   $��541,104,0,0q�6H   $	��Top=�6]   $	��120��6u   $ *��6�   �� 5    
   $��Enter Password��6   $
��Left=�6)   $��
541,15,0,0q�6D   $	��Top=�6X   �� 5!   
   $��Re-Enter Password��6   $
��Left=�6,   $��
541,73,0,0q�6G   $	��Top=�6[   �� 5"   
   -   5        $ PassUpdatebtn��5"      $��Update password��6D   $
��Left=�6^   $��548,157,0,0q�6y   $	��Top=�6�   $��23��6�   $	��106��6�    �� 	IsDefault$
 True��6�   5$      5%      