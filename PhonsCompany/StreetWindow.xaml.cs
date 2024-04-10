using PhonsCompany.ViewModel;
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
using System.Windows.Shapes;

namespace PhonsCompany
{
    /// <summary>
    /// Логика взаимодействия для StreetWindow.xaml
    /// </summary>
    public partial class StreetWindow : Window
    {
        public StreetWindow()
        {
            InitializeComponent();
            DataContext = new StreetViewModel();
        }

    }
}
