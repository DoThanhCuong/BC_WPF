   M S B A M L   `   `   `  ����  Simple Animation    MyWPFApp.Window1   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5        � Title$  Simple Animation��5      $	��192��6   $	��428��6+   .��5      �� $��20q�6   .+�5
   
   �� -   5        $��SimpleGreenRectangle��5
      
���""��$��50��5      $��26��6#    J� BitmapEffect 5      O� 5       O� 	GlowColor$ 
DarkViolet��6(   5      �� 5   
    �� Orientation$ Vertical=�6   $��0,20,0,0q�6,   .+�5      �� -   5        $��btnStart��5      $	��133��6%    5      F� 5       F� Color$ 
Chartreuse��6-   .��5   '   Start6/   �� 5      -   5        $��btnStop��5      $	��132��6$    5      F� 5      $ 
Chartreuse��6-   .��5   '   Stop6.    � Triggers 5      :� 5       :� 
SourceName$ btnStart��6    :� RoutedEvent$ Button.Click��65   .[�5       �� -   5         ��Name$ myStoryboard��5    &   .��5!      �� .��5#      W� 	 �� 
TargetName$	 SimpleGreenRectangle��5$      
 �� TargetProperty$
 Width�5%       W� From$ 50X�5&      	 W� To$	 300X�6    g� Duration$ 0:0:4D�6$    g� RepeatBehavior$ Forever��65   5'      5(      5)      :� 5*      $ btnStop��6   $ Button.Click��64   .[�5+      ��  �� BeginStoryboardName$ myStoryboard��6%   5,      5/      50      51      