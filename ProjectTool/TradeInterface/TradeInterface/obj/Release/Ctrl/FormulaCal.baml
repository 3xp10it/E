   M S B A M L   `   `   `  ����   TradeInterface$    TradeInterface.Ctrl.FormulaCal   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .���   � 	Resources  &   System.Windows.Controls.DataGrid �� 
TargetType �� Property �� Value��%�   '        �� "  .���  �@ AutoGenerateColumns .  ��  �@ CanUserAddRows .  ��  �@ 
IsReadOnly . ��  �@ ClipboardCopyMode$ IncludeHeader=� � ColumnDefinitions �� $��* � � RowDefinitions �� $
��Auto ��� $��40 ��� .+���  �� Orientation$ 
Horizontal=�$��1��$��Center=�$��2��.+��� -   $��导入��$��	10,0,20,0q�$��70���� -    ��Name$ lblMultiply��.��
乘系数:�� -    ��Name$ txtMul��$��80���� -   $ 	lblDivide��$��10,0,0,0q�.��
除系数:�� -   $ txtDiv��$	��100���� -   $��重新计算��$��	10,0,10,0q�$��80���� $��2��.@��� $��计算结果��.��  -   	  Name$	 dgCal��
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 	交易员��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Trader+  $ 股票代码�� �� *	StockID+  $ 股票名称�� �� *	StockName+  $ 现价(元)�� �� *
PriceNow+  $ 区间换手率�� �� *TurnoverRate+  $ 区间振幅�� �� *FluctuationRate+  $ 区间成交量�� �� *	FillQty+  $ 分数�� �� *Score+  $ 市值�� �� *MarketValue+  $ 股数�� �� *
TotalQty+  $ 	组合号�� �� *Group+�� $��券单��.��  -   $	 dgLimit��
   $ 	组合号�� �� *Group+  $ 	交易员�� �� *TraderAccount+  $ 股票代码�� �� *	StockID+  $ 总计可分配�� �� *
TotalQty+�� $��股票信息��.��  -	   $	 dgStock��
   $ 股票代码�� �� *	StockID+  $ 股票名称�� �� *	StockName+  $ 现价(元)�� �� *
PriceNow+  $ 区间换手率�� �� *TurnoverRate+  $ 区间振幅�� �� *FluctuationRate+  $ 区间成交量�� �� *	FillQty+