   M S B A M L   `   `   `  ����?  ;zad3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:zad3zad3  5   	       zad3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:zad3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	   	   �� *Main+   Locator �� Source# [  .��5
      � .+�5   
   �� $��Previous��6   $
��Left=�6$   $��
176,10,0,0q�6?   $	��Top=�6S   $��75��6k   $	��400��6v   ��6�   �� *OnPreviousClickedCommand+�� 5   
   $
��Next��6   $
��Left=�6    $��
605,10,0,0q�6;   $	��Top=�6O   $��75��6g   $	��400��6r   ��6   �� *OnNextClickedCommand+�� 5   
   $
��Left=�6   $��23��6/   $��	39,73,0,0q�6;   $
��Wrap=�6N   $
��Id: ��6b   $	��Top=�6n   $��23��6�   �� 5   
   $
��Left=�6   $��23��6/   $��	67,73,0,0q�6;   $
��Wrap=�6N   $	��Top=�6�   $��84��6�   ��6b   �� *Id+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��23��6/   $��
39,115,0,0q�6;   $
��Wrap=�6O   $��Name: ��6c   $	��Top=�6q   $��42��6�   �� 5   
   $
��Left=�6   $��23��6/   $��
86,115,0,0q�6;   $
��Wrap=�6O   $	��Top=�6�   $��65��6�   ��6c   �� *Name+$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
301,41,0,0q�6/   $
��Wrap=�6C   $��Type: ��6W   $	��Top=�6e   $��38��6}   $��20��6�   y�6�   �� *VisCar+$ PropertyChanged=��� 5   
   $
��Left=�6   $��
301,76,0,0q�6/   $
��Wrap=�6C   $��Color: ��6W   $	��Top=�6f   $��38��6~   $��20��6�   y�6�   �� *VisCar+$ PropertyChanged=��� 5   
   $
��Left=�6   $��301,115,0,0q�6/   $
��Wrap=�6D   $��IsFlatRoof: ��6X   $	��Top=�6�   $��55��6�   $��16��6�    J� RenderTransformOrigin$ 0.529,3.099&�6�   y�6l   �� *
VisHouse+$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��301,143,0,0q�6/   $
��Wrap=�6D   $��NumberOfFloors: ��6X   $	��Top=�6p   $	��109��6�   $��20��6�   $ 0.529,3.099&�6�   y�6�   �� *
VisHouse+$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��301,168,0,0q�6/   $
��Wrap=�6D   $��Age: ��6X   $	��Top=�6e   $��38��6}   $��20��6�   $ 0.529,3.099&�6�   y�6�   �� *	VisPerson+$ PropertyChanged=� �� Mode$ OneWay=�6�   �� 5   
   $
��Left=�6   $��301,193,0,0q�6/   $
��Wrap=�6D   $��	Address: ��6X   $	��Top=�6i   $��60��6�   $��28��6�   $ 0.529,3.099&�6�   y�6�   �� *	VisPerson+$ PropertyChanged=�$ OneWay=�6�   �� 5   
   $
��Left=�6   $��23��6/   $��
362,41,0,0q�6;   $
��Wrap=�6O   $	��Top=�6�   $	��120��6�   ��6c   �� *Type+$ PropertyChanged=�y�6�   �� *VisCar+$ PropertyChanged=��� 5   
   $
��Left=�6   $��23��6/   $��
362,76,0,0q�6;   $
��Wrap=�6O   $	��Top=�6�   $	��120��6�   ��6c   �� *Color+$ PropertyChanged=�y�6�   �� *VisCar+$ PropertyChanged=��� 5   
   $
��Left=�6   $��23��6/   $��362,115,0,0q�6;   $
��Wrap=�6P   $	��Top=�6�   $	��120��6�   ��6d   �� *
IsFlatRoof+$ PropertyChanged=�y�6�   �� *
VisHouse+$ PropertyChanged=��� 5   
   $
��Left=�6   $��23��6/   $��410,143,0,0q�6;   $
��Wrap=�6P   $	��Top=�6�   $	��120��6�   ��6d   �� *NumberOfFloors+$ PropertyChanged=�y�6�   �� *
VisHouse+$ PropertyChanged=��� 5   
   $
��Left=�6   $��23��6/   $��344,168,0,0q�6;   $
��Wrap=�6P   $	��Top=�6�   $	��120��6�   ��6d   �� *Age+$ PropertyChanged=�y�6�   �� *	VisPerson+$ PropertyChanged=��� 5   
   $
��Left=�6   $��23��6/   $��366,193,0,0q�6;   $
��Wrap=�6P   $	��Top=�6�   $	��200��6�   ��6d   �� *	Address+$ PropertyChanged=�y�6�   �� *	VisPerson+$ PropertyChanged=�5      5      