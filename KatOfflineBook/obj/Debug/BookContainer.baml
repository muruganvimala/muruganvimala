   M S B A M L   `   `   `  ����?  ;Pro1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Pro1Pro1  5   	       Pro1.BookContainer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Pro1     5   	   -   5          � Title$  BookContainer��5   	   $
��auto��6   $
��auto��6-    � WindowStyle$
 None=�6:    � WindowStartupLocation$ CenterScreen=�6M   .��5	      � -   5         � RowDefinitions 5
   
   �� 5      $
��127* �6   �� 5      $
��402* �6   .+�5   
   � -   5        $��topgrid��5      $
��auto��6   $��40��6+   $	��Top=�67   ���	#FF83C4EB.+�5      �� $��Center=�6   $��Center=�6/   $��Tahoma)�6L   $��16(�6`   
�������$
��Bold"�6�   .��6�   
KAT BOOK6�   � 5      $��Right=�6   $��Center=�64   .+�5      �� -   5        $��
homebutton��5      $�� ��6+   $
��Left=�66   $	��Top=�6Q   $��30��6i   $��30��6u   ��6�   Z� ��5      �� 5       �� ImageSource$ Img/home.png��6%   5      �� 5      -   5         ��Name$ minimizebtn��5      $	��—��6.   $��30��6:   $��30��6E   
�������$��16(�6�   ��6Q   Z� ��6g   Z� 6�   �� 5      -   5        $ closebtn��5      $��X��6+   $��30��67   $��30��6B   $��15(�6|   
���������6N   Z� ��6f   Z� 6�   5      5      � 5   
   -   5        $��usergrid��5      $��0��6   $��0,40,0,27.6q�6,   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5       � 	 � Color$	 	#FF83C4EB��6#   
 � Offset$
 1Q�65   � 5!      $	 White��6#   � 5"      $	 	#FFF8FBFD��6#   $
 0.929Q�65   5#      .+�5%      �� -   5        $��namelbl��5%      $��25(�69   $��MS Reference Sans Serif)�6G   $��Center=�6l   $��Center=�6�   ��6#   Z� .��6�   State Board6�   � 5&      -	   5        $��
userDetail��5&      $
��auto��6%   $
��auto��62   $��Right=�6@   $��0,0,15,0q�6\   .+�5'      �� $��Center=�6   .+�5(      �� -
   5         ��Name$ 
welcomelbl��5(      $��Welcome��60   $��0,0,-0.001,0q�6B   $��16(�6s   �� 5)      -   5        $ userlbl��5)      $��Murugan��6-   $��0,0,37.475,0q�6?   $	��Top=�6U   $��14(�6�   ���	#FF52B9F7$
��Bold"�6�   5*      5+      5,       � 5-   
   -   5          �Name$ myframe��5-      $��1��6!     � NavigationUIVisibility$ Hidden=�6.   5/      �� 50   
   -   5        $��NavigationParent��50      $��1��61   51      53      