   M S B A M L   `   `   `  ����F  BUITermPaper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:UITermPapper.SearchWindowsUITermPapper.SearchWindows  5   	   3    -UITermPapper.SearchWindows.SearchResultResume   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:UITermPapper.SearchWindows     5   	     � Title$  SearchResultResumeWindow��5   	   $	��303��6*   $	��750��67   .��5	      � ���#505050$��0,0,0,-6q�6    .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SearchResult_DataGrid_CV��5   8      CanUserAddRows$ False��5
         CanUserDeleteRows$ False��6*      
IsReadOnly$
 True��6D      CanUserReorderColumns$ False��6V      AutoGenerateColumns$ False��6t      RowBackground �#6e6e6e���#6e6e6e � 	Resources 5      *  $System.Windows.Controls.DataGridCell	 �� 
TargetType
 �� Triggers P� Property P� Value �� Property �� Value��%j  '        �� 5      "	  6   
 5      P� 5       �@ 
IsSelected$ False��6E   . �5      ��  � �� �#6e6e6e6;   5      P� 5       �@ 
IsSelected$
 True��6E   . �5      ��  � �� �#6e6e6e6;   5      P� 5       �@ 
IsSelected$
 True��6E   . �5      ��  � ��
 �   �6<   5      5      5         Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5   6   ,  &System.Windows.Controls.DataGridColumn   Header$ Person��6M      CellTemplate 5   :   �� 5   >   .R�5   B   �� ��6L   ��  �� Path$ Person.FullName� � ToolTip 6t   �� $ Person.String�5    ?   5"   7   0  *System.Windows.Controls.DataGridTextColumn  5#   6   $ Sphere��6I   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Y   �� *Sphere+ �� ValidatesOnDataErrors$
 True��" �� ValidatesOnNotifyDataErrors$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�   ElementStyle 5$   :   �� 5%   >   "	 ��6D   .�5&   B   ��  �@�ToolTip 5'   E   ��  �� RelativeSource �� *Self+$&  (Validation.Errors)/ErrorContent�5)   ?   5+   7     5,   6   $ 
Experience��6J    6^   �� *
Experience+$
 True��$
 True��$ PropertyChanged=� 5-   :   �� 5.   >   "	 ��6D   .�5/   B   ��  �@�ToolTip 50   E   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�52   ?   54   7     55   6   $ Expected Sallary��6I    6c   �� *Expected_sallary+$
 True��$
 True��$ PropertyChanged=� 56   :   �� 57   >   "	 ��6D   .�58   B   ��  �@�ToolTip 59   I   ��  �� *Self+$&  (Validation.Errors)/ErrorContent�5;   ?   5=   7   4  .System.Windows.Controls.DataGridCheckBoxColumn  5>   6   $ Higher Education��6M    6g   �� *Higher_education+$
 True��$
 True��$ PropertyChanged=�6�     5?   6   $ Eng Knowledge��6M    6d   �� *Eng_knowledge+$
 True��$
 True��$ PropertyChanged=�  5@   6   $ About Person��6I    6_   �� *About_person+$
 True��$
 True��$ PropertyChanged=�5B      5C      5D      