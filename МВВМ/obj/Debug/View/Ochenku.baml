   M S B A M L   `   `   `  ����C  ?МВВМ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:МВВМ.ViewМВВМ.View  5   	   7 clr-namespace:МВВМ.ViewModelМВВМ.ViewModel  6/       МВВМ.View.Ochenku   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:МВВМ.View     5   	   6	viewmodel clr-namespace:МВВМ.ViewModel     6/     � Title$  Оценки��5   	   $	��450��6   $	��800��6%   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��80 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  $
��auto��6   $
��auto��6!   $��99��6.      CanUserAddRows .   �� SelectedItem 6Z   �� *Sele+��6x   �� *OInfo+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��1��6   $��0��6   $
��auto��6.   $
��auto��6;   $#��Добавить Оценку��6I   ��6c   �� *AddCommand2+�� 5   
   $��1��6   $��1��6   $
��auto��6.   $
��auto��6;   $!��Удалить Оценку��6I   ��6b   �� *RemoveCommand2+�� 5   
   $��1��6   $��2��6   $
��auto��6.   $
��auto��6;   $#��Изменить Оценку��6I   ��6c   �� *UpdateCommand2+�� 5   
   $��1��6   $��3��6   $
��auto��6.   $
��auto��6;   $��Группы��6I   ��6Z   �� *
GOTO_group+�� 5   
   $��1��6   $��5��6   $
��auto��6.   $
��auto��6;   $��ФИО��6I   ��6W   �� *BACKCommand+5      5      