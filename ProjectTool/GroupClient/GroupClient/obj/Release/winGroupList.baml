   M S B A M L   `   `   `  ����   GroupClient    GroupClient.winGroupList   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  券商列表��$	��300��$	��520�� � Icon$ Images\RighteousFury.ico��.��� .+�&   System.Windows.Controls.DataGrid  -     Name$ dgMain��$��1��   AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .     ClipboardCopyMode$ IncludeHeader=�   
IsReadOnly . 	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$
 名称��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *名称+4  .System.Windows.Controls.DataGridCheckBoxColumn  $
 启用�� �� *启用+  $
 交易服务器��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100  �� *交易服务器+  $
 IP�� �� *IP+  $

 Port�� �� *Port+  $
 	版本号�� �� *	版本号+  $
 营业部代码�� �� *营业部代码+4  .System.Windows.Controls.DataGridTemplateColumn  $
 操作��   CellTemplate �� .R���  �� Orientation$ 
Horizontal=�.+��� -   $��2,0,2,0q� � DataContext �� .��编辑�� -   $��2,0,2,0q� �� .��删除