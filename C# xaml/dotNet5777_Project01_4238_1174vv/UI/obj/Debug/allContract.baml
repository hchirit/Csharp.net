   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	       UI.allContract   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	     � Title$  allContract��5   	   $��336.058��6   $��536.538��6.   .��5	      � .+�5
   
   �� -   5         ��Name$ button1��5
      $
��Left=�6#   $��
476,10,0,0q�6>   $	��Top=�6R   $��43��6j   $��43��6u   ��5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��image/GoBack.png��6   $��39��66   $��41��6A    J� RenderTransformOrigin$ 0.245,0.508&�6M   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ contractDataGrid��5         
IsReadOnly .    AutoGenerateColumns .     EnableRowVirtualization . $��104,10,75,55q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6z   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        brutSalaryColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 Brut Salary��5   ^      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6s   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *
BrutSalary+6s     5      -   5        
cityColumn��$

 city��5   R   $ SizeToHeader 6`    69   �� *city+6`     5      -   5        commissionColumn��$
 
Commission��5   ^   $ SizeToHeader 6r    6?   �� *
Commission+6r   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        companyDateCreationColumn��$
 Company Date Creation��5   L   $ SizeToHeader 6k      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *CompanyDateCreation+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      -   5        contractIsSignedColumn��$
 Contract Is Signed��5   n   $ SizeToHeader 6�    6I   �� *ContractIsSigned+6�     5      -   5        contractNumberColumn��$
 Contract Number��5   f   $ SizeToHeader 6    6C   �� *ContractNumber+6     5      -	   5        doInterviewColumn��$
 Do Interview��5   d   $ SizeToHeader 6z    6D   �� *DoInterview+6z     5       -
   5        domainColumn��$
 Domain��5    V   $ SizeToHeader 6f    6;   �� *Domain+6f     5!      -   5        employeeIdColumn��$
 Employee Id��5!   ^   $ SizeToHeader 6s    6?   �� *
EmployeeId+6s     5"      -   5        employerIdColumn��$
 Employer Id��5"   ^   $ SizeToHeader 6s    6?   �� *
EmployerId+6s     5#      -   5        hourPerWeekColumn��$
 Hour Per Week��5#   `   $ SizeToHeader 6w    6@   �� *HourPerWeek+6w     5$      -   5        jobBeginsColumn��$
 
Job Begins��5$   B   $ SizeToHeader 6V    5%      �� 5&      .R�5'         6)   �� *	JobBegins+$ TwoWay=� .  . 5(      5*        5+      -   5        jobEndsupColumn��$
 
Job Endsup��5+   B   $ SizeToHeader 6V    5,      �� 5-      .R�5.         6)   �� *	JobEndsup+$ TwoWay=� .  . 5/      51        52      -   5        netSalaryColumn��$
 
Net Salary��52   \   $ SizeToHeader 6p    6>   �� *	NetSalary+6p   54      ��55   
   �� 56      -   5        	Image�� �� ImageSource$# image/contract_background.jpg��56   )   58      59      