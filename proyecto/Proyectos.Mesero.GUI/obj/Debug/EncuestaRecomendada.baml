   M S B A M L   `   `   `  ����O  KProyectos.Mesero.GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Proyectos.Mesero.GUIProyectos.Mesero.GUI  5   	   .    (Proyectos.Mesero.GUI.EncuestaRecomendada   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Proyectos.Mesero.GUI     5   	     � Title$  Inicio encuesta��5   	   $	��400��6!   $	��660��6.   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/    �� 
StartPoint$ 0.5,0&�6S   .��5      �  � Color$ Black��6   � 5      $ 	#FF3C91E6��6    � Offset$ 1Q�6-   5      .��5      �� 
������� �� CornerRadius$ 20��6    $��20q�62   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��39* �6#   �� 5      $
��234* �6#   �� 5      $	��53* �6#    � RowDefinitions 5      �� 5      $	��85* �6    �� 5      $	��35* �6    �� 5      $
��114* �6    �� 5      $
��135* �6    .+�5      �� -   5        	 ��Name$	 txtEvaluarDesicion��5      $	��300��62   $��30��6>   $��0��6J   $��2��6Z   $��10q�6n   $��1��6z   $��Right=�6�   $��16(�6�   ��6�   Z� ��6�   Z� 6�   �� 5      -   5        $	 txtNombreEmpleado��5      $	��300��61   $��30��6=   $��0��6I   $��2��6Y   $��10q�6m   $��1��6y   $��Right=�6�   $��16(�6�   ��6�   Z� ��6�   Z� 6�   �� 5      -   5        $	 txtNombreEmpresa��5      $	��300��60   $��30��6<   $��0��6H   $��2��6X   $��10q�6l   $��1��6x   $��Right=�6�   $��16(�6�   ��6�   Z� ��6�   Z� 6�   �� 5       $��0��6   $��Center=�6!   $��97,15,179,10q�6>   $��36(�6T   $
��Bold"�6b   $	��163��6t   $��1��6�   .��6�   ReCSaM6�   �� 5!      $
��Left=�6   $��82��6/   $��16(�6:   $
��Bold"�6H   $��41��6Z   $��Bottom=�6f   $��1��6�   $��2��6�   .��6�   
Objetivo :6�   �� 5"      $��2��6   $��
62,10,20,0q�6!   $����Por Favor, dedique unos minutos a completar esta pequeña encuesta.

Sus respuestas serán tratadas de forma confidencial y serán utilizadas únicamente
para mejorar el servicio que le proporcionamos��65   $��14(�6  $��3��6#  �� 5#      -   5        
 ��Name$
 btnSiguiente��5#      $��1��6F   $��Center=�6V   $��3��6s   $��30��6�   $	��130��6�   .��6�   	Siguiente6�   �� 5$      -   5        $
 btnVerPoliticas��5$      $��1��6L   $��0��6\   $
��Auto��6i    � ToolTip$ Ver Politicas��6w   $��2��6�   $��333,67,10,9q�6�   $��2��6�   .��6�   Politicas de Privacidad6�   5%      5&      5'      