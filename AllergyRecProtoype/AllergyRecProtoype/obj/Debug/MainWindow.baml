   M S B A M L   `   `   `  ����N  JMultiSelectComboBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:MultiSelectComboBox;assembly=MultiSelectComboBoxMultiSelectComboBox  5   	   M IAllergyRecProtoype, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AllergyRecProtoypeAllergyRecProtoype 5   	   #   AllergyRecProtoype.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   F BWpfControls, Version=1.0.0.8, Culture=neutral, PublicKeyToken=null!wpfhttp://wpfcontrols.com/  5   	   Kcustom>clr-namespace:MultiSelectComboBox;assembly=MultiSelectComboBox  5   	   ,local clr-namespace:AllergyRecProtoype  5   	     � Title$  
MainWindow��5   	   $	��768��6   $
��1024��6)    � 	Resources 5       �� MergedDictionaries �� Source+  %AllergyRecProtoype.SuggestionProvider   provider  allergenTemplate �� Padding �� Path1  +AllergyRecProtoype.AllergenTemplateSelector  AllergenTemplateSelector   AllergenTemplate�� 5	   
    5
      �� 5      $- 'pack://application:,,,/Style/Style.xaml?�6%   %�   &	        &	      &	 �     7    5      6'   �� 5      .R�5      �� $ 2q�6   ._�5      �� $��Arial)�6;   $��12(�6N   $��Center=�6\   ��6    �� $
 Name�6\   5      5        5      8   6N   5      .��5      � .+�5   
   �� .+�5      �   PatientInfoGrid#��[ 6    � RowDefinitions 5      �� 5      $��10 �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$    � ColumnDefinitions 5       �� 5!      $��* �6'   �� 5"      $��* �6'   �� 5#      $��* �6'   .+�5&      �� -   5        	 ��Name$	 patientName��5&   M   $��1��6   $��0��6)   $��2��69   $��Last Name, First Name��6b     PatientNameLabel#��[ 6   �� 5(      $��1��6   $��2��6*   
 �� Orientation$
 
Horizontal=�6:   .+�5)      �� -   5         ��Name$ mrnLabel��5)      $��Patient ID:��6.    	 Label#��[ 6D   �� 5*      -   5        $ mrnValueLabel��5*      $��7005290��63     
ValueLabel#��[ 6E   5+      �� 5-      $��2��6   $��2��6*   $
 
Horizontal=�6:   .+�5.      �� -   5        $ 
visitLabel��5.      $��	Visit ID:��60   #��[ 6D   �� 5/      -   5        $ visitValueLabel��5/      $��
0011234878��65   #��[ 6J   50      �� 52      $��2��6   $��0��6*   $��2��6:   $
 
Horizontal=�6N   $
��Left=�6g   .+�53      �� -   5        $ dobLabel��53      $
��DOB:��6.   #��[ 6=   �� 54      -   5        $ dobValue��54      $��
03/28/1985��6.   #��[ 6C   �� 55      -   5        $ ageLabel��55      $��Age: ��6.   #��[ 6>   �� 56      -	   5        $ ageValueLabel��56      $��30��63   #��[ 6@   57      �� 59      $��3��6   $��0��6*   $��2��6:   $
 
Horizontal=�6N   $
��Left=�6g   .+�5:      �� -
   5        $ gende4rLabel��5:      $��Gender:��62   #��[ 6D   �� 5;      -   5        $ genderValue��5;      $
��Male��61   #��[ 6@   5<      �� 5>      $��3��6   $��2��6*   $
 
Horizontal=�6:   .+�5?      �� -   5        $ locationLabel��5?      $��Location ID:��63   #��[ 6J   �� 5@      -   5        $ locationValueLabel��5@      $��CH 3 Tower CT-MRAC��68   #��[ 6U   5A      5B      �� 5E      
�������$��1q�6(   $��5,0,5,0q�6<   ._�5F      �� .��5G      �   DataGrid#��[ 6    5H      �� 5I      $
��Auto �6,   �� 5J      $
��Auto �6,   �� 5K      $
��Auto �6,   �� 5L      $
��Auto �6,    5N      �� 5O      $��* �6/   �� 5P      $
��Auto �6/   �� 5Q      $��* �6/   .+�5U      �� $��0��6$   $��3��61   $��Current Allergies��6E   ���#428bca$��SemiBold"�5V   >   $
��Left=�6T   $��15(�6o   $��5q�6}   6�   &   System.Windows.Controls.DataGrid  5W      -   5          Name$ currAllergies��5X   %   $��1��5W   #   $��3��60      AutoGenerateColumns .  $   HorizontalScrollBarVisibility$ Hidden=�5X   <   "   VerticalScrollBarVisibility$ Hidden=�6c   $��Stretch=�6�      
IsReadOnly . ��5Y   %   �� *CurrentAllergies+   Columns 5Z      0  *System.Windows.Controls.DataGridTextColumn  5[   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Category��65      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6R   �� *
Category+  5\   "   $
 Type��65   $ * 6C    6N   �� *Type+  5]   "   $ Allergen��65   $ * 6G    6R   �� *
Allergen+  5^   "   $ 	Reactions��65   $ * 6H    6S   �� *	Reactions+  5_   "   $ Entered��65   $ 75 6F    6R   �� *	EnteredOn+5a      �� 5d      $��2��6$   $��3��61   $=��7ATTENTION: Additional Allergies Found at Other Campuses��6E   ���#d9534f$
��Bold"�5e   >   $��Center=�6P   $��15(�6m   $��5q�6{   6�     5f      -   5        $ allergyRecDG��5g   %   $��3��5f   #   $��0��60    .  $ Hidden=�5g   ;   $ Hidden=�6b    . ��5h   %   �� *AllergyRecVMList+ �� Mode$ TwoWay=� 5i        5j   "   $ Category��65   $
 Auto 6G    6U   �� *
Category+  5k   "   $
 Type��65   $
 Auto 6C    6Q   �� *Type+  5l   "   $ Campus��65   $
 Auto 6E    6S   �� *Campus+  5m   "   $ Allergen��65   $
 Auto 6G    6U   �� *
Allergen+  5n   "   $ 	Reactions��65   $
 Auto 6H    6V   �� *	Reactions+5p        5s      -   5        $ actionDG��5t   %   $��3��5s   #   $��1��60    .  $ Hidden=�5t   7   $ Hidden=�6^    .    GridLinesVisibility$
 None=�5v   %   $��0q�6@   ��5s   ]   �� *ActualHeight+ �� ElementName$ allergyRecDG����5u   %   �� *AllergyRecVMList+$ TwoWay=�   RowStyle 5w      �� 5x   "    �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6(    �� Triggers 5y   &   P� 5z   *    P� Property �@ 
IsSelected P� Value . . �5{   .   ��  �� Property � �� �� Value
 �����6K   �� 5|   .    � ��
 �����6K   5}   +   5   #    5�      4	  .System.Windows.Controls.DataGridTemplateColumn	  5�   "      HeaderStyle 5�   &   �� 5�   *   =
  7System.Windows.Controls.Primitives.DataGridColumnHeader" 
 60   .�5�   .   ��  � ��$ 30��6G   �� 5�   .    � ��
 �����6K   5�   +       	CellStyle  5�   &   �� 5�   *   *  $System.Windows.Controls.DataGridCell"  60   .�5�   .   ��  � ��$ 30��6G   �� 5�   .    � ��$ 0q�6P   �� 5�   .    � ��$ 2q�6H   �� 5�   .    � �� 5�   2   �� 5�   6   ! �� 
TargetType"!  6F   .R�5�   :   �� # z��6A   " J� SnapsToDevicePixels" . ._�5�   >   �� #" z" 6O   #��z��5�   O   #��z��5�   O   5�   ;   5�   7   5�   /    5�   .   P� 5�   2    �@ 
IsSelected . . �5�   6   ��  � ��
 �����6S   5�   3   P� 5�   2    �@ 
IsSelected . . �5�   6   ��  � ��
 �����6S   5�   3   5�   +   # 	  CellTemplate# 5�   &   �� 5�   *   .R�5�   .   �� ���#5cb85c��5�   2   �� 5�   6   "! ��6F   .R�5�   :   � .+�5�   >   �� $
 
Horizontal=�6I   .+�5�   B   �� $��20��6L   $��14��6W   #��z��6c   #��z��6�   $��Center=�6�   � 5�   B   $ � Points$ �   ��� �ا  -1#��z��6c   #��z��6�   $��Center=�6�   5�   ?   �� 5�   >   $��Center=�6O   $��Center=�6l   5�   ;   5�   7   5�   /   5�   +   5�   #   5�        5�      -   5        $ reccDG��5�   %   $��3��5�   #   $��2��60    .  $ Hidden=�5�   5   $ Hidden=�6\    . ��5�   %   �� *AllergyRecVMList+$ TwoWay=� 5�      	  5�   "   $ * 69    5�   &   �� 5�   *   $��Allergen��60   
�������6C   # 5�   &   �� 5�   *   .R�5�   .   �� .+�5�   2   -  'WpfControls.Editors.AutoCompleteTextBox  $	��Top=�5�   5   $��30��5�   5   $��1��5�   5   %   DisplayMember$
% Name��5�   5   &   	Watermark$& Search Allergen��5�   5   '   IconPlacement$
' Left=�5�   5   (   IconVisibility$( Hidden=�5�   5   )   ItemTemplateSelector#) [ 5�   5   *   Provider#* [  5�   5   +   SelectedItem+ 5�   5   �� $ SelectedAllergen�$ TwoWay=�, �� UpdateSourceTrigger$, PropertyChanged=�-   LoadingContent- 5�   2   �� 5�   6   $��
Loading...��6@   $��5q�5�   =   $��14(�5�   =   5�   3   5�   /   5�   +   5�   #   	  5�   "   $ * 69    5�   &   �� 5�   *   $��	Reactions��60   
�������6D   # 5�   &   �� 5�   *   .R�5�   .   -   'MultiSelectComboBox.MultiSelectComboBox  .  Name$. MC��5�   1   $
��Auto��5�   1   $
��Auto��5�   1   /   ItemsSource/ 5�   1   �� *ReactionsDictionary+0   SelectedItems0 5�   1   �� *SelectedReactions+5�   1   5�   +   5�   #     5�   "   $ Entered��65   $ 75 6F    6R   �� *	EnteredOn+5�      5�      5�      5�      � 5�        
ActionGrid#��[ 6    5�      �� 5�      $
��Auto �6$   �� 5�      $��10 �6$   �� 5�      $
��Auto �6$    5�      �� 5�      $��* �6'   �� 5�      $
��Auto �6'   �� 5�      $
��Auto �6'   .+�5     �� $��0��6   $��2��6(   $U��OI have verified the selected allergies from other NYP campuses with my patient.��6<    	 AndroidCheckBoxStyle#��[	 6�   
���   �$��Center=�6�   �� 5     -   5        1 ��Name$1 reconcileButton��5  �   $��2��6   $��1��6&   $	��100��66   $��5q�6B   $��	Reconcile��6M    
 btn-success#��[
 6a   6�   �� 5     -   5        $1 closeButton��5  �   $��2��6   $��2��6&   $	��100��66   $��5q�6B   $��Close��6M     
btn-danger#��[ 6]   6�   5     5     5     5     