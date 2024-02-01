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

namespace WpfApp1
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
        private void ColorIt(object sender, ExecutedRoutedEventArgs e)
        {
            RoutedCommand command = e.Command as RoutedCommand;
            var focusedControl = FocusManager.GetFocusedElement(this);
            if (focusedControl == null) return;
            FrameworkElement ? el  = focusedControl as FrameworkElement;
            {
                el ?.SetValue(Control.BackgroundProperty, new SolidColorBrush((Color)ColorConverter.ConvertFromString(command?.Name)));
            }
        }

    }

    public class MyCommand 
    {
        static MyCommand()
        {
            SetRed = new RoutedCommand("Red", typeof(MainWindow));
            SetGreen = new RoutedCommand("Green", typeof(MainWindow));
            SetBlue = new RoutedCommand("Blue", typeof(MainWindow));
        }

        public static RoutedCommand SetRed { get; set; }
        public static RoutedCommand SetGreen { get; set; }
        public static RoutedCommand SetBlue { get; set; }
    }
}
