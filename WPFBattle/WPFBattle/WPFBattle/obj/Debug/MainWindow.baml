   M S B A M L   `   `   `  ����D  @WPFBattle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPFBattle	WPFBattle  5   	   ]3clr-namespace:Thiagarajan.RoleplayingGameInterfaces%Thiagarajan.RoleplayingGameInterfaces  5   	       WPFBattle.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WPFBattle     5   	   YRoleplayingGameInterfaces3clr-namespace:Thiagarajan.RoleplayingGameInterfaces     5   	     � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��463* �6   �� 5      $	��55* �6   ��5   
   �� 5       �� ImageSource$ assets\cave.jpg��6   .+�5   
   �� $��assets\console.png��6   $��240,10,28,192.5q�6,   $��2��6E   �� 5   
   -   5         ��Name$ console��5   5   " �� VerticalScrollBarVisibility$
 Auto=�6   $��7(�6F   
���   �$��273,20,10,192.5q�6f   :   4Thiagarajan.RoleplayingGameInterfaces.CharacterImage  5   
   -   5          Name$
 Riku��5   3   $
��Left=�6A   $	��100��6\   $��
10,183,0,0q�6i   $	��Top=�6}   $	��100��6�    J� RenderTransformOrigin$ 0.552,0.513&�6�      DeadImageSource$ assets/Riku_dead.png��6�      AttackingImageSource$ assets/Riku_attack.png��6�   	   IdleImageSource$	 assets/Riku_idle.png��6  
   TakeDamageImageSource$
 assets/Riku_hurt.png��6A  $��assets/Riku_idle.png��6n    5   
   -   5        $ Vexen��5   3   $
��Left=�6B   $	��100��6]   $��158,183,0,0q�6j   $	��Top=�6   $	��110��6�   $ 0.552,0.513&�6�   $ assets/Vexen_dead.png��6�   $ assets/Vexen_attack.png��6�   $	 assets/Vexen_idle.png��6  $
 assets/Vexen_hurt.png��6F  $��assets/Vexen_idle.png��6t    5   
   -   5        $ Flare��5   3   $
��Left=�6B   $	��100��6]   $��	29,30,0,0q�6j   $	��Top=�6}   $	��100��6�   $ assets/Flare_attack.png��6�   $ assets/Flare_dead.png��6�   $��assets/Flare_idle.png��6�   $
 assets/Flare_hurt.png��6    5   
   -   5        $ Xenmas��5   3   $
��Left=�6C   $	��100��6^   $��
168,30,0,0q�6k   $	��Top=�6   $	��100��6�   $
 assets/Xenmas_hurt.png��6�   $��assets/Xenmas_idle.png��6�      State$
 Idle=�6�   $	 assets/Xenmas_idle.png��6�   $ assets/Xenmas_dead.png��6(  5      5      