   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       UI.UpdateContract   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  UpdateContract��5	   	   $��605.471��6    $��1135.164��61   .��5
      � .+�5   
   �� -   5         ��Name$ button��5      $��36(�6"   
���  ��
���   �$��Update��6W   $
��Left=�6h   $��
23,462,0,0q�6�   $	��Top=�6�   $	��125��6�   $��73��6�   6�   �� 5   
   -   5        $ button1��5      $
��Left=�6#   $��1007,462,0,0q�6>   $	��Top=�6T   $��73��6l   $��73��6w   ��5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��image/GoBack.png��6   $��69��66   $��70��6A    J� RenderTransformOrigin$ 0.245,0.508&�6M   5      5      � 5   
   -   5         �Name$ grid2��5      $
��Left=�6   $	��Top=�6:    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
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
��Auto �6    .+�5(      �� $��Brut Salary:��6   
�������$��0��6>   $
��Left=�6N   $��3q�6i   $��0��6t   $��Center=�6�   �� 5)      -   5         ��Name$ brutSalaryTextBox��5)      $��1��61   $
��Left=�6A   $��23��6\   $��3q�6h   $��0��6s   $��Center=�6�   $	��120��6�   ��6�   �� *
BrutSalary+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6�   �� 5*      $��city:��6   
�������$��0��67   $
��Left=�6G   $��3q�6b   $��1��6m   $��Center=�6z   �� 5+      -   5         ��Name$ cityComboBox��5+      $��1��6-   $
��Left=�6=   $
��Auto��6X   $��3q�6�   $��1��6�   $��Center=�6�   $	��120��6�    �� SelectedItem 6f   �� *city+6�   �� 5,      $��Company Date Creation:��6   
�������$��0��6H   $
��Left=�6X   $��3q�6s   $��3��6~   $��Center=�6�   (  "System.Windows.Controls.DatePicker  5-      -   5          Name$$ companyDateCreationDatePicker1��5-      $��1��6A   $
��Left=�6Q   $��3q�6l   $��3��6w   $��Center=�6�      SelectedDate 6�   �� *CompanyDateCreation+$ TwoWay=�	 . 
 . 6�   �� 5.      $��Contract Is Signed:��6   
�������$��0��6E   $
��Left=�6U   $��3q�6p   $��4��6{   $��Center=�6�   �� 5/      -   5         ��Name$ contractIsSignedCheckBox1��5/      $�� ��6:   $��1��6E   $
��Left=�6U   $��3q�6�   $��4��6�   $��Center=�6�    d� 	IsChecked 6p   �� *ContractIsSigned+$ TwoWay=�	 . 
 . 6�   �� 50      $��ID to update:��6   $��16(�6,   
���  ��$��0��6N   $
��Left=�6^   $��3q�6y   $��5��6�   $��Center=�6�   �� 51      -   5        $ contractNumberTextBox1��51      $��1��66   $
��Left=�6F   $��23��6a   $��3q�6m   $��5��6x   $��Center=�6�   $	��120��6  ��6�   �� *ContractNumber+$ TwoWay=�	 . 
 . 6  �� 52      $��Do Interview:��6   
�������$��0��6?   $
��Left=�6O   $��3q�6j   $��6��6u   $��Center=�6�   �� 53      -	   5        $ doInterviewCheckBox1��53      $�� ��65   $��1��6@   $
��Left=�6P   $��3q�6�   $��6��6�   $��Center=�6�    6k   �� *DoInterview+$ TwoWay=�	 . 
 . 6�   �� 54      $��Domain:��6   
�������$��0��69   $
��Left=�6I   $��3q�6d   $��7��6o   $��Center=�6|   �� 55      -
   5        $ domainComboBox��55      $��1��6/   $
��Left=�6?   $
��Auto��6Z   $��3q�6�   $��7��6�   $��Center=�6�   $	��120��6�    6h   �� *Domain+6�   �� 57      $��Employee Id:��6   
�������$��0��6>   $
��Left=�6N   $��3q�6i   $��8��6t   $��Center=�6�   �� 58      -   5        $ employeeIdTextBox1��58      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��8��6t   $��Center=�6�   $	��120��6�   ��6�   �� *
EmployeeId+$ TwoWay=�	 . 
 . 6�   �� 59      $��Employer Id:��6   
�������$��0��6>   $
��Left=�6N   $��3q�6i   $��9��6t   $��Center=�6�   �� 5:      -   5        $ employerIdTextBox1��5:      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��9��6t   $��Center=�6�   $	��120��6�   ��6�   �� *
EmployerId+$ TwoWay=�	 . 
 . 6�   �� 5;      $��Hour Per Week:��6   
�������$��0��6@   $
��Left=�6P   $��3q�6k   $��10��6v   $��Center=�6�   �� 5<      -   5        $ hourPerWeekTextBox1��5<      $��1��63   $
��Left=�6C   $��23��6^   $��3q�6j   $��10��6u   $��Center=�6�   $	��120��6  ��6�   �� *HourPerWeek+$ TwoWay=�	 . 
 . 6  �� 5=      $��Job Begins:��6   
�������$��0��6=   $
��Left=�6M   $��3q�6h   $��11��6s   $��Center=�6�     5>      -   5        $ jobBeginsDatePicker1��5>      $��1��67   $
��Left=�6G   $��3q�6b   $��11��6m   $��Center=�6�    6{   �� *	JobBegins+$ TwoWay=�	 . 
 . 6�   �� 5?      $��Job Endsup:��6   $��0��6*   
�������$
��Left=�6M   $��3q�6h   $��12��6s   $��Center=�6�     5@      -   5        $ jobEndsupDatePicker1��5@      $��1��67   $
��Left=�6G   $��3q�6b   $��12��6m   $��Center=�6�    6{   �� *	JobEndsup+$ TwoWay=�	 . 
 . 6�   5A      &   System.Windows.Controls.DataGrid  5B   
   -   5          Name$ contractDataGrid��5B         AutoGenerateColumns .     EnableRowVirtualization . $��305,0,32,179q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�      
IsReadOnly . ��6h   ��    Columns 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      -   5        brutSalaryColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Brut Salary��5D   ^      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6s   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *
BrutSalary+6s     5E      -   5        
cityColumn��$
 city��5E   R   $ SizeToHeader 6`    69   �� *city+6`     5F      -   5        commissionColumn��$ 
Commission��5F   ^   $ SizeToHeader 6r    6?   �� *
Commission+6r   4  .System.Windows.Controls.DataGridTemplateColumn  5G      -   5        companyDateCreationColumn��$ Company Date Creation��5G   L   $ SizeToHeader 6k      CellTemplate 5H      �� 5I      .R�5J         6)   �� *CompanyDateCreation+$ TwoWay=�	 . 
 . 5K      5M      4  .System.Windows.Controls.DataGridCheckBoxColumn  5N      -   5        contractIsSignedColumn��$ Contract Is Signed��5N   n   $ SizeToHeader 6�    6I   �� *ContractIsSigned+6�     5O      -   5        contractNumberColumn��$ Contract Number��5O   f   $ SizeToHeader 6    6C   �� *ContractNumber+6     5P      -   5        doInterviewColumn��$ Do Interview��5P   d   $ SizeToHeader 6z    6D   �� *DoInterview+6z     5Q      -   5        domainColumn��$ Domain��5Q   V   $ SizeToHeader 6f    6;   �� *Domain+6f     5R      -   5        employeeIdColumn��$ Employee Id��5R   ^   $ SizeToHeader 6s    6?   �� *
EmployeeId+6s     5S      -   5        employerIdColumn��$ Employer Id��5S   ^   $ SizeToHeader 6s    6?   �� *
EmployerId+6s     5T      -   5        hourPerWeekColumn��$ Hour Per Week��5T   `   $ SizeToHeader 6w    6@   �� *HourPerWeek+6w     5U      -   5        jobBeginsColumn��$ 
Job Begins��5U   B   $ SizeToHeader 6V    5V      �� 5W      .R�5X         6)   �� *	JobBegins+$ TwoWay=�	 . 
 . 5Y      5[        5\      -   5        jobEndsupColumn��$ 
Job Endsup��5\   B   $ SizeToHeader 6V    5]      �� 5^      .R�5_         6)   �� *	JobEndsup+$ TwoWay=�	 . 
 . 5`      5b        5c      -   5        netSalaryColumn��$ 
Net Salary��5c   \   $ SizeToHeader 6p    6>   �� *	NetSalary+6p   5e      ��5f   
   �� 5g      -   5        	Image�� �� ImageSource$ image/fondss.jpg��5g   )   5i      5j      