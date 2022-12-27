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
    /// Interaction logic for UpdateBandlid.xaml
    /// </summary>
    public partial class UpdateBandlid : Window
    {

        private readonly MainWindow _mainWindow;
        private int _lidID;
        public UpdateBandlid(MainWindow mainWindow, int lidID)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _lidID = lidID;
            
        }

        
        private void BtnPasAan_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Lid lid = DatabaseOperations.OphalenLidById(_lidID);
            txtBandlidnr.Text = _lidID.ToString();
            txtVoornaam.Text = lid.voornaam;
            txtFamilienaam.Text = lid.familienaam;
            txtStraat.Text = lid.straat;
            txtHuisnummer.Text = lid.huisnummer;
            txtGemeente.Text = lid.gemeente;
            txtPostcode.Text = lid.postcode;
            txtLand.Text = lid.land;
            txtRijksregnr.Text = lid.rijksregisternr;
            txtTelefoonnr.Text = lid.telefoon;
            txtEmail.Text = lid.email;
            dateInschrijvingsDatum.SelectedDate = lid.inschrijvingsDatum;

            if (lid.geslacht == "M")
            {
                cbMan.IsChecked = true;
                cbVrouw.IsChecked = false;
                cbNeutraal.IsChecked = false;
            }
            else if (lid.geslacht == "V")
            {
                cbVrouw.IsChecked = true;
                cbMan.IsChecked = false;
                cbNeutraal.IsChecked = false;
            }
            else
            {
                cbNeutraal.IsChecked = true;
                cbMan.IsChecked = false;
                cbVrouw.IsChecked = false;
            }


        }

        private void CbMan_Checked(object sender, RoutedEventArgs e)
        {
            cbMan.IsChecked = true;
            cbVrouw.IsChecked = false;
            cbNeutraal.IsChecked = false;
        }

        private void CbVrouw_Checked(object sender, RoutedEventArgs e)
        {
            cbVrouw.IsChecked = true;
            cbMan.IsChecked = false;
            cbNeutraal.IsChecked = false;
        }

        private void CbNeutraal_Checked(object sender, RoutedEventArgs e)
        {
            cbNeutraal.IsChecked = true;
            cbMan.IsChecked = false;
            cbVrouw.IsChecked = false;
        }
    }
}
