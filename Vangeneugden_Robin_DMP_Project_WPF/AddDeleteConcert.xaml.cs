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
    /// Interaction logic for AddDeleteConcert.xaml
    /// </summary>
    public partial class AddDeleteConcert : Window
    {
        private readonly MainWindow _mainWindow;
        private int _lidID;
        public AddDeleteConcert(MainWindow mainWindow, int lidID)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _lidID = lidID;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblBandlid.Content = _mainWindow.cmbBandlid.Text;
            lbConcert.ItemsSource = DatabaseOperations.OphalenOptredens();
            lbBandlid.ItemsSource = DatabaseOperations.OphalenOptredensVanBandlid(_lidID);
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (lbConcert.SelectedItem != null)
            {
                DatabaseOperations.AddOptredensVanBandlid(_lidID, ((Optreden)lbConcert.SelectedItem).id);
                lbBandlid.ItemsSource = DatabaseOperations.OphalenOptredensVanBandlid(_lidID);
                MessageBox.Show($"{((Optreden)lbConcert.SelectedItem).omschrijving} is toegevoegd aan de lijst van {_mainWindow.cmbBandlid.Text}!", "Optreden Toevoegen", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (lbBandlid.SelectedItem != null)
            {
                MessageBox.Show("Een optreden uit deze lijst kan niet toegevoegd worden!");
            }
            else
            {
                MessageBox.Show("Selecteer het toe te voegen optreden!");
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbBandlid.SelectedItem != null)
            {
                if (MessageBox.Show("Wil je het optreden uit deze lijst verwijderen?", "Optreden verwijderen?", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    MessageBox.Show("Fijn dat je nog meedoet aan het optreden!");
                }
                else
                {
                    DatabaseOperations.DeleteOptredenVanBandlid(_lidID, ((Optreden)lbBandlid.SelectedItem).id);
                    MessageBox.Show($"{((Optreden)lbBandlid.SelectedItem).omschrijving} is succesvol verwijderd uit de lijst van {_mainWindow.cmbBandlid.Text}!", "Optreden Verwijderd", MessageBoxButton.OK, MessageBoxImage.Information);
                    lbBandlid.ItemsSource = DatabaseOperations.OphalenOptredensVanBandlid(_lidID);
                }
            }
            else if (lbConcert.SelectedItem != null)
            {
                MessageBox.Show("Een optreden uit deze lijst kan niet verwijderd worden!");
            }
            else
            {
                MessageBox.Show("Selecteer het te verwijderen optreden!");
            }
        }
    }
}
