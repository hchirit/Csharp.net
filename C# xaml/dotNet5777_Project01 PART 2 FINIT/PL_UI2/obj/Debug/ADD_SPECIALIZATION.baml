   M S B A M L   `   `   `  ����?  ;BE-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BE;assembly=BE-1BE  5   �    PL_UI2-5"   PL_UI2.Window_specialization   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   -BEclr-namespace:BE;assembly=BE-1     6�     � Title$  Window_specialization��5   	    � WindowState$ 	Maximized=�6'   $	��303��6?   $��804.425��6L   .��5
      �  � RowDefinitions 5   
   �� 5      $
��194* �6   �� 5      $	��22* �6   �� 5      $	��35* �6   �� 5      $	��21* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DataGrid_s��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6(      
IsReadOnly . $��Stretch=�6J   $��256,10,28,0q�6f    J� RenderTransformOrigin$ 0.612,0.477&�6{   � 5   
   -   5         �Name$ grid1��5      $
��Left=�6   $��	18,10,0,0q�6:   $	��Top=�6M   $	��168��6e   $	��233��6r    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��discipline:��6   
�������$��0��6=   $��3,4,0,3q�6N   $��0��6_   $
��Left=�6l   $��Center=�6�   $��97��6�   �� 5       -   5        	 ��Name$	 disciplineComboBox��5       $��1��63   $
��Left=�5"      $
��Auto��5#      $��3q�5$      $��0��6"   $��Center=�5%      $	��120��5&      
 �� SelectedItem
 5!      �� *
discipline+5'      �� 5)      $��
expertise:��6   
�������$��0��6<   $
��Left=�6L   $��3,4,0,3q�6g   $��1��6x   $��Center=�6�   $��97��6�   �� 5*      -   5        $	 expertiseComboBox��5*      $��1��62   $
��Left=�5,      $
��Auto��62   $��3q�5-      $��1��6"   $��Center=�6/   $	��120��6J   
 5+      �� *	expertise+5/      �� 50      $��	max Wage:��6   
�������$��0��6;   $
��Left=�6K   $��3,4,0,3q�6f   $��2��6w   $��Center=�6�   $��97��6�   �� 51      -   5         ��Name$ maxWageTextBox��51      $��1��6.   $
��Left=�6>   $��23��6Y   $��3q�6e   $��2��6p   $��Center=�6�   $	��120��6�   ��6}   �� *	maxWage+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6�   �� 52      $��	min Wage:��6   
�������$��0��6;   $
��Left=�6K   $��3,4,0,3q�6f   $��3��6w   $��Center=�6�   $��97��6�   �� 53      -   5        $ minWageTextBox��53      $��1��6.   $
��Left=�6>   $��23��6Y   $��3q�6e   $��3��6p   $��Center=�6�   $	��120��6�   ��6}   �� *	minWage+$ TwoWay=� .  . 6�   �� 54      $��specialization id:��6   
�������$��0��6D   $
��Left=�6T   $��3q�6o   $��4��6z   $��Center=�6�   �� 55      -   5        $ specialization_idTextBox��55      $��1��68   $
��Left=�6H   $��23��6c   $��3q�6o   $��4��6z   $��Center=�6�   $	��120��6  ��6�   �� *specialization_id+$ TwoWay=� .  . 6  56      �� 57   
   -   5         ��Name$ button��57      $	��add��6!   
����  �$��30(�6A   $
��Left=�6O   $��76,0,0,0q�6j   $��2��6|   $	��126��6�   6�   �� 58   
   -	   5        $��2��58      $��
696,0,55,0q�6!   ��59      �� 5:       �� Orientation$ 
Horizontal=�6   .+�5;      �� $��images/return.png��6   $��32��67   $��22��6B   5<      5>      ��5?   
   
� 5@      .��5A      �  � Color$ SkyBlue��6    � Offset$ 0.918Q�6/   � 5B      $ 
WhiteSmoke��6   5C      5F      5H      