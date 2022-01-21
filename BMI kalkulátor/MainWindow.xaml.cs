using System;
using System.Windows;
using System.Windows.Media;

namespace BMI_kalkulátor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Nyomja meg a Számítás gombot a BMI eredmény megjelenítéséhez
            double height = double.Parse(HeightBox.Text) / 100;
            double weight = double.Parse(WeightBox.Text);

            double BMI = Math.Round(weight / Math.Pow(height, 2), 2);
            result.Text = BMI.ToString();

            // színváltoztatás az eredmény alapján
            if (BMI < 18.5)
            {
                result.Foreground = Brushes.Red;
            }

            else if (18.5 <= BMI & BMI < 24)
            {
                result.Foreground = Brushes.Green;
            }

            else if (BMI > 24)
            {
                result.Foreground = Brushes.Goldenrod;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //visszaállítja az értéket nullára
            HeightBar.Value = 0;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Slider értéke

            HeightBox.Text = HeightBar.Value.ToString();
            WeightBox.Text = WeightBar.Value.ToString();

            // Kiszámítja a BMI eredményt és kimenetet

            double height = double.Parse(HeightBox.Text) / 100;
            double weight = double.Parse(WeightBox.Text);

            double BMI = Math.Round(weight / Math.Pow(height, 2), 2);
            result.Text = BMI.ToString();

            //Színváltoztatás az eredmény alapján

            if (BMI < 16)
            {
                result.Foreground = Brushes.Red;
                resultText.Foreground = Brushes.Red;
                resultText.Text = "súlyosan sovány";
            }

            else if (16 <= BMI & BMI < 17)
            {
                result.Foreground = Brushes.Red;
                resultText.Foreground = Brushes.Red;
                resultText.Text = "mérsékelten sovány";
            }

            else if(17 <= BMI & BMI < 18.5)
            {
                result.Foreground = Brushes.Red;
                resultText.Foreground = Brushes.Red;
                resultText.Text = "enyhény sovány";
            }

            else if (18.5 <= BMI & BMI < 25)
            {
                result.Foreground = Brushes.Green;
                resultText.Foreground = Brushes.Green;
                resultText.Text = "normális testsúly";
            }


            else if (25 <= BMI & BMI < 30)
            {
                result.Foreground = Brushes.Goldenrod;
                resultText.Foreground = Brushes.Goldenrod;
                resultText.Text = "túlsúlyos";
            }

            else if (30 <= BMI & BMI < 35)
            {
                result.Foreground = Brushes.Goldenrod;
                resultText.Foreground = Brushes.Goldenrod;
                resultText.Text = "I. fokú elhízás";
            }

            else if (35 <= BMI & BMI < 40)
            {
                result.Foreground = Brushes.Goldenrod;
                resultText.Foreground = Brushes.Goldenrod;
                resultText.Text = "II. fokú elhízás";
            }


            else if (BMI >= 40)
            {
                result.Foreground = Brushes.Goldenrod;
                resultText.Foreground = Brushes.Goldenrod;
                resultText.Text = "	III. fokú (súlyos) elhízás";
            }

        }

        private void ButtonClear2_Click(object sender, RoutedEventArgs e)
        {
            // visszaállítja az értéket nullára

            WeightBar.Value = 0;
        }
    }
}
