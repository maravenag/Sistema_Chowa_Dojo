   M S B A M L   `   `   `  ����M  ISistema_Chowa_Dojo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Sistema_Chowa_DojoSistema_Chowa_Dojo  5   	   0    *Sistema_Chowa_Dojo.formulario_Nueva_Lesion   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Sistema_Chowa_Dojo     5   	     � Title$  Nueva Lesión��5   	   $	��300��6   $	��300��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��205* �6   �� 5      $	��87* �6   .+�5   
   �� -   5         ��Name$ label��5      $��Lesión:��6   $
��Left=�61   $��23,0,0,0q�6L   $	��Top=�6^   �� 5   
   -   5         ��Name$ Nombre_Lesion_text��5      $
��Left=�6.   $��23��6I   $��69,4,0,0q�6U    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ Fecha_Lesion��5      $
��Left=�6+   $��	69,32,0,0q�6F   $	��Top=�6Y   �� 5   
   -   5        $ label1��5      $��Fecha:��6    $
��Left=�61   $��	23,32,0,0q�6L   $	��Top=�6_   �� 5   
   -   5        $ label2��5      $��Referencia:��6    $
��Left=�66   $��	23,63,0,0q�6Q   $	��Top=�6d   �� 5   
   -   5        $ Referencia_Lesion��5      $
��Left=�6-   $	��116��6H   $��	23,94,0,0q�6U   $
 Wrap=�6h   $	��Top=�6|   $	��217��6�   $��2��6�   �� 5   
   -   5         ��Name$ crear_lesion��5      $��Aceptar��6'   $
��Left=�69   $��122,224,0,0q�6T   $	��Top=�6i   $��75��6�   6�   �� 5   
   -   5        $ cerrar_nueva_lesion��5      $��Cerrar��6.   $
��Left=�6?   $��204,223,0,0q�6Z   $	��Top=�6o   $��75��6�   $��2��6�   6�   5      5      