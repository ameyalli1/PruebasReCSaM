   M S B A M L   `   `   `  ����O  KProyectos.Mesero.GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Proyectos.Mesero.GUIProyectos.Mesero.GUI  5   	   '    !Proyectos.Mesero.GUI.ERFrecuencia   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Proyectos.Mesero.GUI     5   	     � Title$  Encuesta��5   
   $	��400��6   $	��660��6(   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/    �� 
StartPoint$ 0.5,0&�6S   .��5      �  � Color$ Black��6   � 5      $ 	#FF3C91E6��6    � Offset$ 1Q�6-   5      .��5      �� 
������� �� CornerRadius$ 20��6    $��20q�62   ._�5   
   �  � ColumnDefinitions 5      �� 5      $
��116* �6#   �� 5      $
��209* �6#   �� 5      $
��327* �6#    � RowDefinitions 5      �� 5      $	��94* �6    �� 5      $
��216* �6    �� 5      $	��59* �6    .+�5      �� -   5        	 ��Name$	 txtNombreEmpleado��5      $	��300��61   $��30��6=   $��0��6I   $��2��6Y   $��10q�6m   $��1��6y   $��Right=�6�   $��16(�6�   ��6�   Z� ��6�   Z� 6�   �� 5      -   5        $	 txtNombreEmpresa��5      $	��300��60   $��30��6<   $��0��6H   $��2��6X   $��10q�6l   $��1��6x   $��Right=�6�   $��16(�6�   ��6�   Z� ��6�   Z� 6�   �� 5      $��0��6   $��
10,25,0,25q�6$   $��16(�68   $
��Bold"�6F   $��
Pregunta 4��6X   �� 5       $��1��6   $��2��6$   $��10, 25, 0, 25q�68   $��18(�6O   $6��0¿Con que frecuencia utiliza nuestros servicios?��6]   � 5!      $��1��6   $��2��6(   
 � Orientation$
 Vertical=�6<   $��1��6S   .+�5"      	� -   5         	�Name$ 
radSemanal��5"      $��5q�62   $��16(�6=   .��6K   	Semanal6T   	� 5#      -   5        $ radQuincenal��5#      $��5q�64   $��16(�6?   .��6M   
Quicenal6W   	� 5$      -   5        $ 
radMensual��5$      $��5q�62   $��16(�6=   .��6K   	Mensual6T   	� 5%      -   5        $ radTrimestral��5%      $��5q�65   $��16(�6@   .��6N   
Trimestral6Z   	� 5&      -   5        $ radSemestral��5&      $��5q�64   $��16(�6?   .��6M   	Semestral6X   	� 5'      -   5        $ radAnual��5'      $��5q�60   $��16(�6;   .��6I   Anual6P   5(      �� 5)      -	   5         ��Name$ btnSiguiente��5)      $��2��6F   $��2��6V   $��30��6c   $	��120��6o   .��6{   	Siguiente6�   5*      5+      5,      