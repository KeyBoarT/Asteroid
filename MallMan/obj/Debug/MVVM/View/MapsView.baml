   M S B A M L   `   `   `  ����B  >MallMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MallMan.MVVM.ViewModelMallMan.MVVM.ViewModel  5      5clr-namespace:MallMan.MVVM.ViewMallMan.MVVM.View  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5           MallMan.MVVM.View.MapsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :	modelview$clr-namespace:MallMan.MVVM.ViewModel     5      1localclr-namespace:MallMan.MVVM.View     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5        � DataContext  5      *  $MallMan.MVVM.ViewModel.MapsViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��3* �6   .+�5   
   ��    ViewParentBorder#��[  6    K� ZIndex$ 1��6;   $��1��6L    �� Padding$	 7.5q�6\   
������ ._�5        LiveCharts.Wpf.GeoMap     Source$@ :C:\Users\mehme\source\repos\MallMan\MallMan\Map\Turkey.xml��6   
������    	Hoverable .    HeatMap 6]   �� *	KeyValues+6�   5      �� 5   
    	 Bulut#���  6   $ 0��66    �� CornerRadius$ 0,0,5,0��6G   $��0q�6^   $��2��6r   $��2��6�   ._�5      �� $
��Fill=�6    �� BitmapScalingMode$
 Fant=�5      	 J� OpacityMask	 5      �� 5      
 �� EndPoint$
 0.5, 1&�6*    �� 
StartPoint$ 0.5, 0&�6<   .��5      �  � Color$ Transparent��6'    � Offset$ 0Q�6;   � 5        
BulutRengi# [ 6'   $ 1Q�6K   5       � Triggers 5      :� 5       :� RoutedEvent$ Loaded��6#   .[�5       �� .��5!      ��  g� RepeatBehavior$ Forever��6)   .��5"   "   T�  �� TargetProperty$ Source�6@    g� Duration$ 0:0:40D�6c   ..�5#   &   i�  R� KeyTime$ 0:0:0��6=    
 earth1 R� Value# [ 6M   i� 5$   &   $ 0:0:10��6=    
 earth2# [ 6N   i� 5%   &   $ 0:0:20��6=    
 earth3# [ 6N   i� 5&   &   $ 0:0:30��6=    
 earth4# [ 6N   5'   #   5(      5)      5*      5,      5-      5.      5/      