   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   
       UI.AddContract   5   
   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	   +BEclr-namespace:BE;assembly=BE     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   
     � Title$  AddContract��5
   	   $��594.326��6   $��1125.253��6.   .��5      � .+�5   
   �� -   5         ��Name$ button��5      $��30(�6"   
�������
���   �$	��ADD��6U   $
��Left=�6c   $��
23,462,0,0q�6~   $	��Top=�6�   $��98��6�   $��73��6�   6�   �� 5      -   5        $ button1��5      $
��Left=�6'   $��1007,462,0,0q�6B   $	��Top=�6X   $��73��6p   $��73��6{   ��5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��image/GoBack.png��6   $��69��66   $��70��6A    J� RenderTransformOrigin$ 0.245,0.508&�6M   5      5      � 5   
   -   5         �Name$ grid2��5      $
��Left=�6   $	��Top=�6:    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    �� 5$      $
��Auto �6    �� 5%      $
��Auto �6    �� 5&      $
��Auto �6    �� 5'      $
��Auto �6    .+�5)      �� $��Brut Salary:��6   
�������$��0��6>   $
��Left=�6N   $��3q�6i   $��0��6t   $��Center=�6�   �� 5*      -   5         ��Name$ brutSalaryTextBox��5*      $��1��61   $
��Left=�6A   $��23��6\   $��3q�6h   $��0��6s   $��Center=�6�   $	��120��6�   ��6�   �� *
BrutSalary+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6�   �� 5+      $��city:��6   
�������$��0��67   $
��Left=�6G   $��3q�6b   $��1��6m   $��Center=�6z   �� 5,      -   5         ��Name$ cityComboBox��5,      $��1��6-   $
��Left=�6=   $
��Auto��6X   $��3q�6�   $��1��6�   $��Center=�6�   $	��120��6�    �� SelectedItem 6f   �� *city+6�   �� 5-      $��Company Date Creation:��6   
�������$��0��6H   $
��Left=�6X   $��3q�6s   $��3��6~   $��Center=�6�   (  "System.Windows.Controls.DatePicker  5.      -   5          Name$$ companyDateCreationDatePicker1��5.      $��1��6A   $
��Left=�6Q   $��3q�6l   $��3��6w   $��Center=�6�      SelectedDate 6�   �� *CompanyDateCreation+$ TwoWay=�	 . 
 . 6�   �� 5/      $��Contract Is Signed:��6   
�������$��0��6E   $
��Left=�6U   $��3q�6p   $��4��6{   $��Center=�6�   �� 50      -   5         ��Name$ contractIsSignedCheckBox1��50      $�� ��6:   $��1��6E   $
��Left=�6U   $��3q�6�   $��4��6�   $��Center=�6�    d� 	IsChecked 6p   �� *ContractIsSigned+$ TwoWay=�	 . 
 . 6�   �� 51      $��Contract Number:��6   
�������$��0��6B   $
��Left=�6R   $��3q�6m   $��5��6x   $��Center=�6�   �� 52      -   5        $ contractNumberTextBox1��52      $��1��66   $
��Left=�6F   $��23��6a   $��3q�6m   $��5��6x   $��Center=�6�   $	��120��6  ��6�   �� *ContractNumber+$ TwoWay=�	 . 
 . 6  �� 53      $��Do Interview:��6   
�������$��0��6?   $
��Left=�6O   $��3q�6j   $��6��6u   $��Center=�6�   �� 54      -	   5        $ doInterviewCheckBox1��54      $�� ��65   $��1��6@   $
��Left=�6P   $��3q�6�   $��6��6�   $��Center=�6�    6k   �� *DoInterview+$ TwoWay=�	 . 
 . 6�   �� 55      $��Domain:��6   
�������$��0��69   $
��Left=�6I   $��3q�6d   $��7��6o   $��Center=�6|   �� 56      -
   5        $ domainComboBox��56      $��1��6/   $
��Left=�6?   $
��Auto��6Z   $��3q�6�   $��7��6�   $��Center=�6�   $	��120��6�    6h   �� *Domain+6�   �� 58      $��Employee Id:��6   
�������$��0��6>   $
��Left=�6N   $��3q�6i   $��8��6t   $��Center=�6�   �� 59      -   5        $ employeeIdTextBox1��59      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��8��6t   $��Center=�6�   $	��120��6�   ��6�   �� *
EmployeeId+$ TwoWay=�	 . 
 . 6�   �� 5:      $��Employer Id:��6   
�������$��0��6>   $
��Left=�6N   $��3q�6i   $��9��6t   $��Center=�6�   �� 5;      -   5        $ employerIdTextBox1��5;      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��9��6t   $��Center=�6�   $	��120��6�   ��6�   �� *
EmployerId+$ TwoWay=�	 . 
 . 6�   �� 5<      $��Hour Per Week:��6   
�������$��0��6@   $
��Left=�6P   $��3q�6k   $��10��6v   $��Center=�6�   �� 5=      -   5        $ hourPerWeekTextBox1��5=      $��1��63   $
��Left=�6C   $��23��6^   $��3q�6j   $��10��6u   $��Center=�6�   $	��120��6  ��6�   �� *HourPerWeek+$ TwoWay=�	 . 
 . 6  �� 5>      $��Job Begins:��6   
�������$��0��6=   $
��Left=�6M   $��3q�6h   $��11��6s   $��Center=�6�     5?      -   5        $ jobBeginsDatePicker1��5?      $��1��67   $
��Left=�6G   $��3q�6b   $��11��6m   $��Center=�6�    6{   �� *	JobBegins+$ TwoWay=�	 . 
 . 6�   �� 5@      $��Job Endsup:��6   $��0��6*   
�������$
��Left=�6M   $��3q�6h   $��12��6s   $��Center=�6�     5A      -   5        $ jobEndsupDatePicker1��5A      $��1��67   $
��Left=�6G   $��3q�6b   $��12��6m   $��Center=�6�    6{   �� *	JobEndsup+$ TwoWay=�	 . 
 . 6�   5B      &   System.Windows.Controls.DataGrid  5C   
   -   5          Name$ contractDataGrid��5C         
IsReadOnly .    AutoGenerateColumns .     EnableRowVirtualization . $��305,0,32,179q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6z   ��    Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      -   5        brutSalaryColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Brut Salary��5E   ^      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6s   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *
BrutSalary+6s     5F      -   5        
cityColumn��$
 city��5F   R   $ SizeToHeader 6`    69   �� *city+6`     5G      -   5        commissionColumn��$ 
Commission��5G   ^   $ SizeToHeader 6r    6?   �� *
Commission+6r   4  .System.Windows.Controls.DataGridTemplateColumn  5H      -   5        companyDateCreationColumn��$ Company Date Creation��5H   L   $ SizeToHeader 6k      CellTemplate 5I      �� 5J      .R�5K         6)   �� *CompanyDateCreation+$ TwoWay=�	 . 
 . 5L      5N      4  .System.Windows.Controls.DataGridCheckBoxColumn  5O      -   5        contractIsSignedColumn��$ Contract Is Signed��5O   n   $ SizeToHeader 6�    6I   �� *ContractIsSigned+6�     5P      -   5        contractNumberColumn��$ Contract Number��5P   f   $ SizeToHeader 6    6C   �� *ContractNumber+6     5Q      -   5        doInterviewColumn��$ Do Interview��5Q   d   $ SizeToHeader 6z    6D   �� *DoInterview+6z     5R      -   5        domainColumn��$ Domain��5R   V   $ SizeToHeader 6f    6;   �� *Domain+6f     5S      -   5        employeeIdColumn��$ Employee Id��5S   ^   $ SizeToHeader 6s    6?   �� *
EmployeeId+6s     5T      -   5        employerIdColumn��$ Employer Id��5T   ^   $ SizeToHeader 6s    6?   �� *
EmployerId+6s     5U      -   5        hourPerWeekColumn��$ Hour Per Week��5U   `   $ SizeToHeader 6w    6@   �� *HourPerWeek+6w     5V      -   5        jobBeginsColumn��$ 
Job Begins��5V   B   $ SizeToHeader 6V    5W      �� 5X      .R�5Y         6)   �� *	JobBegins+$ TwoWay=�	 . 
 . 5Z      5\        5]      -   5        jobEndsupColumn��$ 
Job Endsup��5]   B   $ SizeToHeader 6V    5^      �� 5_      .R�5`         6)   �� *	JobEndsup+$ TwoWay=�	 . 
 . 5a      5c        5d      -   5        netSalaryColumn��$ 
Net Salary��5d   \   $ SizeToHeader 6p    6>   �� *	NetSalary+6p   5f      ��5g   
   �� 5h      -   5        	Image�� �� ImageSource$ image/fondss.jpg��5h   )   5j      5k      