   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       UI.UpdateEmployer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  UpdateEmployer��5	   	   $��482.076��6    $��1100.282��61   .��5      � .+�5   
   �� -   5         ��Name$ button��5      
���  ��$��Update��65   $��30(�6G   $
��Left=�6V   $��
10,359,0,0q�6q   $	��Top=�6�   $	��109��6�    J� RenderTransformOrigin$ 
0.49,0.495&�6�   $��57��6�   6�   �� 5   
   -   5        $ button1��5      $��
0,359,35,0q�6"   $	��Top=�66   $��57��6N   $��Right=�6q   $��58��6�   ��5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��image/GoBack.png��6   $��52��66   $��53��6A   $ -0.054,0.553&�6M   5      5      � 5   
   -   5         �Name$ grid1��5      $
��Left=�6   $	��Top=�69    � ColumnDefinitions 5      �� 5      $
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
��Auto �6    .+�5%      �� $��Adress:��6   $��0��6&   $
��Left=�66   $��3q�6Q   $��6��6\   $��Center=�6i   �� 5&      -   5         ��Name$ adressTextBox��5&      $��1��6-   $
��Left=�6=   $��23��6X   $��3q�6d   $��6��6o   $��Center=�6�   $	��120��6�   ��6|   �� *Adress+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6�   �� 5'      $��Company Date Creation:��6   $��0��65   $
��Left=�6E   $��3q�6`   $��1��6k   $��Center=�6x   (  "System.Windows.Controls.DatePicker  5(      -   5          Name$# companyDateCreationDatePicker��5(      $��1��6@   $
��Left=�6P   $��3q�6k   $��1��6v   $��Center=�6�      SelectedDate 6�   �� *CompanyDateCreation+$ TwoWay=�	 . 
 . 6�   �� 5)      $��Company Name:��6   $��0��6,   $
��Left=�6<   $��3q�6W   $��2��6b   $��Center=�6o   �� 5*      -   5        $ companyNameTextBox��5*      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��2��6t   $��Center=�6�   $	��120��6   ��6�   �� *CompanyName+$ TwoWay=�	 . 
 . 6   �� 5+      $��Date Contract Signed:��6   $��0��64   $
��Left=�6D   $��3q�6_   $��3��6j   $��Center=�6w     5,      -   5        $" dateContractSignedDatePicker��5,      $��1��6?   $
��Left=�6O   $��3q�6j   $��3��6u   $��Center=�6�    6�   �� *DateContractSigned+$ TwoWay=�	 . 
 . 6�   �� 5-      $��Domain:��6   $��0��6&   $
��Left=�66   $��3q�6Q   $��4��6\   $��Center=�6i   �� 5.      -   5         ��Name$ domainComboBox��5.      $��1��6/   $
��Left=�6?   $
��Auto��6Z   $��3q�6�   $��4��6�   $��Center=�6�   $	��120��6�    �� SelectedItem 6i   �� *Domain+6�   �� 5/      $��First Name:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��5��6`   $��Center=�6m   �� 50      -	   5        $ firstNameTextBox��50      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��5��6r   $��Center=�6�   $	��120��6�   ��6   �� *	FirstName+$ TwoWay=�	 . 
 . 6�   �� 51      $��Id to update:��6   
���  ��$��18(�6@   $��0��6N   $
��Left=�6^   $��3,0,0,3q�6y   $��0��6�   $��Bottom=�6�   �� 52      -
   5        $ 	idTextBox��52      $��1��6)   $
��Left=�69   $��23��6T   $��3q�6`   $��0��6k   $��Center=�6�   $	��120��6�   ��6x   �� *Id+$ TwoWay=�	 . 
 . 6�   �� 53      $��Is Private:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��7��6`   $��Center=�6m   �� 54      -   5         ��Name$ isPrivateCheckBox��54      $�� ��62   $��1��6=   $
��Left=�6M   $��3q�6�   $��7��6�   $��Center=�6�    d� 	IsChecked 6h   �� *	IsPrivate+$ TwoWay=�	 . 
 . 6�   �� 55      $��
Last Name:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��8��6_   $��Center=�6l   �� 56      -   5        $ lastNameTextBox��56      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��8��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
LastName+$ TwoWay=�	 . 
 . 6�   �� 57      $��Phone Number:��6   $��0��6,   $
��Left=�6<   $��3q�6W   $��9��6b   $��Center=�6o   �� 58      -   5        $ phoneNumberTextBox��58      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��9��6t   $��Center=�6�   $	��120��6   ��6�   �� *PhoneNumber+$ TwoWay=�	 . 
 . 6   59      &   System.Windows.Controls.DataGrid  5:   
   -   5          Name$ employerDataGrid��5:         AutoGenerateColumns .     EnableRowVirtualization . $��300,0,25,155q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�      
IsReadOnly . ��6h   ��    Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      -   5        adressColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Adress��5<   V      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Adress+6f   4  .System.Windows.Controls.DataGridTemplateColumn  5=      -   5        companyDateCreationColumn��$ Company Date Creation��5=   L   $ SizeToHeader 6k      CellTemplate 5>      �� 5?      .R�5@         6)   �� *CompanyDateCreation+$ TwoWay=�	 . 
 . 5A      5C        5D      -   5        companyNameColumn��$ Company Name��5D   `   $ SizeToHeader 6v    6@   �� *CompanyName+6v     5E      -   5        dateContractSignedColumn��$ Date Contract Signed��5E   K   $ SizeToHeader 6i    5F      �� 5G      .R�5H         6)   �� *DateContractSigned+$ TwoWay=�	 . 
 . 5I      5K        5L      -   5        domainColumn��$ Domain��5L   V   $ SizeToHeader 6f    6;   �� *Domain+6f     5M      -   5        firstNameColumn��$ 
First Name��5M   \   $ SizeToHeader 6p    6>   �� *	FirstName+6p     5N      -   5        idColumn��$ Id��5N   N   $ SizeToHeader 6Z    67   �� *Id+6Z   4  .System.Windows.Controls.DataGridCheckBoxColumn  5O      -   5        isPrivateColumn��$ 
Is Private��5O   `   $ SizeToHeader 6t    6B   �� *	IsPrivate+6t     5P      -   5        lastNameColumn��$ 	Last Name��5P   Z   $ SizeToHeader 6m    6=   �� *
LastName+6m     5Q      -   5        phoneNumberColumn��$ Phone Number��5Q   `   $ SizeToHeader 6v    6@   �� *PhoneNumber+6v   5S      ��5T   
   �� 5U      -   5        	Image�� �� ImageSource$ image/fond3.jpg��5U   )   5W      5X      