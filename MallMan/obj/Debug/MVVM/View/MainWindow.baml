   M S B A M L   `   `   `  ����B  >MallMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MallMan.MVVM.ViewMallMan.MVVM.View  5   	   ?$clr-namespace:MallMan.MVVM.ViewModelMallMan.MVVM.ViewModel  5   	   +clr-namespace:MallMan.CoreMallMan.Core  5   	   "    MallMan.MVVM.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MallMan.MVVM.View     5   	   :	modelview$clr-namespace:MallMan.MVVM.ViewModel     5   	   1
extensionsclr-namespace:MallMan.Core     5   	   -   5          �Name$  
windowMain��5   	   
������  � AllowsTransparency .  � WindowStyle$
 None=�5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 
MainWindow��5   	   $	��900��5   	   $	��900��5   	   $
��1600��5   	   $
��1600��5   	    � DataContext 5      *  $MallMan.MVVM.ViewModel.MainViewModel  5   
   .��5      ]� -   5         ]�Name$ 	RootPanel��5      
������ .+�5   
   �� $��75��6   $
��Left=�5       �� CornerRadius$ 5,0,0,5��5      ��5      �� 5      	 �� 
StartPoint$
	 .5,0&�6&   
 �� EndPoint$

 .5,1&�68   .��5      �    GeceYarisiMavisiRengi � Color# [  6#    � Offset$ .3Q�6R   � 5         islakAsfaltRengi# [ 6#   $ 1Q�6M   5!      ��5#      �� 5$       �� Triggers 5%      :� 5&       :� RoutedEvent$ Border.MouseEnter��6'   .[�5'      �� .��5(   "   �� .��5)   &   W�  �� TargetProperty$ (Border.Width)�66   	 W� To$	 200X�5*   6    g� Duration$ 0:0:.1D�5+   6   5,   #   5-      5.      :� 50      $ Border.MouseLeave��6'   .[�51      �� .��52   "   �� .��53   &   W� $ (Border.Width)�66   $ 75X�54   6   $ 0:0:.1D�55   6   56   #   57      58      5:      ._�5<      �  � RowDefinitions 5=      �� 5>      $	��100 �6$   �� 5?      �� 5@      $��60 �6$   .+�5B      ��   GeceYarisiMavisi#��[ 6   $ 5,0,0,0��6H    J� Effect 5C      3  -System.Windows.Media.Effects.DropShadowEffect  5D         ShadowDepth$ .5Q�6+      	Direction$ 0Q�6<      Opacity$ .3Q�5E   /   ._�5G      �� $��/Icons/icon.png��6   $	��200��65   $	��100��6A   $��8,8,0,0q�6N   5H      �� 5I      $��1��6   ._�5J      ��  �� Orientation$ Vertical=�6!   $��0,16,0,0q�5K   !   .+�5L      	� $��Anamenü��6&    d� 	IsChecked$
 TrueY�5M   &     MallMan.Core.Extensions   Icon$
 🏠��5O   &   ��5N   &   �� *ShowHomeViewCommand+5O   &   	� 5P      $��
Mağazalar��6&   $
 📰��5R   &   ��5Q   &   �� *ShowStoresViewCommand+5R   &   	� 5S      $��Harita��6&   $
 🗺��5U   &   $��2,0,-2,0q�6F   ��5T   &   �� *ShowMapsViewCommand+5U   F   	� 5V      $��Ayarlar��6&   $
 🔧��5X   &   ��5W   &   �� *ShowSettingViewCommand+5X   &   	� 5Y      $��Geliştirici��6&   $
 🔍��5[   &   ��5Z   &   �� *ShowDeveloperViewCommand+5[   &   5\      5]      �� 5^        islakAsfalt#��[ 6   $��2��5_      $ 0,0,0,5��5`      ._�5a      �� $��Version 1.0.0��6    $��9(�5b        �� TextAlignment$ Center=�5c       $��Consolas)�5d       $��Center=�5e       $��Stretch=�5f        	 Beton#��[ 5g       5h      5i      5j      �� 5k   
   $ 0,5,5,0��6   ��5l      �� 5m      $
	 .5,0&�6&   $

 .5,1&�68   .��5n      �   
BulutRengi# [ 6#   $ 0Q�6G   � 5o      $ 	AliceBlue��6#   $ 1Q�66   5p      ._�5r      ]� .+�5s      �� 
������ $	��100��5t      $ 0,5,0,0��5u      $	��Top=�5v       J� InputBindings 5w      d� 5x       d� MouseAction$ 	LeftClicke�6'    �� Command 5y      �� *MoveWindowCommand+ �� CommandParameter 5z      ��  �� ElementName$ 
windowMain��d� 5|      $ LeftDoubleClicke�6'    5}      �� *MaximizeWindowCommand+ 5~      �� $ 
windowMain��._�5�      �   � ColumnDefinitions  5�      �� 5�      �� 5�      $	��250 �6/   .+�5�      �� $��36(�5�      $��DemiBold"�5�      $��Miriam Mono CLM)�5�      $��Bottom=�5�      #��[ 5�      $��	10,0,0,16q�5�      ��5�   $   �� *CurrentAccount.AdminName+ 5�        5�   "   $ .5Q�63   $ 0Q�6D   $ .3Q�5�   /   5�      �� 5�      $��0,0,10,0q�5�      $ 
Horizontal=�5�      $��Right=�5�      $��1��5�      .+�5�      o� $
��10,5q�6#   
������ $��Center=�6J   $��Center=�6g   .@�5�   "   m� $	��☰��6+   $��12,0,0,0q�5�   +     MainMenuItem#��[ 5�   +   .@�5�   &   m� $��	Çıkış��6/     SubMenuItem#��[ 6>   ! m� Command! 6c   �� *CloseWindowCommand+" m� Icon" 5�   *   �� 5�   .   $��/Icons/exit.png��64   5�   '   m� 5�   &   $��Minimize��6/   #��[ 5�   /   ! 5�   /   �� *MinimizeWindowCommand+# m� CommandParameter# 5�   /   �� $ 
windowMain��" 5�   *   �� 5�   .   $��/Icons/minimize.png��64   5�   '   m� 5�   &   $��Maximize��6/   #��[ 5�   /   ! 5�   /   �� *MaximizeWindowCommand+# 5�   /   �� $ 
windowMain��" 5�   *   �� 5�   .   $��/Icons/maximize.png��64   5�   '   m� 5�   &   $��	Güncelle��6/   #��[ 5�   /   ! 5�   /   �� *RefreshWindowCommand+" 5�   *   �� 5�   .   $��/Icons/refresh.png��64   5�   '   5�   #   m� 5�   "   $
��🔔��6+   $��7,0,0,0q�5�   +   #��[ 5�   +   .@�5�   &   m� $��Selam��6/   #��[ 6>   " 5�   *   �� 5�   .   $��/Icons/hello.png��64   5�   '   5�   #   5�      A� 5�      $��75��6&   $��75��61   ��5�   "   �� 5�   &   $ j� Stretch$
$ Fill=�6�   % �� ImageSource% 61   �� *CurrentAccount.AdminImage+& �� UpdateSourceTrigger$& PropertyChanged=�6�   5�      5�      5�      5�      �� 5�      ��6#   �� *CurrentView+' �� Mode$' TwoWay=�$& PropertyChanged=�5�      5�      5�      5�      