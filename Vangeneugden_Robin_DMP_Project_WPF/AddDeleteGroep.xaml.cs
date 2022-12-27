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
using Vangeneugden_Robin_DMP_Project_DAL;

namespace Vangeneugden_Robin_DMP_Project_WPF
{
    /// <summary>
    /// Interaction logic for AddDeleteGroep.xaml
    /// </summary>
    public partial class AddDeleteGroep: Window

    {

        private readonly MainWindow _mainWindow;
        private int _lidID;
        public AddDeleteGroep(MainWindow mainWindow, int lidID)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _lidID = lidID;  
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblBandlid.Content = _mainWindow.cmbBandlid.Text;
            lbBandlid.ItemsSource = DatabaseOperations.OphalenGroepenVanBandlid(_lidID);
            lbGroepen.ItemsSource = DatabaseOperations.OphalenGroepen();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
