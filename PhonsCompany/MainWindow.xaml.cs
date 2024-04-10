using Microsoft.Win32;
using PhonsCompany.Data;
using PhonsCompany.ViewModel;
using System.ComponentModel;
using System.IO;
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

namespace PhonsCompany
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataGrid abonentsDataGrid { get { return this.AbonentsDataGrid; } }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new AbonentViewModel();
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow(abonentsDataGrid);
            searchWindow.SearchResultUpdated += (sender, result) =>
            {
                abonentsDataGrid.ItemsSource = result;
            };
            searchWindow.ShowDialog();
        }
        private void ExportCSVButton_Click(object sender, RoutedEventArgs e)
        {

            DataGrid dataGrid = (DataGrid)FindName("AbonentsDataGrid");

            if (dataGrid != null)
            {
                //Создаем диалоговое окно для выбора места сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                if (saveFileDialog.ShowDialog() == true)
                {
                    // Открываем файл для записи
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        string str = "";
                        // Записываем заголовки столбцов
                        foreach (DataGridColumn column in dataGrid.Columns)
                        {
                            if (String.IsNullOrEmpty(str))
                            {
                                str = (string)column.Header;
                            }
                            else
                            {
                                str += ";" + column.Header;
                            }

                        }
                        sw.WriteLine(str);

                        // Записываем данные из DataGrid
                        foreach (var item in dataGrid.Items)
                        {
                            str = "";
                            foreach (DataGridColumn column in dataGrid.Columns)
                            {
                                var cellValue = (column.GetCellContent(item) as TextBlock)?.Text;
                                if (String.IsNullOrEmpty(str))
                                {
                                    str = cellValue;
                                }
                                else
                                {
                                    str += ";" + cellValue;
                                }

                            }
                            sw.WriteLine(str);
                        }
                    }
                    MessageBox.Show("Данные успешно выгружены в CSV файл.");
                }
            }
            else
            {
                MessageBox.Show("DataGrid не найден.");
            }
        }
        private void StreetsButton_Click(object sender, RoutedEventArgs e)
        {
            StreetWindow streetWindow = new StreetWindow();
            streetWindow.ShowDialog();
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ICollectionView view = CollectionViewSource.GetDefaultView(AbonentsDataGrid.ItemsSource);
            view.Filter = item =>
            {
                AbonentInfo abonent = item as AbonentInfo;
                if (abonent != null)
                {
                    string filterValue = (sender as TextBox)?.Text.ToLower(); // Получаем значение фильтра из соответствующего текстового поля
                    if (filterValue != null)
                    {
                        switch (((TextBox)sender).Name)
                        {
                            case "FullNameFilterTextBox":
                                return abonent.FullName.ToLower().Contains(filterValue) || filterValue == "";
                            case "StreetFilterTextBox":
                                return abonent.Street.ToLower().Contains(filterValue) || filterValue == "";
                            case "HomeFilterTextBox":
                                return abonent.HouseNumber.ToLower().Contains(filterValue) || filterValue == "";
                            case "HomePhoneFilterTextBox":
                                return abonent.HomePhone != null && abonent.HomePhone.ToLower().Contains(filterValue) || filterValue == "";
                            case "WorkPhoneFilterTextBox":
                                return abonent.WorkPhone != null && abonent.WorkPhone.ToLower().Contains(filterValue) || filterValue == "";
                            case "MobilePhoneFilterTextBox":
                                return abonent.MobilePhone != null && abonent.MobilePhone.ToLower().Contains(filterValue) || filterValue == "";
                            default:
                                return true;
                        }
                    }
                }
                return false;
            };
        }
    }
}