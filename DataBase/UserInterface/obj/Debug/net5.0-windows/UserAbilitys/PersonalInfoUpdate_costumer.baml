   M S B A M L   `   `   `  ����H  DUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:UserInterface.UserAbilitysUserInterface.UserAbilitys  5   	   <    6UserInterface.UserAbilitys.PersonalInfoUpdate_costumer   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:UserInterface.UserAbilitys     5   	   -   5          � Title$!  PersonalInfoUpdate_costumer��5   	   $	��450��6-   $	��800��6:   .��5	      � .+�5
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
   -   5         ��Name$ 	Updatebtn��5      $��Update��6<   $
��Left=�6M   $��226,354,0,0q�6h   $	��Top=�6}   $��57��6�   $	��132��6�   �� 5   
   $��First Name:��6   $
��Left=�6&   $��	10,31,0,0q�6A   $	��Top=�6T   �� 5   
   $��Email:��6   $
��Left=�6!   $��	10,93,0,0q�6<   $	��Top=�6O   $��68��6g   �� 5   
   $��Phone number:��6   $
��Left=�6(   $��
10,126,0,0q�6C   $	��Top=�6W   �� 5   
   $��
Addresses:��6   $
��Left=�6%   $��
10,160,0,0q�6@   $	��Top=�6T   $��91��6l   �� 5   
   $��
Last Name:��6   $
��Left=�6%   $��	10,62,0,0q�6@   $	��Top=�6S   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Addressgrid��5      $��10,191,10,106q�6)      AutoGenerateColumns$ False��6@      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Street Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *Street_Name+  5      $ House number��6%    6;   �� *House_Number+  5      $ Apartment Number��6%    6?   �� *Apartment_Number+  5      $ Zipcode��6%    66   �� *	Zipcode+  5      $
 City��6%    63   �� *City+4  .System.Windows.Controls.DataGridTemplateColumn  5      	   HeaderTemplate	 5      �� 5      .R�5      �� $��Action��6(   5      
   CellTemplate
 5!      �� 5"      .R�5#      ��  �� Orientation$ 
Horizontal=�6)   .+�5$   "   �� $ 	insertBtn��6)   -   5        $��Insert��5$   <   6M   �� 5%   "   $ 	updateBtn��6)   -	   5        $��Update��5%   <   6M   �� 5&   "   $ 	deleteBtn��6)   -
   5        $��Delete��5&   <   6M   5'      5(      5*      5,      G� 5-   
   -   5         G�Name$ Passwordbox��5-      $
��Left=�6+   $��
575,39,0,0q�6F   $	��Top=�6Z   $	��120��6r    � ToolTip$. (Password Must be between 8-12 characters��6~    G� PasswordChar$ *��6�   G� 5.   
   -   5        $ Repasswordbox��5.      $
��Left=�6-   $��
575,97,0,0q�6H   $	��Top=�6\   $	��120��6t   $ *��6�   �� 5/   
   $��Enter Password��6   $
��Left=�6)   $��	575,8,0,0q�6D   $	��Top=�6W   �� 50   
   $��Re-Enter Password��6   $
��Left=�6,   $��
575,66,0,0q�6G   $	��Top=�6[   �� 51   
   -   5        $ PassUpdatebtn��51      $��Update Password��6D   $
��Left=�6^   $��575,150,0,0q�6y   $	��Top=�6�   $��23��6�   $��90��6�    �� 	IsDefault$
 True��6�   52      53      