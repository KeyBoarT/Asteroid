   M S B A M L   `   `   `  ����B  >MallMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MallMan.MVVM.ViewModelMallMan.MVVM.ViewModel  5   	   5clr-namespace:MallMan.MVVM.ViewMallMan.MVVM.View  5   	   '    !MallMan.MVVM.View.ProductAddPopUp   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   :	viewmodel$clr-namespace:MallMan.MVVM.ViewModel     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MallMan.MVVM.View     5   	   -   5          �Name$  AddPopUpWindow��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � Title$ ProductUpdatePopUp��5   	   $
��1000��6$   $	��600��62    � DataContext 5      5  /MallMan.MVVM.ViewModel.ProductAddPopUpViewModel  5   
   .��5      ��    islakAsfalt#��[  6    �� CornerRadius$ 5��5       �� Padding$ 7q�5      $��0q�5      	 J� Effect	 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 10Q�6      Color$ Black��6/      ShadowDepth$ 10Q�6=   ._�5   
   �  � RowDefinitions 5      �� 5      $��45 �6    �� 5      $	��200 �6    �� 5      $��60 �6    �� 5      $	��150 �6    �� 5       $��60 �6    �� 5!      �� 5"      $��60 �6    .+�5$      �� 
������ ._�5%      �� $��40��6   $��40��5&      $��1��5'        TitleMenuButton#��[ 5(      $��X��5)       	 Bulut#��[ 5,      ��5*      ��  �� ElementName$ AddPopUpWindow����5+      �� *CloseWindowCommand+5,       J� InputBindings 5-      d� 5.       d� MouseAction$ 	LeftClicke�6#    �� Command 5/   #   �� *MoveWindowCommand+ �� CommandParameter 50   #   �� $ AddPopUpWindow����52      �� 53       �� Triggers 54      P� 55       P� Property �@J�IsMouseOver P� Value . . �56   "   ��  �� Property � �� �� Value# [ 6F   57      59      5;      �� 5<      -   5         ��Name$ imageBorder��5>      $��1��5<      $	��190��5=      $ 5��5?      $��2q�5@      
����� �$
��0,10q�5B      ��5C      �� 5D       �� ImageSource 6!   �� *Image+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5F      �� 5G      $��2��6     GeceYarisiMavisi#��[ 5J        newProductButton#��[ 5K      $��100,0q�5L      $��
Resim Ekle��5M      ��5H      �� *AddImageCommand+��5I      �� $ imageBorder��5M      � 5N      $��3��6    5O      �� 5P      �� 5Q      �� 5R       � ColumnDefinitions 5T      �� 5U      �� 5V      .+�5X      �� $��Ürün Adı��6   
�������$��25(�5Z       �� TextAlignment$
 Left=�5[      $��Center=�5\      �� 5]      $��:��6   
�������$��25(�5_      $ Right=�5`      $��Center=�5a      �� 5b      $��Ürün Adedi��6   
�������$��1��5d      $��25(�5e      $
 Left=�5f      $��Center=�5g      �� 5h      $��:��6   
�������$��1��5j      $��25(�5k      $ Right=�5l      $��Center=�5m      �� 5n      $��Ürün Fiyatı��6   
�������$��2��5p      $��25(�5q      $
 Left=�5r      $��Center=�5s      �� 5t      $��:��6   
�������$��2��5v      $��25(�5w      $ Right=�5x      $��Center=�5y      �� 5z      $��1��6   
�������$��0q�5}      $��25(�5~      
������ ��5|      �� *ProductName+$ TwoWay=�$ PropertyChanged=�5      �� 5�      $��1��6   $��Bottom=�5�      �� 5�      $��1��6   $��1��5�      $��0q�5�      
�������$��25(�5�      
������ ��5�      �� *ProductAmount+$ TwoWay=�$ PropertyChanged=�5�      �� 5�      $��1��6   $��1��5�      $��Bottom=�5�      �� 5�      $��1��6   $��2��5�      $��0q�5�      
�������$��25(�5�      
������ ��5�      �� *ProductPrice+$ TwoWay=�$ PropertyChanged=�5�      �� 5�      $��1��6   $��2��5�      $��Bottom=�5�      5�      �� 5�      $��
Açıklama��6   $��4��6(   $ Center=�5�      $��Center=�5�      #��[ 5�      $��40(�5�      $��Consolas)�5�      �� 5�      $��5��6   $��7q�6#     AcikGeceYarisiMavisi#��[ 6.   $��Consolas)�5�       �� TextWrapping$
 Wrap=�5�      $��0q�5�      $��25(�5�      ��5�      �� *ProductInfo+$ TwoWay=�$ PropertyChanged=�5�      �� 5�      $��6��6   #��[ 5�      #��[ 5�      $��100,0q�5�      $��Kaydet��5�      ��5�      �� *SaveCommand+��5�      �� $ AddPopUpWindow��5�      5�      5�      5�      