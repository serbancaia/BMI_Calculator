using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BMI_Calculator_Alin_Caia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Sets the metric measuring system as the default measuring system when opening the page
            RadioButtonMetric.IsChecked = true;
        }

        private void clickMetric(object sender, RoutedEventArgs e)
            //Changes the measuring system into the metric system by showing the metric measuring system on the page and by hiding the imperial measuring system from the page when clicked
        {
            if (RadioButtonImperial.IsChecked != true)
            {
            }
            else
            {
                RadioButtonImperial.IsChecked = false;
            }
            RadioButtonMetric.IsChecked = true;
            WeightInfoLbs.Visibility = Visibility.Hidden; /*Source: https://stackoverflow.com/questions/8284159/how-to-hide-textboxes-labels-and-buttons-c-sharp-wpf */
            HeightInfoInches.Visibility = Visibility.Hidden;
            WeightInfoKg.Visibility = Visibility.Visible;
            HeightInfoMeters.Visibility = Visibility.Visible;
        }

        private void clickImperial(object sender, RoutedEventArgs e)
        //Changes the measuring system into the imperial system by showing the imperial measuring system on the page and by hiding the metric measuring system from the page when clicked
        {
            if (RadioButtonMetric.IsChecked != true)
            {
            }
            else
            {
                RadioButtonMetric.IsChecked = false;
            }
            RadioButtonImperial.IsChecked = true;
            WeightInfoKg.Visibility = Visibility.Hidden;
            HeightInfoMeters.Visibility = Visibility.Hidden;
            WeightInfoLbs.Visibility = Visibility.Visible;
            HeightInfoInches.Visibility = Visibility.Visible;
        }

        private void clickCalculate(object sender, RoutedEventArgs e)
            //Calculates the BMI depending if the user entered the right values for the corresponding measuring system (if the user enters an outer-bound value, a message pops up indicating, either in French or in English, the range of values that the user can put in a specific textbox)
        {
            if (WeightInfoKg.IsVisible)
            {
                if (Convert.ToDouble(this.WeightTextBox.Text) > 300 || Convert.ToDouble(this.WeightTextBox.Text) < 10) /*Source https://stackoverflow.com/questions/3548875/convert-textbox-text-to-integer */
                {
                    if (TextLanguage_Fr.IsVisible)
                    {
                        MessageBox.Show("The value of the weight must range between 10 kg and 300 kg");
                    }
                    else
                    {
                        MessageBox.Show("La valeur du poids doit se situer entre 10 kg et 300 kg");
                    }
                }
                else if (Convert.ToDouble(this.HeightTextBox.Text) > 2.2 || Convert.ToDouble(this.HeightTextBox.Text) < 0.2)
                {
                    if (TextLanguage_Fr.IsVisible)
                    {
                        MessageBox.Show("The value of the height must range between 0.2 m and 2.2 m");
                    }
                    else
                    {
                        MessageBox.Show("La valeur de la hauteur doit se situer entre 0.2 m et 2.2 m");
                    }
                }
                else
                {
                    Double bmiResult = Convert.ToDouble(this.WeightTextBox.Text) / (Convert.ToDouble(this.HeightTextBox.Text) * Convert.ToDouble(this.HeightTextBox.Text)); /*Source: https://en.wikipedia.org/wiki/Body_mass_index */
                    BmiResultTextBox.Text += bmiResult;
                    showBmiResult(bmiResult);
                }
            }
            else
            {
                if (Convert.ToDouble(this.WeightTextBox.Text) > 661.387 || Convert.ToDouble(this.WeightTextBox.Text) < 22.0462)
                {
                    if (TextLanguage_Fr.IsVisible)
                    {
                        MessageBox.Show("The value of the weight must range between 22.0462 lbs and 661.387 lbs");
                    }
                    else
                    {
                        MessageBox.Show("La valeur du poids doit se situer entre 22.0462 livres et 661.387 livres");
                    }
                }
                else if (Convert.ToDouble(this.HeightTextBox.Text) > 86.6142 || Convert.ToDouble(this.HeightTextBox.Text) < 7.87402)
                {
                    if (TextLanguage_Fr.IsVisible)
                    {
                        MessageBox.Show("The value of the height must range between 7.87402 in and 86.6142 in");
                    }
                    else
                    {
                        MessageBox.Show("La valeur de la hauteur doit se situer entre 7.87402 pouces et 86.6142 pouces");
                    }
                }
                else
                {
                    Double bmiResult = (Convert.ToDouble(this.WeightTextBox.Text) / (Convert.ToDouble(this.HeightTextBox.Text) * Convert.ToDouble(this.HeightTextBox.Text))) * 703; /*Source: https://en.wikipedia.org/wiki/Body_mass_index */
                    BmiResultTextBox.Text += bmiResult;
                    showBmiResult(bmiResult);
                }
            }
        }

        public void showBmiResult(Double bmiResult)
            //Hides everything but the BMI result, the PageTitle, the BMI photo related to the value of the BMI calculation, the health recommendation for the user, the language-changing button, and the button to recalculate the BMI
        {
            if(bmiResult < 18.5)
            {
                UnderweightRecommendation.Visibility = Visibility.Visible;
                UnderweightPerson.Visibility = Visibility.Visible;
            }
            else if(bmiResult >= 18.5 && bmiResult < 23)
            {
                FitRecommendation.Visibility = Visibility.Visible;
                FitPerson.Visibility = Visibility.Visible;
            }
            else if (bmiResult >= 23 && bmiResult <= 27.5)
            {
                OverweightRecommendation.Visibility = Visibility.Visible;
                OverweightPerson.Visibility = Visibility.Visible;
            }
            else
            {
                ObeseRecommendation.Visibility = Visibility.Visible;
                ObesePerson.Visibility = Visibility.Visible;
            }
            RecalculatingButton.Visibility = Visibility.Visible;
            BmiResultTextBox.Visibility = Visibility.Visible;
            WeightInfoKg.Visibility = Visibility.Hidden;
            WeightInfoLbs.Visibility = Visibility.Hidden;
            WeightTextBox.Visibility = Visibility.Hidden;
            HeightInfoMeters.Visibility = Visibility.Hidden;
            HeightInfoInches.Visibility = Visibility.Hidden;
            HeightTextBox.Visibility = Visibility.Hidden;
            MeasureRadioButtonContainer.Visibility = Visibility.Hidden;
            CalculatingButton.Visibility = Visibility.Hidden;
        }

        private void numericWeightInput(object sender, TextCompositionEventArgs e) /*Source: https://social.msdn.microsoft.com/Forums/en-US/cbc8bf43-eb0e-439a-a08d-5336dd1ce5c5/wpf-how-to-make-textbox-only-allow-enter-certain-range-of-numbers?forum=wpf
            https://stackoverflow.com/questions/1268552/how-do-i-get-a-textbox-to-only-accept-numeric-input-in-wpf */
            //Checks whether the text for the weight input is numeric (including decimals)                                                                                                                                                                //Checks whether the text for the weight input is numeric (including decimals)
        {
            e.Handled = IsTextNumeric(e.Text);
        }
        public static bool IsTextNumeric(string str) /*Source: https://social.msdn.microsoft.com/Forums/en-US/cbc8bf43-eb0e-439a-a08d-5336dd1ce5c5/wpf-how-to-make-textbox-only-allow-enter-certain-range-of-numbers?forum=wpf
            https://stackoverflow.com/questions/1268552/how-do-i-get-a-textbox-to-only-accept-numeric-input-in-wpf */
            //Checks whether the text of a string is numeric (including decimals)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("[^0-9.]");
            return reg.IsMatch(str);
        }

        private void numericHeightInput(object sender, TextCompositionEventArgs e) /*Source: https://social.msdn.microsoft.com/Forums/en-US/cbc8bf43-eb0e-439a-a08d-5336dd1ce5c5/wpf-how-to-make-textbox-only-allow-enter-certain-range-of-numbers?forum=wpf
            https://stackoverflow.com/questions/1268552/how-do-i-get-a-textbox-to-only-accept-numeric-input-in-wpf */
            //Checks whether the text for the height input is numeric (including decimals)
        {
            e.Handled = IsTextNumeric(e.Text);
        }

        private void recalculateBmi(object sender, RoutedEventArgs e)
            //Goes back to the state the page was before the calculating button was clicked (including the values entered for the weight and height, and excluding whether the user changed the measure or the language of the system)
        {
            RecalculatingButton.Visibility = Visibility.Hidden;
            if (RadioButtonMetric.IsChecked == true)
            {
                WeightInfoKg.Visibility = Visibility.Visible;
                WeightInfoLbs.Visibility = Visibility.Hidden;
                HeightInfoMeters.Visibility = Visibility.Visible;
                HeightInfoInches.Visibility = Visibility.Hidden;
            }
            else
            {
                WeightInfoKg.Visibility = Visibility.Hidden;
                WeightInfoLbs.Visibility = Visibility.Visible;
                HeightInfoMeters.Visibility = Visibility.Hidden;
                HeightInfoInches.Visibility = Visibility.Visible;
            }
            WeightTextBox.Visibility = Visibility.Visible;
            HeightTextBox.Visibility = Visibility.Visible;
            MeasureRadioButtonContainer.Visibility = Visibility.Visible;
            CalculatingButton.Visibility = Visibility.Visible;
            UnderweightRecommendation.Visibility = Visibility.Hidden;
            UnderweightPerson.Visibility = Visibility.Hidden;
            FitRecommendation.Visibility = Visibility.Hidden;
            FitPerson.Visibility = Visibility.Hidden;
            OverweightRecommendation.Visibility = Visibility.Hidden;
            OverweightPerson.Visibility = Visibility.Hidden;
            ObeseRecommendation.Visibility = Visibility.Hidden;
            ObesePerson.Visibility = Visibility.Hidden;
            BmiResultTextBox.Text = "";
            BmiResultTextBox.Visibility = Visibility.Hidden;
        }

        private void changeToFrench(object sender, RoutedEventArgs e)
            //Changes whatever words are written on the page the user is currently on to French words
        {
            PageTitle.Text = "Calculatrice d'IMC";
            TextLanguage_Fr.Visibility = Visibility.Hidden;
            RadioButtonMetric.Content = "Métrique";
            RadioButtonImperial.Content = "Impérial";
            WeightInfoKg.Text = "Entre ton poids (kg)";
            WeightInfoLbs.Text = "Entre ton poids (livres)";
            HeightInfoMeters.Text = "Entre ta hauteur (m)";
            HeightInfoInches.Text = "Entre ta hauteur (pouces)";
            CalculatingButton.Content = "Calcule ton IMC";
            RecalculatingButton.Content = "Recalcule ton IMC";
            UnderweightRecommendation.Text = "Tu es en INSUFFISANCE PONDÉRALE (IMC en bas de 18.5). Tu es à risque de développer des problèmes comme la déficience nutritionnelle et l'ostéoporose. Tu devrais considérer changer tes habitudes de santé.";
            FitRecommendation.Text = "Tu es EN FORME (IMC entre 18.5 et 23). Tu es à faible risque de développer des problèmes de santé. Continue à garder tes habitudes de santé.";
            OverweightRecommendation.Text = "Tu es EN SURPOIDS (IMC entre 23 et 27.5). Tu es à risque modéré de développer des problèmes de coeur, de l'hypertension artérielle, des accidents vasculaires cérébraux, et le diabète. Tu devrais considérer changer tes habitudes de santé.";
            ObeseRecommendation.Text = "Tu es OBÈSE (IMC en haut de 27.5). Tu es à grand risque de développer des problèmes de coeur, de l'hypertension artérielle, des accidents vasculaires cérébraux, et le diabète. Tu devrais URGEMMENT changer tes habitudes de santé.";
            TextLanguage_Eng.Visibility = Visibility.Visible;
        }

        private void changeToEnglish(object sender, RoutedEventArgs e)
        //Changes whatever words are written on the page the user is currently on to English words
        {
            PageTitle.Text = "BMI Calculator";
            TextLanguage_Eng.Visibility = Visibility.Hidden;
            RadioButtonMetric.Content = "Metric";
            RadioButtonImperial.Content = "Imperial";
            WeightInfoKg.Text = "Enter weight (kg)";
            WeightInfoLbs.Text = "Enter weight (lbs)";
            HeightInfoMeters.Text = "Enter height (m)";
            HeightInfoInches.Text = "Enter height (in)";
            CalculatingButton.Content = "Calculate your BMI";
            RecalculatingButton.Content = "Recalculate your BMI";
            UnderweightRecommendation.Text = "You are UNDERWEIGHT (BMI below 18.5). You have a risk of developing problems such as nutritional deficiency and osteoporosis. You should consider changing your health habits.";
            FitRecommendation.Text = "You are FIT (BMI between 18.5 and 23). You have a low risk of developing health problems. Keep up your current health habits.";
            OverweightRecommendation.Text = "You are OVERWEIGHT (BMI between 23 and 27.5). You have a moderate risk of developing heart disease, high blood pressure, stroke, and diabetes. You should consider changing your health habits.";
            ObeseRecommendation.Text = "You are OBESE (BMI over 27.5). You have a high risk of developing heart disease, high blood pressure, stroke, and diabetes. You should URGENTLY change your health habits.";
            TextLanguage_Fr.Visibility = Visibility.Visible;
        }
    }
}
