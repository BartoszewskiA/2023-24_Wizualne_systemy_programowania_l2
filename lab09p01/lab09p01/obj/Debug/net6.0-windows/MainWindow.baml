   M S B A M L   `   `   `  ����C  ?lab09p01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:lab09p01lab09p01  5   	       lab09p01.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:lab09p01     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��500��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      .+�5%   
   �� $��Przelicznik rat��5&      $��1��5'      $��1��5(      $��10��5)       �� TextAlignment$ Center=�5+      $��Center=�5,      $
��20pt(�5-       �� Padding$ 	0 10 0 10q�5.      �� 51   
   -   5         ��Name$ tb_kwota��52      $��1��53      $��3��54      $��6��55       �� TextAlignment$ Center=�56      $��Center=�57      $
��15pt(�58      �� 5:   
   -   5         ��Name$ tbl_liczba_rat��5;      $��Liczba rat: 1��5<      $��1��5=      $��5��5>      $��3��5?      $��Center=�5@      $
��15pt(�5A      $ 	0 10 0 10q�5B      �� 5D   
   -   5         ��Name$ scrol��5E      	 �� Orientation$	 
Horizontal=�5F      $
��auto��5G      $��5��5H      $��5��5I      $��6��5J      5K      �� 5M      -   5        $ 	tbl_wynik��5N      $��Rata = ��5O      $��1��5P      $��7��5Q      $��7��5R      $��Center=�5S   	   $
��15pt(�5T   	   $ 	0 10 0 10q�5U   	   o� 5X   
   $��0��5Y      $��0��5Z      $��12��5[      .@�5^      m� $��Pamięć��6   .@�5_      m� -   5        $��Zapamiętaj��5_      6/   m� 5`      -   5        $��Pokaż wszystkie��5`      64   m� 5a      -   5        $��Wyczyść pamięć��5a      64   5b      5c      5d      5e      