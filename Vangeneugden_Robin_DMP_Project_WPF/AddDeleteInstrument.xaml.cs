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
    /// Interaction logic for AddDeleteInstrument.xaml
    /// </summary>
    public partial class AddDeleteInstrument : Window
    {
        private readonly MainWindow _mainWindow;
        private int _lidID;
        public AddDeleteInstrument(MainWindow mainWindow, int lidID)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _lidID = lidID;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblBandlid.Content = _mainWindow.cmbBandlid.Text;
            lbBandlid.ItemsSource = DatabaseOperations.OphalenInstrumentenVanBandlid(_lidID);
            lbInstrument.ItemsSource = DatabaseOperations.OphalenInstrumenten();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (lbInstrument.SelectedItem != null)
            {
                DatabaseOperations.AddInstrumentVanBandlid(_lidID, ((Instrument)lbInstrument.SelectedItem).id);
                lbBandlid.ItemsSource = DatabaseOperations.OphalenInstrumentenVanBandlid(_lidID);
                MessageBox.Show($"{((Instrument)lbInstrument.SelectedItem).naam} is toegevoegd aan de lijst van {_mainWindow.cmbBandlid.Text}!", "Instrument Toevoegen", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (lbBandlid.SelectedItem != null)
            {
                MessageBox.Show("Een instrument uit deze lijst kan niet toegevoegd worden!");
            }
            else
            {
                MessageBox.Show("Selecteer het toe te voegen instrument!");
            }
            
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbBandlid.SelectedItem != null)
            {
                if (MessageBox.Show("Wil je instrument uit deze lijst verwijderen?", "Instrument verwijderen?", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    MessageBox.Show("Keep playing!");
                }
                else
                {
                    DatabaseOperations.DeleteInstrumentVanBandlid(_lidID, ((Instrument)lbBandlid.SelectedItem).id);
                    MessageBox.Show($"{((Instrument)lbBandlid.SelectedItem).naam} is succesvol verwijderd uit de lijst van {_mainWindow.cmbBandlid.Text}!", "Instrument Verwijderd", MessageBoxButton.OK, MessageBoxImage.Information);
                    lbBandlid.ItemsSource = DatabaseOperations.OphalenInstrumentenVanBandlid(_lidID);
                }
            }
            else if (lbInstrument.SelectedItem != null)
            {
                MessageBox.Show("Een instrument uit deze lijst kan niet verwijderd worden!");
            }
            else
            {
                MessageBox.Show("Selecteer het te verwijderen instrument!");
            }
        }
    }
}
