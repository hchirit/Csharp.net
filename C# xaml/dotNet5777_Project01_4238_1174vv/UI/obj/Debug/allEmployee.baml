   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	       UI.allEmployee   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	     � Title$  allEmployee��5   	   $��408.173��6   $��734.135��6.   .��5	      � .+�5
   
   �� -   5         ��Name$ button1��5
      $
��Left=�6"   $��
660,10,0,0q�6=   $	��Top=�6Q   $��56��6i   $��58��6t   ��5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��image/GoBack.png��6   $��52��66   $��53��6A   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ employeeDataGrid��5         
IsReadOnly .    AutoGenerateColumns .     EnableRowVirtualization . $��144,10,146,10q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6z   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        adressColumn��,  &System.Windows.Controls.DataGridColumn	   Header$	 Adress��5   V   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 SizeToHeader 6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Adress+6f     5      -   5        	ageColumn��$		 age��5   P   $
 SizeToHeader 6]    68   �� *age+6]     5      -   5        degreeColumn��$	 degree��5   V   $
 SizeToHeader 6f    6;   �� *degree+6f     5      -   5        firstNameColumn��$	 
First Name��5   \   $
 SizeToHeader 6p    6>   �� *	FirstName+6p     5      -   5        idColumn��$	 Id��5   N   $
 SizeToHeader 6Z    67   �� *Id+6Z   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      -   5        isDoArmyColumn��$	 
Is Do Army��5   ^   $
 SizeToHeader 6r    6A   �� *
IsDoArmy+6r     5      -	   5        lastNameColumn��$	 	Last Name��5   Z   $
 SizeToHeader 6m    6=   �� *
LastName+6m     5      -
   5        phoneNumberColumn��$	 Phone Number��5   `   $
 SizeToHeader 6v    6@   �� *PhoneNumber+6v   5      ��5   
   �� 5      -   5        	image�� �� ImageSource$ image/Employees2.jpg��5   *   5!      5"      