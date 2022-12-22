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
            AddDeleteGroep GroepWindow = new AddDeleteGroep(this, ((Lid)cmbBandlid.SelectedItem).id);
            GroepWindow.ShowDialog();
        }

        private void BtnAddDeleteConcert_Click(object sender, RoutedEventArgs e)
        {
            AddDeleteConcert ConcertWindow = new AddDeleteConcert(this, ((Lid)cmbBandlid.SelectedItem).id);
            ConcertWindow.ShowDialog();
        }

        private void BtnAddDeleteRepetitie_Click(object sender, RoutedEventArgs e)
        {
            AddDeleteRepetite RepetitieWindow = new AddDeleteRepetite(this, ((Lid)cmbBandlid.SelectedItem).id);
            RepetitieWindow.ShowDialog();
        }

        private void BtnAddDeleteInstrument_Click(object sender, RoutedEventArgs e)
        {
            AddDeleteInstrument InstrumentWindow = new AddDeleteInstrument(this, ((Lid)cmbBandlid.SelectedItem).id);
            InstrumentWindow.ShowDialog();
        }

        private void BtnVerwijderBandlid_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnPasGegevensAan_Click(object sender, RoutedEventArgs e)
        {
            UpdateBandlid UpdateGegevensWindow = new UpdateBandlid();
            UpdateGegevensWindow.Owner = this;
            UpdateGegevensWindow.ShowDialog();
        }

        private void BtnVoegBandlidToe_Click(object sender, RoutedEventArgs e)
        {
            AddBandlid BandlidToevoegenWindow = new AddBandlid();
            BandlidToevoegenWindow.Owner = this;
            BandlidToevoegenWindow.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbBandlid.ItemsSource = DatabaseOperations.OphalenLeden();
        }
    }
}
