   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��250��6   $	��500��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��Stretch=�6   $��Enter your date��6;   $��Center=�6U   $��Center=�5      $��22(�62   (  "System.Windows.Controls.DatePicker  5   
   $��1��6   $��22(�6"   $��Center=�60   $��Stretch=�6T   $��Center=�5         FirstDayOfWeek$ Monday=�67      IsTodayHighlighted$
 True��6O      SelectedDate 5      �� *Date+ �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��2��6   $��80��6   
��� � �$��Submit��6<   $��15(�6M   
�������$��
50,10,50,0q�5   ,   ��6   �� *Submit+6,   �� 5   
   $��0��6   $��1��6!   $��	10,10,0,0q�61   $
��Left=�6D   $��Stretch=�5      $��18(�60    �� TextAlignment$ Center=�6>   ��5      �� *Age+$ PropertyChanged=��� 5   
   $��1��6   $��1��6!   $��	10,10,0,0q�61   $
��Left=�6D   $��Stretch=�5      $��18(�60   $ Center=�6>   ��5      �� *WesternZodiac+$ PropertyChanged=��� 5    
   $��2��6   $��1��6!   $��	10,10,0,0q�61   $
��Left=�6D   $��Stretch=�5!      $��18(�60   $ Center=�6>   ��5"      �� *ChineseZodiac+$ PropertyChanged=�5#      5$      