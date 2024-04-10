using PhonsCompany.Data;
using PhonsCompany.Model;
using PhonsCompany.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices;
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
    /// Логика взаимодействия для SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        private DataGrid _abonentsDataGrid;
        public SearchWindow(DataGrid abonentsDataGrid)
        {
            InitializeComponent();
            _abonentsDataGrid = abonentsDataGrid;
        }

        public event EventHandler<List<Abonent>> SearchResultUpdated;

        private void SearcNumberhButton_Click(object sender, RoutedEventArgs e)
        {
            string phoneNumber = searchTextBox.Text; // Получаем номер телефона из TextBox
            AbonentViewModel abonentViewModel = new AbonentViewModel();
            List<AbonentInfo> foundAbonents = abonentViewModel.FindAbonentsByPhoneNumber(phoneNumber); // Вызов метода поиска по номеру телефона

            if (foundAbonents.Count > 0)
            {
                ObservableCollection<AbonentInfo> searchResult = new ObservableCollection<AbonentInfo>();

                foreach (AbonentInfo foundAbonent in foundAbonents)
                {
                    searchResult.Add(foundAbonent);
                }
                _abonentsDataGrid.ItemsSource = searchResult;
            }
            else
            {
                    MessageBox.Show("Нет абонентов, удовлетворяющих критерию поиска.");
            }
        }
    }
}