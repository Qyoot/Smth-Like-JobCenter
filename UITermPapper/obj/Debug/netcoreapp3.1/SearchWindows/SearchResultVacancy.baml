   M S B A M L   `   `   `  ����F  BUITermPaper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:UITermPapper.SearchWindowsUITermPapper.SearchWindows  5   	   4    .UITermPapper.SearchWindows.SearchResultVacancy   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:UITermPapper.SearchWindows     5   	     � Title$  SearchResultVacancyWindow��5   	   $	��332��6+   $	��651��68   .��5	      � ���#505050$��0,0,0,0q�6    .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$# SearchResult_DataGrid_Vacancy��5   8      CanUserAddRows$ False��5
         CanUserDeleteRows$ False��6+      CanUserReorderColumns$ False��6E      AutoGenerateColumns$ False��6c      RowBackground �#6e6e6e���#6e6e6e$��0,0,0,0q�5   u   $��2��6�    � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType	 �� Triggers
 P� Property P� Value �� Property �� Value��%j  '        �� 5      "  6   	 5      P� 5      
 �@ 
IsSelected$ False��6E   . �5      ��  � �� �#6e6e6e6;   5      P� 5      
 �@ 
IsSelected$
 True��6E   . �5      ��  � �� �#6e6e6e6;   5      P� 5      
 �@ 
IsSelected$
 True��6E   . �5      ��  � ��
 �   �6<   5      5      5         Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Firm��6)      CellTemplate 5      �� 5      .R�5      �� ��6(   ��  �� Path$ 	Firm.Name� � ToolTip 6J   �� $ Firm.String�5       5"      0  *System.Windows.Controls.DataGridTextColumn  5#      $ Sphere��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Sphere+ �� ValidatesOnDataErrors$
 True��" �� ValidatesOnNotifyDataErrors$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�   ElementStyle 5$      �� 5%      " ��6    .�5&      ��  �@�ToolTip 5'   I   ��  �� RelativeSource �� *Self+$&  (Validation.Errors)/ErrorContent�5)      5+        5,      $ Sallary��6%    66   �� *	Sallary+$
 True��$
 True��$ PropertyChanged=� 5-      �� 5.      " ��6    .�5/      ��  �@�ToolTip 50   I   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�52      54      4  .System.Windows.Controls.DataGridCheckBoxColumn  55      $ Higher Education��6)    6C   �� *Higher_education+$
 True��$
 True��$ PropertyChanged=�  56      $ Eng Knowledge��6)    6@   �� *Eng_knowledge+$
 True��$
 True��$ PropertyChanged=�  57      $ 
Experience��6%    69   �� *
Experience+$
 True��$
 True��$ PropertyChanged=� 58      �� 59      " ��6    .�5:      ��  �@�ToolTip 5;   I   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5=      5?        5@      $ Address��6%    66   �� *	Address+$
 True��$
 True��$ PropertyChanged=� 5A      �� 5B      " ��6    .�5C      ��  �@�ToolTip 5D   I   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5F      5H      5J      5K      5L      