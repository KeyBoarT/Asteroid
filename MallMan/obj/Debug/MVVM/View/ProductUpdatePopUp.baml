   M S B A M L   `   `   `  ����B  >MallMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MallMan.MVVM.ViewModelMallMan.MVVM.ViewModel  5   	   5clr-namespace:MallMan.MVVM.ViewMallMan.MVVM.View  5   	   *    $MallMan.MVVM.View.ProductUpdatePopUp   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   :	viewmodel$clr-namespace:MallMan.MVVM.ViewModel     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MallMan.MVVM.View     5   	   -   5          �Name$  UpdatePopUpWindow��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � Title$ ProductUpdatePopUp��5   	   $
��1000��6$   $	��600��62   .��5      ��    islakAsfalt#��[  6    �� CornerRadius$ 5��5       �� Padding$ 7q�5      $��0q�5       J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      	   
BlurRadius$	 10Q�6   
   Color$
 Black��6/      ShadowDepth$ 10Q�6=   ._�5   
   �  � RowDefinitions 5      �� 5      $��45 �6    �� 5      $	��200 �6    �� 5      $��60 �6    �� 5      $	��150 �6    �� 5      $��60 �6    �� 5      �� 5      $��60 �6    .+�5!      ��  �� TextAlignment$ Center=�5"      $��Center=�5#      $��25(�5$      $��Consolas)�5%      
���������5!      �� *	ProductID+5&      �� 5'      
������ ._�5(      �� $��40��6   $��40��5)      $��1��5*        TitleMenuButton#��[ 5+      $��X��5,       	 Bulut#��[ 5/      ��5-      ��  �� ElementName$ UpdatePopUpWindow����5.      �� *CloseWindowCommand+5/       J� InputBindings 50      d� 51       d� MouseAction$ 	LeftClicke�6#    �� Command 52   #   �� *MoveWindowCommand+ �� CommandParameter 53   #   �� $ UpdatePopUpWindow����55      �� 56       �� Triggers 57      P� 58       P� Property �@J�IsMouseOver P� Value . . �59   "   ��  �� Property � �� �� Value# [ 6F   5:      5<      5>      �� 5?      -   5         ��Name$ imageBorder��5A      $��1��5?      $	��190��5@      $ 5��5B      $��2q�5C      
����� �$
��0,10q�5E      ��5F      �� 5G       �� ImageSource 6!   �� *Image+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5I      �� 5J      $��2��6     GeceYarisiMavisi#��[ 5M        newProductButton#��[ 5N      $��100,0q�5O      $��
Resim Ekle��5P      ��5K      �� *AddImageCommand+��5L      �� $ imageBorder��5P      � 5Q      $��3��6    5R      �� 5S      �� 5T      �� 5U       � ColumnDefinitions 5W      �� 5X      �� 5Y      .+�5[      �� $��Ürün Adı��6   
�������$��25(�5]      $
 Left=�5^      $��Center=�5_      �� 5`      $��:��6   
�������$��25(�5b      $ Right=�5c      $��Center=�5d      �� 5e      $��Ürün Adedi��6   
�������$��1��5g      $��25(�5h      $
 Left=�5i      $��Center=�5j      �� 5k      $��:��6   
�������$��1��5m      $��25(�5n      $ Right=�5o      $��Center=�5p      �� 5q      $��Ürün Fiyatı��6   
�������$��2��5s      $��25(�5t      $
 Left=�5u      $��Center=�5v      �� 5w      $��:��6   
�������$��2��5y      $��25(�5z      $ Right=�5{      $��Center=�5|      �� 5}      $��1��6   
�������$��0q�5�      $��25(�5�      
������ ��5      �� *ProductName+$ TwoWay=�$ PropertyChanged=�5�      �� 5�      $��1��6   $��Bottom=�5�      �� 5�      $��1��6   $��1��5�      $��0q�5�      
�������$��25(�5�      
������ ��5�      �� *ProductAmount+$ TwoWay=�$ PropertyChanged=�5�      �� 5�      $��1��6   $��1��5�      $��Bottom=�5�      �� 5�      $��1��6   $��2��5�      $��0q�5�      
�������$��25(�5�      
������ ��5�      �� *ProductPrice+$ TwoWay=�$ PropertyChanged=�5�      �� 5�      $��1��6   $��2��5�      $��Bottom=�5�      5�      �� 5�      $��
Açıklama��6   $��4��6(   $ Center=�5�      $��Center=�5�      #��[ 5�      $��40(�5�      $��Consolas)�5�      �� 5�      $��5��6   $��7q�6#     AcikGeceYarisiMavisi#��[ 6.   $��Consolas)�5�       �� TextWrapping$
 Wrap=�5�      $��0q�5�      $��25(�5�      ��5�      �� *ProductInfo+$ TwoWay=�$ PropertyChanged=�5�      �� 5�      $��6��6   #��[ 5�      #��[ 5�      $��100,0q�5�      $��Kaydet��5�      ��5�      �� *SaveCommand+��5�      �� $ UpdatePopUpWindow��5�      5�      5�      5�      