   M S B A M L   `   `   `  ����J  FBuildVersionWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BuildVersionWPFBuildVersionWPF  5   	        BuildVersionWPF.MainWindow   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   8x,http://schemas.microsoft.com/winfx/2006/xaml    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5   	   -localclr-namespace:BuildVersionWPF    5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         buildversionTemplate  buildversionTemplate1  Storyboard1 �� TargetProperty �� 
TargetName O� KeyTime O� Value��%�  &	        &	 Z     &	 �     �� 5
   
   .R�5      �� .+�5      �� ��6   �� *build+5      5      �� 5   
   .R�5      �� .+�5      �� ��6   �� *name+5      5      �� 5   
   .��5      U� $ (UIElement.Opacity)�6,   $ listBox��6\   .\�5      �� $ 0��6'   $ 0Q�63   �� 5      $ 0:0:1��6'   $ 1Q�67   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[ 6   5      .��5       �  � DataContext 6   ��   dataSampleDataSource	 �� Source#	 [ .+�5!   
   �� -   5        $��Detail��5!      $��3��6'   $��3��64   $��9,0,0,0q�5#      �� 5$   
   -   5        
 ��Name$
 listBox��5$      #���  6#   $��
10,10,0,10q�6�   $
��Left=�6�   $��240.115��6�   ��6Z   �� *buildversionCollection+6�   5%      5&      