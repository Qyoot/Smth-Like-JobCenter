   M S B A M L   `   `   `  ����F  BUITermPaper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:UITermPapper.AddWindowsUITermPapper.AddWindows  5   	   *    $UITermPapper.AddWindows.AddResumeWin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:UITermPapper.AddWindows     5   	     � Title$  AddResumeWin��5   	   $	��471��6   $	��837��6+   .��5	      � ���#505050 � RowDefinitions 5
   
   �� 5      $
��220* �6   �� 5      $
��220* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ CV_Person_Add��5      $	��200��6*   ���#646464   AutoGenerateColumns$ False��6L      CanUserAddRows$
 True��6h   $��150,15,10,5q�6    � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property	 P� Value
 �� Property �� Value��%j  '        �� 5      "  6    5      P� 5       �@ 
IsSelected$	 False��6E   . �5      �� 
 � �� �#6e6e6e6;   5      P� 5       �@ 
IsSelected$
	 True��6E   . �5      �� 
 � �� �#6e6e6e6;   5      P� 5       �@ 
IsSelected$
	 True��6E   . �5      �� 
 � ��
 �   �6<   5      5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6&   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *
First_Name+ �� ValidatesOnDataErrors$
 True��" �� ValidatesOnNotifyDataErrors$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�   ElementStyle 5       �� 5!      " ��6    .�5"      �� 
 �@�ToolTip 5#   1   ��  �� RelativeSource �� *Self+ �� Path$&  (Validation.Errors)/ErrorContent�5%      5'        5(      $ 	Last Name��6%    68   �� *Second_Name+$
 True��$
 True��$ PropertyChanged=� 5)      �� 5*      " ��6    .�5+      �� 
 �@�ToolTip 5,   1   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5.      50        51      $
 City��6&    64   �� *City+$
 True��$
 True��$ PropertyChanged=� 52      �� 53      " ��6    .�54      �� 
 �@�ToolTip 55   1   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�57      59        5:      $ Gender��6%    65   �� *Gender+$
 True��$
 True�� 5;      �� 5<      " ��6    .�5=      �� 
 �@�ToolTip 5>   1   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5@      5B      5D        5E   
   -   5        $ CV_Resume_Add��5E   Z   ���#646464$ False��6(   $
 True��6D   $��150,2,10,10q�6q   $��1��6�    5F      ��%j  '        �� 5G      "  6    5H      P� 5I       �@ 
IsSelected$	 False��6E   . �5J      �� 
 � �� �#6e6e6e6;   5K      P� 5L       �@ 
IsSelected$
	 True��6E   . �5M      �� 
 � �� �#6e6e6e6;   5N      P� 5O       �@ 
IsSelected$
	 True��6E   . �5P      �� 
 � ��
 �   �6<   5Q      5S      5T       5U        5V      $ Sphere��6%    65   �� *Sphere+$
 True��$
 True��$ PropertyChanged=� 5W      �� 5X      " ��6    .�5Y      �� 
 �@�ToolTip 5Z   E   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5\      5^        5_      $ 
Experience��6%    69   �� *
Experience+$
 True��$
 True��$ PropertyChanged=� 5`      �� 5a      " ��6    .�5b      �� 
 �@�ToolTip 5c   E   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5e      5g        5h      $ Expected Sallary��6%    6?   �� *Expected_sallary+$
 True��$
 True��$ PropertyChanged=� 5i      �� 5j      " ��6    .�5k      �� 
 �@�ToolTip 5l   I   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5n      5p      4  .System.Windows.Controls.DataGridCheckBoxColumn  5q      $ Higher Education��6)    6C   �� *Higher_education+$
 True��$
 True��$ PropertyChanged=�6�     5r      $ Eng Knowledge��6)    6@   �� *Eng_knowledge+$
 True��$
 True��$ PropertyChanged=�  5s      $ About Person��6%    6;   �� *About_person+$
 True��$
 True��$ PropertyChanged=�5u      �� 5v   
   $��2q�6   ���#6e6e6e$��2��6<   $��10,42,692,41q�6M   ._�5w      �� -   5        $��Add CV��5w      $	��100��6&   ���#6e6e6e���#5050506]   5x      5y      5z      