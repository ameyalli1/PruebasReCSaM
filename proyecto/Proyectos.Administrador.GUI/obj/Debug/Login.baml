   M S B A M L   `   `   `  ����V  RProyectos.Administrador.GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Proyectos.Administrador.GUIProyectos.Administrador.GUI  5   	   '    !Proyectos.Administrador.GUI.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Proyectos.Administrador.GUI     5   	     � Title$  ReCSaM Login��5   	   $	��450��6   $	��320��6+   ��5
      �� 5   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/    �� 
StartPoint$ 0.5,0&�6S   .��5      �  � Color$ Black��6   � 5      $ 	#FF3C91E6��6    � Offset$ 1Q�6-   5      .��5      �� 
������� �� CornerRadius$ 20��6    $��20q�62   ._�5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��0��6   $��0��6!   $��Center=�61   $	��120��6N   $	��120��6[   $��15q�6g   ��5      �� 5       �� ImageSource$ Imagenes/lagoReCSaM.png��6!   5      �� 5      $��0��6   $��1��6)   	 �� Orientation$	 Vertical=�66   $��Center=�6M   $��2q�6j   .+�5       �� $
��Bold"�6   .��6*   	Empresa63   �� 5!      -   5        
 ��Name$
 
cmbEmpresa��5!      $��32��60   $	��207��6<   $��3q�6I   $
��Bold"�6T   �� 5"      $
��Bold"�6   .��6*   Contraseña66   5#      �� 5$      -   5         ��Name$ txtContrasenaLabel��5$      $��0��62   $��2��6B   $��25��6P   $	��160��6\   $��3q�6i   6v   G� 5%      -   5         G�Name$ txtContrasena��5%      $��0��61   $��2��6A   $��25��6O   $��	30,7,56,7q�6\   $
��Bold"�6o   �� 5&      -   5         ��Name$ cheVisualizarContrasena��5&      $��Right=�6^   $��0��6z   $��2��6�   $��15��6�   $��	0,17,29,7q�6�   $��25��6�    J� RenderTransformOrigin$ -0.08,0.867&�6�   6�   �� 5(      $��8q�6   $��3��6$   $��0��61   $	 
Horizontal=�6A   .+�5)      �� -   5         ��Name$ btnIngresar��5)   H   $��	76,7,76,0q�6   $	��120��6-   $
��Auto��6:   .��5*      �� $	 
Horizontal=�6!   .+�5+      �� .��6!   
Ingresar6+   �� 5,      $��16��6    $��/Imagenes/door_in.png��6+   6N   5-      5.      5/      �� 51      $��0��6   $��4��6)   $��Center=�66   $	 
Horizontal=�6S   .+�52      �� -   5        $ BtnRegistro��52      $��10(�6.   $
��Bold"�6V   $.��(No cuenta con ninguna cuenta. Registrese��6�   $��0,0,0,2q�6�   
���   ���6h   Z� ��6~   Z� 6�   53      56      57      58      