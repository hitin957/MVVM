   M S B A M L   `   `   `  ����C  ?МВВМ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp7WpfApp7  5   	   7 clr-namespace:МВВМ.ViewModelМВВМ.ViewModel  6-       WpfApp7.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp7     5   	   6	viewmodel clr-namespace:МВВМ.ViewModel     6-     � Title$  ФИО��5   	   $	��450��6   $	��800��6"   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��80 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  $
��auto��6   $
��auto��6!   $��99��6.   $��99��6C      CanUserAddRows .   �� SelectedItem 6m   �� *
Selected+��6�   �� *	FIOInfo+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��1��6   $��0��6   $
��auto��6.   $
��auto��6;   $'��!Добавить Студента��6I   ��6e   �� *
AddCommand+�� 5   
   $��1��6   $��1��6   $
��auto��6.   $
��auto��6;   $%��Удалить Студента��6I   ��6d   �� *RemoveCommand+�� 5   
   $��1��6   $��2��6   $
��auto��6.   $
��auto��6;   $'��!Изменить Студетна��6I   ��6e   �� *UpdateCommand+�� 5   
   $��1��6   $��3��6   $
��auto��6.   $
��auto��6;   $��Группы��6I   ��6Z   �� *
GOTO_group+�� 5   
   $��1��6   $��5��6   $
��auto��6.   $
��auto��6;   $��ОЦЕНКИ��6I   ��6Z   �� *GOTOOCHENKU+5      5      