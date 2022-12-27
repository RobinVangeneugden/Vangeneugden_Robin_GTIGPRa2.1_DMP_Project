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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Lid lid = new Lid();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddDeleteGroep_Click(object sender, RoutedEventArgs e)
        {
            if (cmbBandlid.SelectedItem == null)
            {
                MessageBox.Show("U moet een bandlid selecteren!", "Selecteer Bandlid", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                AddDeleteGroep GroepWindow = new AddDeleteGroep(this, ((Lid)cmbBandlid.SelectedItem).id);
                GroepWindow.ShowDialog();
            }
        }

        private void BtnAddDeleteConcert_Click(object sender, RoutedEventArgs e)
        {
            if (cmbBandlid.SelectedItem == null)
            {
                MessageBox.Show("U moet een bandlid selecteren!", "Selecteer Bandlid", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                AddDeleteConcert ConcertWindow = new AddDeleteConcert(this, ((Lid)cmbBandlid.SelectedItem).id);
                ConcertWindow.ShowDialog();
            }
            
        }

        private void BtnAddDeleteRepetitie_Click(object sender, RoutedEventArgs e)
        {
            if (cmbBandlid.SelectedItem == null)
            {
                MessageBox.Show("U moet een bandlid selecteren!", "Selecteer Bandlid", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                AddDeleteRepetite RepetitieWindow = new AddDeleteRepetite(this, ((Lid)cmbBandlid.SelectedItem).id);
                RepetitieWindow.ShowDialog();
            }
            
        }

        private void BtnAddDeleteInstrument_Click(object sender, RoutedEventArgs e)
        {
            if (cmbBandlid.SelectedItem == null)
            {
                MessageBox.Show("U moet een bandlid selecteren!", "Selecteer Bandlid", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                AddDeleteInstrument InstrumentWindow = new AddDeleteInstrument(this, ((Lid)cmbBandlid.SelectedItem).id);
                InstrumentWindow.ShowDialog();
            }
            
        }

        private void BtnVerwijderBandlid_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnPasGegevensAan_Click(object sender, RoutedEventArgs e)
        {
            if (cmbBandlid.SelectedItem == null)
            {
                MessageBox.Show("U moet een bandlid selecteren!", "Selecteer Bandlid", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                UpdateBandlid UpdateGegevensWindow = new UpdateBandlid();
                UpdateGegevensWindow.ShowDialog();
            }
            
        }

        private void BtnVoegBandlidToe_Click(object sender, RoutedEventArgs e)
        {
            if (cmbBandlid.SelectedItem == null)
            {
                MessageBox.Show("U moet een bandlid selecteren!", "Selecteer Bandlid", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                AddBandlid BandlidToevoegenWindow = new AddBandlid();
                BandlidToevoegenWindow.ShowDialog();
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbBandlid.ItemsSource = DatabaseOperations.OphalenLeden();
        }

        private void BtnToonInfo_Click(object sender, RoutedEventArgs e)
        {
            if (cmbBandlid.SelectedItem == null)
            {
                MessageBox.Show("U moet een bandlid selecteren!", "Selecteer Bandlid", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                string bandLidGroepen = cmbBandlid.Text + " is lid van: " + string.Join(" en ", DatabaseOperations.OphalenGroepenVanBandlid(((Lid)cmbBandlid.SelectedItem).id));

                string bandLidInstrumenten = cmbBandlid.Text + " bespeeld volgende instrumenten: " + Environment.NewLine + string.Join(Environment.NewLine, DatabaseOperations.OphalenInstrumentenVanBandlid(((Lid)cmbBandlid.SelectedItem).id));

                lblToonInfo.Content = bandLidGroepen + Environment.NewLine + Environment.NewLine + bandLidInstrumenten;
            }
            
        }
    }
}
