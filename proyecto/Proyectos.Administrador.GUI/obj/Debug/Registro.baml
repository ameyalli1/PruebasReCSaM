   M S B A M L   `   `   `  ����V  RProyectos.Administrador.GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Proyectos.Administrador.GUIProyectos.Administrador.GUI  5   	   *    $Proyectos.Administrador.GUI.Registro   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Proyectos.Administrador.GUI     5   	     � Title$  ReCSaM Registro��5   	   $	��470��6!   $	��320��6.   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/    �� 
StartPoint$ 0.5,0&�6S   .��5      �  � Color$ Black��6   � 5      $ 	#FF3C91E6��6    � Offset$ 1Q�6-   5      .��5      �� 
������� �� CornerRadius$ 20��6    $��20q�62   ._�5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    $	��137��6.   �� 5      $
��auto �6    $��79��6.   �� 5      $
��auto �6    $��38��6.   �� 5      $
��auto �6    $��60��6.   �� 5      $
��auto �6    $��60��6.   �� 5      $
��auto �6    $��25��6.   .+�5      �� $��0��6   $��0��6!   $��Center=�61   $	��120��6N   $��76,16,76,15q�6Z   ��5      �� 5       �� ImageSource$ Imagenes/lagoReCSaM.png��6!   5      � 5      $��0��6   $��1��6(   	 � Orientation$	 Vertical=�65   $��Center=�6L   $
��51,0q�6i   $	��170��6w   .+�5       �� 
 �� Orientation$
 Vertical=�6   $��3q�64   .+�5!      �� $
��Bold"�6   .��6.   	Empresa67   �� 5"      -   5         ��Name$ txtNombreEmpresa��5"      $	��199��68   $��25��6D   6R   �� 5#      $
��Bold"�6   .��6.   Contraseña6:   5$      5%      G� 5&      -   5         G�Name$ txtContrasena��5&      $��0��61   $��2��6A   $��	62,6,90,6q�6N   �� 5'      -   5        $ txtContrasenaLabel��5'      $��0��62   $��2��6B   $��	51,6,85,6q�6O   �� 5(      -   5         ��Name$ cheVisualizarContrasena��5(      $��Right=�6^   $��0��6z   $��2��6�   $
��0,10q�6�   $��71��6�   � 5+      $��3��6   $	 
Horizontal=�6%   $��
68,10,10,0q�6>   .+�5,      �� -   5         ��Name$ btnRegistro��5,      $��2q�6H   $��Center=�6T   $
��Auto��6q   $	��120��6   .��5-      �� $
 
Horizontal=�6!   .+�5.      �� .��6    	Registrar6+   �� 5/      $��16��6    $��/Imagenes/page_save.png��6+   6N   50      51      52      � 53      $��4��6   $	 
Horizontal=�6%   $��
68,10,10,0q�6>   .+�54      �� -   5        $ btnRegresar��54      $��2q�6J   $��Center=�6V   $
��Auto��6s   $	��120��6�   .��55      �� $
 
Horizontal=�6!   .+�56      �� .��6    
Regresar6*   �� 57      $��16��6    $#��/Imagenes/arrow_turn_left.png��6+   6T   58      59      5:      5<      5=      5>      