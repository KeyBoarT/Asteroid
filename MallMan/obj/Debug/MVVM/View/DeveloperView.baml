   M S B A M L   `   `   `  ����B  >MallMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MallMan.MVVM.ViewModelMallMan.MVVM.ViewModel  5      5clr-namespace:MallMan.MVVM.ViewMallMan.MVVM.View  5      %    MallMan.MVVM.View.DeveloperView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :	viewmodel$clr-namespace:MallMan.MVVM.ViewModel     5      1localclr-namespace:MallMan.MVVM.View     5        � DataContext  5
      /  )MallMan.MVVM.ViewModel.DeveloperViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   .+�5   
   ��  K� ZIndex$ 1��6      ViewParentBorder#��[  6"   $��0��6L   ._�5      ��  �� Orientation$ Vertical=�6   .+�5      ��   logo#��[ 6   $
��Fill=�67   �� 5      $��Mehmet Sezer��6     LightButton#���  5      $��60��5      $��10q�6%   $��Stretch=�61   ��5      �� *dev1Command+5   1   �� 5      $��
Buse Yener��6   #���  5      $��60��6?   $��10q�6K   $��Stretch=�6W   ��5      �� *dev2Command+5   W   �� 5      $��
Nisa Aksoy��6   #���  5      $��60��6?   $��10q�6K   $��Stretch=�6W   ��5      �� *dev3Command+5   W   5      5       �� 5!   
   $ 1��6   #��[  6"   $��1��6L    �� Padding$ 30q�6\   ._�5"      �  � RowDefinitions 5#      �� 5$      $	��150 �6$   �� 5%       5'      �� 5(      $	��150 �6'   �� 5)      .+�5+      A� $��10q�6   ��5,      �� 5-       �� ImageSource 6%   �� * CurrentDevModel.DeveloperImage+ �� UpdateSourceTrigger$ PropertyChanged=�5/      �� 51      $��1��6    �� TextAlignment$ Center=�52        KoyuGeceYarisiMavisi#���  53      $	��100(�54      $��SemiBold"�55      ��51   ,   �� *CurrentDevModel.DeveloperName+$ PropertyChanged=�55      �� 56      $��0��6   $��Bottom=�6,   $	��6,0q�6G   �� 57      $��1��6   $��Bottom=�6,   $	��6,0q�6G   �� 58      $��1��6   $��1��6,   .��59      �� $��24(�6s    	 Bulut#��[ 6�   $
 Left=�6�   	 �� Padding$	 2q�6�   $��Consolas)�6�   $
��Wrap=�6�   ��6    �� *CurrentDevModel.DeveloperCV+$ PropertyChanged=�6�   5:      5;      5<      �� 5=   
   #���  6   $ 0��66   
 �� CornerRadius$
 0,0,5,0��6G   $��0q�6^   $��2��6r   $��2��6�   ._�5>      �� $
��Fill=�6    �� BitmapScalingMode$
 Fant=�5?       J� OpacityMask 5@      �� 5A       �� EndPoint$ 0.5, 1&�6*    �� 
StartPoint$ 0.5, 0&�6<   .��5B      �  � Color$ Transparent��6'    � Offset$ 0Q�6;   � 5C        
BulutRengi# [ 6'   $ 1Q�6K   5D       � Triggers 5F      :� 5G       :� RoutedEvent$ Loaded��6#   .[�5H      �� .��5I      ��  g� RepeatBehavior$ Forever��6)   .��5J   "   T�  �� TargetProperty$ Source�6@    g� Duration$ 0:0:40D�6c   ..�5K   &   i�  R� KeyTime$ 0:0:0��6=     
developer1 R� Value# [ 6M   i� 5L   &   $ 0:0:10��6=     
developer2# [ 6N   i� 5M   &   $ 0:0:20��6=     
developer3# [ 6N   i� 5N   &   $ 0:0:30��6=    	 
developer4# [	 6N   5O   #   5P      5Q      5R      5T      5U      5V      5W      