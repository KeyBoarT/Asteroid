   M S B A M L   `   `   `  ����B  >MallMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MallManMallMan  5   	   ?$clr-namespace:MallMan.MVVM.ViewModelMallMan.MVVM.ViewModel  5   	       MallMan.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MallMan     5   	   :	viewmodel$clr-namespace:MallMan.MVVM.ViewModel     5   	   -   5          �Name$  windowLogin��5	   	    � AllowsTransparency . 
������  � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ LoginWindow��5   	   $	��500��6   $	��800��6*    � DataContext 5      +  %MallMan.MVVM.ViewModel.LoginViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��1.5* �6   .+�5   
   ��  �� CornerRadius$ 	10,0,0,10��6   $��2��6*   ��5      �� 5      	 �� 
StartPoint$		 0,0&�6&   
 �� EndPoint$	
 1,1&�67   .��5      �    GeceYarisiMavisiRengi � Color# [  6#    � Offset$ 0Q�6R   � 5        AcikGeceYarisiMavisiRengi# [ 6#   $ 1Q�6V   5      ._�5!      � .+�5"      �� .+�5#      �  � Points �    -1��� ;X��  GeceYarisiMavisi#��[ 6;   � 5$      ' �    �� �� ���� ��
��#��[ 6A   A� 5%      $��250, 430, 0, 0q�6   $��40��66   $��40��6A   #��[ 6M   A� 5&      $��50, 400, 0, 0q�6   $��20��65   $��20��6@   #��[ 6L   5'      �� 5)      $��20,50,20,20q�6   5*      5+      �� 5-   
   
�������$ 	0,10,10,0��6$   $��2��6=   $��2��6M    J� InputBindings 5.      d� 5/       d� MouseAction$ 	LeftClicke�6    �� Command 50   #   �� *MoveWindowCommand+ �� CommandParameter 51   #   ��  �� ElementName$ windowLogin��._�53      �� .+�54      ��  �� Orientation$ 
Horizontal=�6   $��Right=�66   $��50��6R   .+�55      �� $	��╳��6     TitleMenuButton#��[ 56      $	��2.5q�57      ��58      �� *CloseWindowCommand+��59      �� $ windowLogin��5:      �� 5;      $��36(�6   $
��Bold"�5<       �� TextAlignment$ Center=�5=      ���#566472$��
Giriş Yap��5?       J� Effect 5@      3  -System.Windows.Media.Effects.DropShadowEffect  5A         ShadowDepth$ 1Q�6+     KoyuGeceYarisiMavisiRengi   Color# [ 6;      RenderingBias$ Quality=�6n   5C      �� 5D      $ 
Horizontal=�6   $
��0,20q�66   $��Center=�6D   .+�5E      ��   
IconButton#��[ 6   5F      �� 5G      $$��ID Adresini girerek giriş yap��6   $��20(�5H        �� 
LineHeight$ 28��5I       $
��Wrap=�5J       $ Center=�5K       
������ ���#878787 J� Opacity$	 0.8Q�5N       $��	0 10 0 15q�5O       �� 5P      $��1q�6   ���#ACB0AF$
��70 7q�6C   $ 5��6Q   ._�5Q      � $	��7 9q�6    5R      �� 5S      $
��auto �6/   �� 5T      $��* �6/   .+�5V      �� $��/Icons/mail.png��6    $��20��69   $��10, 0q�6E   �� 5W        EmailBox#��[ 6"   $��1��6D   $��Admin ID��6T   5X      5Y      �� 5[      $��1q�6   ���#ACB0AF$
��70 7q�6C   $ 5��6Q   ._�5\      � $	��7 9q�6    5]      �� 5^      $
��auto �6/   �� 5_      $��* �6/   .+�5a      �� $��/Icons/lock.png��6    $��20��69   $��10, 0q�6E   �� 5b        PasswordBox#��[ 6"   $��1��6G   $��Parola��6W   5c      5d      �� 5e      -   5         ��Name$ 
rememberMe��5j      $
��70,0q�5e      $��Beni Hatırla��5f      $��Consolas)�5g      $��14(�5h        AcikGeceYarisiMavisi#��[ 5k       d� 	IsChecked 5i      �� *
RememberMe+ �� Mode$ TwoWay=�5k      �� 5l      $��
Giriş Yap��6    	 
DarkButton#��[	 5m      $��0,16,0,0q�5n      ��5o      �� *SignInCommand+��5p      �� $ windowLogin��5q      5r      5s      5t      