   M S B A M L   `   `   `  ����I  ETradeInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:TradeInterface.CtrlTradeInterface.Ctrl  5   	   #    TradeInterface.winImportLimit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   2ctrl!clr-namespace:TradeInterface.Ctrl     5   	     � Title$  winImportLimit��5   	   $	��480��6    $	��620��6-   .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5	      �� 5
      $��60 �6   �� 5      $��60 �6   .+�5   
   �� $��导入参数��6   $��0��6!   .��5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5      �� .��6   文本编码方式6    �� 5      -   5         ��Name$ 	cmbEncode��5      $��70��6.   .@�5      �� $��Default��6#    �� 
IsSelected . 6I   �� 5      $��ASCII��6#   65   �� 5      $
��UTF8��6#   64   �� 5      $��Unicode��6#   67   5      �� 5      -   5        $��50��5   .   $��	10,0,10,0q�69   .��6L   导入6P   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgImportData��5       $��1��6      CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly . 	   AutoGenerateColumns	 . 6�   �� 5   
   $��保存参数��6   $��2��6!   .��5      �� $ 
Horizontal=�6   $��Center=�62   .+�5      �� .��6   保存类型:6   �� 5      -   5        $ cmbDataType��5      $	��100��60   .@�5       �� .��6#   券单6'   �� 5!      .��6#   证券区间数据6+   5"      �� 5$      -   5        
 ��Name$
 btnSave��5$   M   $��50��6/   $��	10,0,10,0q�6:   .��6^   保存6b   5%      5&      �� 5'   
   -   5         ��Name$ txtMsg��5'   #   $��3��6   65   !   TradeInterface.Ctrl.Loading  5)   
   -   5          Name$ loading��5)      $��4��6(   $y�	Collapsed=�69   6R   5*      5+      