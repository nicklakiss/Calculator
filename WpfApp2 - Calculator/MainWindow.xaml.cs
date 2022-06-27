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

namespace WpfApp2___Calculator
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
          
        private void Connect(string style)
        {
            //Application.Current.Resources.Clear();
            //Uri urbrush = new Uri("Brushes.xaml", UriKind.Relative);
            //ResourceDictionary ress = (ResourceDictionary)Application.LoadComponent(urbrush);
            //Application.Current.Resources.MergedDictionaries.Add(ress);
            Uri uri = new Uri(style, UriKind.Relative);
            ResourceDictionary res = (ResourceDictionary)Application.LoadComponent(uri);
            if (Application.Current.Resources.MergedDictionaries.Count > 1) Application.Current.Resources.MergedDictionaries.RemoveAt(Application.Current.Resources.MergedDictionaries.Count - 1);
            Application.Current.Resources.MergedDictionaries.Add(res);
        }

        private void DefaultRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            if (DefaultRadiobutton.IsChecked == true)
            {
                Connect("Default.xaml");
            }
        }

        private void BlueYellowRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            if(BlueYellowRadiobutton.IsChecked == true)
            {
                Connect("Ukraine.xaml");
            }
        }

        private void BlackRedRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            if(BlackRedRadiobutton.IsChecked == true)
            {
                Connect("Upa.xaml");
            }
        }

        private void ClasicRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            if (ClasicRadiobutton.IsChecked == true)
            {
                Connect("Clasic.xaml");
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonHide_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }
    }
}
