   M S B A M L   `   `   `  ����B  >TestWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TestWPFTestWPF  5   	       TestWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:TestWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $C =pack://application:,,,/TestWPF;component/Resources/Theme.xaml?�6%   %    5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ Close��5      6)    J� InputBindings 5      �� 5   
    �� Command$ Close��6   
 �� Key$	 Esc��6%   .��5      � $��30q�6   	 � RowDefinitions	 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��1q�5       %  !ComboBox.MaterialDesign.Lightgrey#���   5      ._�5      �� $
��Auto=�6   $	��100��6>   .��5       �� -   5        $��ViewsOrSheets��5       $��10q�5"   #   
���������5!   #   �� *TestControl+��5#      �� 5$      .R�5%      �� $��10(�6(   $	��0 2q�66   ��6C   �� *DisplayValues+
 �� Mode$
 OneWay=�5&      5(      5)      5*      � 5,   
   $��1��6   .+�5-       � -   5        $��FrameWithinGrid��5-      5/      �� 51      -   5        $��button1��51   6   $��23��6   $��114,12,25,0q�6!   $	��Top=�6E   .��6s   Navigate to C# Corner53      55      56      57      