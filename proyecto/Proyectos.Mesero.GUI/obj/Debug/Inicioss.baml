   M S B A M L   `   `   `  ����O  KProyectos.Mesero.GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Proyectos.Mesero.GUIProyectos.Mesero.GUI  5   	   #    Proyectos.Mesero.GUI.Inicioss   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Proyectos.Mesero.GUI     5   	     � Title$  Inicio��5   	   $	��450��6   $	��400��6%   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/    �� 
StartPoint$ 0.5,0&�6S   .��5      �  � Color$ Black��6   � 5      $ 	#FF3C91E6��6    � Offset$ 1Q�6-   5      .��5      �� 
������� �� CornerRadius$ 20��6    $��20q�62   ._�5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    $��37��6.   �� 5      $
��auto �6    $��53��6.   �� 5      $	��81* �6    �� 5      $��8* �6     � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $��226.09 �6#   �� 5      $��28.91 �6#   .+�5       � $��2��6   $��0��6(   $��Center=�65   	 � Orientation$	 Vertical=�6R   $��7,5,60,4q�6i   $	��160��6{   .+�5!      �� $��Center=�6   $��22(�65   $
��Bold"�6C   $��4q�6U   .��6`   ReCSaM6h   �� 5"      $��Center=�6   $	��124��65   $	��160��6B   ��5#      �� 5$      
 �� ImageSource$
 Imegenes/lagoReCSaM.png��6%   5&      5'      �� 5(      $��1��6   $��1��6$   $��5,7,6,4q�61   .��6B   	Empresa6K   �� 5)      -   5         ��Name$ 
cmbEmpresa��5)   4   $��2��6   $��1��6'   $��24��6y   $��8,8,7,5q�6�   $��2��6�   �� 5*      $��1��6   $��2��6$   $��5,8,6,3q�61   .��6C   
Usuario:6M   �� 5+      -   5        $ 
cmbUsuario��5+      $��2��6+   $��2��6;   $��26��6H   $��7,7,8,4q�6T   $��2��6e   �� 5,      $��1��6   $��3��6$   $��	5,16,6,11q�61   .��6E   Contraseña:6R   �� 5-      -   5         ��Name$ txtPassword��5-      $��2��6+   $��3��6;   $��	8,16,8,11q�6H   G� 5.      -   5         G�Name$ passPasword��5.      $��2��6/   $��3��6?   $��	8,16,8,11q�6L   �� 5/      -   5         ��Name$ CheBoxPassword��5/      $��3��6L   $��3��6\   $��5,12,5,2q�6i   6}   �� 52      $��4��6   $��2��6'    �� Orientation$ 
Horizontal=�67   .+�53      �� -   5         ��Name$ btnIngresar��53   I   $��26,10,80,10q�6   $	��120��6.   $
��Auto��6;   .��54      �� $ 
Horizontal=�6!   .+�55      �� .��6!   
Ingresar6+   �� 56      $��16��6    $��/Imegenes/door_in.png��6+   6N   57      58      59      5<      5=      5>      