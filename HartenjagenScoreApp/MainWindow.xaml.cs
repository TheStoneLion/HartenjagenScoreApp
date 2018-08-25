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

        private void RondeScoreWaardeSpeler1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void RondeScoreNaamSpeler1_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox != null)
            {
                if (StandNaamSpeler1 != null)
                    this.StandNaamSpeler1.Text = textbox.Text;
                if (RondeNaamSpeler1 != null)
                    this.RondeNaamSpeler1.Text = textbox.Text;
            }
        }

        private void RondeScoreWaardeSpeler1_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.SpelInfoRest.Text = "1";
        }

        private void RondeScoreNaamSpeler2_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox != null)
            {
                if (StandNaamSpeler2 != null)
                    this.StandNaamSpeler2.Text = textbox.Text;
                if (RondeNaamSpeler2 != null)
                    this.RondeNaamSpeler2.Text = textbox.Text;
            }
        }

        private void RondeScoreWaardeSpeler2_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.SpelInfoRest.Text = "2";
        }

        private void RondeScoreNaamSpeler3_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox != null)
            {
                if (StandNaamSpeler3 != null)
                    this.StandNaamSpeler3.Text = textbox.Text;
                if (RondeNaamSpeler3 != null)
                    this.RondeNaamSpeler3.Text = textbox.Text;
            }
        }

        private void RondeScoreWaardeSpeler3_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.SpelInfoRest.Text = "3";
        }

        private void RondeScoreNaamSpeler4_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox != null)
            {
                if (StandNaamSpeler4 != null)
                    this.StandNaamSpeler4.Text = textbox.Text;
                if (RondeNaamSpeler4 != null)
                    this.RondeNaamSpeler4.Text = textbox.Text;
            }
        }

        private void RondeScoreWaardeSpeler4_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.SpelInfoRest.Text = "4";
        }
    }
}
