   M S B A M L   `   `   `  ����V  RProyectos.Administrador.GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Proyectos.Administrador.GUIProyectos.Administrador.GUI  5   	   ,    &Proyectos.Administrador.GUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Proyectos.Administrador.GUI     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��600��5      $
��1080��6!     � 
ResizeMode$  NoResize=�6.    � WindowStartupLocation$ CenterScreen=�6D    � WindowStyle$
 None=�6i   
������� � 	Resources 5	         	MenuAbrir �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  
MenuCerrar��%�  &	        &	 �     �� 5
   
   .��5      U� $ (FrameworkElement.Width)�6,   $
 Menu��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $
 Menu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.5��6'   $ 60Q�69   5      5      5       � Triggers 5      :� 5   
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 	AbrirMenu��66   .[�5      �� #��[  6   5      :� 5   
   $	 ButtonBase.Click��6   $
 
CerrarMenu��66   .[�5      �� #��[ 6   5      .��5#      � 
�������.+�5$   
   �� $��296,120,280,60q�6   ��5%      �� 5&       �� ImageSource$ Imagenes/lagoReCSaM.png��6   5(      � 5)   
   $��60��6   $	��Top=�6   ���	#FF3C91E6.+�5*      �� $��ReCSaM��6   $��Center=�6&   $��Center=�6C   $��60(�6^   $��430,-12,378,-8q�6l   $	��272��6�   �� 5+      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�5,      �� $��ReCSaM��6   $��Center=�6*   $��18(�6E   '  !MaterialDesignThemes.Wpf.PopupBox  5-      $��10q�6+      PlacementMode$ BottomAndAlignRightEdges=�67      	StaysOpen .     PopupContent. 5.      �� $	��150��6!   .+�52      �� -   5         ��Name$ ButtonPopup��52   !   $��Salir��6R   57      58      5:      5;      � 5<   
   -   5         �Name$
 Menu��5<      $��60��6   $
��Left=�6(   ���	#FF3C91E6.+�5=      �� .+�5>      � $��59��6   
�������$��0,0,4,0q�66   .+�5?      �� -   5        $ 
CerrarMenu��5?      $��60��6J   $��60��6U   
�������$	��Top=�6�   $��Right=�6�   $y�	Collapsed=�6�   ��6t   Z� .��5@      '  !MaterialDesignThemes.Wpf.PackIcon  ���	#FF1B3861�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowLeft=�6I   $��25��6Z   $��25��6e   5A      �� 5B      -   5        $ 	AbrirMenu��5B      $��56��6H   $��60��6S   
�������$	��Top=�6�   $��Right=�6�   $��0,0,0,-1q�6�   ��6r   Z� .��5C        ���	#FF1B3861$
 Menu=�6I   $��40��6U   $��30��6`   5D      5E      �� 5F      $��Disabled=�6   ���	#FF1368BD.@�5G      �� $��60��6#   .��5H      �� $ 
Horizontal=�6%   .+�5I        $ Pencil=�66   $��25��6D   $��25��6O   $��10q�6[   $��Center=�6g   
�������6�   �� 5J      -   5        $��btnAdmin��5J   %   $��Administrador��6L   $��Center=�6d   $��2q�6   $	��150��6�   5K      5L      5Q      5S      5U      5W      5Y      