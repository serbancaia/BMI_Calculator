   M S B A M L   `   `   `  ����S  OBMI_Calculator_Alin_Caia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:BMI_Calculator_Alin_CaiaBMI_Calculator_Alin_Caia  5   	   )    #BMI_Calculator_Alin_Caia.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:BMI_Calculator_Alin_Caia     5   	     � Title$  	Alin Caia��5   	   $	��450��6   $	��800��6(   .��5	      � $��0,3,-0.4,-3q�6   ���	#FFDF8823.+�5
   
   �� -   5        $!��MeasureRadioButtonContainer��5
      $��31��68   $��
708,38,0,0q�6D   $	��Top=�6X   $��76��6p   .+�5      	� -   5        $��RadioButtonMetric��5      $��Metric��63   $��
0,0,-8.8,0q�6D   6X   	� 5      -   5        $��RadioButtonImperial��5      $��Imperial��65   $��
0,0,-8.8,0q�6^   5      �� 5   
   -   5        $��ObesePerson��5   ]   $��41,114,453,138q�6   $"��fat-luffy-5907e4d233046.jpeg��6(   $
��Fill=�6N   $y�Hidden=�6p   �� 5   
   -   5        $��OverweightPerson��5   ]   $��41,114,453,138q�6   $"��6939700-1145097068-46688.jpg��6(   $
��Fill=�6N   $y�Hidden=�6u   �� 5   
   -   5        $��	FitPerson��5   U   $��111,52,523,83q�6   $*��$6be9945e60584e6f5b469a6d5a4314cf.jpg��6'   $y�Hidden=�6f   �� 5   
   -   5        $��UnderweightPerson��5   M   $��41,114,453,138q�6   $��download.jpg��6(   $
��Fill=�6>   $y�Hidden=�6f   �� 5   
   -   5        $��	PageTitle��5   ~   $��Center=�6    �� TextAlignment$ Center=�61   $��23��6H   $��266,10,273,0q�6T   $
��Wrap=�6j   $��BMI Calculator��6�   $	��Top=�6�   $	��255��6�   $��	Underline{�6�   $��Times New Roman)�6�   $��18(�6  �� 5   
   -	   5        $��WeightTextBox��5   G   $��23��6   $��459,136,0,0q�6    �� TextWrapping$
 Wrap=�63   $	��Top=�6\   $	��240��6t   
���   �
���   �$	��2,2q�6�   
�������6�   �� 5   
   -
   5        $��HeightTextBox��5   G   $��23��6   $��459,184,0,0q�6   $
 Wrap=�63   $	��Top=�6\   $	��240��6t   
���   �
���   �$	��2,2q�6�   
�������6�   �� 5   
   -   5        $��CalculatingButton��5      $��Calculate your BMI��6*   $��459,301,10,12q�6G   $	��Top=�6^   $	��294��6v   $��74��6�   $��24(�6�   ���	#FFFF1C01���	#FFFDFF00���	#FF1800FF6�   �� 5   
   -   5        $��TextLanguage_Fr��5      $��Fr��6(   $��4q�65   $��Times New Roman)�6A   $��23��6^   $��747,10,12,0q�6j   $	��Top=�6   $
��Bold"�6�   ���	#FF090909���	#FFA441F16�   �� 5   
   -   5        $��ObeseRecommendation��5   &   $y�Hidden=�6   $	��180��6A   $��413,116,0,0q�6N   $
 Wrap=�6c   $����You are OBESE (BMI over 27.5). You have a high risk of developing heart disease, high blood pressure, stroke, and diabetes. You should URGENTLY change your health habits.��6w   $	��Top=�6)  $	��295��6A  ���	#FF0FD1E4$��18(�6d  �� 5   
   -   5        $��OverweightRecommendation��5   &   $y�Hidden=�6   $	��180��6F   $��413,116,0,0q�6S   $
 Wrap=�6h   $����You are OVERWEIGHT (BMI between 23 and 27.5). You have a moderate risk of developing heart disease, high blood pressure, stroke, and diabetes. You should consider changing your health habits.��6|   $	��Top=�6C  $	��295��6[  ���	#FF0FD1E4$��18(�6~  �� 5   
   -   5        $��FitRecommendation��5   &   $y�Hidden=�6   $	��180��6?   $��413,116,0,0q�6L   $
 Wrap=�6a   $���}You are FIT (BMI between 18.5 and 23). You have a low risk of developing health problems. Keep up your current health habits.��6u   $	��Top=�6�   $	��295��6  ���	#FF0FD1E4$��18(�65  �� 5   
   -   5        $��UnderweightRecommendation��5   &   $y�Hidden=�6   $	��180��6G   $��413,116,0,0q�6T   $
 Wrap=�6i   $����You are UNDERWEIGHT (BMI below 18.5). You have a risk of developing problems such as nutritional deficiency and osteoporosis. You should consider changing your health habits.��6}   $	��Top=�63  $	��295��6K  ���	#FF0FD1E4$��18(�6n  �� 5   
   -   5        $��WeightInfoKg��5      $��506,114,142,0q�6(   $
��Wrap=�6?   $��Enter weight (kg):��6S   $	��Top=�6m   �� 5   
   -   5        $��HeightInfoMeters��5      $��506,163,142,0q�6,   $
��Wrap=�6C   $��Enter height (m):��6W   $	��Top=�6p   �� 5   
   -   5        $��WeightInfoLbs��5   (   $y�Hidden=�6   $��506,114,142,0q�6=   $
��Wrap=�6T   $��Enter weight (lbs):��6h   $	��Top=�6�   �� 5   
   -   5        $��HeightInfoInches��5   (   $y�Hidden=�6   $��506,163,142,0q�6@   $
��Wrap=�6W   $��Enter height (in):��6k   $	��Top=�6�   �� 5   
   -   5        $��RecalculatingButton��5   %   $y�Hidden=�6   $��Recalculate your BMI��6@   $��459,301,0,0q�6_   $	��Top=�6t   $	��294��6�   $��74��6�   $��24(�6�   ���	#FF1800FF���	#FFFF1C01���	#FFFDFF006�   �� 5    
   -   5        $��BmiResultTextBox��5       $y�Hidden=�6*   $��44��6>   $��
413,65,0,0q�6J   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��295��6�   ���	#FF1FD128$��24(�6�   $	��2,4q�6�   �� 5!   
   -   5        $��TextLanguage_Eng��5!      $y�Hidden=�6)   $	��Eng��6=   $��4q�6K   $��Times New Roman)�6W   $��23��6t   $��747,10,9.6,0q�6�   $	��Top=�6�   $
��Bold"�6�   ���	#FF090909���	#FFA441F16�   5"      5#      