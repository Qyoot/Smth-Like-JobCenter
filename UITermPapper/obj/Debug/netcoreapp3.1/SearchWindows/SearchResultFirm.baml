   M S B A M L   `   `   `  ����F  BUITermPaper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:UITermPapper.SearchWindowsUITermPapper.SearchWindows  5   	   1    +UITermPapper.SearchWindows.SearchResultFirm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:UITermPapper.SearchWindows     5   	     � Title$  SearchResultFirm��5   	   $	��210��6"   $	��413��6/   .��5	      � $��0,0,0,-6q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid_Firm_Search��5
   �      CanUserAddRows$ False��6      CanUserDeleteRows$ False��6*      CanUserReorderColumns$ False��6D      
IsReadOnly$
 True��6b      AutoGenerateColumns$ False��6t      RowBackground �#6e6e6e���#6e6e6e � 	Resources 5      *  $System.Windows.Controls.DataGridCell	 �� 
TargetType
 �� Triggers P� Property P� Value �� Property �� Value��%j  '        �� 5      "	  6   
 5      P� 5       �@ 
IsSelected$ False��6E   . �5      ��  � �� �#6e6e6e6;   5      P� 5       �@ 
IsSelected$
 True��6E   . �5      ��  � �� �#6e6e6e6;   5      P� 5       �@ 
IsSelected$
 True��6E   . �5      ��  � ��
 �   �6<   5      5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6&   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Name+ �� ValidatesOnDataErrors$
 True��" �� ValidatesOnNotifyDataErrors$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�   ElementStyle 5      �� 5      "	 ��6    .�5      ��  �@�ToolTip 5   1   ��  �� RelativeSource �� *Self+ �� Path$&  (Validation.Errors)/ErrorContent�5!      5#        5$      $ Sphere��6%    65   �� *Sphere+$
 True��$
 True��$ PropertyChanged=� 5%      �� 5&      "	 ��6    .�5'      ��  �@�ToolTip 5(   1   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5*      5,        5-      $ Company Size��6%    6;   �� *Quantity_of_employee+$
 True��$
 True��$ PropertyChanged=� 5.      �� 5/      "	 ��6    .�50      ��  �@�ToolTip 51   1   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�53      55        56      $ 
Market Exp��6%    69   �� *Market_experience+$
 True��$
 True��$ PropertyChanged=� 57      �� 58      "	 ��6    .�59      ��  �@�ToolTip 5:   1   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5<      5>      5@      5A      5B      