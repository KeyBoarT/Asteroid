   M S B A M L   `   `   `  ����B  >MallMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MallMan.MVVM.ViewMallMan.MVVM.View  5      ?$clr-namespace:MallMan.MVVM.ViewModelMallMan.MVVM.ViewModel  5      $    MallMan.MVVM.View.ProductsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:MallMan.MVVM.View     5      :	viewmodel$clr-namespace:MallMan.MVVM.ViewModel     5        � DataContext  5
      .  (MallMan.MVVM.ViewModel.ProductsViewModel  5   
   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      .+�5   
   ��    newProductButton#��[  6   $	��200��5      $
��Left=�5      ��5      �� *AddProductCommand+��5      �� 5       �� Orientation$ 
Horizontal=�6   $��Stretch=�5      .+�5      �� $F��@C:\Users\mehme\source\repos\MallMan\MallMan\Icons\newProduct.png��6   $��40��5      $��0,0,20,0q�5      $��40��5      �� 5      $��Yeni Ürün��6    $��Center=�5        5!      5#      �� 5$   
   $ 
Horizontal=�6   $��Right=�5%      .+�5&      �� #��[  6   $	��Sil��5'      $	��100��5)      $��0,0,30,0q�5*      $��Center=�5+      ��5(      �� *DeleteProductCommand+5,      �� 5.      #��[  6   $��Düzenle��5/      $	��150��51      $��0,0,30,0q�52      $��Center=�53      ��50      �� *EditProductCommand+54      �� 55      $	��350��6   
������� �� CornerRadius$ 10��57      $��0,0,30,0q�58       �� Padding$ 10q�59      ._�5:      �� $ 
Horizontal=�6   .+�5;      �� $��20��6   $��20��5<      $B��<C:\Users\mehme\source\repos\MallMan\MallMan\Icons\search.png��5=      �� 5>      $	��300��6    �� TextAlignment$
 Left=�5@      $��Center=�5A      
�������$��0q�5C      ��5?      �� *Filter+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5C      5D      5E      �� 5F      $	��150��6   
�������$��0,0,0,0q�5H      $ 10��5I      $
 10,0q�5J      ._�5K      o� 
������ $��Center=�5L      
�������$��Verdana)�5N      $��14(�5O      .@�5P      m� $��Filtrele��6   $��Center=�5Q   #    m� Icon 5R      �� 5S      $B��<C:\Users\mehme\source\repos\MallMan\MallMan\Icons\search.png��6$   .@�5U      m� $��Ürün Adı��6#   
�������$��Center=�5X   #   	 m� Command	 5V   #   �� *FilterByName+5Y      m� 5Z      $��	Ürün No��6#   
�������$��Center=�5]   #   	 5[   #   �� *FilterByProductNo+5^      m� 5_      $��Ürün Fiyatı��6#   
�������$��Center=�5b   #   	 5`   #   �� *FilterByProductPrice+5c      5d      5e      5f      5g      � 5h   
   $��2��6   
 � ColumnDefinitions
 5i      �� 5j      $��70 �6#   �� 5k      $	��680 �6#   �� 5l      �� 5m      .+�5o      �� $��#��6    �� TextAlignment$ Center=�5p      $��Verdana)�5q      $��Center=�5r      $��20(�5s      $
��Bold"�5t      
���iii�5u      �� 5v      $��Ürün Detayları��6   $��1��5w      $��Verdana)�5x      $
 Left=�5y      $��Center=�5z      $��20(�5{      
���iii�5|      �� 5}      $��Fiyat��6   $��2��5~      $��Verdana)�5      $
 Left=�5�      $��Center=�5�      $��20(�5�      
���iii�5�      �� 5�      $��Ürün Adedi��6   $��3��5�      $��Verdana)�5�      $
 Left=�5�      $��Center=�5�      $��20(�5�      
���iii�5�      5�      �� 5�   
   $��3��6   
������   ProductCard#��[ 5�      $��0q�5�       �� SelectedItem 5�      �� *SelectedProduct+$ TwoWay=�$ PropertyChanged=���5�      �� *ProductsCollectionView+$ PropertyChanged=�5�      5�      5�      