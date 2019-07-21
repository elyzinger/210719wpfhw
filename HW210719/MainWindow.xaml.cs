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

namespace HW210719
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Country> countries = new List<Country>();
        public MainWindow()
        {
            InitializeComponent();

            countries.Add(new Country { Name = " isreal ", Capital = " jerusalem  ", flag = "Resources/il-flag.jpg" });
            countries.Add(new Country { Name = " russia ", Capital = " moscow  ", flag = "Resources/russia-flag.jpg" });
            countries.Add(new Country { Name = " usa", Capital = " new york  ", flag = "Resources/usa35n_-01_3ft-x-5ft-us-nylon-flag-by-valley-forge_3.jpg" });

            myComboBox.ItemsSource = countries;
            myComboBox.SelectedIndex = 0;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

      

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = (Convert.ToInt16(Number1.Text) + Convert.ToInt16(Number2.Text)).ToString();
        }
        public class Country
        {
            public string Name { get; set; }
            public string Capital { get; set; }
            public string flag { get; set; }
        }
        public override string ToString()
        {
            return "{Name}  {capital}";
        }
    }
}
