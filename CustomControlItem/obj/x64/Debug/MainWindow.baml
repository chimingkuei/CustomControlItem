   M S B A M L   `   `   `  ����L  HCustomControlItem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFUIWPFUI  5   	       WPFUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:WPFUI     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$
 test��5
         
BaseButton#��[  6   $��22,113,666,258q�6C    	 btnOk#���  6[    � ToolTip 5      _� 5      .��5      �� .+�5      �� 	說明16)   �� 5      	說明26)   5      5      5      �� 5   
   -   5          CircleButton#��[ 5      $��24,4,667,313q�67   .��6b   Localization6p   �� 5   
     BaseCheckBox#��[ 6   ���#5387b9 d� 	IsChecked$ FalseY�6N   $	��Off��6`   
 � Tag$ On��6n   $��32,198,685,180q�6w   	� 5   
     BaseRadioButton#��[ 6   $��29,168,721,218q�6?   .��6W   是6Z   	� 5   
   #��[ 6   $��76,169,674,217q�6?   .��6W   否6Z   �� 5   
     BaseTextBox#��[ 6   $��12,340,625,37q�67   6P   �� 5   
   -   5        $	��Cmb��5       $
��Auto��6    �� Text$ 	請選擇��6+     BaseComboBox#��[ 66   $��30,292,647,96q�6\   $
��Auto��6s   .@�5      �� .��6   	English6$   �� 5       �� 
IsSelected . .��6-   	Chinese66   5      �� 5   
   -   5        $��comboBox��5   =     AdvancedComboBox#��[ 6   $
��Left=�6M   $��10,234,0,138q�6h   $	��160��6~   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�   .@�5      �� .��6   	English6$   �� 5       . .��6-   	Chinese66   5       &   System.Windows.Controls.DataGrid  5!   
   -   5        $��dataGrid��5!   9     BaseDataGrid#��[ 6   $
��Left=�6I   $	��158��6d   $��	150,8,0,0q�6q   $	��Top=�6�   $	��332��6�    �� AlternationCount$ 2��6�   �� 5"   
    	 BaseGroupBox#��[	 6   $��496,12,22,258q�69   $��檢測結果��6P   $��22(�6^   
���  ��
����� �6}   �� 5#   
   	 �� Orientation$	 Vertical=�6   $��Center=�6,   $��178,176,346,143q�6I   $	��268��6b   .+�5$      �� -   5        $��slider��5$       
 
BaseSlider#��[
 6#   
 �� TickPlacement$
 BottomRight=�6G   �� 5%      $��Center=�6H   $��Center=�6e   ��6   ��  �� ElementName$ slider�� �� Path$ Value�6e   5&      �� 5'   
   -   5         ��Name$ 
tabControl��5'      $
��Left=�6)   $	��116��6D   $��201,286,0,0q�6Q   $	��Top=�6f   $	��218��6~   .@�5(      �� $��TabItem��6     BaseTabcontrol#��[ 6'   .��5)      � ���	#FFE5E5E56   5*      �� 5+      $��TabItem��6   #��[ 6'   .��5,      � ���	#FFE5E5E56   5-      5.      5/      50      