   M S B A M L   `   `   `  ����F  BUITermPaper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:UITermPapper.AddWindowsUITermPapper.AddWindows  5   	   -    'UITermPapper.AddWindows.AddVacanciesWin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:UITermPapper.AddWindows     5   	     � Title$  AddVacanciesWin��5   	   $	��450��6!   $	��800��6.   .��5	      � ���#505050.+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid_Add_Firm��5
      ���#646464   AutoGenerateColumns$ False��6C      CanUserAddRows$
 True��6_   $��150,10,10,229q�6v    � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value	 �� Property
 �� Value��%j  '        �� 5      "  6    5      P� 5       �@ 
IsSelected$ False��6E   . �5      �� 	 � ��
 �#6e6e6e6;   5      P� 5       �@ 
IsSelected$
 True��6E   . �5      �� 	 � ��
 �#6e6e6e6;   5      P� 5       �@ 
IsSelected$
 True��6E   . �5      �� 	 � ��

 �   �6<   5      5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6&   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Name+ �� ValidatesOnDataErrors$
 True��" �� ValidatesOnNotifyDataErrors$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�   ElementStyle 5      �� 5      " ��6    .�5      �� 	 �@�ToolTip
 5   1   ��  �� RelativeSource �� *Self+ �� Path$&  (Validation.Errors)/ErrorContent�5!      5#        5$      $ Sphere��6%    65   �� *Sphere+$
 True��$
 True��$ PropertyChanged=� 5%      �� 5&      " ��6    .�5'      �� 	 �@�ToolTip
 5(   1   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5*      5,        5-      $ Company Size��6%    6;   �� *Quantity_of_employee+$
 True��$
 True��$ PropertyChanged=� 5.      �� 5/      " ��6    .�50      �� 	 �@�ToolTip
 51   1   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�53      55        56      $ 
Market Exp��6%    69   �� *Market_experience+$
 True��$
 True��$ PropertyChanged=� 57      �� 58      " ��6    .�59      �� 	 �@�ToolTip
 5:   1   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5<      5>      5@        5A   
   -   5        $ DataGrid_Add_Vacancy��5A      $
 True��64   $ False��6K      RowBackground �#6e6e6e$��150,210,10,10q�6�   ���#646464 5B      ��%j  '        �� 5C      "  6    5D      P� 5E       �@ 
IsSelected$ False��6E   . �5F      �� 	 � ��
 �#6e6e6e6;   5G      P� 5H       �@ 
IsSelected$
 True��6E   . �5I      �� 	 � ��
 �#6e6e6e6;   5J      P� 5K       �@ 
IsSelected$
 True��6E   . �5L      �� 	 � ��

 �   �6<   5M      5O      5P       5Q        5R      $ Sphere��6%    65   �� *Sphere+$
 True��$
 True��$ PropertyChanged=� 5S      �� 5T      " ��6    .�5U      �� 	 �@�ToolTip
 5V   I   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5X      5Z        5[      $ Sallary��6%    66   �� *	Sallary+$
 True��$
 True��$ PropertyChanged=� 5\      �� 5]      " ��6    .�5^      �� 	 �@�ToolTip
 5_   I   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5a      5c      4  .System.Windows.Controls.DataGridCheckBoxColumn  5d      $ Higher Education��6)    6C   �� *Higher_education+$
 True��$
 True��$ PropertyChanged=�  5e      $ Eng Knowledge��6)    6@   �� *Eng_knowledge+$
 True��$
 True��$ PropertyChanged=�  5f      $ 
Experience��6%    69   �� *
Experience+$
 True��$
 True��$ PropertyChanged=� 5g      �� 5h      " ��6    .�5i      �� 	 �@�ToolTip
 5j   I   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5l      5n        5o      $ Address��6%    66   �� *	Address+$
 True��$
 True��$ PropertyChanged=� 5p      �� 5q      " ��6    .�5r      �� 	 �@�ToolTip
 5s   I   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5u      5w      5y      �� 5z   
   $��2q�6   ���#6e6e6e$��10,42,675,41q�6;   ._�5{      �� -   5        $��Add CV��5{      $	��100��6&   ���#6e6e6e���#5050506]   5|      5}      5~      