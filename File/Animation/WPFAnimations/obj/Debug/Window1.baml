   M S B A M L   `   `   `  ����  WPFAnimations    WPFAnimations.Window1   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5        � Title$  WPF Animations��5      $	��233��6   $	��370��6)   .��5      �  � RowDefinitions 5      �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5      �� 5      $
��Auto �6   .+�5      �� -   5        $��ColorBtn��5      $��50��6   $��25��6&   $
��Left=�62   $��0��6M   ��5      �� 5       �� 
TargetType" ��6   .R�5      � .+�5      A�  A�Name$ PlayButtonEllipse��6   
����d�#��z��6A   #��z��6c    J� Opacity$
 0.75Q�6�   � 5       �Name$ PlayButtonArrow��6    � Points# �   @KL @KL  -1 -1��� 
�������
���   �$	��0.5��5      $��Center=�6.   $��Center=�6K   5       �� Triggers 5      :� 5      	 :� RoutedEvent$	 Button.Click��6   [�5   	   �� 5   
   .��5      �� .��5      �� 
 �� 
TargetName$
 PlayButtonEllipse��6    �� TargetProperty$ 
Fill.Color�6F    �� From$ CornflowerBlueX�6m   	 �� To$
 NavyX�6�    g� Duration$ 0:0:0.5D�6�    g� AutoReverse . 6�   �� 5      $
 PlayButtonArrow��6   $ 
Fill.Color�6D   $ LightYellowX�6k   $ OrangeX�6~   $ 0:0:0.5D�6�    . 6�   5       5!      5#   	   5%      5'      �� 5)      -   5        $
��Rect��5)      $��1��6   $��30��6'   $��50��63   
����  �$
��Left=�6J    � Triggers 5*      :� 5+      $#	 Rectangle.MouseLeftButtonDown��6   [�5,      �� 5-      .��5.   	   �� .��5/   
   W� $ Width�6    W� From$ 50X�50      	 W� To$	 300X�51      $ 0:0:10D�52      �� 53   
   $ 
Fill.Color�6   $ YellowX�54       g� 	BeginTime$ 0:0:5X�55      56   
   57   	   59      5;      �� 5=      -   5        $��
MovingRect��5=      
���  ��$��50��6+   $��25��66   $��2��6B   $
��Left=�6O   ��5>      �� 5?       �� 
TargetType" ��6    �� Triggers 5@      :� 5A      $#	 Rectangle.MouseLeftButtonDown��6   [�5B   	   �� 5C   
   .��5D      �� .��5E      W� $, &RenderTransform.(TranslateTransform.X)�6   $ 0X�6_   $	 200X�6h   5F      5G      5I   	   5K      z�5M      T� 5N       T� X$ 0Q�6    T� Y$ 0Q�6   5P      �� 5R      -   5        $��RedirectionalRect��5R      $��50��6'   $��25��62   
���2͚�$��3��6Q   $
��Left=�6^    5S      :� 5T      $#	 Rectangle.MouseLeftButtonDown��6   [�5U      �� 5V      .��5W   	   �� .��5X   
   U� $
 Trans��6(   $ X�5Y      $ 0:0:15D�5Z      .\�5[      ��  O� Value$	 350Q�6     O� KeyTime$ 0:0:7��6,   �� 5\      $ 50Q�6    $ 0:0:5��6+   �� 5]      $	 200Q�6    $ 0:0:3��6,   5^      5_   
   5`   	   5b      z�5d      T� 5e      -   5        	Trans��$ 0Q�5e   (   $ 0Q�6.   5g      �� 5i      -   5        $��
SplineTest��5i      $��25��6    $��50��6,   
���   �$��4��6D   $
��Left=�6Q   z�5j      T� 5k      -   5        SplineTestTrans��$ 0Q�5k   2   $ 0Q�68    5m      :� 5n      $#	 Rectangle.MouseLeftButtonDown��6   [�5o      �� 5p      .��5q   	   �� .��5r   
   U� $
 SplineTestTrans��6(   $ X�5s      $ 0:0:15D�5t      .\�5u      �� $	 350Q�6    $ 0:0:7��6,    �� 	KeySpline$ 0.0,1.0, 1.0,0.0��6<   �� 5v      $ 0Q�6    $ 0:0:8��6*   $ 0.25,0.5, 0.5,0.75��6:   5w      U� 5x   
   $
 SplineTestTrans��6(   $ Y�5y      $ 0:0:15D�5z      .\�5{      �� $	 350Q�6    $ 0:0:7��6,   $ 0.0,1.0, 1.0,0.0��6<   �� 5|      $ 0Q�6    $ 0:0:8��6*   $ 0.25,0.5, 0.5,0.75��6:   5}      5~   
   5   	   5�      5�      5�      5�      