   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       WpfApp.DataGrid   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   7core&clr-namespace:System;assembly=mscorlib     5   	     � Title$  DataGrid��5	   	   $	��450��6   $	��800��6'   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dataGrid��5         AutoGenerateColumns .  $
��Left=�5      $	��345��5      $��0,64,0,0q�5      $	��Top=�5      $   HorizontalScrollBarVisibility$
 Auto=�5      "   VerticalScrollBarVisibility$
 Auto=�5         CanUserAddRows .  $	��792��5      ��5      ��    Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn   HeaderTemplate 5       �� 5!      .R�5%      ��  ��Name$ ckbSelectedAll��6'   -   5         d� 	IsChecked 5%   �   �� 	 �� Path$	 
IsSelected�
 �� UpdateSourceTrigger$
 PropertyChanged=�5&      5(      0  *System.Windows.Controls.DataGridTextColumn  5)         
Visibility$ Hidden=�6%      
IsReadOnly .    Header$ ID��6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6W   �� *id+  5*       . $ 姓名��67    6C   �� *name+  5+       . $ 年龄��67    6C   �� *age+  5,       . $ 性别��67    6C   �� *sexual+5.      �� 5/   
   -   5        $��修 改��5/      $
��Left=�6   $��	21,31,0,0q�6:   $	��Top=�6M   $��75��6e   6p   �� 50   
   -   5        $��
Btn_Import��50   *   $��导 入��6<   $
��Left=�6J   $��
138,31,0,0q�6e   $	��Top=�6y   $��75��6�   �� 51   
   -   5        $��
Btn_Export��51   *   $��导 出��6<   $
��Left=�6J   $��
241,31,0,0q�6e   $	��Top=�6y   $��75��6�   52      53      