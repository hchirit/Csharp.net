   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       UI.UpdateEmployee   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  UpdateEmployee��5	   	   $��407.261��6    $��703.111��61   .��5
      �  � RowDefinitions 5   
   �� 5      $
��363* �6   �� 5      $
��106* �6   .+�5   
   �� -   5         ��Name$ button��5      
���  ��$��Update��65   $��30(�6F   $
��Left=�6T   $��10,0,0,0q�6o   $��1��6�   $	��Top=�6�   $	��121��6�   $��69��6�   6�   �� 5   
   -   5        $ button1��5      $
��Left=�6"   $��	597,0,0,0q�6=   $��1��6P   $	��Top=�6]   $��69��6u   $��69��6�   ��5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��image/GoBack.png��6   $��66��66   $��65��6A   5      5      � 5   
   -   5         �Name$ grid1��5      $
��Left=�6   $	��Top=�69   $	��267��6Q    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    �� 5$      $
��Auto �6    �� 5%      $
��Auto �6    �� 5&      $
��Auto �6    .+�5(      �� $��Adress:��6   $��0��6&   $
��Left=�66   $��3q�6Q   $��3��6\   $��Center=�6i   �� 5)      -   5         ��Name$ adressTextBox��5)      $��1��6-   $
��Left=�6=   $��23��6X   $��3q�6d   $��3��6o   $��Center=�6�   $	��120��6�   ��6|   �� *Adress+ �� Mode$ TwoWay=� �� NotifyOnValidationError . 	 �� ValidatesOnExceptions	 . 6�   �� 5*      $
��age:��6   $��0��6#   $
��Left=�63   $��3q�6N   $��1��6Y   $��Center=�6f   �� 5+      -   5        $ 
ageTextBox��5+      $��1��6*   $
��Left=�6:   $��23��6U   $��3q�6a   $��1��6l   $��Center=�6�   $	��120��6�   ��6y   �� *age+$ TwoWay=� . 	 . 6�   �� 5,      $��First Name:��6   $��0��6*   $
��Left=�6:   $��4q�6U   $��4��6`   $��Center=�6m   �� 5-      -   5        $ firstNameTextBox��5-      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��4��6r   $��Center=�6�   $	��120��6�   ��6   �� *	FirstName+$ TwoWay=� . 	 . 6�   �� 5.      $��ID to update:��6   
���  ��$��0��6@   $
��Left=�6P   $��3q�6k   $��0��6v   $��Center=�6�   �� 5/      -   5        $ 	idTextBox��5/      $��1��6)   $
��Left=�69   $��23��6T   $��3q�6`   $��0��6k   $��Center=�6�   $	��120��6�   ��6x   �� *Id+$ TwoWay=� . 	 . 6�   �� 50      $��Is Do Army:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��6��6`   $��Center=�6m   �� 51      -   5        
 ��Name$
 isDoArmyCheckBox��51      $�� ��61   $��1��6<   $
��Left=�6L   $��3q�6�   $��6��6�   $��Center=�6�    d� 	IsChecked 6g   �� *
IsDoArmy+$ TwoWay=� . 	 . 6�   �� 52      $��
Last Name:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��5��6_   $��Center=�6l   �� 53      -	   5        $ lastNameTextBox��53      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��5��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
LastName+$ TwoWay=� . 	 . 6�   �� 54      $��Phone Number:��6   $��0��6,   $
��Left=�6<   $��3q�6W   $��7��6b   $��Center=�6o   �� 55      -
   5        $ phoneNumberTextBox��55      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��7��6t   $��Center=�6�   $	��120��6   ��6�   �� *PhoneNumber+$ TwoWay=� . 	 . 6   �� 57      -   5         ��Name$ degreeComboBox��57      $
��Left=�6/   $
��Auto��6J   $��0,0,0,4q�6x   $��Center=�6�   $	��120��6�   $��1��6�   $��8��6�    �� SelectedItem 6X   �� *degree+6�   �� 58      -   5         ��Name$ label��58      $��Degree��6#   $
��Left=�64   $��8��6O    J� RenderTransformOrigin$ 0.526,0.462&�6\   59      &   System.Windows.Controls.DataGrid  5:   
   -   5          Name$ employeeDataGrid��5:         AutoGenerateColumns .     EnableRowVirtualization . $��230,0,29,24q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�      
IsReadOnly . ��6h   ��    Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      -   5        adressColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Adress��5<   V      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Adress+6f     5=      -   5        	ageColumn��$	 age��5=   P   $ SizeToHeader 6]    68   �� *age+6]     5>      -   5        degreeColumn��$ degree��5>   V   $ SizeToHeader 6f    6;   �� *degree+6f     5?      -   5        firstNameColumn��$ 
First Name��5?   \   $ SizeToHeader 6p    6>   �� *	FirstName+6p     5@      -   5        idColumn��$ Id��5@   N   $ SizeToHeader 6Z    67   �� *Id+6Z   4  .System.Windows.Controls.DataGridCheckBoxColumn  5A      -   5        isDoArmyColumn��$ 
Is Do Army��5A   ^   $ SizeToHeader 6r    6A   �� *
IsDoArmy+6r     5B      -   5        lastNameColumn��$ 	Last Name��5B   Z   $ SizeToHeader 6m    6=   �� *
LastName+6m     5C      -   5        phoneNumberColumn��$ Phone Number��5C   `   $ SizeToHeader 6v    6@   �� *PhoneNumber+6v   5E      ��5G   
   �� 5H      -   5        	image�� �� ImageSource$  image/téléchargement.jpg��5H   *   5J      5K      