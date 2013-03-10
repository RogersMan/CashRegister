using System.Windows.Controls;

namespace Display
{
    /// <summary>
    /// Interaction logic for SimpleDisplay.xaml
    /// </summary>
    public partial class SimpleDisplay : GenericDisplay
    {
        public SimpleDisplay()
        {
            InitializeComponent();
        }

        public override void SetDisplay(string TheText)
        {
            textBox1.Text = TheText;
        }
    }
}
