   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	       UI.allSpecialization   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	     � Title$  allSpecialization��5   	   $	��493��6#   $	��633��60   .��5	      � $��0,0,-8,0q�6   $��Right=�6   $	��635��69   ��5
   
   �� 5      -   5        	image�� �� ImageSource$- 'image/specialization-in-outsourcing.png��5   *   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ specializationDataGrid��5         
IsReadOnly .    AutoGenerateColumns .     EnableRowVirtualization . $��151,39,167,97q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6�   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        expertiseDomainColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Expertise Domain��5   h   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 SizeToHeader 6�   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6D   �� *ExpertiseDomain+6�     5      -   5        maxTarifColumn��$ 	max Tarif��5   Z   $	 SizeToHeader 6m   
 6=   �� *
maxTarif+6m     5      -   5        minTarifColumn��$ 	min Tarif��5   Z   $	 SizeToHeader 6m   
 6=   �� *
minTarif+6m     5      -   5        specializationNumberColumn��$ specialization Number��5   r   $	 SizeToHeader 6�   
 6I   �� *specializationNumber+6�   5      �� 5   
   -   5         ��Name$ button1��5      $
��Left=�6"   $��
573,10,0,0q�6=   $	��Top=�6Q   $��52��6i   $��52��6t   ��5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��image/GoBack.png��6   $��48��66   $��49��6A   5      5      5      5      