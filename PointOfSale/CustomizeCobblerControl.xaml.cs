using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;



namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// if the Peach Radio Button gets checked then it will set the cobbler to be Peach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PeachChecked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            var cobbler = (Cobbler)DataContext;
            if (rb.IsChecked == true)
            {
                cobbler.Fruit = FruitFilling.Peach;
            }
        }
        /// <summary>
        /// if the Cherry Radio Button gets checked then it will set the cobbler to be Cheery 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CherryChecked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            var cobbler = (Cobbler)DataContext;
            if (rb.IsChecked == true)
            {
                cobbler.Fruit = FruitFilling.Cherry;
            }
        }
        /// <summary>
        /// if the Blue Berry Radio Button gets checked then it will set the cobbler to be Blue Berry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlueBerryCheck(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            var cobbler = (Cobbler)DataContext;
            if (rb.IsChecked == true)
            {
                cobbler.Fruit = FruitFilling.Blueberry;
            }
        }
    }
}
