   M S B A M L   `   `   `  ����J  FQL_DatVeXemPhim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:QL_DatVeXemPhimQL_DatVeXemPhim  5   	       QL_DatVeXemPhim.frmLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:QL_DatVeXemPhim     5   	   -   5          � Title$  
The Parcel��5   	   $	��354��6   $	��618��6)   {�.  � ShowInTaskbar .  � WindowStyle$
 None=�6[    � WindowStartupLocation$ CenterScreen=�6n   ��5	      �� 5
   
    �� ImageSource$U OC:\Users\cuongdo\Desktop\WPF\QL_DatVeXemPhim\Images/Simple-Orange-Wallpaper.jpg��6    � 	Resources 5         imgLogin��%f   &	        �� 5   
   $H��BC:\Users\cuongdo\Desktop\WPF\QL_DatVeXemPhim\Images\loginimage.png��6!   5      .��5      (�  (� Stretch$ Uniform=�6   .��5   
   �  � ShowGridLines .   � ColumnDefinitions 5      �� 5      $
��356* �6#   �� 5      $��0* �6#   �� 5      $	��80* �6#   �� 5      $	��22* �6#   �� 5      $	��45* �6#   .+�5      �� -   5        $��	groupBox1��5   k   $��
Login Here��6   $	��270��6+   $��Center=�68   $��209,12,12,12q�6U   $��Center=�6|   $	��374��6�   $��5��6�   $��Center=�6�   $��Center=�6�   $��15(�6�   |�. .��5      � $	��240��6    5      �� 5      $	��50* �6+   �� 5      $
��138* �6+   .+�5!      �� -   5        $��txtUserName��5!   W   $��28��6   $
��Left=�6*   $��3,51,0,0q�6E   $	��Top=�6j   $	��241��6�   $��1��6�   G� 5"      -   5        $��txtPassword��5"   \   $��28��6"   $
��Left=�6.   $��	2,108,0,0q�6I   $	��Top=�6o   $	��242��6�   $��1��6�   �� 5#      -   5        $��btnLogin��5#   y   $��Login��6   $��34��6-   	 �� 	IsDefault	 . $
��Left=�6J   $��
19,175,0,0q�6e   $	��Top=�6�   $��82��6�   

 J� Uid$
 btnLogin��6�   $��1��6�   ��5$      �� 5%       �� EndPoint$ 0.5,1&�62    �� 
StartPoint$ 0.5,0&�6C   .��5&   "   �  � Color$ Black��6/    � Offset$ 0Q�6=   � 5'   "   $ 	#9300B100��6/   $ 0.472Q�6A   5(      5*      �� 5+      -   5        $��	btnCancel��5+   j   $��Cancel��6   $��34��6.   $
��Left=�6:   $��122,175,0,0q�6U   $	��Top=�6{   $��82��6�   $
 	btncancel��6�   $��1��6�   ��5,      �� 5-      $ 0.5,1&�62   $ 0.5,0&�6C   .��5.   "   � $ Black��6/   $ 0Q�6=   � 5/   "   $ 	#9300B100��6/   $ 0.472Q�6A   50      52      �� 53      -   5        $��label1��53   k   $��User Name :��6   $��28��62   $
��Left=�6>   $��6,51,0,0q�6Y   $	��Top=�6y   �� 54      -   5        $��label2��54   a   $��
Password :��6   $
��Left=�61   $��6,108,0,104q�6L   6a   �� 55      -	   5        $��lblErr1��55   �   $2��,You have entered wrong UserName or Password.��6   $��29��6S   $
��Left=�6_   $��6,6,0,0q�6z   $	��Top=�6�   ���	#FF1526EF$	��334��6�   $��2��6�   $y�Hidden=�6�   �� 56      -
   5        $��lblErr2��56   �   $'��!Please enter correct credentials.��6   ���	#FF1526EF$��29��6_   $
��Left=�6k   $��6,24,0,0q�6�   $	��Top=�6�   $	��227��6�   $��2��6�   $y�Hidden=�6�   �� 57      -   5         ��Name$ erUser��57   G   $��19��6    $
��Left=�6,   $	��Top=�6X   $	��235��6p   $��9,84,0,0q�6|    J� OpacityMask
 �<�����	#FFE5572C$��1��6�   �� 58      -   5        $ erPass��58   G   $��19��6    $
��Left=�6,   $	��Top=�6X   $	��235��6p   $��	3,141,0,0q�6|   
 �<�����	#FFE5572C$��1��6�   59      5:      �� 5;      -   5        $��image1��5;   Q   $	��260��6   $
��Left=�6#   $��	12,43,0,0q�6>   $
��Fill=�6_   $	��Top=�6n   $	��191��6�   $��Images/loginimage.png��6�    J� Opacity$ 10Q�6�   5<      5=      5>      