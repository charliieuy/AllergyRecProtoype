   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   ComboBoxToggleButton �� 
TargetType �� Property �� Value �� 
TargetType � ColumnDefinitions ��Name �� CornerRadius	 �� Padding
 F�Name �� Triggers P� Property P� Value �� 
TargetName  ComboBoxTextBox �� 	ClickMode �� Path �� Mode �� RelativeSource �� Mode �� AncestorType d� 	IsChecked J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� 
IsReadOnly �� 
IsReadOnly �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth  �� MaxDropDownHeight! K� IsItemsHost-   'System.Windows.Input.KeyboardNavigation"    DirectionalNavigation# P� 
SourceName$ �� Triggers% � RowDefinitions  AndroidCheckBoxStyle�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5        5      �� 5   
   $- 'pack://application:,,,/Style/Style.xaml?�6   %�  &	        &	 3    '�� �    7   7  '�� �    7  �� 5      " d�6)   .�5	   
   ��  � �� 5
   
   �� 5      " d�6   .R�5      �  5      �� 5      .+�5      �� $ Border��5      $��2��5      $ 0��5      #��z��5      #��z��5      $��2q�5      �� 5      $ 0��5      
������ ���#808080$��1q�5      $	 2q�6/   $��0 0 0 6q�6;   ._�5      F� $
 Arrow��5      #��z��5      #��z��5      $��Right=�5       $��Center=�5!      "����        � z  � � $�     	5"      5#      5$       5%      P� 5&       � {� .  . �5'      �� $ Border��6!    � ��
 �����6K   �� 5(      $ Border��6!    � ��
 �����6L   �� 5)       � ��
 �����67   �� 5*      $ Arrow��6!    � ��
 �����6D   5+      5-      5/      50      �� 52      " ��6.   .R�53   
   �� $ PART_ContentHost��6   |�. ���#808080$��0,0,0,1q�6R   54      �� 56      " ��6   .�57   
   ��  � ��
 �����6'   �� 58   
    � ��
 �����6'   �� 59   
    �@J�SnapsToDevicePixels . 60   �� 5:   
    �@�OverridesDefaultStyle . 62   �� 5;   
    � ��$
 Auto=�6G   �� 5<   
    � ��$
 Auto=�6E   �� 5=   
    � �� . 6:   �� 5>   
    � ��$ 12(�6%   �� 5?   
    � ��$ 50��6%   �� 5@   
    � ��$ 32��6&   �� 5A   
    � �� 5B      �� 5C      " ��6"   .R�5D      � .+�5E      d� $��ToggleButton��5F   !   #��z��5G   !   #��z��5H   !   #��z��5I   !   8��  $��2��5L   !   |�.  $ Press=�5O   !   ��5K   !   �� $
 Text�$ TwoWay=� �� $ FindAncestor=�$ UserControlL� 5N   !   �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+5P      �� 5Q      $��ContentSite��5R   !    .  #��z 5T   !   #��z 5U   !   #��z��5V   !   $��	10,3,30,3q�5W   !   $��Center=�5X   !   $��Center=�5Y   !   �� 5Z      $ PART_EditableTextBox��6"   8�� $��Center=�5]   !   $��Center=�5^   !   $��3,3,23,3q�5_   !   |�. $y�	Collapsed=�5a   !   # z 5b   !   ��5[   !   Z� 5b   !   � 5c      $��Popup��5d   !   $��Bottom=�5e   !   #��z 5f   !    . |�.  $��Slide=�5i   !   .��5j      � $��DropDown��5k   #    . #��z 5m   #   #��z  5n   #   .+�5o   "   �� $ DropDownBorder��5p   )   
�������$��1q�5r   )   
�������5s   )   �� 5t   "   $��4,6,4,6q�6/    . .��5u   &   �� ! . $" 	Contained=�6D   5v   #   5w      5x      5z       5{      P� 5|       �@��HasItems .  . �5}      �� $ DropDownBorder��6%    � ��$ 95��6V   5~      P� 5       �@��
IsGrouping . . �5�      ��  � �� .  6N   5�      P� 5�      $# Popup��6"    �@�AllowsTransparency . . �5�      �� $ DropDownBorder��6%    �@��CornerRadius$ 0��6Y   �� 5�      $ DropDownBorder��6%    � ��$ 0,2,0,0q�6S   5�      P� 5�       �@��
IsEditable . . �5�      ��  � �� .  6:   �� 5�      $ PART_EditableTextBox��6%    � y�$ Visible=�6]   �� 5�      $ ContentSite��6%    � y�$ Hidden=�6T   5�      P� 5�       �@J�	IsFocused . . �5�      ��  � ��
 �����6;   5�      5�      5�      $ 5�   
   5�      �� 5�      " ��6   .�5�   
   ��  �@J�SnapsToDevicePixels . 60   �� 5�   
    � ��$ Stretch=�60   �� 5�   
    � ��$ Stretch=�6.   �� 5�   
    � ��$ 12(�6%   �� 5�   
    � ��
 �   �6'   �� 5�   
    �@�OverridesDefaultStyle . 62   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $��Border��5�      $	 5q�5�      $��0q�5�      $��1q�5�      $ 0��5�      
������ 
������ ._�5�      � % 5�      �� 5�   &   $
��Auto �64    5�      �� 5�   "   $
��Auto �63   �� 5�   "   $��* �63   .+�5�      �� $��0��6'   $��0��64   8��  .��5�   "   �� 5�      5�      5�       5�      P� 5�       �@��IsHighlighted . . �5�      �� $ Border��6%    � ��
 �����6P   �� 5�      $ Border��6%    � ��
 �����6O   5�      5�      5�      5�      5�      