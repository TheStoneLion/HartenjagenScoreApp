using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace HartenjagenScoreApp
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

        private void ProcessRoundButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DeleteLastRoundButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Weet je het zeker?", "Verwijderen laatste ronde", MessageBoxButton.YesNo, MessageBoxImage.Warning);
        }

        private void StartGameButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Weet je het zeker?", "Nieuw spel starten", MessageBoxButton.YesNo, MessageBoxImage.Warning);
        }

        private void RondeScoreWaardeSpeler1_DataContextChanged(object sender, RoutedEventArgs e)
        {
            this.SpelInfoRest.Text = "1";
        }

        private void RondeScoreWaardeSpeler2_DataContextChanged(object sender, RoutedEventArgs e)
        {
            this.SpelInfoRest.Text = "2";
        }
        private void RondeScoreWaardeSpeler3_DataContextChanged(object sender, RoutedEventArgs e)
        {
            this.SpelInfoRest.Text = "3";
        }
        private void RondeScoreWaardeSpeler4_DataContextChanged(object sender, RoutedEventArgs e)
        {
            this.SpelInfoRest.Text = "4";
        }

        private void RondeScoreWaardeSpeler1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
