   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	       UI.allEmployer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	     � Title$  allEmployer��5   	   $��421.154��6   $��615.866��6.   .��5	      � .+�5
   
   �� -   5         ��Name$ button1��5
      $
��Left=�6#   $��
557,10,0,0q�6>   $	��Top=�6R   $��41��6j   $��42��6u   ��5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��image/GoBack.png��6   $��36��66   $��36��6A    J� RenderTransformOrigin$ -0.054,0.553&�6M   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ employerDataGrid��5         
IsReadOnly .    AutoGenerateColumns .     EnableRowVirtualization . $��
71,40,74,0q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   $	��163��6�   $	��Top=�6�   ��6z   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        adressColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 Adress��5   V      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Adress+6f   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        companyDateCreationColumn��$
 Company Date Creation��5   L   $ SizeToHeader 6k      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *CompanyDateCreation+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5        5      -   5        companyNameColumn��$
 Company Name��5   `   $ SizeToHeader 6v    6@   �� *CompanyName+6v     5      -   5        dateContractSignedColumn��$
 Date Contract Signed��5   K   $ SizeToHeader 6i    5      �� 5      .R�5         6)   �� *DateContractSigned+$ TwoWay=� .  . 5       5"        5#      -   5        domainColumn��$
 Domain��5#   V   $ SizeToHeader 6f    6;   �� *Domain+6f     5$      -   5        firstNameColumn��$
 
First Name��5$   \   $ SizeToHeader 6p    6>   �� *	FirstName+6p     5%      -	   5        idColumn��$
 Id��5%   N   $ SizeToHeader 6Z    67   �� *Id+6Z   4  .System.Windows.Controls.DataGridCheckBoxColumn  5&      -
   5        isPrivateColumn��$
 
Is Private��5&   `   $ SizeToHeader 6t    6B   �� *	IsPrivate+6t     5'      -   5        lastNameColumn��$
 	Last Name��5'   Z   $ SizeToHeader 6m    6=   �� *
LastName+6m     5(      -   5        phoneNumberColumn��$
 Phone Number��5(   `   $ SizeToHeader 6v    6@   �� *PhoneNumber+6v   5*      ��5+   
   �� 5,      -   5        	Image�� �� ImageSource$ image/meeting.jpg��5,   )   5.      5/      