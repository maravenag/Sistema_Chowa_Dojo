   M S B A M L   `   `   `  ����M  ISistema_Chowa_Dojo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Sistema_Chowa_DojoSistema_Chowa_Dojo  5   	   *    $Sistema_Chowa_Dojo.Historial_Ascenso   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Sistema_Chowa_Dojo     5   	     � Title$  Historial_Ascenso��5   	   $��348.836��6#   $	��300��64   .��5	      � $	��303��6   $	��Top=�6   .+�5
   
   �� -   5         ��Name$ grado��5
      $
��Left=�6"   $��	91,10,0,0q�6=   $	��Top=�6P   $	��141��6h   �� 5   
   -   5         ��Name$ label��5      $��Grado: ��6   $
��Left=�61   $��38,6,0,0q�6L   $	��Top=�6^   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	fecha_asc��5      $
��Left=�6(   $��
81,0,0,233q�6C   $��Bottom=�6W   $	��141��6r      Text$ seleccione dia de ascenso��6~      FirstDayOfWeek$ Monday=�6�   �� 5   
   -   5         ��Name$ lv_histo_ascenso��5      $
��Left=�6-   $	��141��6H   $��	38,98,0,0q�6U   $	��Top=�6h   $	��194��6�    �� View 5      �� 5      .P�5      �� $��Fecha��6%    �� Width$	 100��6[   	 �� DisplayMemberBinding	 64   �� *Fecha+6[   �� 5      $��Grado��6%   $	 100��6[   	 64   �� *Grado+6[   5      5      �� 5   
   -   5        $ label1��5      $��Historial de Ascensos��6    $
��Left=�6@   $��	38,70,0,0q�6[   $	��Top=�6n   
 J� RenderTransformOrigin$
 0.547,0.909&�6�   �� 5   
   -   5        $ label2��5      $��Fecha:��6    $
��Left=�61   $��	38,43,0,0q�6L   $	��Top=�6_   �� 5   
   -   5         ��Name$ boton_aceptar��5      $��Aceptar��6(   $
��Left=�6:   $��
83,256,0,0q�6U   $	��Top=�6i   $��75��6�   6�   �� 5   
   -   5        $ boton_cancelar��5      $��Cancelar��6)   $
��Left=�6<   $��186,257,0,0q�6W   $	��Top=�6l   $��75��6�   6�   5      5      