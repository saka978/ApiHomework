   M S B A M L   `   `   `  ����F  BApiHomeWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ApiHomeWorkApiHomeWork  5   	       ApiHomeWork.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ApiHomeWork     5   	     � Title$  
MainWindow��5   	   $	��280��6   $	��960��6)    � 
ResizeMode$ NoResize=�65    � 	Resources 5
         	Watermark �� 
TargetType �� Property �� Value �� 
TargetType ��Name ��Name
	 � Tag
 �� Triggers ]� 
Conditions �� Property �� Value �� 
TargetName P� Property P� Value��%�  &	        �� 5   
   " ��6"   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� 
����������	#FF7D8683$��1q�6P   �� 5      $ PART_ContentHost��6+   $��5,0,0,0q�6E   $��Center=�6V   �� 5      $ WaterMarkLabel��65   $��5,0,0,0q�6$   #��z	 6M   $��Center=�6m   $y�	Collapsed=�5       
�������$��Arial)�6I   5      
 5      ]� 5       5   "   �� 5   &    � ��$  ��6@   ./�5   "   �� $ WaterMarkLabel��6?    � y�$ Visible=�6[   5      P� 5       � {�$ False��6;   . �5   "   ��  � ��
 �iii�6?   5      5       5"      5#      5$      .��5&      � .+�5'   
   �� -   5        $��MyLabel��5'      $��5q�6   �� 5(   
   -   5        $��Anime_Title��5(   (   $��Anime title:��6   $��20(�6;   $��5q�6I   �� 5)   
   -   5        $��	Character��5)   4   $��
Character:��6   $
��auto��6&   $��
5,32,10,10q�6E   $��20(�6Y   �� 5*   
   -   5        $��Quote��5*   "   $��Quote:��6   $	��700��6/   $
��auto��6;   $
��Left=�6I   $��
5,60,10,10q�6d   $��20(�6x   $��WrapWithOverflow=�6�   �� 5+   
   -   5         ��Name$ Random_Quote_Button��5+      $��30��6.   $	��170��6:   $��Get Random Quote��5,      $��10,20,10,10q�5-      $	��Top=�5.      $��Right=�5/      $��12(�51      52      �� 53   
   -   5        $ Search_Quote_By_Anime��53      $��30��60   $	��170��6<   $��Get quote by anime name��54      $��10,100,10,10q�55      $	��Top=�56      $��Right=�57      $��12(�59      5:      �� 5;   
   -   5        $$ Search_Quote_By_Character_Name��5;      $��30��69   $	��170��6E   $!��Get quote by character name��5<      $��10,60,10,10q�5=      $	��Top=�5>      $��Right=�5?      $��12(�5A      5B      �� 5C   
   -   5        $��Query_TextBox��5C      $��30��6'   $	��170��63   $��10,150,10,10q�5D      $	��Top=�5E      $��Right=�5F      #��[  5G      $	 
Enter name��5H      5I      5J      