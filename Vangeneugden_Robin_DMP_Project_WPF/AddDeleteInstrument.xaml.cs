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

            foreach (Instrument instrument in lbInstrument.Items)
            {
                if (!lbBandlid.Items.Contains(instrument))
                {
                    MessageBox.Show("Bandlid bespeeld dit instrument al.", "Oeps", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            DatabaseOperations.AddInstrumentVanBandlid(_lidID, ((Instrument)lbInstrument.SelectedItem).id);
            lbBandlid.ItemsSource = DatabaseOperations.OphalenInstrumentenVanBandlid(_lidID);

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbBandlid.SelectedItem != null)
            {
                DatabaseOperations.DeleteInstrumentVanBandlid(((Instrument)lbBandlid.SelectedItem).id);
            }
            else
            {
                MessageBox.Show("Selecteer het te verwijderen instrument!");
            }
        }
    }
}
