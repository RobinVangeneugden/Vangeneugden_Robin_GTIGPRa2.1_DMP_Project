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
            string error = Valideer();
            string geslacht = "";

            if (cbMan.IsChecked == true)
            {
                geslacht = "M";
            }
            else if (cbVrouw.IsChecked == true)
            {
                geslacht = "V";
            }
            else
            {
                geslacht = "X";
            }



            if (string.IsNullOrEmpty(error))
            {
                Lid lid = new Lid()
                {
                    id = int.Parse(txtBandlidnr.Text),
                    voornaam = txtVoornaam.Text,
                    familienaam = txtFamilienaam.Text,
                    geslacht = geslacht,
                    straat = txtStraat.Text,
                    huisnummer = txtHuisnummer.Text,
                    postcode = txtPostcode.Text,
                    gemeente = txtGemeente.Text,
                    land = txtLand.Text,
                    rijksregisternr = txtRijksregnr.Text,
                    telefoon = txtTelefoonnr.Text,
                    email = txtEmail.Text,
                    inschrijvingsDatum = dateInschrijvingsDatum.SelectedDate.Value
                };
                DatabaseOperations.UpdateBandlid(lid);
                _mainWindow.cmbBandlid.ItemsSource = DatabaseOperations.OphalenLeden();
                if (MessageBox.Show("Bandlid is gewijzigd", "Wijzigen succesvol", MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(error, "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private string Valideer()
        {
            string fout = "";

            if (string.IsNullOrEmpty(txtBandlidnr.Text))
            {
                fout += "Bandlidnr is een verplicht in te vullen veld!" + Environment.NewLine;
            }
            if (!int.TryParse(txtBandlidnr.Text, out int bandlidnr))
            {
                fout += "Bandlidnr moet nummeriek zijn!" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtVoornaam.Text))
            {
                fout += "Voornaam is een verplicht in te vullen veld!" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtFamilienaam.Text))
            {
                fout += "Familienaam is een verplicht in te vullen veld!" + Environment.NewLine;
            }
            if (cbMan.IsChecked == false && cbVrouw.IsChecked == false && cbNeutraal.IsChecked == false)
            {
                fout += "Gelieve een geslacht te kiezen" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtStraat.Text))
            {
                fout += "Straat is een verplicht in te vullen veld!" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtHuisnummer.Text))
            {
                fout += "Huisnummer is een verplicht in te vullen veld!" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtPostcode.Text))
            {
                fout += "Postcode is een verplicht in te vullen veld!" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtGemeente.Text))
            {
                fout += "Gemeente is een verplicht in te vullen veld!" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtLand.Text))
            {
                fout += "Land is een verplicht in te vullen veld!" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtRijksregnr.Text))
            {
                fout += "Rijksregisternummer is een verplicht in te vullen veld!" + Environment.NewLine;
            }
            if (!dateInschrijvingsDatum.SelectedDate.HasValue)
            {
                fout += "Inschrijvingsdatum is verplicht" + Environment.NewLine;
            }

            return fout;

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
