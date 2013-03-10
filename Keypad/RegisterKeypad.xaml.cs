using System.Windows;
using System.Windows.Input;


namespace Keypad
{
    /// <summary>
    /// Interaction logic for RegisterKeypadxaml.xaml
    /// </summary>
    public partial class RegisterKeypad : GenericKeypad
    {
        public RegisterKeypad()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonPressed(Key.D1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonPressed(Key.D2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonPressed(Key.D3);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonPressed(Key.D4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonPressed(Key.D5);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonPressed(Key.D6);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonPressed(Key.D7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonPressed(Key.D8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonPressed(Key.D9);
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            RaiseButtonPressed(Key.D0);
        }

        private void btn00_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
