   M S B A M L   `   `   `  ����G  CCRUDSemana06, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CRUDSemana06CRUDSemana06  5   	       CRUDSemana06.ManProducto   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:CRUDSemana06     5   	     � Title$  ManProducto��5   	   $	��550��6   $	��500��6*    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Comic Sans MS)�6+   �� 5       � ��$ 14(�6)   5      5      .��5      � .+�5   
   �� .+�5      �� .+�5      �� $ ��MANTENIMIENTO DE PRODUCTOS��6   5      �� 5       �� Orientation$ Vertical=�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��ID��6   $	��200��6)   �� 5      -   5         ��Name$ lblID��5   )   $��ID��6   $	��150��68   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��NOMBRE��6   $	��200��6-   �� 5      -   5         ��Name$ 	txtNombre��5      $	��200��61   6?   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��ID PROVEEDOR��6   $	��200��63   �� 5       -   5        $ txtIdProveedor��5        K� NumeralStyle$ Normal=�66   $	��200��6W   6e   5!      �� 5"      $ 
Horizontal=�6   .+�5#      �� $��ID CATEGORIA��6   $	��200��63   �� 5$      -   5        $ txtIdCategoria��5$      $	��200��66   6D   5%      �� 5&      $ 
Horizontal=�6   .+�5'      �� $��CANTIDAD POR UNIDAD��6   $	��200��6:   �� 5(      -   5        $ txtCantidadProUnidad��5(      $	��200��6<   6J   5)      �� 5*      $ 
Horizontal=�6   .+�5+      �� $��PRECIO UNIDAD��6   $	��200��64   �� 5,      -   5        $ txtPrecioUnidad��5,      $	��200��67   6E   5-      �� 5.      $ 
Horizontal=�6   .+�5/      �� $��UNIDADES EXISTENTES��6   $	��200��6:   �� 50      -   5        $ txtUnidadesExistentes��50      $	��200��6=   6K   51      �� 52      $ 
Horizontal=�6   .+�53      �� $��UNIDADES PEDIDAS��6   $	��200��67   �� 54      -   5        $ txtUnidadesPedidas��54      $	��200��6:   6H   55      �� 56      $ 
Horizontal=�6   .+�57      �� $��NIVEL NUEVO PEDIDO��6   $	��200��69   �� 58      -	   5        $ txtNivelNuevoPedido��58      $	��200��6;   6I   59      �� 5:      $ 
Horizontal=�6   .+�5;      �� $��
SUSPENDIDO��6   $	��200��61   �� 5<      -
   5        	 ��Name$	 txtSuspendido��5<      $	��200��66   6D   5=      �� 5>      $ 
Horizontal=�6   .+�5?      �� $��CATEGORIA PRODUCTO��6   $	��200��69   �� 5@      -   5        $ txtCategoriaProducto��5@      $��Categoria D��6<   $	��200��6O   6]   5A      �� 5B      $ 
Horizontal=�6   .+�5C      �� -   5        
 ��Name$
 	btnGrabar��5C      .��6I   Grabar6Q   �� 5D      -   5        $
 btnEliminar��5D      .��6M   
Eliminar6W   �� 5E      -   5        $
 	btnCerrar��5E      .��6J   Cerrar6R   5F      5G      5H      5I      5J      